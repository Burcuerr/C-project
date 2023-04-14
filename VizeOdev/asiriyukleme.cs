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
    public partial class asiriyukleme : Form
    {
        public asiriyukleme()
        {
            InitializeComponent();
        }

        private void SelamVer2(int sayi)
        {
            MessageBox.Show("Merhaba! en sevdğim sayı " + sayi + "");
        }

        // string türünde parametre alan metot
        private void SelamVer(string renk)
        {
            MessageBox.Show("Merhaba, en sevdiğim renk " + renk + "!");
        }

     


     

        private void btnString_Click_1(object sender, EventArgs e)
        {
            string renk = txtRenk.Text;
            SelamVer(renk);
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

        private void btnInt_Click(object sender, EventArgs e)
        {
           


            int sayi = Convert.ToInt32(txtSayi.Text);
            SelamVer2(sayi);
        }
    }
}
