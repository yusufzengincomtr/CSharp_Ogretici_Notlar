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

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
  
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
           lbldurum.Text = "EVLİSİNİZ";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
           lbldurum.Text = "BEKARSİNİZ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bekar.Checked = false;
            evli.Checked = false;
        }

        private void evli_CheckedChanged(object sender, EventArgs e)
        {
            if (evli.Checked == true)//EVLİ rbtn seçiliyse          //2.Yapılıs
            {
                bekar.Checked = false;//rbbekar false atayalım ki 2siaynı anda tıklı olmasın
                lbldurum.Text = "Evlisınız";
            }
        }

        private void bekar_CheckedChanged(object sender, EventArgs e)
        {
            if (bekar.Checked==true)// BEKAR rbtn seçiliyse          //2.Yapılıs
            {
                evli.Checked = false;//rbbekar false atayalım ki 2siaynı anda tıklı olmasın
                lbldurum.Text = "Bekarsınız";
            }
        }
    }
}
