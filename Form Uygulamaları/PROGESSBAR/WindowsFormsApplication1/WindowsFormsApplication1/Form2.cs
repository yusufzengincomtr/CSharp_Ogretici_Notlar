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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int sayac =0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            progressBar1.Value++;
            label1.Text = "%" + sayac + "Tamamlandı. Lütfen Bekleyiniz..";
            if (sayac==100)
            {
                timer1.Stop();
                MessageBox.Show("Yükleme Tamamlandı..");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
