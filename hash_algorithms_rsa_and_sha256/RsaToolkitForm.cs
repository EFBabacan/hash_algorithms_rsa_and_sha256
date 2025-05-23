using System;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Security.Cryptography; //bunu sha256 formu için oluşturduk imzalamada kullanmak için

// BouncyCastle using'leri
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.Utilities.IO.Pem;
using Org.BouncyCastle.OpenSsl;// PemReader için

// using Org.BouncyCastle.X509; // PublicKeyFactory için, gerekirse eklenecek
// using Org.BouncyCastle.Crypto.Encodings; // OaepEncoding, Pkcs1Encoding için
// using Org.BouncyCastle.Crypto.Engines; // RsaEngine için
// using Org.BouncyCastle.Crypto.Digests; // Sha256Digest vb. için
using Org.BouncyCastle.Crypto.Encodings; // OaepEncoding, Pkcs1Encoding için
using Org.BouncyCastle.Crypto.Engines;   // RsaEngine, RsaBlindedEngine için
using Org.BouncyCastle.Crypto.Digests;   // Sha1Digest, Sha256Digest vb. için
// using Org.BouncyCastle.X509; // SubjectPublicKeyInfoFactory için değil, PublicKeyFactory için.


namespace hash_algorithms_rsa_and_sha256
{
    public partial class RsaToolkitForm : Form
    {
        private string publicKeyString;
        private string privateKeyString;

        public RsaToolkitForm()
        {
            InitializeComponent();
        }

