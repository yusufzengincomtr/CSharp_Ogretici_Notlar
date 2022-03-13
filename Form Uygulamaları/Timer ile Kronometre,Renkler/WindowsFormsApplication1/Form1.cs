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
        int salise = 0, saniye = 0, dakika=0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            salise++;
            label1.Text = salise.ToString();
            if (salise==50)
            {
                salise = 0;
           //     label2.Text = saniye.ToString();
                saniye++;
                label2.Text = saniye.ToString();
            }
            if (saniye==59)
            {
                saniye = 0;
            //    label2.Text = saniye.ToString();
                dakika++;
                label3.Text = dakika.ToString();
            }
            if (saniye == 3)
            {

                this.BackColor = Color.Red;
            }
            if (saniye == 8)
            {
                this.BackColor = Color.Blue;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            salise = 0;
            label1.Text = salise.ToString();
            saniye = 0;
            label2.Text = saniye.ToString();
            dakika = 0;
            label3.Text = dakika.ToString();
            this.BackColor = DefaultBackColor;
            this.BackColor = DefaultBackColor;
            timer1.Stop();

        }

        private void button2_Click(object sender, EventArgs e)
        {  
            timer1.Stop();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 16;          
        }
    }
}
