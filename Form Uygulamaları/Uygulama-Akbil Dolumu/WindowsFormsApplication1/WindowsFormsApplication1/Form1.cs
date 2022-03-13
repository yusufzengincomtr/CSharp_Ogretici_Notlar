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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double kredi, dolum, sonuc = 0;

        int sayac = 0;

        private void btnmetrobus_Click(object sender, EventArgs e)
        {
            kredi = Convert.ToInt32(textBox1.Text);

            if (rbögr.Checked)
            {
                sonuc = kredi - 1.60;
                textBox1.Text = sonuc.ToString();


            }
            else if (rbögrt.Checked)
            {
                sonuc = kredi - 1.90;
                textBox1.Text = sonuc.ToString();
            }

            else if (rbnormal.Checked)
            {
                sonuc = kredi - 2.75;
                textBox1.Text = sonuc.ToString();
            }
            else if (rbücret.Checked)
            {
                sonuc = kredi + 0;
                textBox1.Text = sonuc.ToString();
            }
            timer1.Start();
        }

        private void btnıdo_Click(object sender, EventArgs e)
        {
            timer1.Start();

            kredi = Convert.ToDouble(textBox1.Text);
            if (rbögr.Checked)
            {
                sonuc = kredi - 1.70;
                textBox1.Text = sonuc.ToString();


            }
            else if (rbögrt.Checked)
            {
                sonuc = kredi - 2.10;
                textBox1.Text = sonuc.ToString();
            }

            else if (rbnormal.Checked)
            {
                sonuc = kredi - 3.20;
                textBox1.Text = sonuc.ToString();
            }
            else if (rbücretsiz.Checked)
            {
                sonuc = kredi + 0;
                textBox1.Text = sonuc.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            lblsure.Text = sayac.ToString();

            timer1.Interval = 100;
        }


        private void btnotobus_Click(object sender, EventArgs e)
        {
            timer1.Start();
            dolum = Convert.ToDouble(textBox2.Text);
            if (rbögr.Checked)
            {
                    sonuc = kredi - 1.20;
                    textBox1.Text = sonuc.ToString();
                }
            
            else if (rbögrt.Checked)
            {
                sonuc = kredi - 1.50;
                textBox1.Text = sonuc.ToString();
            }

            else if (rbnormal.Checked)
            {
                sonuc = kredi - 2.50;
                textBox1.Text = sonuc.ToString();
            }
            else if (rbücretsiz.Checked)
            {
                sonuc = kredi + 0;
                textBox1.Text = sonuc.ToString();
            }
            else if (rbaylık.Checked)
            {
                sonuc = 100;
                textBox1.Text = sonuc.ToString();
            }
        }

        private void btndoldur_Click(object sender, EventArgs e)
        {
            dolum = Convert.ToDouble(textBox2.Text);
            if (rbögr.Checked && rbaylık.Checked)
            {
                if (dolum < 60)
                {
                    label1.Text = "60TL'den Aşağı Ücret Kabul Edilmez.";
                }
                else if (dolum >= 60)
                {
                    sonuc +=100;
                    textBox1.Text = sonuc.ToString();
                    label1.Text = "100 Dolum Hakkı Vardır.";
                }

            }
            if (rbögrt.Checked && rbaylık.Checked)
            {
                if (dolum < 80)
                {
                    label1.Text = "80TL'den Aşağı Ücret Kabul Edilmez.";
                }
                else if (dolum >= 80)
                {
                    sonuc += 100;
                    textBox1.Text = sonuc.ToString();
                    label1.Text = "100 Dolum Hakkı Vardır.";
                }

            }
            if (rbnormal.Checked && rbaylık.Checked)
            {
                if (dolum < 100)
                {
                    label1.Text = "100TL'den Aşağı Ücret Kabul Edilmez.";
                }
                else if (dolum >= 100)
                {
                    sonuc += 100;
                    textBox1.Text = sonuc.ToString();
                    label1.Text = "100 Dolum Hakkı Vardır.";
                }


            }


        }
    }
}
