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
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            sayac = 0;
            lblzaman.Text = "00";
            if (chkçmşr.Checked == false)
            {
                timer1.Stop();
                MessageBox.Show("ÇAMAŞIR KONMADAN MAKİNE ÇALIŞIR MI?");
            }
            if (chksu.Checked == false)
            {
                timer1.Stop();
                MessageBox.Show("SU OLMADAN ÇAMAŞIR YIKANIR MI ?");
            }
            if (chkelktr.Checked == false)
            {
                timer1.Stop();
                MessageBox.Show("ELEKTRİK OLMADAN MAKİNE ÇALIŞIR MI?");
            }
            if (chkekstra.Checked)
            {
                MessageBox.Show("30 Saniye Fazla Yıkanma Etkinleştirildi.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rbeyaz3dk.Checked)
            {
                sayac++;
                lblzaman.Text = sayac.ToString();
                if (sayac == 180)
                {
                    lbldurum.Text = "Makine Bitti";
                    timer1.Stop();
                }
            }
            if (rbrenk2dk.Checked)
            {
                sayac++;
                lblzaman.Text = sayac.ToString();
                if (sayac == 120)
                {
                    lbldurum.Text = "Makine Bitti";
                    timer1.Stop();
                }
            }
            if (rbnarin1dk.Checked)
            {
                sayac++;
                lblzaman.Text = sayac.ToString();
                if (sayac == 60)
                {
                    lbldurum.Text = "Makine Bitti";
                    timer1.Stop();
                }
            }
            if (rbeyaz3dk.Checked && chkekstra.Checked)
            {
                sayac++;
                lblzaman.Text = sayac.ToString();
                if (sayac == 210)
                {
                        lbldurum.Text = "Makine Gecikmeli Olarak Bitti";
                        timer1.Stop();
                }
            }
            if (rbrenk2dk.Checked && chkekstra.Checked)
            {
                sayac++;
                lblzaman.Text = sayac.ToString();
                if (sayac == 150)
                {
                    lbldurum.Text = "Makine Gecikmeli Olarak Bitti";
                    timer1.Stop();
                }
            }
            if (rbnarin1dk.Checked && chkekstra.Checked)
            {
                sayac++;
                lblzaman.Text = sayac.ToString();
                if (sayac == 90)
                {
                    lbldurum.Text = "Makine Gecikmeli Olarak Bitti";
                    timer1.Stop();
                }
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            lbldurum.Text = "MAKİNE DURDURULDU.";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            chkekstra.Checked = false;
            chkelktr.Checked = false;
            chkçmşr.Checked = false;
            chksu.Checked = false;
            rbeyaz3dk.Checked = false;
            rbnarin1dk.Checked = false;
            rbrenk2dk.Checked = false;
            sayac = 0;
            lbldurum.Text = "Makine Resetlendi..";
            lblzaman.Text = "00";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
