using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizeOdev
{
    public partial class geriyedegerondurenmetot : Form
    {
        public geriyedegerondurenmetot()
        {
            InitializeComponent();
        }
        private int Toplam(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }


    

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);

            int sonuc = Toplam(sayi1, sayi2);

            MessageBox.Show("Sonuç: " + sonuc.ToString());
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Yeni formu oluştur
            Form1 yeniForm = new Form1();
            // Yeni formu aç
            yeniForm.Show();
            // Ana formu gizle (opsiyonel)
            this.Hide();
        }
    }
}
