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
        private void btnaktar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i%5==0)
                {
                    l1.Items.Add(i.ToString());
                }
                else if (i%7==0)
                {
                    l2.Items.Add(i.ToString());
                }
            }
                
        }
    }
}
