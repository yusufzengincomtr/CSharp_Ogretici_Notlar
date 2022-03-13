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
        int s1, s2, toplam = 0;
        private void btntoplam_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToInt32(txts1.Text);
            s2 = Convert.ToInt32(txts2.Text);
            toplam = s1 + s2;
            lbltoplam.Text =toplam.ToString();
        }
    }
}
