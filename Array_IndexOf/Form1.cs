using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_IndexOf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] isimler = new string[5];
            isimler[0] = "Negan";
            isimler[1] = "Rick";
            isimler[2] = "Daryl";
            isimler[3] = "Morgan";
            isimler[4] = "Rosita";
            int sonuc = Array.IndexOf(isimler, "aa");
            int sonuc_2 = Array.IndexOf(isimler, "Negan");
            string var_olan = isimler[sonuc_2];
            MessageBox.Show(var_olan);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 4 elemanlı bir isim dizisi oluşturunuz. Textbox'tan girilen değeri        diziniz de var mı yokmu diye aratınız. Var ise aranan isim dizide mevcut  mesajı, yok ise yok mesajı veriniz.
            string[] isimler = { "Negan", "Rick", "Daryl", "Morgan" };
            int sonuc = Array.IndexOf(isimler, textBox1.Text);
            if (sonuc == -1)
            {
                MessageBox.Show("Böyle bir isim yoktur.");
            }
            else
            {
                MessageBox.Show("Bu isim vardır.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] sayi = new int[10];
            Random rastgele = new Random();
            for (int i = 0; i < 10; i++)
            {
                int uretilen_sayi = rastgele.Next(1, 50);
                sayi[i] = uretilen_sayi;
            }
            foreach (int liste in sayi)
            {
                listBox1.Items.Add(liste);
            }
        }
    }
}
// Dizi içerisinde arama işlemi yapar.
// Eğer aranan eleman dizide varsa elemanın index numarasını döner, yoksa -1 döner.