using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace label_olusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt32(textBox1.Text);
            Label[] dizi = new Label[s];
            for (int i = 0; i <= s; i++)
            {
                dizi[i] = new Label();
                dizi[i].Text = "yusufzengin"+ i.ToString();
                this.Controls.Add(dizi[i]);
                dizi[i].Top =i*30;
                dizi[i].Left = 10;
                dizi[i].Width = 100;
            }
        }
    }
}
