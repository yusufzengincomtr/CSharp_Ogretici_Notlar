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
           // timer1.Start();
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
            if ( pictureBox1.Left > pictureBox3.Left )
            {
                label5.Text = "1 Numaralı Atlet 3 NumaralI Atletin Önüne Geçti";
            }
            if (pictureBox1.Left > pictureBox4.Left)
            {
                label5.Text = "1 Numaralı Atlet 4 NumaralI Atletin Önüne Geçti";
            }

            if (pictureBox1.Left>pictureBox2.Left && pictureBox1.Left>pictureBox3.Left && pictureBox1.Left>pictureBox4.Left)
            {
                label5.Text = "1 Numaralı Atlet Önde Gidiyor";
            }
            if (pictureBox2.Left > pictureBox1.Left && pictureBox2.Left > pictureBox3.Left && pictureBox2.Left > pictureBox4.Left)
            {
                label5.Text = "2 Numaralı Atlet Önde Gidiyor";
            }
            if (pictureBox3.Left > pictureBox1.Left && pictureBox3.Left > pictureBox2.Left && pictureBox3.Left > pictureBox4.Left)
            {
                label5.Text = "3 Numaralı Atlet Önde Gidiyor";
            }
            if (pictureBox4.Left > pictureBox1.Left && pictureBox4.Left > pictureBox3.Left && pictureBox4.Left > pictureBox2.Left)
            {
                label5.Text = "4 Numaralı Atlet Önde Gidiyor";
            }
            ////////////////////////////////////////////////////////////////////////
            if (pictureBox2.Left > pictureBox1.Left)
            {
                label5.Text = "2 Numaralı 1 NumaralI Atletin Önüne Geçti";
            }
            if (pictureBox2.Left > pictureBox3.Left)
            {
                label5.Text = "2 Numaralı 3 NumaralI Atletin Önüne Geçti";
            }
            if (pictureBox2.Left > pictureBox4.Left)
            {
                label5.Text = "2 Numaralı 4 NumaralI Atletin Önüne Geçti";
            }
            ////////////////////////////////////////////////////////////////////////
            if (pictureBox3.Left > pictureBox1.Left)
            {
                label5.Text = "3 Numaralı 1 NumaralI Atletin Önüne Geçti";
            }
            if (pictureBox3.Left > pictureBox2.Left)
            {
                label5.Text = "3 Numaralı 2 NumaralI Atletin Önüne Geçti";
            }
            if ( pictureBox3.Left > pictureBox4.Left)
            {
                label5.Text = "3 Numaralı 4 NumaralI Atletin Önüne Geçti";
            }
            ////////////////////////////////////////////////////////////////////////
            if (pictureBox4.Left > pictureBox1.Left)
            {
                label5.Text = "4 Numaralı 1 NumaralI Atletin Önüne Geçti";
            }
            if (pictureBox4.Left > pictureBox3.Left )
            {
                label5.Text = "4 Numaralı 3 NumaralI Atletin Önüne Geçti";
            }
            if (pictureBox4.Left > pictureBox2.Left)
            {
                label5.Text = "4 Numaralı 2 NumaralI Atletin Önüne Geçti";
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
            kazanc = Convert.ToInt32(textBox1.Text);
            if (label5.Text == "1 Numaralı Atlet Yarışı Kazandı" && comboBox1.SelectedIndex == 0)
            {
                kazanc = kazanc * 10;
                label10.Text = kazanc.ToString();
            }
            else if (label5.Text == "2 Numaralı Atlet Yarışı Kazandı" && comboBox1.SelectedIndex == 1)
            {
                kazanc = kazanc * 10;
                label10.Text = kazanc.ToString();
            }
            else if (label5.Text == "3 Numaralı Atlet Yarışı Kazandı" && comboBox1.SelectedIndex == 2)
            {
                kazanc = kazanc * 10;
                label10.Text = kazanc.ToString();
            }
            else if (label5.Text == "4 Numaralı Atlet Yarışı Kazandı" && comboBox1.SelectedIndex == 3)
            {
                kazanc = kazanc * 10;
                label10.Text = kazanc.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label5.Text = " ";
            pictureBox4.Left = 10;
            pictureBox3.Left = 10;
            pictureBox2.Left = 10;
            pictureBox1.Left = 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            kazanc = Convert.ToInt32(textBox1.Text);
            if (label5.Text == "1 Numaralı Atlet Yarışı Kazandı" && comboBox1.SelectedIndex == 0)
            {
                kazanc = kazanc * 10;
                label10.Text = kazanc.ToString();
            }
            else if (label5.Text == "2 Numaralı Atlet Yarışı Kazandı" && comboBox1.SelectedIndex == 1)
            {
                kazanc = kazanc * 10;
                label10.Text = kazanc.ToString();
            }
            else if (label5.Text == "3 Numaralı Atlet Yarışı Kazandı" && comboBox1.SelectedIndex == 2)
            {
                kazanc = kazanc * 10;
                label10.Text = kazanc.ToString();
            }
            else if (label5.Text == "4 Numaralı Atlet Yarışı Kazandı" && comboBox1.SelectedIndex == 3)
            {
                kazanc = kazanc * 10;
                label10.Text = kazanc.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int kazanc;
        private void button4_Click(object sender, EventArgs e)
        {
            kazanc = Convert.ToInt32(textBox1.Text);
            if (label5.Text == "1 Numaralı Atlet Yarışı Kazandı" && comboBox1.SelectedIndex == 0)
            {
                kazanc = kazanc * 10;
                label10.Text = kazanc.ToString();
            }
            else if (label5.Text == "2 Numaralı Atlet Yarışı Kazandı" && comboBox1.SelectedIndex == 1)
            {
                kazanc = kazanc * 10;
                label10.Text = kazanc.ToString();
            }
            else if (label5.Text == "3 Numaralı Atlet Yarışı Kazandı" && comboBox1.SelectedIndex == 2)
            {
                kazanc = kazanc * 10;
                label10.Text = kazanc.ToString();
            }
            else if (label5.Text == "4 Numaralı Atlet Yarışı Kazandı" && comboBox1.SelectedIndex == 3)
            {
                kazanc = kazanc * 10;
                label10.Text = kazanc.ToString();
            }
        }
    }
}
