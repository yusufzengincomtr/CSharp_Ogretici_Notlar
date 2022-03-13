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
        int sayi;
        private void btnaktar_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(txts1.Text);//ÇİFTSE
            if (sayi%2==0)
            {
                liste2.Items.Add(sayi.ToString());//LİSTE2 YE YAZDIR ELSE İF YANİ DEĞİLSE
            }
            else if (sayi%2==1)
            {
                liste.Items.Add(sayi.ToString());//TEK İSE LİSTE 1E YAZDIR.
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
