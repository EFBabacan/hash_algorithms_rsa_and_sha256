namespace hash_algorithms_rsa_and_sha256
{
    partial class RsaToolkitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlRsa = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonSavePrivateKey = new System.Windows.Forms.Button();
            this.buttonSavePublicKey = new System.Windows.Forms.Button();
            this.textBoxPrivateKeyRsa = new System.Windows.Forms.TextBox();
            this.labelPrivateKeyRsa = new System.Windows.Forms.Label();
            this.textBoxPublicKeyRsa = new System.Windows.Forms.TextBox();
            this.labelPublicKeyRsa = new System.Windows.Forms.Label();
            this.textBoxPasswordConfirmKeyGen = new System.Windows.Forms.TextBox();
            this.labelPasswordConfirmPrompt = new System.Windows.Forms.Label();
            this.textBoxPasswordKeyGen = new System.Windows.Forms.TextBox();
            this.labelPasswordKeyGenPrompt = new System.Windows.Forms.Label();
            this.buttonGenerateKeysRsa = new System.Windows.Forms.Button();
            this.comboBoxKeySize = new System.Windows.Forms.ComboBox();
            this.labelKeySizePrompt = new System.Windows.Forms.Label();
            this.tabPageEncryption = new System.Windows.Forms.TabPage();
            this.tabPageSignMessage = new System.Windows.Forms.TabPage();
            this.tabPageVerifySignature = new System.Windows.Forms.TabPage();
            this.saveFileDialogKey = new System.Windows.Forms.SaveFileDialog();
            this.tabPageDecryption = new System.Windows.Forms.TabPage();
            this.labelPublicKeyEncryptPrompt = new System.Windows.Forms.Label();
            this.textBoxPublicKeyEncrypt = new System.Windows.Forms.TextBox();
            this.buttonLoadPublicKeyEncrypt = new System.Windows.Forms.Button();
            this.labelPlaintextPrompt = new System.Windows.Forms.Label();
            this.textBoxPlaintext = new System.Windows.Forms.TextBox();
            this.labelEncryptionPaddingPrompt = new System.Windows.Forms.Label();
            this.comboBoxEncryptionPadding = new System.Windows.Forms.ComboBox();
            this.buttonEncryptRsa = new System.Windows.Forms.Button();
            this.labelCiphertextPrompt = new System.Windows.Forms.Label();
            this.textBoxCiphertext = new System.Windows.Forms.TextBox();
            this.openFileDialogEncryptTab = new System.Windows.Forms.OpenFileDialog();
            this.labelPrivateKeyDecryptPrompt = new System.Windows.Forms.Label();
            this.textBoxPrivateKeyDecrypt = new System.Windows.Forms.TextBox();
            this.buttonLoadPrivateKeyDecrypt = new System.Windows.Forms.Button();
            this.labelPasswordDecryptPrompt = new System.Windows.Forms.Label();
            this.textBoxPasswordDecrypt = new System.Windows.Forms.TextBox();
            this.labelCiphertextDecryptPrompt = new System.Windows.Forms.Label();
            this.textBoxCiphertextDecrypt = new System.Windows.Forms.TextBox();
            this.labelDecryptionPaddingPrompt = new System.Windows.Forms.Label();
            this.comboBoxDecryptionPadding = new System.Windows.Forms.ComboBox();
            this.buttonDecryptRsa = new System.Windows.Forms.Button();
            this.labelDecryptedTextPrompt = new System.Windows.Forms.Label();
            this.textBoxDecryptedText = new System.Windows.Forms.TextBox();
            this.openFileDialogDecryptTab = new System.Windows.Forms.OpenFileDialog();
            this.labelPrivateKeySignPrompt = new System.Windows.Forms.Label();
            this.labelPasswordSignPrompt = new System.Windows.Forms.Label();
            this.labelMessageToSignPrompt = new System.Windows.Forms.Label();
            this.labelSignaturePrompt = new System.Windows.Forms.Label();
            this.textBoxPrivateKeySign = new System.Windows.Forms.TextBox();
            this.textBoxSignature = new System.Windows.Forms.TextBox();
            this.textBoxMessageToSign = new System.Windows.Forms.TextBox();
            this.textBoxPasswordSign = new System.Windows.Forms.TextBox();
            this.buttonLoadPrivateKeySign = new System.Windows.Forms.Button();
            this.buttonSignMessage = new System.Windows.Forms.Button();
            this.openFileDialogSignTab = new System.Windows.Forms.OpenFileDialog();
            this.labelPublicKeyVerifyPrompt = new System.Windows.Forms.Label();
            this.textBoxPublicKeyVerify = new System.Windows.Forms.TextBox();
            this.buttonLoadPublicKeyVerify = new System.Windows.Forms.Button();
            this.labelOriginalMessageVerifyPrompt = new System.Windows.Forms.Label();
            this.textBoxSignatureVerify = new System.Windows.Forms.TextBox();
            this.buttonVerifySignature = new System.Windows.Forms.Button();
            this.labelVerificationResult = new System.Windows.Forms.Label();
            this.openFileDialogVerifyTab = new System.Windows.Forms.OpenFileDialog();
            this.textBoxOriginalMessageVerify = new System.Windows.Forms.TextBox();
            this.labelSignatureVerifyPrompt = new System.Windows.Forms.Label();
            this.tabControlRsa.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageEncryption.SuspendLayout();
            this.tabPageSignMessage.SuspendLayout();
            this.tabPageVerifySignature.SuspendLayout();
            this.tabPageDecryption.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlRsa
            // 
            this.tabControlRsa.Controls.Add(this.tabPage1);
            this.tabControlRsa.Controls.Add(this.tabPageEncryption);
            this.tabControlRsa.Controls.Add(this.tabPageDecryption);
            this.tabControlRsa.Controls.Add(this.tabPageSignMessage);
            this.tabControlRsa.Controls.Add(this.tabPageVerifySignature);
            this.tabControlRsa.Location = new System.Drawing.Point(12, 12);
            this.tabControlRsa.Name = "tabControlRsa";
            this.tabControlRsa.SelectedIndex = 0;
            this.tabControlRsa.Size = new System.Drawing.Size(1240, 657);
            this.tabControlRsa.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonSavePrivateKey);
            this.tabPage1.Controls.Add(this.buttonSavePublicKey);
            this.tabPage1.Controls.Add(this.textBoxPrivateKeyRsa);
            this.tabPage1.Controls.Add(this.labelPrivateKeyRsa);
            this.tabPage1.Controls.Add(this.textBoxPublicKeyRsa);
            this.tabPage1.Controls.Add(this.labelPublicKeyRsa);
            this.tabPage1.Controls.Add(this.textBoxPasswordConfirmKeyGen);
            this.tabPage1.Controls.Add(this.labelPasswordConfirmPrompt);
            this.tabPage1.Controls.Add(this.textBoxPasswordKeyGen);
            this.tabPage1.Controls.Add(this.labelPasswordKeyGenPrompt);
            this.tabPage1.Controls.Add(this.buttonGenerateKeysRsa);
            this.tabPage1.Controls.Add(this.comboBoxKeySize);
            this.tabPage1.Controls.Add(this.labelKeySizePrompt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1232, 631);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Key Generator";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonSavePrivateKey
            // 
            this.buttonSavePrivateKey.Location = new System.Drawing.Point(489, 527);
            this.buttonSavePrivateKey.Name = "buttonSavePrivateKey";
            this.buttonSavePrivateKey.Size = new System.Drawing.Size(480, 23);
            this.buttonSavePrivateKey.TabIndex = 13;
            this.buttonSavePrivateKey.Text = "Private Key\'i Kaydet...";
            this.buttonSavePrivateKey.UseVisualStyleBackColor = true;
            this.buttonSavePrivateKey.Click += new System.EventHandler(this.buttonSavePrivateKey_Click);
            // 
            // buttonSavePublicKey
            // 
            this.buttonSavePublicKey.Location = new System.Drawing.Point(6, 527);
            this.buttonSavePublicKey.Name = "buttonSavePublicKey";
            this.buttonSavePublicKey.Size = new System.Drawing.Size(477, 23);
            this.buttonSavePublicKey.TabIndex = 12;
            this.buttonSavePublicKey.Text = "Public Key\'i Kaydet...";
            this.buttonSavePublicKey.UseVisualStyleBackColor = true;
            this.buttonSavePublicKey.Click += new System.EventHandler(this.buttonSavePublicKey_Click);
            // 
            // textBoxPrivateKeyRsa
            // 
            this.textBoxPrivateKeyRsa.Location = new System.Drawing.Point(489, 19);
            this.textBoxPrivateKeyRsa.Multiline = true;
            this.textBoxPrivateKeyRsa.Name = "textBoxPrivateKeyRsa";
            this.textBoxPrivateKeyRsa.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPrivateKeyRsa.Size = new System.Drawing.Size(480, 502);
            this.textBoxPrivateKeyRsa.TabIndex = 11;
            this.textBoxPrivateKeyRsa.WordWrap = false;
            this.textBoxPrivateKeyRsa.TextChanged += new System.EventHandler(this.textBoxPrivateKeyRsa_TextChanged);
            // 
            // labelPrivateKeyRsa
            // 
            this.labelPrivateKeyRsa.AutoSize = true;
            this.labelPrivateKeyRsa.Location = new System.Drawing.Point(490, 3);
            this.labelPrivateKeyRsa.Name = "labelPrivateKeyRsa";
            this.labelPrivateKeyRsa.Size = new System.Drawing.Size(212, 13);
            this.labelPrivateKeyRsa.TabIndex = 10;
            this.labelPrivateKeyRsa.Text = "Private Key (PKCS#8 PEM - Şifreli/Şifresiz):";
            this.labelPrivateKeyRsa.Click += new System.EventHandler(this.labelPrivateKeyRsa_Click);
            // 
            // textBoxPublicKeyRsa
            // 
            this.textBoxPublicKeyRsa.Location = new System.Drawing.Point(6, 166);
            this.textBoxPublicKeyRsa.Multiline = true;
            this.textBoxPublicKeyRsa.Name = "textBoxPublicKeyRsa";
            this.textBoxPublicKeyRsa.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPublicKeyRsa.Size = new System.Drawing.Size(477, 355);
            this.textBoxPublicKeyRsa.TabIndex = 9;
            this.textBoxPublicKeyRsa.WordWrap = false;
            // 
            // labelPublicKeyRsa
            // 
            this.labelPublicKeyRsa.AutoSize = true;
            this.labelPublicKeyRsa.Location = new System.Drawing.Point(6, 150);
            this.labelPublicKeyRsa.Name = "labelPublicKeyRsa";
            this.labelPublicKeyRsa.Size = new System.Drawing.Size(127, 13);
            this.labelPublicKeyRsa.TabIndex = 8;
            this.labelPublicKeyRsa.Text = "Public Key (PEM Format):";
            // 
            // textBoxPasswordConfirmKeyGen
            // 
            this.textBoxPasswordConfirmKeyGen.Location = new System.Drawing.Point(5, 98);
            this.textBoxPasswordConfirmKeyGen.Name = "textBoxPasswordConfirmKeyGen";
            this.textBoxPasswordConfirmKeyGen.Size = new System.Drawing.Size(166, 20);
            this.textBoxPasswordConfirmKeyGen.TabIndex = 7;
            // 
            // labelPasswordConfirmPrompt
            // 
            this.labelPasswordConfirmPrompt.AutoSize = true;
            this.labelPasswordConfirmPrompt.Location = new System.Drawing.Point(3, 82);
            this.labelPasswordConfirmPrompt.Name = "labelPasswordConfirmPrompt";
            this.labelPasswordConfirmPrompt.Size = new System.Drawing.Size(105, 13);
            this.labelPasswordConfirmPrompt.TabIndex = 6;
            this.labelPasswordConfirmPrompt.Text = "Parola Tekrar Giriniz ";
            // 
            // textBoxPasswordKeyGen
            // 
            this.textBoxPasswordKeyGen.Location = new System.Drawing.Point(3, 59);
            this.textBoxPasswordKeyGen.Name = "textBoxPasswordKeyGen";
            this.textBoxPasswordKeyGen.Size = new System.Drawing.Size(166, 20);
            this.textBoxPasswordKeyGen.TabIndex = 5;
            // 
            // labelPasswordKeyGenPrompt
            // 
            this.labelPasswordKeyGenPrompt.AutoSize = true;
            this.labelPasswordKeyGenPrompt.Location = new System.Drawing.Point(0, 43);
            this.labelPasswordKeyGenPrompt.Name = "labelPasswordKeyGenPrompt";
            this.labelPasswordKeyGenPrompt.Size = new System.Drawing.Size(171, 13);
            this.labelPasswordKeyGenPrompt.TabIndex = 4;
            this.labelPasswordKeyGenPrompt.Text = "Parola(Opsiyonel - Private Key için)";
            // 
            // buttonGenerateKeysRsa
            // 
            this.buttonGenerateKeysRsa.Location = new System.Drawing.Point(199, 59);
            this.buttonGenerateKeysRsa.Name = "buttonGenerateKeysRsa";
            this.buttonGenerateKeysRsa.Size = new System.Drawing.Size(212, 59);
            this.buttonGenerateKeysRsa.TabIndex = 3;
            this.buttonGenerateKeysRsa.Text = "Anahtarları Oluştur (PKCS#8 Hedefli)";
            this.buttonGenerateKeysRsa.UseVisualStyleBackColor = true;
            this.buttonGenerateKeysRsa.Click += new System.EventHandler(this.buttonGenerateKeysRsa_Click);
            // 
            // comboBoxKeySize
            // 
            this.comboBoxKeySize.FormattingEnabled = true;
            this.comboBoxKeySize.Items.AddRange(new object[] {
            "1024",
            "2048",
            "3072",
            "4096"});
            this.comboBoxKeySize.Location = new System.Drawing.Point(3, 19);
            this.comboBoxKeySize.Name = "comboBoxKeySize";
            this.comboBoxKeySize.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKeySize.TabIndex = 1;
            // 
            // labelKeySizePrompt
            // 
            this.labelKeySizePrompt.AutoSize = true;
            this.labelKeySizePrompt.Location = new System.Drawing.Point(6, 3);
            this.labelKeySizePrompt.Name = "labelKeySizePrompt";
            this.labelKeySizePrompt.Size = new System.Drawing.Size(80, 13);
            this.labelKeySizePrompt.TabIndex = 0;
            this.labelKeySizePrompt.Text = "Anahtar Boyutu";
            // 
            // tabPageEncryption
            // 
            this.tabPageEncryption.Controls.Add(this.textBoxCiphertext);
            this.tabPageEncryption.Controls.Add(this.labelCiphertextPrompt);
            this.tabPageEncryption.Controls.Add(this.buttonEncryptRsa);
            this.tabPageEncryption.Controls.Add(this.comboBoxEncryptionPadding);
            this.tabPageEncryption.Controls.Add(this.labelEncryptionPaddingPrompt);
            this.tabPageEncryption.Controls.Add(this.textBoxPlaintext);
            this.tabPageEncryption.Controls.Add(this.labelPlaintextPrompt);
            this.tabPageEncryption.Controls.Add(this.buttonLoadPublicKeyEncrypt);
            this.tabPageEncryption.Controls.Add(this.textBoxPublicKeyEncrypt);
            this.tabPageEncryption.Controls.Add(this.labelPublicKeyEncryptPrompt);
            this.tabPageEncryption.Location = new System.Drawing.Point(4, 22);
            this.tabPageEncryption.Name = "tabPageEncryption";
            this.tabPageEncryption.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEncryption.Size = new System.Drawing.Size(1232, 631);
            this.tabPageEncryption.TabIndex = 1;
            this.tabPageEncryption.Text = "Encryption";
            this.tabPageEncryption.UseVisualStyleBackColor = true;
            this.tabPageEncryption.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPageSignMessage
            // 
            this.tabPageSignMessage.Controls.Add(this.buttonSignMessage);
            this.tabPageSignMessage.Controls.Add(this.buttonLoadPrivateKeySign);
            this.tabPageSignMessage.Controls.Add(this.textBoxPasswordSign);
            this.tabPageSignMessage.Controls.Add(this.textBoxMessageToSign);
            this.tabPageSignMessage.Controls.Add(this.textBoxSignature);
            this.tabPageSignMessage.Controls.Add(this.textBoxPrivateKeySign);
            this.tabPageSignMessage.Controls.Add(this.labelSignaturePrompt);
            this.tabPageSignMessage.Controls.Add(this.labelMessageToSignPrompt);
            this.tabPageSignMessage.Controls.Add(this.labelPasswordSignPrompt);
            this.tabPageSignMessage.Controls.Add(this.labelPrivateKeySignPrompt);
            this.tabPageSignMessage.Location = new System.Drawing.Point(4, 22);
            this.tabPageSignMessage.Name = "tabPageSignMessage";
            this.tabPageSignMessage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSignMessage.Size = new System.Drawing.Size(1232, 631);
            this.tabPageSignMessage.TabIndex = 3;
            this.tabPageSignMessage.Text = "Sign Message";
            this.tabPageSignMessage.UseVisualStyleBackColor = true;
            // 
            // tabPageVerifySignature
            // 
            this.tabPageVerifySignature.Controls.Add(this.labelSignatureVerifyPrompt);
            this.tabPageVerifySignature.Controls.Add(this.textBoxOriginalMessageVerify);
            this.tabPageVerifySignature.Controls.Add(this.labelVerificationResult);
            this.tabPageVerifySignature.Controls.Add(this.buttonVerifySignature);
            this.tabPageVerifySignature.Controls.Add(this.textBoxSignatureVerify);
            this.tabPageVerifySignature.Controls.Add(this.labelOriginalMessageVerifyPrompt);
            this.tabPageVerifySignature.Controls.Add(this.buttonLoadPublicKeyVerify);
            this.tabPageVerifySignature.Controls.Add(this.textBoxPublicKeyVerify);
            this.tabPageVerifySignature.Controls.Add(this.labelPublicKeyVerifyPrompt);
            this.tabPageVerifySignature.Location = new System.Drawing.Point(4, 22);
            this.tabPageVerifySignature.Name = "tabPageVerifySignature";
            this.tabPageVerifySignature.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVerifySignature.Size = new System.Drawing.Size(1232, 631);
            this.tabPageVerifySignature.TabIndex = 4;
            this.tabPageVerifySignature.Text = "Verify Signature";
            this.tabPageVerifySignature.UseVisualStyleBackColor = true;
            // 
            // tabPageDecryption
            // 
            this.tabPageDecryption.Controls.Add(this.textBoxDecryptedText);
            this.tabPageDecryption.Controls.Add(this.labelDecryptedTextPrompt);
            this.tabPageDecryption.Controls.Add(this.buttonDecryptRsa);
            this.tabPageDecryption.Controls.Add(this.comboBoxDecryptionPadding);
            this.tabPageDecryption.Controls.Add(this.labelDecryptionPaddingPrompt);
            this.tabPageDecryption.Controls.Add(this.textBoxCiphertextDecrypt);
            this.tabPageDecryption.Controls.Add(this.labelCiphertextDecryptPrompt);
            this.tabPageDecryption.Controls.Add(this.textBoxPasswordDecrypt);
            this.tabPageDecryption.Controls.Add(this.labelPasswordDecryptPrompt);
            this.tabPageDecryption.Controls.Add(this.buttonLoadPrivateKeyDecrypt);
            this.tabPageDecryption.Controls.Add(this.textBoxPrivateKeyDecrypt);
            this.tabPageDecryption.Controls.Add(this.labelPrivateKeyDecryptPrompt);
            this.tabPageDecryption.Location = new System.Drawing.Point(4, 22);
            this.tabPageDecryption.Name = "tabPageDecryption";
            this.tabPageDecryption.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDecryption.Size = new System.Drawing.Size(1232, 631);
            this.tabPageDecryption.TabIndex = 2;
            this.tabPageDecryption.Text = "Decryption ";
            this.tabPageDecryption.UseVisualStyleBackColor = true;
            // 
            // labelPublicKeyEncryptPrompt
            // 
            this.labelPublicKeyEncryptPrompt.AutoSize = true;
            this.labelPublicKeyEncryptPrompt.Location = new System.Drawing.Point(7, 7);
            this.labelPublicKeyEncryptPrompt.Name = "labelPublicKeyEncryptPrompt";
            this.labelPublicKeyEncryptPrompt.Size = new System.Drawing.Size(187, 13);
            this.labelPublicKeyEncryptPrompt.TabIndex = 0;
            this.labelPublicKeyEncryptPrompt.Text = "Kullanılacak Public Key (PEM Format):";
            // 
            // textBoxPublicKeyEncrypt
            // 
            this.textBoxPublicKeyEncrypt.Location = new System.Drawing.Point(6, 23);
            this.textBoxPublicKeyEncrypt.Multiline = true;
            this.textBoxPublicKeyEncrypt.Name = "textBoxPublicKeyEncrypt";
            this.textBoxPublicKeyEncrypt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPublicKeyEncrypt.Size = new System.Drawing.Size(465, 228);
            this.textBoxPublicKeyEncrypt.TabIndex = 1;
            this.textBoxPublicKeyEncrypt.WordWrap = false;
            // 
            // buttonLoadPublicKeyEncrypt
            // 
            this.buttonLoadPublicKeyEncrypt.Location = new System.Drawing.Point(6, 257);
            this.buttonLoadPublicKeyEncrypt.Name = "buttonLoadPublicKeyEncrypt";
            this.buttonLoadPublicKeyEncrypt.Size = new System.Drawing.Size(465, 23);
            this.buttonLoadPublicKeyEncrypt.TabIndex = 2;
            this.buttonLoadPublicKeyEncrypt.Text = "Public Key Yükle...";
            this.buttonLoadPublicKeyEncrypt.UseVisualStyleBackColor = true;
            this.buttonLoadPublicKeyEncrypt.Click += new System.EventHandler(this.buttonLoadPublicKeyEncrypt_Click);
            // 
            // labelPlaintextPrompt
            // 
            this.labelPlaintextPrompt.AutoSize = true;
            this.labelPlaintextPrompt.Location = new System.Drawing.Point(3, 306);
            this.labelPlaintextPrompt.Name = "labelPlaintextPrompt";
            this.labelPlaintextPrompt.Size = new System.Drawing.Size(98, 13);
            this.labelPlaintextPrompt.TabIndex = 3;
            this.labelPlaintextPrompt.Text = "Şifrelenecek Metin:";
            // 
            // textBoxPlaintext
            // 
            this.textBoxPlaintext.Location = new System.Drawing.Point(6, 322);
            this.textBoxPlaintext.Multiline = true;
            this.textBoxPlaintext.Name = "textBoxPlaintext";
            this.textBoxPlaintext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPlaintext.Size = new System.Drawing.Size(419, 228);
            this.textBoxPlaintext.TabIndex = 4;
            // 
            // labelEncryptionPaddingPrompt
            // 
            this.labelEncryptionPaddingPrompt.AutoSize = true;
            this.labelEncryptionPaddingPrompt.Location = new System.Drawing.Point(488, 7);
            this.labelEncryptionPaddingPrompt.Name = "labelEncryptionPaddingPrompt";
            this.labelEncryptionPaddingPrompt.Size = new System.Drawing.Size(133, 13);
            this.labelEncryptionPaddingPrompt.TabIndex = 5;
            this.labelEncryptionPaddingPrompt.Text = "RSA Dolgulama (Padding):";
            // 
            // comboBoxEncryptionPadding
            // 
            this.comboBoxEncryptionPadding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEncryptionPadding.FormattingEnabled = true;
            this.comboBoxEncryptionPadding.Location = new System.Drawing.Point(491, 23);
            this.comboBoxEncryptionPadding.Name = "comboBoxEncryptionPadding";
            this.comboBoxEncryptionPadding.Size = new System.Drawing.Size(196, 21);
            this.comboBoxEncryptionPadding.TabIndex = 6;
            // 
            // buttonEncryptRsa
            // 
            this.buttonEncryptRsa.Location = new System.Drawing.Point(491, 50);
            this.buttonEncryptRsa.Name = "buttonEncryptRsa";
            this.buttonEncryptRsa.Size = new System.Drawing.Size(196, 23);
            this.buttonEncryptRsa.TabIndex = 7;
            this.buttonEncryptRsa.Text = "Metni Şifrele";
            this.buttonEncryptRsa.UseVisualStyleBackColor = true;
            this.buttonEncryptRsa.Click += new System.EventHandler(this.buttonEncryptRsa_Click);
            // 
            // labelCiphertextPrompt
            // 
            this.labelCiphertextPrompt.AutoSize = true;
            this.labelCiphertextPrompt.Location = new System.Drawing.Point(428, 306);
            this.labelCiphertextPrompt.Name = "labelCiphertextPrompt";
            this.labelCiphertextPrompt.Size = new System.Drawing.Size(109, 13);
            this.labelCiphertextPrompt.TabIndex = 8;
            this.labelCiphertextPrompt.Text = "Şifreli Metin (Base64):";
            // 
            // textBoxCiphertext
            // 
            this.textBoxCiphertext.Location = new System.Drawing.Point(431, 322);
            this.textBoxCiphertext.Multiline = true;
            this.textBoxCiphertext.Name = "textBoxCiphertext";
            this.textBoxCiphertext.ReadOnly = true;
            this.textBoxCiphertext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCiphertext.Size = new System.Drawing.Size(542, 227);
            this.textBoxCiphertext.TabIndex = 9;
            this.textBoxCiphertext.WordWrap = false;
            // 
            // openFileDialogEncryptTab
            // 
            this.openFileDialogEncryptTab.Filter = "PEM Dosyaları (*.pem)|*.pem|Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*";
            this.openFileDialogEncryptTab.Title = "Public Key Dosyasını Seçin";
            // 
            // labelPrivateKeyDecryptPrompt
            // 
            this.labelPrivateKeyDecryptPrompt.AutoSize = true;
            this.labelPrivateKeyDecryptPrompt.Location = new System.Drawing.Point(6, 3);
            this.labelPrivateKeyDecryptPrompt.Name = "labelPrivateKeyDecryptPrompt";
            this.labelPrivateKeyDecryptPrompt.Size = new System.Drawing.Size(191, 13);
            this.labelPrivateKeyDecryptPrompt.TabIndex = 0;
            this.labelPrivateKeyDecryptPrompt.Text = "Kullanılacak Private Key (PEM Format):";
            // 
            // textBoxPrivateKeyDecrypt
            // 
            this.textBoxPrivateKeyDecrypt.Location = new System.Drawing.Point(6, 19);
            this.textBoxPrivateKeyDecrypt.Multiline = true;
            this.textBoxPrivateKeyDecrypt.Name = "textBoxPrivateKeyDecrypt";
            this.textBoxPrivateKeyDecrypt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPrivateKeyDecrypt.Size = new System.Drawing.Size(470, 352);
            this.textBoxPrivateKeyDecrypt.TabIndex = 1;
            this.textBoxPrivateKeyDecrypt.WordWrap = false;
            // 
            // buttonLoadPrivateKeyDecrypt
            // 
            this.buttonLoadPrivateKeyDecrypt.Location = new System.Drawing.Point(6, 377);
            this.buttonLoadPrivateKeyDecrypt.Name = "buttonLoadPrivateKeyDecrypt";
            this.buttonLoadPrivateKeyDecrypt.Size = new System.Drawing.Size(470, 23);
            this.buttonLoadPrivateKeyDecrypt.TabIndex = 2;
            this.buttonLoadPrivateKeyDecrypt.Text = "Private Key Yükle...";
            this.buttonLoadPrivateKeyDecrypt.UseVisualStyleBackColor = true;
            this.buttonLoadPrivateKeyDecrypt.Click += new System.EventHandler(this.buttonLoadPrivateKeyDecrypt_Click);
            // 
            // labelPasswordDecryptPrompt
            // 
            this.labelPasswordDecryptPrompt.AutoSize = true;
            this.labelPasswordDecryptPrompt.Location = new System.Drawing.Point(6, 409);
            this.labelPasswordDecryptPrompt.Name = "labelPasswordDecryptPrompt";
            this.labelPasswordDecryptPrompt.Size = new System.Drawing.Size(179, 13);
            this.labelPasswordDecryptPrompt.TabIndex = 3;
            this.labelPasswordDecryptPrompt.Text = "Private Key Parolası (Eğer Şifreliyse):";
            // 
            // textBoxPasswordDecrypt
            // 
            this.textBoxPasswordDecrypt.Location = new System.Drawing.Point(191, 406);
            this.textBoxPasswordDecrypt.Name = "textBoxPasswordDecrypt";
            this.textBoxPasswordDecrypt.PasswordChar = '*';
            this.textBoxPasswordDecrypt.Size = new System.Drawing.Size(285, 20);
            this.textBoxPasswordDecrypt.TabIndex = 4;
            this.textBoxPasswordDecrypt.UseSystemPasswordChar = true;
            // 
            // labelCiphertextDecryptPrompt
            // 
            this.labelCiphertextDecryptPrompt.AutoSize = true;
            this.labelCiphertextDecryptPrompt.Location = new System.Drawing.Point(484, 3);
            this.labelCiphertextDecryptPrompt.Name = "labelCiphertextDecryptPrompt";
            this.labelCiphertextDecryptPrompt.Size = new System.Drawing.Size(162, 13);
            this.labelCiphertextDecryptPrompt.TabIndex = 5;
            this.labelCiphertextDecryptPrompt.Text = "Çözülecek Şifreli Metin (Base64):";
            // 
            // textBoxCiphertextDecrypt
            // 
            this.textBoxCiphertextDecrypt.Location = new System.Drawing.Point(487, 19);
            this.textBoxCiphertextDecrypt.Multiline = true;
            this.textBoxCiphertextDecrypt.Name = "textBoxCiphertextDecrypt";
            this.textBoxCiphertextDecrypt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxCiphertextDecrypt.Size = new System.Drawing.Size(470, 250);
            this.textBoxCiphertextDecrypt.TabIndex = 6;
            // 
            // labelDecryptionPaddingPrompt
            // 
            this.labelDecryptionPaddingPrompt.AutoSize = true;
            this.labelDecryptionPaddingPrompt.Location = new System.Drawing.Point(6, 440);
            this.labelDecryptionPaddingPrompt.Name = "labelDecryptionPaddingPrompt";
            this.labelDecryptionPaddingPrompt.Size = new System.Drawing.Size(174, 13);
            this.labelDecryptionPaddingPrompt.TabIndex = 7;
            this.labelDecryptionPaddingPrompt.Text = "Şifre Çözme Dolgulaması (Padding):";
            // 
            // comboBoxDecryptionPadding
            // 
            this.comboBoxDecryptionPadding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDecryptionPadding.FormattingEnabled = true;
            this.comboBoxDecryptionPadding.Location = new System.Drawing.Point(191, 440);
            this.comboBoxDecryptionPadding.Name = "comboBoxDecryptionPadding";
            this.comboBoxDecryptionPadding.Size = new System.Drawing.Size(285, 21);
            this.comboBoxDecryptionPadding.TabIndex = 8;
            // 
            // buttonDecryptRsa
            // 
            this.buttonDecryptRsa.Location = new System.Drawing.Point(9, 467);
            this.buttonDecryptRsa.Name = "buttonDecryptRsa";
            this.buttonDecryptRsa.Size = new System.Drawing.Size(467, 89);
            this.buttonDecryptRsa.TabIndex = 9;
            this.buttonDecryptRsa.Text = "Metni Çöz";
            this.buttonDecryptRsa.UseVisualStyleBackColor = true;
            this.buttonDecryptRsa.Click += new System.EventHandler(this.buttonDecryptRsa_Click);
            // 
            // labelDecryptedTextPrompt
            // 
            this.labelDecryptedTextPrompt.AutoSize = true;
            this.labelDecryptedTextPrompt.Location = new System.Drawing.Point(484, 283);
            this.labelDecryptedTextPrompt.Name = "labelDecryptedTextPrompt";
            this.labelDecryptedTextPrompt.Size = new System.Drawing.Size(84, 13);
            this.labelDecryptedTextPrompt.TabIndex = 10;
            this.labelDecryptedTextPrompt.Text = "Çözülmüş Metin:";
            // 
            // textBoxDecryptedText
            // 
            this.textBoxDecryptedText.Location = new System.Drawing.Point(482, 299);
            this.textBoxDecryptedText.Multiline = true;
            this.textBoxDecryptedText.Name = "textBoxDecryptedText";
            this.textBoxDecryptedText.ReadOnly = true;
            this.textBoxDecryptedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDecryptedText.Size = new System.Drawing.Size(475, 257);
            this.textBoxDecryptedText.TabIndex = 11;
            // 
            // openFileDialogDecryptTab
            // 
            this.openFileDialogDecryptTab.FileName = "openFileDialog1";
            this.openFileDialogDecryptTab.Filter = "PEM Dosyaları (*.pem)|*.pem|Tüm Dosyalar (*.*)|*.*";
            this.openFileDialogDecryptTab.Title = "Private Key PEM Dosyasını Seçin";
            // 
            // labelPrivateKeySignPrompt
            // 
            this.labelPrivateKeySignPrompt.AutoSize = true;
            this.labelPrivateKeySignPrompt.Location = new System.Drawing.Point(6, 3);
            this.labelPrivateKeySignPrompt.Name = "labelPrivateKeySignPrompt";
            this.labelPrivateKeySignPrompt.Size = new System.Drawing.Size(191, 13);
            this.labelPrivateKeySignPrompt.TabIndex = 0;
            this.labelPrivateKeySignPrompt.Text = "Kullanılacak Private Key (PEM Format):";
            // 
            // labelPasswordSignPrompt
            // 
            this.labelPasswordSignPrompt.AutoSize = true;
            this.labelPasswordSignPrompt.Location = new System.Drawing.Point(6, 308);
            this.labelPasswordSignPrompt.Name = "labelPasswordSignPrompt";
            this.labelPasswordSignPrompt.Size = new System.Drawing.Size(179, 13);
            this.labelPasswordSignPrompt.TabIndex = 1;
            this.labelPasswordSignPrompt.Text = "Private Key Parolası (Eğer Şifreliyse):";
            // 
            // labelMessageToSignPrompt
            // 
            this.labelMessageToSignPrompt.AutoSize = true;
            this.labelMessageToSignPrompt.Location = new System.Drawing.Point(6, 330);
            this.labelMessageToSignPrompt.Name = "labelMessageToSignPrompt";
            this.labelMessageToSignPrompt.Size = new System.Drawing.Size(101, 13);
            this.labelMessageToSignPrompt.TabIndex = 2;
            this.labelMessageToSignPrompt.Text = "İmzalanacak Mesaj:";
            // 
            // labelSignaturePrompt
            // 
            this.labelSignaturePrompt.AutoSize = true;
            this.labelSignaturePrompt.Location = new System.Drawing.Point(446, 0);
            this.labelSignaturePrompt.Name = "labelSignaturePrompt";
            this.labelSignaturePrompt.Size = new System.Drawing.Size(133, 13);
            this.labelSignaturePrompt.TabIndex = 3;
            this.labelSignaturePrompt.Text = "Oluşturulan İmza (Base64):";
            // 
            // textBoxPrivateKeySign
            // 
            this.textBoxPrivateKeySign.Location = new System.Drawing.Point(6, 19);
            this.textBoxPrivateKeySign.Multiline = true;
            this.textBoxPrivateKeySign.Name = "textBoxPrivateKeySign";
            this.textBoxPrivateKeySign.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPrivateKeySign.Size = new System.Drawing.Size(408, 250);
            this.textBoxPrivateKeySign.TabIndex = 4;
            this.textBoxPrivateKeySign.WordWrap = false;
            // 
            // textBoxSignature
            // 
            this.textBoxSignature.Location = new System.Drawing.Point(449, 19);
            this.textBoxSignature.Multiline = true;
            this.textBoxSignature.Name = "textBoxSignature";
            this.textBoxSignature.ReadOnly = true;
            this.textBoxSignature.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSignature.Size = new System.Drawing.Size(524, 250);
            this.textBoxSignature.TabIndex = 5;
            this.textBoxSignature.WordWrap = false;
            // 
            // textBoxMessageToSign
            // 
            this.textBoxMessageToSign.Location = new System.Drawing.Point(9, 346);
            this.textBoxMessageToSign.Multiline = true;
            this.textBoxMessageToSign.Name = "textBoxMessageToSign";
            this.textBoxMessageToSign.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessageToSign.Size = new System.Drawing.Size(402, 144);
            this.textBoxMessageToSign.TabIndex = 6;
            // 
            // textBoxPasswordSign
            // 
            this.textBoxPasswordSign.Location = new System.Drawing.Point(191, 301);
            this.textBoxPasswordSign.Name = "textBoxPasswordSign";
            this.textBoxPasswordSign.PasswordChar = '*';
            this.textBoxPasswordSign.Size = new System.Drawing.Size(220, 20);
            this.textBoxPasswordSign.TabIndex = 7;
            this.textBoxPasswordSign.UseSystemPasswordChar = true;
            // 
            // buttonLoadPrivateKeySign
            // 
            this.buttonLoadPrivateKeySign.Location = new System.Drawing.Point(3, 275);
            this.buttonLoadPrivateKeySign.Name = "buttonLoadPrivateKeySign";
            this.buttonLoadPrivateKeySign.Size = new System.Drawing.Size(408, 23);
            this.buttonLoadPrivateKeySign.TabIndex = 8;
            this.buttonLoadPrivateKeySign.Text = "Private Key Yükle...";
            this.buttonLoadPrivateKeySign.UseVisualStyleBackColor = true;
            this.buttonLoadPrivateKeySign.Click += new System.EventHandler(this.buttonLoadPrivateKeySign_Click);
            // 
            // buttonSignMessage
            // 
            this.buttonSignMessage.Location = new System.Drawing.Point(9, 496);
            this.buttonSignMessage.Name = "buttonSignMessage";
            this.buttonSignMessage.Size = new System.Drawing.Size(402, 54);
            this.buttonSignMessage.TabIndex = 9;
            this.buttonSignMessage.Text = "Mesajı İmzala (SHA256 ile)";
            this.buttonSignMessage.UseVisualStyleBackColor = true;
            this.buttonSignMessage.Click += new System.EventHandler(this.buttonSignMessage_Click);
            // 
            // openFileDialogSignTab
            // 
            this.openFileDialogSignTab.Filter = "PEM Dosyaları (*.pem)|*.pem|Tüm Dosyalar (*.*)|*.*";
            this.openFileDialogSignTab.Title = "İmzalama İçin Private Key PEM Dosyasını Seçin";
            // 
            // labelPublicKeyVerifyPrompt
            // 
            this.labelPublicKeyVerifyPrompt.AutoSize = true;
            this.labelPublicKeyVerifyPrompt.Location = new System.Drawing.Point(4, 7);
            this.labelPublicKeyVerifyPrompt.Name = "labelPublicKeyVerifyPrompt";
            this.labelPublicKeyVerifyPrompt.Size = new System.Drawing.Size(187, 13);
            this.labelPublicKeyVerifyPrompt.TabIndex = 0;
            this.labelPublicKeyVerifyPrompt.Text = "Kullanılacak Public Key (PEM Format):";
            // 
            // textBoxPublicKeyVerify
            // 
            this.textBoxPublicKeyVerify.Location = new System.Drawing.Point(7, 23);
            this.textBoxPublicKeyVerify.Multiline = true;
            this.textBoxPublicKeyVerify.Name = "textBoxPublicKeyVerify";
            this.textBoxPublicKeyVerify.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPublicKeyVerify.Size = new System.Drawing.Size(510, 197);
            this.textBoxPublicKeyVerify.TabIndex = 1;
            this.textBoxPublicKeyVerify.WordWrap = false;
            // 
            // buttonLoadPublicKeyVerify
            // 
            this.buttonLoadPublicKeyVerify.Location = new System.Drawing.Point(7, 226);
            this.buttonLoadPublicKeyVerify.Name = "buttonLoadPublicKeyVerify";
            this.buttonLoadPublicKeyVerify.Size = new System.Drawing.Size(286, 23);
            this.buttonLoadPublicKeyVerify.TabIndex = 2;
            this.buttonLoadPublicKeyVerify.Text = "Public Key Yükle...";
            this.buttonLoadPublicKeyVerify.UseVisualStyleBackColor = true;
            this.buttonLoadPublicKeyVerify.Click += new System.EventHandler(this.buttonLoadPublicKeyVerify_Click);
            // 
            // labelOriginalMessageVerifyPrompt
            // 
            this.labelOriginalMessageVerifyPrompt.AutoSize = true;
            this.labelOriginalMessageVerifyPrompt.Location = new System.Drawing.Point(6, 252);
            this.labelOriginalMessageVerifyPrompt.Name = "labelOriginalMessageVerifyPrompt";
            this.labelOriginalMessageVerifyPrompt.Size = new System.Drawing.Size(72, 13);
            this.labelOriginalMessageVerifyPrompt.TabIndex = 3;
            this.labelOriginalMessageVerifyPrompt.Text = "Orijinal Mesaj:";
            // 
            // textBoxSignatureVerify
            // 
            this.textBoxSignatureVerify.Location = new System.Drawing.Point(549, 23);
            this.textBoxSignatureVerify.Multiline = true;
            this.textBoxSignatureVerify.Name = "textBoxSignatureVerify";
            this.textBoxSignatureVerify.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSignatureVerify.Size = new System.Drawing.Size(414, 71);
            this.textBoxSignatureVerify.TabIndex = 4;
            this.textBoxSignatureVerify.WordWrap = false;
            // 
            // buttonVerifySignature
            // 
            this.buttonVerifySignature.Location = new System.Drawing.Point(9, 527);
            this.buttonVerifySignature.Name = "buttonVerifySignature";
            this.buttonVerifySignature.Size = new System.Drawing.Size(284, 23);
            this.buttonVerifySignature.TabIndex = 5;
            this.buttonVerifySignature.Text = "İmzayı Doğrula (SHA256 ile)";
            this.buttonVerifySignature.UseVisualStyleBackColor = true;
            this.buttonVerifySignature.Click += new System.EventHandler(this.buttonVerifySignature_Click);
            // 
            // labelVerificationResult
            // 
            this.labelVerificationResult.AutoSize = true;
            this.labelVerificationResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelVerificationResult.Location = new System.Drawing.Point(546, 252);
            this.labelVerificationResult.Name = "labelVerificationResult";
            this.labelVerificationResult.Size = new System.Drawing.Size(118, 13);
            this.labelVerificationResult.TabIndex = 6;
            this.labelVerificationResult.Text = "Doğrulama Sonucu:";
            // 
            // openFileDialogVerifyTab
            // 
            this.openFileDialogVerifyTab.Filter = "PEM Dosyaları (*.pem)|*.pem|Tüm Dosyalar (*.*)|*.*";
            // 
            // textBoxOriginalMessageVerify
            // 
            this.textBoxOriginalMessageVerify.Location = new System.Drawing.Point(9, 269);
            this.textBoxOriginalMessageVerify.Multiline = true;
            this.textBoxOriginalMessageVerify.Name = "textBoxOriginalMessageVerify";
            this.textBoxOriginalMessageVerify.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOriginalMessageVerify.Size = new System.Drawing.Size(284, 252);
            this.textBoxOriginalMessageVerify.TabIndex = 7;
            this.textBoxOriginalMessageVerify.WordWrap = false;
            // 
            // labelSignatureVerifyPrompt
            // 
            this.labelSignatureVerifyPrompt.AutoSize = true;
            this.labelSignatureVerifyPrompt.Location = new System.Drawing.Point(546, 7);
            this.labelSignatureVerifyPrompt.Name = "labelSignatureVerifyPrompt";
            this.labelSignatureVerifyPrompt.Size = new System.Drawing.Size(147, 13);
            this.labelSignatureVerifyPrompt.TabIndex = 8;
            this.labelSignatureVerifyPrompt.Text = "Doğrulanacak İmza (Base64):";
            // 
            // RsaToolkitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tabControlRsa);
            this.Name = "RsaToolkitForm";
            this.Text = "RsaToolkitForm";
            this.Load += new System.EventHandler(this.RsaToolkitForm_Load);
            this.tabControlRsa.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPageEncryption.ResumeLayout(false);
            this.tabPageEncryption.PerformLayout();
            this.tabPageSignMessage.ResumeLayout(false);
            this.tabPageSignMessage.PerformLayout();
            this.tabPageVerifySignature.ResumeLayout(false);
            this.tabPageVerifySignature.PerformLayout();
            this.tabPageDecryption.ResumeLayout(false);
            this.tabPageDecryption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlRsa;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageEncryption;
        private System.Windows.Forms.Button buttonGenerateKeysRsa;
        private System.Windows.Forms.ComboBox comboBoxKeySize;
        private System.Windows.Forms.Label labelKeySizePrompt;
        private System.Windows.Forms.Label labelPasswordConfirmPrompt;
        private System.Windows.Forms.TextBox textBoxPasswordKeyGen;
        private System.Windows.Forms.Label labelPasswordKeyGenPrompt;
        private System.Windows.Forms.TextBox textBoxPasswordConfirmKeyGen;
        private System.Windows.Forms.Button buttonSavePrivateKey;
        private System.Windows.Forms.Button buttonSavePublicKey;
        private System.Windows.Forms.TextBox textBoxPrivateKeyRsa;
        private System.Windows.Forms.Label labelPrivateKeyRsa;
        private System.Windows.Forms.TextBox textBoxPublicKeyRsa;
        private System.Windows.Forms.Label labelPublicKeyRsa;
        private System.Windows.Forms.SaveFileDialog saveFileDialogKey;
        private System.Windows.Forms.TabPage tabPageSignMessage;
        private System.Windows.Forms.TabPage tabPageVerifySignature;
        private System.Windows.Forms.TabPage tabPageDecryption;
        private System.Windows.Forms.TextBox textBoxPublicKeyEncrypt;
        private System.Windows.Forms.Label labelPublicKeyEncryptPrompt;
        private System.Windows.Forms.Label labelEncryptionPaddingPrompt;
        private System.Windows.Forms.TextBox textBoxPlaintext;
        private System.Windows.Forms.Label labelPlaintextPrompt;
        private System.Windows.Forms.Button buttonLoadPublicKeyEncrypt;
        private System.Windows.Forms.TextBox textBoxCiphertext;
        private System.Windows.Forms.Label labelCiphertextPrompt;
        private System.Windows.Forms.Button buttonEncryptRsa;
        private System.Windows.Forms.ComboBox comboBoxEncryptionPadding;
        private System.Windows.Forms.OpenFileDialog openFileDialogEncryptTab;
        private System.Windows.Forms.TextBox textBoxPrivateKeyDecrypt;
        private System.Windows.Forms.Label labelPrivateKeyDecryptPrompt;
        private System.Windows.Forms.TextBox textBoxCiphertextDecrypt;
        private System.Windows.Forms.Label labelCiphertextDecryptPrompt;
        private System.Windows.Forms.TextBox textBoxPasswordDecrypt;
        private System.Windows.Forms.Label labelPasswordDecryptPrompt;
        private System.Windows.Forms.Button buttonLoadPrivateKeyDecrypt;
        private System.Windows.Forms.TextBox textBoxDecryptedText;
        private System.Windows.Forms.Label labelDecryptedTextPrompt;
        private System.Windows.Forms.Button buttonDecryptRsa;
        private System.Windows.Forms.ComboBox comboBoxDecryptionPadding;
        private System.Windows.Forms.Label labelDecryptionPaddingPrompt;
        private System.Windows.Forms.OpenFileDialog openFileDialogDecryptTab;
        private System.Windows.Forms.Button buttonLoadPrivateKeySign;
        private System.Windows.Forms.TextBox textBoxPasswordSign;
        private System.Windows.Forms.TextBox textBoxMessageToSign;
        private System.Windows.Forms.TextBox textBoxSignature;
        private System.Windows.Forms.TextBox textBoxPrivateKeySign;
        private System.Windows.Forms.Label labelSignaturePrompt;
        private System.Windows.Forms.Label labelMessageToSignPrompt;
        private System.Windows.Forms.Label labelPasswordSignPrompt;
        private System.Windows.Forms.Label labelPrivateKeySignPrompt;
        private System.Windows.Forms.Button buttonSignMessage;
        private System.Windows.Forms.OpenFileDialog openFileDialogSignTab;
        private System.Windows.Forms.Label labelVerificationResult;
        private System.Windows.Forms.Button buttonVerifySignature;
        private System.Windows.Forms.TextBox textBoxSignatureVerify;
        private System.Windows.Forms.Label labelOriginalMessageVerifyPrompt;
        private System.Windows.Forms.Button buttonLoadPublicKeyVerify;
        private System.Windows.Forms.TextBox textBoxPublicKeyVerify;
        private System.Windows.Forms.Label labelPublicKeyVerifyPrompt;
        private System.Windows.Forms.OpenFileDialog openFileDialogVerifyTab;
        private System.Windows.Forms.TextBox textBoxOriginalMessageVerify;
        private System.Windows.Forms.Label labelSignatureVerifyPrompt;
    }
}