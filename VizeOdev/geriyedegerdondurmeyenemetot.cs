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
    public partial class geriyedegerdondurmeyenemetot : Form
    {
        public geriyedegerdondurmeyenemetot()
        {
            InitializeComponent();
     
        }
        private void SelamVer(string isim)
        {
            MessageBox.Show("Merhaba, " + isim + "!");
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
          
                string isim = txtIsim.Text;
                SelamVer(isim);
            

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
