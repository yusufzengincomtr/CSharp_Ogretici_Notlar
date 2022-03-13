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
        double a, b;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                label1.Text = ((a + b) / 2).ToString();
            }
             catch (FormatException hata)
             {
                 MessageBox.Show("Format HATASI Sayı Girilmesi Gerekiyor.  "+hata.Message);
             }

        }
    }
}
