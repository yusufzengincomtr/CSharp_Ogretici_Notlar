using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_SAYININ_FARKI_TOPLAMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int s1, s2, toplam = 0;
        private void btnişlem_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToInt32(txts1.Text);
            s2 = Convert.ToInt32(txts2.Text);
            if (rbtoplam.Checked == true)
            {
                toplam = s1 + s2;
                lblsonuc.Text = toplam.ToString();
            }
            else if (rbfark.Checked == true)
            {
                toplam = s1 - s2;
                lblsonuc.Text = toplam.ToString();
            }
        }
    }
}
