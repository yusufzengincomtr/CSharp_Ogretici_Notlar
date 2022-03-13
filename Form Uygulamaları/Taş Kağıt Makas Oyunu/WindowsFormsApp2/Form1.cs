using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int rast;
        int puan=0;
        int pcpuan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox4.ImageLocation = "C:\\Users\\Casper\\Desktop\\C# Oyunlarım\\Taş Kağıt Makas\\New folder\\tas.jpg";
            rast = rnd.Next(1, 4);
            if (rast == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Casper\\Desktop\\C# Oyunlarım\\Taş Kağıt Makas\\New folder\\tas.jpg";
            }
            else if (rast == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Casper\\Desktop\\C# Oyunlarım\\Taş Kağıt Makas\\New folder\\kagıt.png";
            }
            else if (rast == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Casper\\Desktop\\C# Oyunlarım\\Taş Kağıt Makas\\New folder\\makas.jpg";
            }
            if (pictureBox1.ImageLocation == "C:\\Users\\Casper\\Desktop\\C# Oyunlarım\\Taş Kağıt Makas\\New folder\\tas.jpg")
            {

                textBox1.Text = "Durum Berabere.";
            }
            else if (pictureBox1.ImageLocation == "C:\\Users\\Casper\\Desktop\\C# Oyunlarım\\Taş Kağıt Makas\\New folder\\kagıt.png")
            {
                textBox1.Text = "Kağıt Taşı Sarar! (PC+1)";
                pcpuan++;
                label1.Text = pcpuan.ToString();
            }
            else if (pictureBox1.ImageLocation == "C:\\Users\\Casper\\Desktop\\C# Oyunlarım\\Taş Kağıt Makas\\New folder\\makas.jpg")
            {
                textBox1.Text = "Taş Makası Kırar! (OYNCU+1)";
                puan++;
                lblbilgi.Text =puan.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox4.ImageLocation = "C:\\Users\\Casper\\Desktop\\C# Oyunlarım\\Taş Kağıt Makas\\New folder\\kagıt.png";
            rast = rnd.Next(1, 4);
            if (rast == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Casper\\Desktop\\C# Oyunlarım\\Taş Kağıt Makas\\New folder\\tas.jpg";
            }
            else if (rast == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Casper\\Desktop\\C# Oyunlarım\\Taş Kağıt Makas\\New folder\\kagıt.png";
            }
            else if (rast == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Casper\\Desktop\\C# Oyunlarım\\Taş Kağıt Makas\\New folder\\makas.jpg";
            }
            if (pictureBox1.ImageLocation == "C:\\Users\\Casper\\Desktop\\C# Oyunlarım\\Taş Kağıt Makas\\New folder\\tas.jpg")
            {
                textBox1.Text = "Kağıt Taşı Sarar! (OYNCU+1)";
                puan++;
                lblbilgi.Text = puan.ToString();
            }
            else if (pictureBox1.ImageLocation == "C:\\Users\\Casper\\Desktop\\C# Oyunlarım\\Taş Kağıt Makas\\New folder\\kagıt.png")
            {
                textBox1.Text = "Durum Berabere.";
            }
           
            else if (pictureBox1.ImageLocation == "C:\\Users\\Casper\\Desktop\\C# Oyunlarım\\Taş Kağıt Makas\\New folder\\makas.jpg")
            {
                textBox1.Text = "Makas Kağıdı Keser! (PC+1)";
                pcpuan++;
                label1.Text =pcpuan.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox4.ImageLocation = "C:\\Users\\Casper\\Desktop\\C# Oyunlarım\\Taş Kağıt Makas\\New folder\\makas.jpg";
            rast = rnd.Next(1, 4);
            if (rast == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Casper\\Desktop\\C# Oyunlarım\\Taş Kağıt Makas\\New folder\\tas.jpg";
            }
            else if (rast == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Casper\\Desktop\\C# Oyunlarım\\Taş Kağıt Makas\\New folder\\kagıt.png";
            }
            else if (rast == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Casper\\Desktop\\C# Oyunlarım\\Taş Kağıt Makas\\New folder\\makas.jpg";
            }
            if (pictureBox1.ImageLocation == "C:\\Users\\Casper\\Desktop\\C# Oyunlarım\\Taş Kağıt Makas\\New folder\\tas.jpg")
            {
                textBox1.Text = "Taş Makası Kırar! (PC+1)";
                pcpuan++;
                label1.Text =pcpuan.ToString();
            }
            else if (pictureBox1.ImageLocation == "C:\\Users\\Casper\\Desktop\\C# Oyunlarım\\Taş Kağıt Makas\\New folder\\kagıt.png")
            {
                textBox1.Text = "Makas Kağıdı Keser! (OYNCU+1)";
                puan++;
                lblbilgi.Text =puan.ToString();
            }
            else if (pictureBox1.ImageLocation == "C:\\Users\\Casper\\Desktop\\C# Oyunlarım\\Taş Kağıt Makas\\New folder\\makas.jpg")
            {
                textBox1.Text = "Durum Berabere.";
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pcpuan >= 10)
            {
                textBox1.Text = "Bilgisayar Oyunu Kazandı.Tebrikler.";
                timer1.Stop();
                DialogResult c;
                c = MessageBox.Show("Oyunu Tekrar Oynamak İstermisiniz.", "Taş Kağıt Makas Oyunu | Yusuf Zengin", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (c == DialogResult.Yes)
                {
                    pictureBox1.BackColor = Color.Coral;
                    pictureBox4.BackColor = Color.Coral;
                    timer1.Start();
                    pcpuan = 0;
                    puan = 0;
                    lblbilgi.Text = " ";
                    label1.Text = " ";
                    textBox1.Clear();
                }
                else
                {
                    Application.Exit();
                }
            }
            else if (puan >= 10)
            {
                textBox1.Text = "Oyuncu Oyunu Kazandı.Tebrikler."; timer1.Stop();
                DialogResult c;
                c = MessageBox.Show("Oyunu Tekrar Oynamak İstermisiniz.", "Taş Kağıt Makas Oyunu | Yusuf Zengin", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (c == DialogResult.Yes)
                {
                    pictureBox1.BackColor = Color.Coral;
                    pictureBox4.BackColor = Color.Coral;
                    timer1.Start();
                    pcpuan = 0;
                    puan = 0;
                    lblbilgi.Text = " ";
                    label1.Text = " ";
                    textBox1.Clear();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
