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
        private void button1_Click(object sender, EventArgs e)
        {
            string metin;
            metin = textBox1.Text;

            int uzunluk = metin.Length;
        //    label1.Text = uzunluk.ToString();

            int bosluksay = 0;//sayac görevi

            for (int i = 0; i < uzunluk; i++)
            {
                if (metin.Substring(i,1)=="")
                {
                    bosluksay++;
                }
            }
            label1.Text = (bosluksay + 1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string k = textBox1.Text;
            string tkelime = "";
           int uzunluk = k.Length;

            for (int i = uzunluk-1; i>=0; i--)
            {
                tkelime += k.Substring(i, 1);
            }
            label1.Text = tkelime;
        }
    }
}