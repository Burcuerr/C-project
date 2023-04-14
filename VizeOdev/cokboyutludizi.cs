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
    public partial class cokboyutludizi : Form
    {
        // 2D Dizi
        //DataGridView'e sütunları eklemek için dgvDizi.Columns.Add() metodunu kullandım
        //ve sütun adını ve başlığını belirledim. Daha sonra, her bir
        //satırı ve hücreyi döngü kullanarak DataGridView'e ekledim.
        private int[,] myDizi;

        public cokboyutludizi()
        {
            InitializeComponent();
        }
  

        private void btnOlustur_Click_1(object sender, EventArgs e)
        {

            // Kullanıcının girdiği değerleri alarak 2D diziyi oluştur
            int satirSayisi = Convert.ToInt32(txtSatir.Text);
            int sutunSayisi = Convert.ToInt32(txtSutun.Text);

            myDizi = new int[satirSayisi, sutunSayisi];

            // Diziyi rastgele değerlerle doldur
            Random rastgele = new Random();
            for (int i = 0; i < satirSayisi; i++)
            {
                for (int j = 0; j < sutunSayisi; j++)
                {
                    myDizi[i, j] = rastgele.Next(1, 101);
                }
            }

            // DataGridView'i temizle
            dgvDizi.Rows.Clear();
            dgvDizi.Columns.Clear();

            // DataGridView'e sütunları ekleyin
            for (int j = 0; j < sutunSayisi; j++)
            {
                // Sütunu DataGridView'e ekle
                dgvDizi.Columns.Add("sutun_" + j, "Sutun " + j);
            }

            // DataGridView'e satırları ekleyin
            for (int i = 0; i < satirSayisi; i++)
            {
                // Satırı DataGridView'e ekle
                dgvDizi.Rows.Add();

                for (int j = 0; j < sutunSayisi; j++)
                {
                    // Hücreyi DataGridView'e ekleyin
                    dgvDizi.Rows[i].Cells[j].Value = myDizi[i, j];
                }
            }
        }
    }
}
