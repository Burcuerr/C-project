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
    public partial class recursive : Form
    {
        public recursive()
        {
            InitializeComponent();
        }
        private int FibonacciHesapla(int n)
        {
            // Base case: n 0 veya 1 ise n'i döndür
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                // Özyinelemeli olarak Fibonacci sayısını hesapla
                return FibonacciHesapla(n - 1) + FibonacciHesapla(n - 2);
            }


       }



        private void btnHesapla_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği değeri int türüne dönüştürerek alın
            int sayi = Convert.ToInt32(txtSayi.Text);

            // Sonuç label'ını temizle
            lblSonuc.Text = string.Empty;

            // Recursive metodu çağır ve sonucu ekrana yazdır
            lblSonuc.Text = "Sonuç: " + FibonacciHesapla(sayi).ToString();
        }

        private void label3_Click_1(object sender, EventArgs e)
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

