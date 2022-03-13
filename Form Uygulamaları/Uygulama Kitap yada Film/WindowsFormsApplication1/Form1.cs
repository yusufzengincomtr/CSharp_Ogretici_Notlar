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

        private void chktp_CheckedChanged(object sender, EventArgs e)
        {
            if (chktp.Checked==true && chktp.Checked==false)
            {
                lbldurum.Text = "Müzik";
            }
            else if(chktp.Checked=true && )
            {

            }
        }
    }
}
