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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Yeni formu oluştur
            tekboyutludizi yeniForm = new tekboyutludizi();
            // Yeni formu aç
            yeniForm.Show();
            // Ana formu gizle (opsiyonel)
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Yeni formu oluştur
            cokboyutludizi yeniForm = new cokboyutludizi();
            // Yeni formu aç
            yeniForm.Show();
            // Ana formu gizle (opsiyonel)
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Yeni formu oluştur
            geriyedegerondurenmetot yeniForm = new geriyedegerondurenmetot();
            // Yeni formu aç
            yeniForm.Show();
            // Ana formu gizle (opsiyonel)
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Yeni formu oluştur
            geriyedegerdondurmeyenemetot yeniForm = new geriyedegerdondurmeyenemetot();
            // Yeni formu aç
            yeniForm.Show();
            // Ana formu gizle (opsiyonel)
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Yeni formu oluştur
            asiriyukleme yeniForm = new asiriyukleme();
            // Yeni formu aç
            yeniForm.Show();
            // Ana formu gizle (opsiyonel)
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Yeni formu oluştur
            recursive yeniForm = new recursive();
            // Yeni formu aç
            yeniForm.Show();
            // Ana formu gizle (opsiyonel)
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
