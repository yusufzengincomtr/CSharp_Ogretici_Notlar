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
        int sayi, sonuc = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                sonuc = sayi * 2;
                label2.Text = sonuc.ToString();
            }
            else if (checkBox2.Checked == true)
            {
                sonuc = sayi / 2;
                label1.Text = sonuc.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(textBox1.Text);
            listBox1.Items.Add(sayi);
        }
    }
}
