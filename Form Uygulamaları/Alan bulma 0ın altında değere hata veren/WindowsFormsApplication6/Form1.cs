using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, alan = 1;
            x = Convert.ToInt32(textBox1.Text);
            if (x<=0)
            {
                label1.Text = "UZUNLUGU SIFIRDAN BÜYÜK GİRİNİZ";
            }
            else
            {
                alan = x * x;
                label1.Text = alan.ToString();
            }
        }
    }
}
