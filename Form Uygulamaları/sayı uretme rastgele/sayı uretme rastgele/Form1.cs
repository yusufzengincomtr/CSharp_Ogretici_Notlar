using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayı_uretme_rastgele
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi;
        Random rastgele = new Random();
        private void btnrast_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i <= sayi; i++)
            {
                if (radioButton1.Checked)
                {
                    int rast = rastgele.Next(10, 99);
                    if (rast%2==1)
                    {
                        listBox1.Items.Add(rast);
                    }
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