        private void RsaToolkitForm_Load(object sender, EventArgs e)
        {
            comboBoxKeySize.Items.Add("1024");
            comboBoxKeySize.Items.Add("2048");
            comboBoxKeySize.Items.Add("3072");
            comboBoxKeySize.Items.Add("4096");
            comboBoxKeySize.SelectedItem = "2048";
            comboBoxKeySize.DropDownStyle = ComboBoxStyle.DropDownList;

            buttonSavePublicKey.Enabled = false;
            buttonSavePrivateKey.Enabled = false;

            // Encryption sekmesi için padding ComboBox'ını doldur
            comboBoxEncryptionPadding.Items.Add("OAEPWithSHA-256AndMGF1Padding"); // Önerilen
            comboBoxEncryptionPadding.Items.Add("OAEPWithSHA-1AndMGF1Padding");
            comboBoxEncryptionPadding.Items.Add("PKCS1Padding"); // PKCS#1 v1.5
            if (comboBoxEncryptionPadding.Items.Count > 0)
            {
                comboBoxEncryptionPadding.SelectedIndex = 0; // Varsayılan olarak ilkini seç
            }
            comboBoxEncryptionPadding.DropDownStyle = ComboBoxStyle.DropDownList;

            // Decryption sekmesi için padding ComboBox'ını doldur (Encryption ile aynı)
            comboBoxDecryptionPadding.Items.Add("OAEPWithSHA-256AndMGF1Padding"); // Önerilen
            comboBoxDecryptionPadding.Items.Add("OAEPWithSHA-1AndMGF1Padding");
            comboBoxDecryptionPadding.Items.Add("PKCS1Padding"); // PKCS#1 v1.5
            if (comboBoxDecryptionPadding.Items.Count > 0)
            {
                comboBoxDecryptionPadding.SelectedIndex = 0; // Varsayılan olarak ilkini seç
            }
            comboBoxDecryptionPadding.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonGenerateKeysRsa_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Anahtar boyutunu kontrol et
                if (comboBoxKeySize.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir anahtar boyutu seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int keySize = int.Parse(comboBoxKeySize.SelectedItem.ToString());

                // 2. Parola kontrolü
                string password = textBoxPasswordKeyGen.Text;
                string confirmPassword = textBoxPasswordConfirmKeyGen.Text;

                if (!string.IsNullOrEmpty(password) && password != confirmPassword)
                {
                    MessageBox.Show("Parolalar eşleşmiyor.", "Parola Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3. RSA anahtar çifti oluştur
                var generator = new RsaKeyPairGenerator();
                var param = new RsaKeyGenerationParameters(
                    Org.BouncyCastle.Math.BigInteger.ValueOf(0x10001), // Public Exponent (65537)
                    new SecureRandom(), // Güvenli rastgele sayı üreteci
                    keySize,            // Anahtar boyutu
                    25);                // Asallık testi için kesinlik
                generator.Init(param);
                var keyPair = generator.GenerateKeyPair(); // AsymmetricCipherKeyPair

                // 4. PUBLIC KEY - PEM formatı
                // keyPair.Public, AsymmetricKeyParameter tipindedir.
                var publicKeyInfo = SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(keyPair.Public);
                var publicPemObject = new PemObject("PUBLIC KEY", publicKeyInfo.GetDerEncoded());

                using (var pubSw = new StringWriter())
                {
                    // Kullandığın PemWriter: Org.BouncyCastle.Utilities.IO.Pem.PemWriter
                    var pubWriter = new Org.BouncyCastle.Utilities.IO.Pem.PemWriter(pubSw);
                    pubWriter.WriteObject(publicPemObject);
                    pubWriter.Writer.Flush();
                    publicKeyString = pubSw.ToString();
                    textBoxPublicKeyRsa.Text = publicKeyString;
                }

                // 5. PRIVATE KEY - PEM formatı
                PemObject privatePemObjectToEncode; // Hem şifreli hem şifresiz durumu tutacak PemObject

                if (string.IsNullOrEmpty(password))
                {
                    // Parola YOKSA: Şifresiz PKCS#8 Private Key oluştur
                    // keyPair.Private, AsymmetricKeyParameter tipindedir.
                    var privateKeyInfo = PrivateKeyInfoFactory.CreatePrivateKeyInfo(keyPair.Private);
                    privatePemObjectToEncode = new PemObject("PRIVATE KEY", privateKeyInfo.GetDerEncoded());
                }
                else
                {
                    // Parola VARSA: Parola ile Şifrelenmiş PKCS#8 Private Key oluştur
                    // Pkcs8Generator Org.BouncyCastle.Pkcs namespace'i altındadır.
                    // PkcsObjectIdentifiers ise Org.BouncyCastle.Asn1.Pkcs altındadır.

                    // Kullanılacak PBE (Password-Based Encryption) algoritmasının OID'si.
                    // PkcsObjectIdentifiers.PbeWithShaAnd3KeyTripleDesCbc.Id -> Triple DES kullanır (eski ama yaygın).
                    // Güvenlik Notu: Üretim ortamları için AES tabanlı PBE algoritmaları
                    // (örn: PKCS#5 v2.0 PBES2 şeması altında AES-256-CBC) daha güvenlidir.
                    // BouncyCastle versiyonuna göre bu OID'ler veya Pkcs8Generator sabitleri değişebilir.
                    string pbeAlgorithmOid = PkcsObjectIdentifiers.PbeWithShaAnd3KeyTripleDesCbc.Id;

                    Pkcs8Generator pkcs8EncryptedGenerator = new Pkcs8Generator(keyPair.Private, pbeAlgorithmOid);

                    pkcs8EncryptedGenerator.Password = password.ToCharArray(); // Parolayı ata
                                                                               // Iterasyon sayısı, parolanın kırılmasını zorlaştıran bir faktördür.
                                                                               // Önerilen değerler genellikle 10000 ve üzeridir.
                    pkcs8EncryptedGenerator.IterationCount = 2048; // Test için, daha sonra artırılabilir.

                    // pkcs8EncryptedGenerator.Generate() bir PemObject döndürür.
                    // Bu PemObject'in tipi (başlık etiketi) BouncyCastle tarafından
                    // otomatik olarak "ENCRYPTED PRIVATE KEY" olarak ayarlanır.
                    privatePemObjectToEncode = pkcs8EncryptedGenerator.Generate();
                }

                // Oluşturulan (şifreli veya şifresiz) PemObject'i string'e çevir
                using (var privSw = new StringWriter())
                {
                    var privWriter = new Org.BouncyCastle.Utilities.IO.Pem.PemWriter(privSw);
                    privWriter.WriteObject(privatePemObjectToEncode);
                    privWriter.Writer.Flush();
                    privateKeyString = privSw.ToString();
                    textBoxPrivateKeyRsa.Text = privateKeyString;
                }

                // 6. Butonları aktif et
                buttonSavePublicKey.Enabled = true;
                buttonSavePrivateKey.Enabled = true;

                MessageBox.Show("Anahtarlar başarıyla oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:\n" + ex.Message + "\n\nDetay:\n" + ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Hata durumunda butonları tekrar pasif yapabiliriz veya anahtar string'lerini temizleyebiliriz.
                buttonSavePublicKey.Enabled = false;
                buttonSavePrivateKey.Enabled = false;
                textBoxPublicKeyRsa.Text = "";
                textBoxPrivateKeyRsa.Text = "";
                publicKeyString = null;
                privateKeyString = null;
            }
        }

        private void buttonSavePublicKey_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(publicKeyString)) return;

            SaveFileDialog sfd = new SaveFileDialog
            {
                Title = "Public Key Kaydet",
                Filter = "PEM Dosyası|*.pem",
                FileName = "public_key.pem"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, publicKeyString);
                MessageBox.Show("Public key kaydedildi.");
            }
        }

