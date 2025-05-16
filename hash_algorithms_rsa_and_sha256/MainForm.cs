using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hash_algorithms_rsa_and_sha256
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Metot Adınız Farklı Olabilir
        private void buttonShowSha256Form_Click(object sender, EventArgs e)
        {
            // 1. Sha256Form'dan yeni bir örnek (instance) oluşturuyoruz.
            //    Bu, bellekte Sha256Form'un bir kopyasını yaratır.

            Sha256Form sha256Window = new Sha256Form();

            // 2. Oluşturulan bu pencereyi kullanıcıya gösteriyoruz.
            //    ShowDialog(): Bu pencere kapatılana kadar ana formla etkileşimi durdurur.
            //    Bir işlem tamamlanana kadar bekletmek için idealdir.
            //    Show(): Bu pencereyi açar ama ana formla etkileşim devam edebilir.

            sha256Window.ShowDialog();
        }
    }
}
