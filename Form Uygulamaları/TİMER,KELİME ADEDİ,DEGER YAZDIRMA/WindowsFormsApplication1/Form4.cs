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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text=sayac.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TİMER: Sayaç kullarak 0 dan 100e kadar labelde gösterelim.
            label1.Text = "0";
            timer1.Interval = 10;
            //1sn=1000ms
            //0.1sn=100ms
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayac = 0;
            label1.Text = sayac.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 yeni = new Form5();
                yeni.Show();// form5i göster
            this.Hide(); // gizleme var olan formu
        }
    }
}
