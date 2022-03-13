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

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 20;
            progressBar1.Maximum = 20;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            progressBar1.Value = textBox1.Text.Length;
            if (textBox1.Text.Length == 20)
            {
                MessageBox.Show("DOLDU!!!");
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
