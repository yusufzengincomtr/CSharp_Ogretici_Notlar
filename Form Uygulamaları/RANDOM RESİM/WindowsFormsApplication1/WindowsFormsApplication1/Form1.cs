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
        Random rast = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int para = 0, sonuc = 0;
            para = Convert.ToInt32(textBox1.Text);

            if (p1 == p2 && p2 == p3)
            {
                sonuc = para * 10;
                lblmiktar.Text = sonuc.ToString();
                lbldurum.Text = "KAZANDINIZ. TEBRİKLER";
                timer1.Stop();
            }
            else if (p1 == p2)
            {
                sonuc = para * 2;
                lblmiktar.Text = sonuc.ToString();
                lbldurum.Text = "KAZANDINIZ. TEBRİKLER";
                timer1.Stop();
            }
            else if (p2 == p3)
            {
                sonuc = para * 2;
                lblmiktar.Text = sonuc.ToString();
                lbldurum.Text = "KAZANDINIZ. TEBRİKLER";
                timer1.Stop();
            }
            else if (pictureBox1 != pictureBox2 && pictureBox2 != pictureBox3)
            {
                sonuc = -para;
                lblmiktar.Text = sonuc.ToString();
                lbldurum.Text = "KAZANAMADINIZ.";
                timer1.Stop();
            }
        }
        int p1, p2, p3;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //sayi = rast.Next(1, 4);
            //label1.Text = sayi.ToString();
            //sayi = rast.Next(1, 4);
            //label3.Text = sayi.ToString();
            //sayi = rast.Next(1, 4);
            //label2.Text = sayi.ToString();
             p1 = rast.Next(1, 4);
            pictureBox1.ImageLocation = "C:\\Users\\LAB4-PC1\\Desktop\\RANDOM RESİM\\WindowsFormsApplication1\\WindowsFormsApplication1\\RES"+p1+".jpg";
             p2 = rast.Next(1, 4);//1-2-3
            pictureBox2.ImageLocation = "C:\\Users\\LAB4-PC1\\Desktop\\RANDOM RESİM\\WindowsFormsApplication1\\WindowsFormsApplication1\\RES"+p2+".jpg";
             p3 = rast.Next(1, 4);//1-2-3
            pictureBox3.ImageLocation = "C:\\Users\\LAB4-PC1\\Desktop\\RANDOM RESİM\\WindowsFormsApplication1\\WindowsFormsApplication1\\RES"+p3+".jpg";

            //sayi = rast.Next(1, 4);
            //if (sayi==1)
            //{
            //    pictureBox1.ImageLocation = "C:\\Users\\LAB4-PC1\\Desktop\\Yeni klasör\\WindowsFormsApplication1\\WindowsFormsApplication1\\RES1.jpg";
            //}
            //else if (sayi==2)
            //{
            //    pictureBox1.ImageLocation = "C:\\Users\\LAB4-PC1\\Desktop\\Yeni klasör\\WindowsFormsApplication1\\WindowsFormsApplication1\\RES2.jpg";
            //}
            //else if (sayi==3)
            //{
            //    pictureBox1.ImageLocation = "C:\\Users\\LAB4-PC1\\Desktop\\Yeni klasör\\WindowsFormsApplication1\\WindowsFormsApplication1\\RES3.jpg";
            //}
            //sayi = rast.Next(1, 4);
            //if (sayi == 1)
            //{
            //    pictureBox2.ImageLocation = "C:\\Users\\LAB4-PC1\\Desktop\\Yeni klasör\\WindowsFormsApplication1\\WindowsFormsApplication1\\RES1.jpg";
            //}
            //else if (sayi == 2)
            //{
            //    pictureBox2.ImageLocation = "C:\\Users\\LAB4-PC1\\Desktop\\Yeni klasör\\WindowsFormsApplication1\\WindowsFormsApplication1\\RES2.jpg";
            //}
            //else if (sayi == 3)
            //{
            //    pictureBox2.ImageLocation = "C:\\Users\\LAB4-PC1\\Desktop\\Yeni klasör\\WindowsFormsApplication1\\WindowsFormsApplication1\\RES3.jpg";
            //}
            //if (sayi == 1)
            //{
            //    pictureBox3.ImageLocation = "C:\\Users\\LAB4-PC1\\Desktop\\Yeni klasör\\WindowsFormsApplication1\\WindowsFormsApplication1\\RES1.jpg";
            //}
            //else if (sayi == 2)
            //{
            //    pictureBox3.ImageLocation = "C:\\Users\\LAB4-PC1\\Desktop\\Yeni klasör\\WindowsFormsApplication1\\WindowsFormsApplication1\\RES2.jpg";
            //}
            //else if (sayi == 3)
            //{
            //    pictureBox3.ImageLocation = "C:\\Users\\LAB4-PC1\\Desktop\\Yeni klasör\\WindowsFormsApplication1\\WindowsFormsApplication1\\RES3.jpg";
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            lbldurum.Text = "_________";
            lblmiktar.Text = "___________";
            textBox1.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Azure;
            button1.BackColor = Color.Turquoise;
            button2.BackColor = Color.Violet;
            textBox1.BackColor = Color.Aqua;
            label4.BackColor = Color.Wheat;
            label5.BackColor = Color.Wheat;
            label6.BackColor = Color.Wheat;
            timer1.Start();
            timer1.Interval = 500;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
