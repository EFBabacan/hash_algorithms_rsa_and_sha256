# Hash ve RSA Kriptografi Aracı (hash_algorithms_rsa_and_sha256)

Bu proje, C# Windows Forms kullanılarak geliştirilmiş bir masaüstü uygulamasıdır. Temel kriptografik işlemleri kullanıcı dostu bir arayüz üzerinden gerçekleştirmeyi amaçlar.

## 📜 Açıklama

SHA256 algoritması ile metin ve dosya hash değerleri hesaplama; RSA algoritması ile anahtar çifti (Public/Private Key) üretme (PKCS#8 formatında hedefleniyor), metin şifreleme/çözme ve ileride mesaj imzalama/doğrulama gibi temel kriptografik işlemleri gerçekleştirmek için geliştirilmektedir.

## ✨ Temel Özellikler

### SHA256 Modülü
* Girilen metnin SHA256 hash değerini hesaplama.
* Seçilen dosyanın SHA256 hash değerini hesaplama.

### RSA Araç Kiti (Geliştirilmekte Olan ve Planlanan Özellikler)
* **Anahtar Üretici (Key Generator):**
    * Farklı bit uzunluklarında (1024, 2048, 4096) RSA anahtar çiftleri (Public/Private) üretme.
    * Özel anahtar için isteğe bağlı parola ile koruma (PKCS#8 formatında hedefleniyor).
    * Üretilen anahtarları PEM formatında gösterme ve kaydetme.
* **Şifreleme (Encryption):** (Planlanıyor)
    * Sağlanan bir Public Key ile metin şifreleme.
    * Farklı RSA dolgulama (padding) şemaları seçimi (örn: OAEP).
* **Şifre Çözme (Decryption):** (Planlanıyor)
    * Sağlanan bir Private Key ile şifreli metni çözme.
    * Gerekirse özel anahtar için parola girişi.
* **Mesaj İmzalama (Sign Message):** (Planlanıyor)
    * Sağlanan bir Private Key ve SHA256 hash algoritması ile mesaj imzalama.
* **İmza Doğrulama (Verify Signature):** (Planlanıyor)
    * Sağlanan bir Public Key ile mesajın ve imzanın doğruluğunu kontrol etme.

## 💻 Kullanılan Teknolojiler
* **Dil:** C#
* **Platform:** .NET Framework (Windows Forms)
* **IDE:** Visual Studio

## 🚀 Nasıl Kullanılır / Çalıştırılır?
1.  Bu depoyu klonlayın veya ZIP olarak indirin.
2.  `hash_algorithms_rsa_and_sha256.sln` çözüm dosyasını Visual Studio ile açın.
3.  Projeyi derleyin (Build) ve çalıştırın (Start).

(Not: Bu proje ISUBU Bilgisayar Mühendisliği 3. Sınıf 2. Dönem dersi olan Bili Güvenliği ve Kriptografi dersi için oluşturulmuştur. Saygılar Enes Furkan Babacan...)