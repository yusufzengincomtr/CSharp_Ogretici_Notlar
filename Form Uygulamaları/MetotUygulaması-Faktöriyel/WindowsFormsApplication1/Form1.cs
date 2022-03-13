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

            int faktoriyelhesapla(int sayi)
       {
            int sonuc = 1;
            for (int i = 1; i <= sayi; i++)
            {
                sonuc = sonuc * i;
            }
            return sonuc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int y;
            y = Convert.ToInt32(textBox1.Text);
            label1.Text = faktoriyelhesapla(y).ToString();
        }
    }
    }
