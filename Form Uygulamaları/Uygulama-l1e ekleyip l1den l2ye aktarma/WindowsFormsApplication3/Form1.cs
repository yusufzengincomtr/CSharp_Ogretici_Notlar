using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string a;
       
        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToString(textBox1.Text);
            l1.Items.Add(a);
        }

        private void btnaktar_Click(object sender, EventArgs e)
        {
            l1.SelectedItem = l2.Text;
            l2.Items.Add(l1.Text);
        }
    }
}
