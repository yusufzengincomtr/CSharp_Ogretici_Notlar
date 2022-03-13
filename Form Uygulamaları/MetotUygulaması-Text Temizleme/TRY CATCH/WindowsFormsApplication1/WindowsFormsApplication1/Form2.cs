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
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                 int a, b;
                 a = Convert.ToInt32(textBox1.Text);
                 b = Convert.ToInt32(textBox2.Text);
                 int toplam = a + b;
                 label1.Text = toplam.ToString();
            }
            catch (OverflowException tasmahatası)
            {
                MessageBox.Show("+-2,147,483,647 aralıkta değer girmelisiniz. " + tasmahatası.Message);
                
            }

        }
    }
}
