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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int sayi;
        private void btnsonuc_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(txts1.Text);
            if (sayi %2== 0) 
            {
                lblsonuc.Text = "Çift";

            }
            else if (sayi%2==1)
            {
                lblsonuc.Text = "Tek";
            }
        }
    }
}
