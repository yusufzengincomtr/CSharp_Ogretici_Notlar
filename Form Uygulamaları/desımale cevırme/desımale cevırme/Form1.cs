using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desımale_cevırme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int üs1;
        int üs2;
        int üs3;
        int üs4;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x,y,z,c;
         
            
            int toplamsonuc = 0;
            x = Convert.ToInt32(textBox1.Text);

            if (x!=0)
            {
                üs1 = 4 * 6;
            }               

                     
            

            /////////////////////////////

            y = Convert.ToInt32(textBox2.Text);
            if (y!=0)
            {
                üs2 = 3 * 2;
            }
            
            
            ////////////////////////////////

            z = Convert.ToInt32(textBox3.Text);
            if (z!=0)
            {
            üs3 = 2*1;
            }
                   
                        
            //////////////////////////////////

            c = Convert.ToInt32(textBox4.Text);
            if (c != 0)
            {
                üs4 = 1;
            }
            

            ///////////////////////
           
            toplamsonuc = üs1 + üs2 + üs3 + üs4;

            label1.Text = toplamsonuc.ToString();         

        }
    }
}
