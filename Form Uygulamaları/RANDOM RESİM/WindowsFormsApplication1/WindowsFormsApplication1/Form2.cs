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
        int sayi, sonuc;
        Random rast = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int para = Convert.ToInt32(textBox1.Text);
            if (label1==label2 && label2==label3)
            {
                sonuc = para * 10;
                lblmiktar.Text = sonuc.ToString();
                lbldurum.Text = "KAZANDINIZ. TEBRİKS";
                timer1.Stop();
            }
            else if (label1 == label2 || label2 == label3)
            {
                sonuc = para * 2;
                lblmiktar.Text = sonuc.ToString();
                lbldurum.Text = "KAZANDINIZ. TEBRİKS";
                timer1.Stop();
            }
            else if (label1 != label2 && label2 != label3)
            {
                sonuc = -para;
                lblmiktar.Text = sonuc.ToString();
                lbldurum.Text = "KAYBETTİN";
                timer1.Stop();
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayi = rast.Next(1, 4);
            label1.Text = sayi.ToString();
            sayi = rast.Next(1, 4);
            label2.Text = sayi.ToString();
            sayi = rast.Next(1, 4);
            label3.Text = sayi.ToString();

        }
    }
}
