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
            for (int i = 0; i < 15; i++)
            {             
                 sayi = rastgele.Next(-100, 100);
                if (sayi > 0)
                {
                    listBox2.Items.Add(sayi);
                }

                else if (sayi < 0)
                {
                    listBox3.Items.Add(sayi);
                }
                listBox1.Items.Add(sayi);
            }
        }
    }
}
