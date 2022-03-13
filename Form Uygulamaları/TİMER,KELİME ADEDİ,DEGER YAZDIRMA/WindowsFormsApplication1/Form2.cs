using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.TextLength == 3)
            {
                int sayi = Convert.ToInt32(textBox1.Text);
                int y, o, b;
                string yüzler = "", onlar = "", birler = "";

                y = sayi / 100;
                sayi = sayi % 100;
                o = sayi / 10;
                sayi = sayi / 10;
                sayi = sayi % 10;
                b = sayi;
                switch (y)
                {
                    case 1:
                        yüzler = "yüz";
                        break;
                    case 2:
                        yüzler = "ikiyüz";
                        break;
                    case 3:
                        yüzler = "üçyüz";
                        break;
                    case 4:
                        yüzler = "dörtyüz";
                        break;
                    case 5:
                        yüzler = "beşyüz";
                        break;
                    case 6:
                        yüzler = "altıyüz";
                        break;
                    case 7:
                        yüzler = "yediyüz";
                        break;
                    case 8:
                        yüzler = "sekizyüz";
                        break;
                    case 9:
                        yüzler = "dokuzyüz";
                        break;
                }
                switch (o)
                {
                    case 1:
                        onlar = "on";
                        break;
                    case 2:
                        onlar = "yirmi";
                        break;
                    case 3:
                        onlar = "otuz";
                        break;
                    case 4:
                        onlar = "kırk";
                        break;
                    case 5:
                        onlar = "elli";
                        break;
                    case 6:
                        onlar = "atmış";
                        break;
                    case 7:
                        onlar = "yetmiş";
                        break;
                    case 8:
                        onlar = "seksen";
                        break;
                    case 9:
                        onlar = "doksan";
                        break;
                }
                switch (b)
                {
                    case 1:
                        birler = "bir";
                        break;
                    case 2:
                        birler = "iki";
                        break;
                    case 3:
                        birler = "üç";
                        break;
                    case 4:
                        birler = "dört";
                        break;
                    case 5:
                        birler = "beş";
                        break;
                    case 6:
                        birler = "altı";
                        break;
                    case 7:
                        birler = "yedi";
                        break;
                    case 8:
                        birler = "sekiz";
                        break;
                    case 9:
                        birler = "dokuz";
                        break;
                }
                        label1.Text = y + "" + o + "" + b + "";
                }                            
            else
            {
                MessageBox.Show("yüz basamaklı sayı gırınız.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 geçiş = new Form4();
            geçiş.Show();
        }
    }
   }

        
   



