using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sayi1;
        string islem;
        private void islemler(object sender, EventArgs e)
        {//"+,-,*,/" topla,çıkar,çarp, bölme butonlarının tek bir işlem olması için yapılan metod
            sayi1 += Convert.ToDouble(textBox1.Text);
            islem = (sender as Button).Text;
            textBox1.Text = "";
        }

        bool sonuc = false;
        private void rakamlar(object sender, EventArgs e)
        {//"0'dan9kadar"rakamlar butonunu tek işlem yapmak için metod textboxta ilk olarak 0 girildiği zaman yazdırmaz.

            if (sonuc == true)
            {
                sonuc = false;
                textBox1.Text = "";
            }
            if (textBox1.Text == "" && (sender as Button).Text == "0")
            {

            }
            else
            {
                textBox1.Text += (sender as Button).Text;
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {//"="Butonu girilen sayıyı islem metedonundaki  toplama,çıkarma,bölme,çarpma hangisi ise sonucu yazırdırma

            if (textBox1.Text == "")
                textBox1.Text = sayi1.ToString();
            else if (islem == "+")
                textBox1.Text = (sayi1 + Convert.ToDouble(textBox1.Text)).ToString();
            else if (islem == "-")
                textBox1.Text = (sayi1 - Convert.ToDouble(textBox1.Text)).ToString();
            else if (islem == "*")
                textBox1.Text = (sayi1 * Convert.ToDouble(textBox1.Text)).ToString();
            else if (islem == "/")
                textBox1.Text = (sayi1 / Convert.ToDouble(textBox1.Text)).ToString();

            
            islem = "";
            sayi1 = 0;
            sonuc = true;//"=" butonuna basılınca gelen 0 sayısının yanına sıfır koydurmama sıfıra basıncada temizleme
        }

        private void button1_Click(object sender, EventArgs e)
        {//"C" butonu hesap makinesini temizleme

            textBox1.Text = "";
            sayi1 = 0;
            islem = "";
            sonuc = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {//"+/-" butonu sayıyı pozitif yada negatif yapma

            textBox1.Text = (Convert.ToDouble(textBox1.Text) * -1).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {//"<--"Butonu girilen sayıyı sağdan silme
            if (textBox1.Text != "")
            {
                int boyut = textBox1.Text.Length;
                textBox1.Text = textBox1.Text.Substring(0, boyut - 1);
            }
        }
    }
}
