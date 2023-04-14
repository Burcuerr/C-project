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
    public partial class tekboyutludizi : Form
    {

        //tek boyutlu bir diziye eklemek için kullanılabilir. Kullanıcı bir sayı girdiğinde,
        //kod, mevcut diziyi bir artırarak yeni değeri dizinin sonuna ekler
        //ve ardından güncellenmiş diziyi formdaki bir Listbox kontrolüne yansıtır.

        private int[] dizi; // Tek boyutlu diziyi tutmak için bir değişken
        public tekboyutludizi()
        {




            InitializeComponent();
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

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            // Kullanıcının girdiği değeri int türüne dönüştürerek alın
            int yeniDeger = Convert.ToInt32(txtDeger.Text);

            // Diziyi genişletmek için mevcut dizinin boyutunu bir artırın
            int[] dizi = new int[lstDizi.Items.Count + 1];

            // Mevcut diziyi yeni dizideki elemanlara kopyalayın
            for (int i = 0; i < lstDizi.Items.Count; i++)
            {
                dizi[i] = Convert.ToInt32(lstDizi.Items[i]);
            }

            // Yeni değeri dizinin sonuna ekleyin
            dizi[dizi.Length - 1] = yeniDeger;

            // Listbox üzerindeki veriyi güncelleyin
            lstDizi.Items.Clear();
            lstDizi.Items.AddRange(dizi.Select(x => x.ToString()).ToArray());

            // Metin kutusunu temizleyin
            txtDeger.Clear();
        }
    }
}
    

