using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x, çarpım = 1;
            x = Convert.ToInt32(textBox1.Text);
            çarpım = x * 4;
            lblsonuc.Text = çarpım.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, alan = 1;
            x = Convert.ToInt32(textBox1.Text);
            alan = x * x;
            lblsonuc.Text = alan.ToString();
          
        }
    }
}