        private void buttonSavePrivateKey_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(privateKeyString)) return;

            SaveFileDialog sfd = new SaveFileDialog
            {
                Title = "Private Key Kaydet",
                Filter = "PEM Dosyası|*.pem",
                FileName = "private_key.pem"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, privateKeyString);
                MessageBox.Show("Private key kaydedildi.");
            }
        }

        private void textBoxPrivateKeyRsa_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPrivateKeyRsa_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoadPublicKeyEncrypt_Click(object sender, EventArgs e)
        {
            // openFileDialogEncryptTab kontrolünün forma eklenmiş ve ayarlarının yapılmış olması lazım
            openFileDialogEncryptTab.Title = "Public Key PEM Dosyasını Seçin";
            openFileDialogEncryptTab.Filter = "PEM Dosyaları (*.pem)|*.pem|Tüm Dosyalar (*.*)|*.*";
            openFileDialogEncryptTab.FileName = ""; // Dialog açıldığında dosya adı kısmı boş olsun

            if (openFileDialogEncryptTab.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialogEncryptTab.FileName;
                    textBoxPublicKeyEncrypt.Text = File.ReadAllText(filePath);
                    MessageBox.Show("Public Key dosyası başarıyla yüklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Public Key dosyası okunurken bir hata oluştu: {ex.Message}", "Dosya Okuma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonEncryptRsa_Click(object sender, EventArgs e)
        {
            // Girdileri al
            string publicKeyPem = textBoxPublicKeyEncrypt.Text;
            string plaintext = textBoxPlaintext.Text;

            if (string.IsNullOrWhiteSpace(publicKeyPem))
            {
                MessageBox.Show("Lütfen şifreleme için bir Public Key girin veya yükleyin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(plaintext)) // Boş metin de şifrelenebilir ama kullanıcıyı uyaralım
            {
                MessageBox.Show("Lütfen şifrelenecek bir metin girin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBoxEncryptionPadding.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir RSA dolgulama (padding) şeması seçin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1. Public Key'i PEM formatından BouncyCastle AsymmetricKeyParameter nesnesine çevir
                AsymmetricKeyParameter publicKey;
                using (StringReader sr = new StringReader(publicKeyPem))
                {
                    Org.BouncyCastle.OpenSsl.PemReader pemReader = new Org.BouncyCastle.OpenSsl.PemReader(sr);
                    object pemObject = pemReader.ReadObject();


                    if (pemObject is AsymmetricKeyParameter directPublicKey)
                    {
                        publicKey = directPublicKey;
                    }
                    // Bazen PemReader doğrudan RsaKeyParameters döndürebilir ya da SubjectPublicKeyInfo
                    else if (pemObject is SubjectPublicKeyInfo spki)
                    {
                        publicKey = PublicKeyFactory.CreateKey(spki);
                    }
                    // Eğer anahtar KeyGenerator'dan kopyalandıysa, tipik olarak SubjectPublicKeyInfo olacaktır.
                    else if (pemObject is Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo asn1Spki) // Farklı tipte SubjectPublicKeyInfo olabilir
                    {
                        publicKey = PublicKeyFactory.CreateKey(asn1Spki);
                    }
                    else
                    {
                        throw new Exception("Okunan PEM dosyası geçerli bir Public Key içermiyor veya formatı tanınmıyor.");
                    }
                }

                if (!(publicKey is RsaKeyParameters || publicKey.IsPrivate == false)) // RsaKeyParameters veya genel public key kontrolü
                {
                    throw new Exception("Sağlanan anahtar geçerli bir RSA Public Key değil.");
                }

                // 2. Şifreleme motorunu ve dolgulamayı ayarla
                IAsymmetricBlockCipher cipher;
                string selectedPadding = comboBoxEncryptionPadding.SelectedItem.ToString();

                RsaBlindedEngine rsaEngine = new RsaBlindedEngine(); // Veya RsaEngine()

                if (selectedPadding == "OAEPWithSHA-256AndMGF1Padding")
                {
                    cipher = new OaepEncoding(rsaEngine, new Sha256Digest(), new Sha256Digest(), null);
                }
                else if (selectedPadding == "OAEPWithSHA-1AndMGF1Padding")
                {
                    cipher = new OaepEncoding(rsaEngine, new Sha1Digest(), new Sha1Digest(), null);
                }
                else if (selectedPadding == "PKCS1Padding") // PKCS#1 v1.5
                {
                    cipher = new Pkcs1Encoding(rsaEngine);
                }
                else
                {
                    throw new Exception("Geçersiz dolgulama şeması seçildi.");
                }

                // Şifreleme modunda başlat
                cipher.Init(true, publicKey); // true = encryption mode

                // 3. Metni byte dizisine çevir (UTF-8)
                byte[] plaintextBytes = Encoding.UTF8.GetBytes(plaintext);

                // ---- RSA ŞİFRELEME BOYUT SINIRI UYARISI ----
                // RSA doğrudan büyük verileri şifrelemek için uygun değildir.
                // Şifrelenebilecek maksimum veri boyutu, anahtar boyutuna ve dolgulamaya bağlıdır.
                // Örneğin 2048-bit RSA ve OAEP-SHA256 ile yaklaşık 190 byte şifrelenebilir.
                // Eğer bu sınırı aşan veri varsa, ProcessBlock metodu hata verecektir.
                // Gerçek uygulamalarda büyük veriler için Hibrit Şifreleme kullanılır (RSA ile simetrik anahtar şifrelenir).
                int inputBlockSize = cipher.GetInputBlockSize();
                if (plaintextBytes.Length > inputBlockSize)
                {
                    MessageBox.Show($"Şifrelenecek metin çok uzun ({plaintextBytes.Length} bytes). " +
                                    $"Bu anahtar ve dolgulama ile maksimum {inputBlockSize} byte şifrelenebilir.\n" +
                                    "Daha uzun metinler için hibrit şifreleme yöntemleri kullanılır.",
                                    "Veri Boyutu Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // return; // İsteğe bağlı: İşlemi burada durdurabiliriz veya devam ettirip hata almasını bekleyebiliriz.
                }
                // ----------------------------------------------

                // 4. Şifreleme işlemini yap
                byte[] ciphertextBytes = cipher.ProcessBlock(plaintextBytes, 0, plaintextBytes.Length);

                // 5. Şifreli byte dizisini Base64 string'e çevir ve göster
                textBoxCiphertext.Text = Convert.ToBase64String(ciphertextBytes);

                MessageBox.Show("Metin başarıyla şifrelendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (InvalidCipherTextException icte) // Şifreleme/Çözme sırasında dolgulama veya veri hatası
            {
                MessageBox.Show($"Şifreleme hatası (veri veya dolgulama sorunu): {icte.Message}\n" +
                                "Şifrelenecek metin, seçilen anahtar boyutu ve dolgulama şeması için çok uzun olabilir.",
                                "Şifreleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Şifreleme sırasında bir hata oluştu: {ex.Message}\n\nDetay: {ex.ToString()}", "Genel Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLoadPrivateKeyDecrypt_Click(object sender, EventArgs e)
        {
            openFileDialogDecryptTab.Title = "Private Key PEM Dosyasını Seçin";
            openFileDialogDecryptTab.Filter = "PEM Dosyaları (*.pem)|*.pem|Tüm Dosyalar (*.*)|*.*";
            openFileDialogDecryptTab.FileName = ""; // Dialog açıldığında dosya adı kısmı boş olsun

            if (openFileDialogDecryptTab.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialogDecryptTab.FileName;
                    textBoxPrivateKeyDecrypt.Text = File.ReadAllText(filePath);
                    MessageBox.Show("Private Key dosyası başarıyla yüklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Private Key dosyası okunurken bir hata oluştu: {ex.Message}", "Dosya Okuma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDecryptRsa_Click(object sender, EventArgs e)
        {
            // Girdileri al
            string privateKeyPem = textBoxPrivateKeyDecrypt.Text;
            string password = textBoxPasswordDecrypt.Text; // Parola alanından parolayı al
            string ciphertextBase64 = textBoxCiphertextDecrypt.Text;

            if (string.IsNullOrWhiteSpace(privateKeyPem))
            {
                MessageBox.Show("Lütfen şifre çözme için bir Private Key girin veya yükleyin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(ciphertextBase64))
            {
                MessageBox.Show("Lütfen çözülecek şifreli bir metin (Base64) girin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBoxDecryptionPadding.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir RSA dolgulama (padding) şeması seçin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1. Private Key'i PEM formatından BouncyCastle AsymmetricKeyParameter nesnesine çevir
                AsymmetricKeyParameter privateKey;
                using (StringReader sr = new StringReader(privateKeyPem))
                {
                    Org.BouncyCastle.OpenSsl.PemReader pemReader = new Org.BouncyCastle.OpenSsl.PemReader(sr, new PasswordFinder(password));
                    object pemObject = pemReader.ReadObject();

                    if (pemObject == null)
                    {
                        throw new Exception("PEM içeriği okunamadı veya boş.");
                    }

                    if (pemObject is AsymmetricCipherKeyPair keyPair) // Eğer PemObject bir anahtar çifti ise
                    {
                        privateKey = keyPair.Private;
                    }
                    else if (pemObject is AsymmetricKeyParameter directPrivateKey) // Doğrudan özel anahtar parametresi ise
                    {
                        privateKey = directPrivateKey;
                    }
                    // Pkcs8EncryptedPrivateKeyInfo veya PrivateKeyInfo durumlarını da ele alabiliriz,
                    // ama PasswordFinder genellikle şifreli PEM'leri doğru bir şekilde çözer ve AsymmetricKeyParameter döndürür.
                    else
                    {
                        // Eğer PemReader şifreli bir anahtarı çözdüyse ve AsymmetricKeyParameter döndürmediyse,
                        // bu durum PrivateKeyFactory ile ele alınabilir, ancak PasswordFinder bunu yapmalı.
                        // Şimdilik bu durumu daha basit tutalım. Genellikle PemReader şifreli anahtarı PasswordFinder ile çözer.
                        throw new Exception($"Okunan PEM nesnesi beklenen özel anahtar formatında değil: {pemObject.GetType().Name}");
                    }
                }

                if (privateKey == null || !privateKey.IsPrivate)
                {
                    throw new Exception("Sağlanan anahtar geçerli bir RSA Private Key değil veya parola yanlış.");
                }

                // 2. Şifre çözme motorunu ve dolgulamayı ayarla
                IAsymmetricBlockCipher cipher;
                string selectedPadding = comboBoxDecryptionPadding.SelectedItem.ToString();
                RsaBlindedEngine rsaEngine = new RsaBlindedEngine();

                if (selectedPadding == "OAEPWithSHA-256AndMGF1Padding")
                {
                    cipher = new OaepEncoding(rsaEngine, new Sha256Digest(), new Sha256Digest(), null);
                }
                else if (selectedPadding == "OAEPWithSHA-1AndMGF1Padding")
                {
                    cipher = new OaepEncoding(rsaEngine, new Sha1Digest(), new Sha1Digest(), null);
                }
                else if (selectedPadding == "PKCS1Padding") // PKCS#1 v1.5
                {
                    cipher = new Pkcs1Encoding(rsaEngine);
                }
                else
                {
                    throw new Exception("Geçersiz dolgulama şeması seçildi.");
                }

                // Şifre çözme modunda başlat
                cipher.Init(false, privateKey); // false = decryption mode

                // 3. Base64 formatındaki şifreli metni byte dizisine çevir
                byte[] ciphertextBytes = Convert.FromBase64String(ciphertextBase64);

                // 4. Şifre çözme işlemini yap
                byte[] decryptedBytes = cipher.ProcessBlock(ciphertextBytes, 0, ciphertextBytes.Length);

                // 5. Çözülmüş byte dizisini UTF-8 string'e çevir ve göster
                textBoxDecryptedText.Text = Encoding.UTF8.GetString(decryptedBytes);

                MessageBox.Show("Metin başarıyla çözüldü!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidCipherTextException icte) // Şifre çözme sırasında dolgulama veya veri hatası
            {
                MessageBox.Show($"Şifre çözme hatası (veri, dolgulama veya parola sorunu): {icte.Message}\n" +
                                "Lütfen doğru Private Key, doğru parola (eğer varsa) ve doğru dolgulama şemasını kullandığınızdan emin olun.",
                                "Şifre Çözme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDecryptedText.Text = ""; // Hata durumunda sonucu temizle
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Şifre çözme sırasında bir hata oluştu: {ex.Message}\n\nDetay: {ex.ToString()}", "Genel Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDecryptedText.Text = ""; // Hata durumunda sonucu temizle
            }
        }
        // PemReader'a parola sağlamak için basit bir yardımcı sınıf
        public class PasswordFinder : IPasswordFinder
        {
            private readonly string _password;

            public PasswordFinder(string password)
            {
                _password = password;
            }

            public char[] GetPassword()
            {
                return string.IsNullOrEmpty(_password) ? null : _password.ToCharArray();
            }
        }

        private void buttonLoadPrivateKeySign_Click(object sender, EventArgs e)
        {
            // openFileDialogSignTab kontrolünün forma eklenmiş ve ayarlarının yapılmış olması lazım
            openFileDialogSignTab.Title = "İmzalama İçin Private Key PEM Dosyasını Seçin";
            openFileDialogSignTab.Filter = "PEM Dosyaları (*.pem)|*.pem|Tüm Dosyalar (*.*)|*.*";
            openFileDialogSignTab.FileName = ""; // Dialog açıldığında dosya adı kısmı boş olsun

            if (openFileDialogSignTab.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialogSignTab.FileName;
                    textBoxPrivateKeySign.Text = File.ReadAllText(filePath);
                    MessageBox.Show("Private Key dosyası (imzalama için) başarıyla yüklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Private Key dosyası okunurken bir hata oluştu: {ex.Message}", "Dosya Okuma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSignMessage_Click(object sender, EventArgs e)
        {
            // Girdileri al
            string privateKeyPem = textBoxPrivateKeySign.Text;
            string password = textBoxPasswordSign.Text; // Parola alanından parolayı al
            string messageToSign = textBoxMessageToSign.Text;

            if (string.IsNullOrWhiteSpace(privateKeyPem))
            {
                MessageBox.Show("Lütfen imzalama için bir Private Key girin veya yükleyin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Boş mesaj da imzalanabilir, bu yüzden burada zorunlu bir kontrol yapmayabiliriz.
            // if (string.IsNullOrEmpty(messageToSign))
            // {
            //     MessageBox.Show("Lütfen imzalanacak bir mesaj girin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //     return;
            // }

            try
            {
                // 1. Private Key'i PEM formatından BouncyCastle AsymmetricKeyParameter nesnesine çevir
                AsymmetricKeyParameter privateKey;
                using (StringReader sr = new StringReader(privateKeyPem))
                {
                    // Decryption sekmesinde kullandığımız PasswordFinder sınıfı burada da geçerli.
                    Org.BouncyCastle.OpenSsl.PemReader pemReader = new Org.BouncyCastle.OpenSsl.PemReader(sr, new PasswordFinder(password));
                    object pemObject = pemReader.ReadObject();
                    

                    if (pemObject == null)
                    {
                        throw new Exception("PEM içeriği okunamadı veya boş.");
                    }

                    if (pemObject is AsymmetricCipherKeyPair keyPair)
                    {
                        privateKey = keyPair.Private;
                    }
                    else if (pemObject is AsymmetricKeyParameter directPrivateKey)
                    {
                        privateKey = directPrivateKey;
                    }
                    else
                    {
                        throw new Exception($"Okunan PEM nesnesi beklenen özel anahtar formatında değil: {pemObject.GetType().Name}");
                    }
                }

                if (privateKey == null || !privateKey.IsPrivate)
                {
                    throw new Exception("Sağlanan anahtar geçerli bir RSA Private Key değil veya parola yanlış.");
                }

                // 2. İmzalanacak mesajı byte dizisine çevir (UTF-8)
                byte[] messageBytes = Encoding.UTF8.GetBytes(messageToSign);

                // 3. Mesajı SHA256 ile Hash'le
                // Standart .NET SHA256 sınıfını kullanabiliriz
                byte[] messageHash;
                using (SHA256 sha256 = SHA256.Create())
                {
                    messageHash = sha256.ComputeHash(messageBytes);
                }
                // Veya BouncyCastle Digest'lerini kullanabiliriz:
                // IDigest digest = new Sha256Digest();
                // digest.BlockUpdate(messageBytes, 0, messageBytes.Length);
                // messageHash = new byte[digest.GetDigestSize()];
                // digest.DoFinal(messageHash, 0);

                // 4. Hash'i RSA Private Key ile İmzala
                // BouncyCastle ISigner arayüzünü kullanacağız.
                // İmzalama şeması olarak genellikle "SHA256withRSA" kullanılır (PKCS#1 v1.5 padding ile).
                ISigner signer = SignerUtilities.GetSigner("SHA256withRSA");
                signer.Init(true, privateKey); // true = signing mode
                signer.BlockUpdate(messageBytes, 0, messageBytes.Length); // ÖNEMLİ: Hash'i değil, orijinal mesajı veriyoruz.
                                                                          // SignerUtilities.GetSigner("SHA256withRSA") zaten hash alıp imzalama işlemini bir arada yapar.
                                                                          // Eğer sadece hash'i imzalamak isteseydik, "NONEwithRSA" kullanıp hash'i manuel verirdik.

                byte[] signatureBytes = signer.GenerateSignature();

                // 5. İmzayı Base64 string'e çevir ve göster
                textBoxSignature.Text = Convert.ToBase64String(signatureBytes);

                MessageBox.Show("Mesaj başarıyla imzalandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Mesaj imzalama sırasında bir hata oluştu: {ex.Message}\n\nDetay: {ex.ToString()}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSignature.Text = ""; // Hata durumunda sonucu temizle
            }
        }

        private void buttonLoadPublicKeyVerify_Click(object sender, EventArgs e)
        {
            // openFileDialogVerifyTab kontrolünün forma eklenmiş ve ayarlarının yapılmış olması lazım
            openFileDialogVerifyTab.Title = "Doğrulama İçin Public Key PEM Dosyasını Seçin";
            openFileDialogVerifyTab.Filter = "PEM Dosyaları (*.pem)|*.pem|Tüm Dosyalar (*.*)|*.*";
            openFileDialogVerifyTab.FileName = ""; // Dialog açıldığında dosya adı kısmı boş olsun

            if (openFileDialogVerifyTab.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialogVerifyTab.FileName;
                    textBoxPublicKeyVerify.Text = File.ReadAllText(filePath);
                    MessageBox.Show("Public Key dosyası (doğrulama için) başarıyla yüklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Public Key dosyası okunurken bir hata oluştu: {ex.Message}", "Dosya Okuma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonVerifySignature_Click(object sender, EventArgs e)
        {
            // Girdileri al
            string publicKeyPem = textBoxPublicKeyVerify.Text;
            string originalMessage = textBoxOriginalMessageVerify.Text;
            string signatureBase64 = textBoxSignatureVerify.Text;

            // Girdi kontrolleri
            if (string.IsNullOrWhiteSpace(publicKeyPem))
            {
                MessageBox.Show("Lütfen doğrulama için bir Public Key girin veya yükleyin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labelVerificationResult.Text = "Doğrulama Sonucu: Bekleniyor...";
                return;
            }
            if (string.IsNullOrWhiteSpace(signatureBase64))
            {
                MessageBox.Show("Lütfen doğrulanacak bir imza (Base64) girin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labelVerificationResult.Text = "Doğrulama Sonucu: Bekleniyor...";
                return;
            }
            // Orijinal mesaj boş olabilir, boş mesaj da imzalanıp doğrulanabilir.

            try
            {
                // 1. Public Key'i PEM formatından BouncyCastle AsymmetricKeyParameter nesnesine çevir
                AsymmetricKeyParameter publicKey;
                using (StringReader sr = new StringReader(publicKeyPem))
                {
                    // "Encryption" ve "Decryption" sekmelerinde kullandığımız PemReader mantığı.
                    // Org.BouncyCastle.OpenSsl.PemReader kullandığımızdan emin olalım.
                    Org.BouncyCastle.OpenSsl.PemReader pemReader = new Org.BouncyCastle.OpenSsl.PemReader(sr);
                    object pemObject = pemReader.ReadObject();

                    if (pemObject == null)
                    {
                        throw new Exception("PEM içeriği okunamadı veya boş.");
                    }

                    if (pemObject is AsymmetricKeyParameter directPublicKey)
                    {
                        publicKey = directPublicKey;
                    }
                    else if (pemObject is SubjectPublicKeyInfo spki)
                    {
                        publicKey = PublicKeyFactory.CreateKey(spki);
                    }
                    else if (pemObject is Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo asn1Spki)
                    {
                        publicKey = PublicKeyFactory.CreateKey(asn1Spki);
                    }
                    else
                    {
                        throw new Exception($"Okunan PEM nesnesi beklenen public key formatında değil: {pemObject.GetType().Name}");
                    }
                }

                if (publicKey == null || publicKey.IsPrivate) // Public key olmalı
                {
                    throw new Exception("Sağlanan anahtar geçerli bir RSA Public Key değil.");
                }

                // 2. Orijinal mesajı byte dizisine çevir (UTF-8)
                byte[] messageBytes = Encoding.UTF8.GetBytes(originalMessage);

                // 3. Base64 formatındaki imzayı byte dizisine çevir
                byte[] signatureBytes = Convert.FromBase64String(signatureBase64);

                // 4. İmza doğrulama için ISigner nesnesi oluştur
                // İmzalama sırasında kullanılan algoritma ile aynı olmalı ("SHA256withRSA").
                ISigner verifier = SignerUtilities.GetSigner("SHA256withRSA");
                verifier.Init(false, publicKey); // false = verification mode
                verifier.BlockUpdate(messageBytes, 0, messageBytes.Length); // Orijinal mesajın byte'larını ver

                // 5. İmzayı doğrula
                bool isSignatureValid = verifier.VerifySignature(signatureBytes);

                // 6. Sonucu göster
                if (isSignatureValid)
                {
                    labelVerificationResult.Text = "Doğrulama Sonucu: İMZA GEÇERLİ";
                    labelVerificationResult.ForeColor = System.Drawing.Color.Green;
                    MessageBox.Show("İmza başarıyla doğrulandı!", "Doğrulama Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    labelVerificationResult.Text = "Doğrulama Sonucu: İMZA GEÇERSİZ!";
                    labelVerificationResult.ForeColor = System.Drawing.Color.Red;
                    MessageBox.Show("İmza doğrulanamadı. Mesaj, imza veya public key uyuşmuyor.", "Doğrulama Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException fex) // Base64 çevrim hatası için
            {
                MessageBox.Show($"Giriş formatı hatası (muhtemelen Base64 imza): {fex.Message}", "Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelVerificationResult.Text = "Doğrulama Sonucu: Hatalı Giriş";
                labelVerificationResult.ForeColor = System.Drawing.Color.DarkOrange;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İmza doğrulama sırasında bir hata oluştu: {ex.Message}\n\nDetay: {ex.ToString()}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelVerificationResult.Text = "Doğrulama Sonucu: Hata Oluştu";
                labelVerificationResult.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
