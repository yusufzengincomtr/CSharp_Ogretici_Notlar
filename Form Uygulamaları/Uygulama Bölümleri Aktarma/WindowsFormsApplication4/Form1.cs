using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnaktar_Click(object sender, EventArgs e)
        {
            if (bilisim.Checked==true)
            {
                lblsonuc.Text = bilisim.Text;
            }
           else if (ulastırma.Checked == true)
            {
                lblsonuc.Text = ulastırma.Text;
            }
            else if (adalet.Checked == true)
            {
                lblsonuc.Text = adalet.Text;
            }
            else if (muhasebe.Checked == true)
            {
                lblsonuc.Text = muhasebe.Text;
            }
        }
    }
}
