// Sha256Form.cs

using System;
using System.IO; // Dosya işlemleri için
using System.Security.Cryptography; // SHA256 sınıfı için
using System.Text; // Encoding sınıfı için
using System.Windows.Forms;

namespace hash_algorithms_rsa_and_sha256 // Namespace'in projenle aynı olmalı
{
    public partial class Sha256Form : Form
    {
        public Sha256Form()
        {
            InitializeComponent();
        }

        // Form ilk yüklendiğinde çalışacak metot
        private void Sha256Form_Load(object sender, EventArgs e)
        {
            radioTextInput.Checked = true; // Başlangıçta "Metin Hashle" seçili olsun
            UpdateInputControls();         // Kontrollerin aktif/pasif durumunu ayarla
            labelActualSelectedFilePath.Text = ""; // Başlangıçta seçilen dosya yolu boş olsun
        }

        // "Metin Hashle" RadioButton'ının seçimi değiştiğinde
        private void radioTextInput_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTextInput.Checked)
            {
                UpdateInputControls();
            }
        }

        // "Dosya Hashle" RadioButton'ının seçimi değiştiğinde
        private void radioFileInput_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFileInput.Checked)
            {
                UpdateInputControls();
            }
        }

        // RadioButton seçimine göre ilgili kontrolleri aktif/pasif yapan yardımcı metot
        private void UpdateInputControls()
        {
            if (radioTextInput.Checked)
            {
                textBoxInput.Enabled = true;
                buttonSelectFile.Enabled = false;
                // labelActualSelectedFilePath.Text = ""; // Metin moduna geçince dosya yolu temizlenebilir (isteğe bağlı)
            }
            else // radioFileInput.Checked olmalı
            {
                textBoxInput.Enabled = false;
                // textBoxInput.Clear(); // Dosya moduna geçince metin girişi temizlenebilir (isteğe bağlı)
                buttonSelectFile.Enabled = true;
            }
        }

        // "Dosya Seç..." butonuna tıklandığında
        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            openFileDialogForSha.Title = "Hashlenecek Dosyayı Seçin";
            openFileDialogForSha.Filter = "Tüm Dosyalar (*.*)|*.*|Metin Dosyaları (*.txt)|*.txt|Resim Dosyaları (*.jpg;*.png)|*.jpg;*.png";
            openFileDialogForSha.FilterIndex = 1;
            openFileDialogForSha.FileName = ""; // Dialog açıldığında dosya adı kısmı boş olsun

            if (openFileDialogForSha.ShowDialog() == DialogResult.OK)
            {
                labelActualSelectedFilePath.Text = openFileDialogForSha.FileName; // Seçilen yolu Label'a yaz
                textBoxResultHash.Clear(); // Yeni dosya seçildiğinde önceki sonucu temizle
            }
        }

        // "SHA256 Hesapla" butonuna tıklandığında
        private void buttonCalculateHash_Click(object sender, EventArgs e)
        {
            textBoxResultHash.Clear(); // Önceki sonucu temizle

            try
            {
                using (SHA256 sha256Algorithm = SHA256.Create())
                {
                    byte[] hashBytes;

                    if (radioTextInput.Checked) // Metin hash'lenecekse
                    {
                        string inputText = textBoxInput.Text;
                        if (string.IsNullOrEmpty(inputText))
                        {
                            MessageBox.Show("Lütfen hash değeri hesaplanacak bir metin girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        hashBytes = sha256Algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputText));
                    }
                    else if (radioFileInput.Checked) // Dosya hash'lenecekse
                    {
                        string filePath = labelActualSelectedFilePath.Text; // Dosya yolunu Label'dan al
                        if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
                        {
                            MessageBox.Show("Lütfen geçerli bir dosya seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        using (FileStream fileStream = File.OpenRead(filePath))
                        {
                            hashBytes = sha256Algorithm.ComputeHash(fileStream);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen bir işlem türü seçin (Metin veya Dosya).", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    StringBuilder stringBuilder = new StringBuilder();
                    for (int i = 0; i < hashBytes.Length; i++)
                    {
                        stringBuilder.Append(hashBytes[i].ToString("x2"));
                    }
                    textBoxResultHash.Text = stringBuilder.ToString();
                }
            }
            catch (IOException ioEx)
            {
                MessageBox.Show($"Dosya okuma hatası: {ioEx.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException uaEx)
            {
                MessageBox.Show($"Dosyaya erişim yetkisi yok: {uaEx.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hash hesaplama sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelResultPrompt_Click(object sender, EventArgs e)
        {

        }
    }
}