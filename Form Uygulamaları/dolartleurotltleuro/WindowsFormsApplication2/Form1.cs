using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbeurotl_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txttutar_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btncevir_Click(object sender, EventArgs e)
        {
            int tutar, dolar, euro;
            tutar = Convert.ToInt32(txttutar.Text);
            if (rbtldolar.Checked==true)
            {
                tutar = tutar / 6;
                lblsonuc.Text=tutar.ToString();
            }
            else if (rbdolartl.Checked == true)
            {
                tutar = tutar*5;
                lblsonuc.Text = tutar.ToString();
            }
            else if (rbtleuro.Checked == true)
            {
                tutar = tutar /7;
                lblsonuc.Text = tutar.ToString();
            }
            else if (rbeurotl.Checked == true)
            {
                tutar = tutar * 6;
                lblsonuc.Text = tutar.ToString();
            }
        }
    }
}
