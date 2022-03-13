using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hareket_ettirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 30;
            pictureBox1.Left += rnd.Next(0, 7);
            pictureBox2.Left += rnd.Next(0, 7);
            pictureBox3.Left += rnd.Next(0, 7);
            pictureBox4.Left += rnd.Next(0, 7);
            if (pictureBox1.Left>pictureBox2.Left )
            {
                label5.Text = "1 Numaralı Atlet 2 NumaralI Atletin Önüne Geçti";
            }
           else if ( pictureBox1.Left > pictureBox3.Left )
            {
                label5.Text = "1 Numaralı Atlet 3 NumaralI Atletin Önüne Geçti";
            }
            else if (pictureBox1.Left > pictureBox4.Left)
            {
                label5.Text = "1 Numaralı Atlet 4 NumaralI Atletin Önüne Geçti";
            }

            if (pictureBox1.Left > pictureBox2.Left && pictureBox1.Left > pictureBox3.Left && pictureBox1.Left > pictureBox4.Left)
            {
                label5.Text = "1 Numaralı Atlet Önde Gidiyor";
            }
            else if (pictureBox2.Left > pictureBox1.Left && pictureBox2.Left > pictureBox3.Left && pictureBox2.Left > pictureBox4.Left)
            {
                label5.Text = "2 Numaralı Atlet Önde Gidiyor";
            }
            else if (pictureBox3.Left > pictureBox1.Left && pictureBox3.Left > pictureBox2.Left && pictureBox3.Left > pictureBox4.Left)
            {
                label5.Text = "3 Numaralı Atlet Önde Gidiyor";
            }
            else if (pictureBox4.Left > pictureBox1.Left && pictureBox4.Left > pictureBox3.Left && pictureBox4.Left > pictureBox2.Left)
            {
                label5.Text = "4 Numaralı Atlet Önde Gidiyor";
            }
            ////////////////////////////////////////////////////////////////////////
             if (pictureBox2.Left > pictureBox1.Left)
            {
                label5.Text = "2 Numaralı Atlet 1 NumaralI Atletin Önüne Geçti";
            }
            else if (pictureBox2.Left > pictureBox3.Left)
            {
                label5.Text = "2 Numaralı Atlet 3 NumaralI Atletin Önüne Geçti";
            }
            else if (pictureBox2.Left > pictureBox4.Left)
            {
                label5.Text = "2 Numaralı Atlet 4 NumaralI Atletin Önüne Geçti";
            }
            ////////////////////////////////////////////////////////////////////////
            if (pictureBox3.Left > pictureBox1.Left)
            {
                label5.Text = "3 Numaralı Atlet 1 NumaralI Atletin Önüne Geçti";
            }
           else if (pictureBox3.Left > pictureBox2.Left)
            {
                label5.Text = "3 Numaralı Atlet 2 NumaralI Atletin Önüne Geçti";
            }
            else if ( pictureBox3.Left > pictureBox4.Left)
            {
                label5.Text = "3 Numaralı Atlet 4 NumaralI Atletin Önüne Geçti";
            }
            ////////////////////////////////////////////////////////////////////////
            if (pictureBox4.Left > pictureBox1.Left)
            {
                label5.Text = "4 Numaralı Atlet 1 NumaralI Atletin Önüne Geçti";
            }
            else if (pictureBox4.Left > pictureBox3.Left )
            {
                label5.Text = "4 Numaralı Atlet 3 NumaralI Atletin Önüne Geçti";
            }
            else if (pictureBox4.Left > pictureBox2.Left)
            {
                label5.Text = "4 Numaralı Atlet 2 NumaralI Atletin Önüne Geçti";
            }
            if (pictureBox1.Left > pictureBox2.Left && pictureBox1.Left > pictureBox3.Left && pictureBox1.Left > pictureBox4.Left)
            {
                label5.Text = "1 Numaralı Atlet Önde Gidiyor";
            }
            else if (pictureBox2.Left > pictureBox1.Left && pictureBox2.Left > pictureBox3.Left && pictureBox2.Left > pictureBox4.Left)
            {
                label5.Text = "2 Numaralı Atlet Önde Gidiyor";
            }
            else if (pictureBox3.Left > pictureBox1.Left && pictureBox3.Left > pictureBox2.Left && pictureBox3.Left > pictureBox4.Left)
            {
                label5.Text = "3 Numaralı Atlet Önde Gidiyor";
            }
            else if (pictureBox4.Left > pictureBox1.Left && pictureBox4.Left > pictureBox3.Left && pictureBox4.Left > pictureBox2.Left)
            {
                label5.Text = "4 Numaralı Atlet Önde Gidiyor";
            }
            ///////////////////////////////////////////////////////////////////////
            if (pictureBox1.Left>730)
            {
                label5.Text = "1 Numaralı Atlet Yarışı Kazandı";
                timer1.Stop();
            }
            else if (pictureBox2.Left>730)
            {
                label5.Text = "2 Numaralı Atlet Yarışı Kazandı";
                timer1.Stop();
            }
            else if (pictureBox3.Left> 730)
            {
                label5.Text = "3 Numaralı Atlet Yarışı Kazandı";
                timer1.Stop();
            }
            else if (pictureBox4.Left> 730)
            {
                label5.Text = "4 Numaralı Atlet Yarışı Kazandı";
                timer1.Stop();
            }
            ////////////////////////////////////////////////

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label5.Text = " ";
            comboBox1.Enabled = true;
            textBox1.Clear();
            comboBox1.ResetText();
            label10.Text = "";
            label9.Text = "";
            textBox1.Enabled = true;
            pictureBox4.Left = 10;
            pictureBox3.Left = 10;
            pictureBox2.Left = 10;
            pictureBox1.Left = 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int kazanc;
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                kazanc = Convert.ToInt32(textBox1.Text);
                if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 1 || comboBox1.SelectedIndex == 2 || comboBox1.SelectedIndex == 3)
                {
                    MessageBox.Show(comboBox1.Text+"'e "+textBox1.Text+" Lira Yatırdınız Başarılar Dileriz.");
                    timer2.Start();
                    comboBox1.Enabled = false;
                    textBox1.Enabled = false;
                }                
            }
            catch (Exception)
            {
                MessageBox.Show("Para Miktarı Giriniz");
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

                timer1.Interval = 10;               
           if (pictureBox1.Left > 730 || pictureBox2.Left > 730 || pictureBox3.Left > 730 || pictureBox4.Left > 730)
           {

                if (label5.Text == "1 Numaralı Atlet Yarışı Kazandı" && comboBox1.SelectedIndex == 0)
                {
                    kazanc = kazanc * 10;
                    label10.Text = kazanc.ToString() + " Lira Kazandınız Tebrikler."; timer2.Stop();

                }
                else if (label5.Text == "2 Numaralı Atlet Yarışı Kazandı" && comboBox1.SelectedIndex == 1)
                {
                    kazanc = kazanc * 10;
                    label10.Text = kazanc.ToString() + " Lira Kazandınız Tebrikler."; timer2.Stop();
                }
                else if (label5.Text == "3 Numaralı Atlet Yarışı Kazandı" && comboBox1.SelectedIndex == 2)
                {
                    kazanc = kazanc * 10;
                    label10.Text = kazanc.ToString() + " Lira Kazandınız Tebrikler."; timer2.Stop();
                }
                else if (label5.Text == "4 Numaralı Atlet Yarışı Kazandı" && comboBox1.SelectedIndex == 3)
                {
                    kazanc = kazanc * 10;
                    label10.Text = kazanc.ToString() + " Lira Kazandınız Tebrikler."; timer2.Stop();
                }
                else
                {
                    kazanc = -kazanc;
                    label10.Text = kazanc.ToString() + " Kaybettiniz Malesef :( ";
                    timer2.Stop();
                }
                label9.Visible = true;
                label10.Visible = true;
            }
           
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
