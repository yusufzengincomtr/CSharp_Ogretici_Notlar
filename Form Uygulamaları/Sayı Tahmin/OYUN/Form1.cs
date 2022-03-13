using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace OYUN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int la = 8;

        ArrayList yeni = new ArrayList();
        ArrayList uzantı = new ArrayList();
        int sayac = 0;
       
        Random rast = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (la == 0)
            {
                MessageBox.Show("TAHMİN HAKKINIZ BİTMİŞTİR.");

            }
            else
            {


                la--;
                lblsonucc.Text = la.ToString();
                sayac = 0;
                lblsonuc.Text = sayac.ToString();
                int x, y, z, c, t, u;
                x = Convert.ToInt32(textBox1.Text);
                y = Convert.ToInt32(textBox2.Text);
                z = Convert.ToInt32(textBox3.Text);
                c = Convert.ToInt32(textBox4.Text);
                t = Convert.ToInt32(textBox5.Text);
                u = Convert.ToInt32(textBox6.Text);
                foreach (Control lala in this.Controls)
                {
                    if (lala.GetType() == typeof(TextBox))
                    {
                        int rastegele = rast.Next(1, uzantı.Count);


                        lala.Text = uzantı[rastegele].ToString();


                        uzantı.RemoveAt(rastegele);
                    }
                }






                //////////////////
                if (textBox1.Text == textBox7.Text)
                {
                    sayac++;
                }
                else if (textBox1.Text == textBox8.Text)
                {
                    sayac++;
                }

                else if (textBox1.Text == textBox9.Text)
                {
                    sayac++;
                }

                else if (textBox1.Text == textBox10.Text)
                {
                    sayac++;
                }

                else if (textBox1.Text == textBox11.Text)
                {
                    sayac++;
                }

                else if (textBox1.Text == textBox12.Text)
                {
                    sayac++;
                }
                /////////////////////////
                if (textBox2.Text == textBox7.Text)
                {
                    sayac++;
                }
                else if (textBox2.Text == textBox8.Text)
                {
                    sayac++;
                }

                else if (textBox2.Text == textBox9.Text)
                {
                    sayac++;
                }

                else if (textBox2.Text == textBox10.Text)
                {
                    sayac++;
                }

                else if (textBox2.Text == textBox11.Text)
                {
                    sayac++;
                }

                else if (textBox2.Text == textBox12.Text)
                {
                    sayac++;
                }
                //////////////////////
                if (textBox3.Text == textBox7.Text)
                {
                    sayac++;
                }
                else if (textBox3.Text == textBox8.Text)
                {
                    sayac++;
                }

                else if (textBox3.Text == textBox9.Text)
                {
                    sayac++;
                }

                else if (textBox3.Text == textBox10.Text)
                {
                    sayac++;
                }

                else if (textBox3.Text == textBox11.Text)
                {
                    sayac++;
                }

                else if (textBox3.Text == textBox12.Text)
                {
                    sayac++;
                }
                //////////////////////////
                if (textBox4.Text == textBox7.Text)
                {
                    sayac++;
                }
                else if (textBox4.Text == textBox8.Text)
                {
                    sayac++;
                }

                else if (textBox4.Text == textBox9.Text)
                {
                    sayac++;
                }

                else if (textBox4.Text == textBox10.Text)
                {
                    sayac++;
                }

                else if (textBox4.Text == textBox11.Text)
                {
                    sayac++;
                }

                else if (textBox4.Text == textBox12.Text)
                {
                    sayac++;
                }
                ////////////////////////
                if (textBox5.Text == textBox7.Text)
                {
                    sayac++;
                }
                else if (textBox5.Text == textBox8.Text)
                {
                    sayac++;
                }

                else if (textBox5.Text == textBox9.Text)
                {
                    sayac++;
                }

                else if (textBox5.Text == textBox10.Text)
                {
                    sayac++;
                }

                else if (textBox5.Text == textBox11.Text)
                {
                    sayac++;
                }

                else if (textBox5.Text == textBox12.Text)
                {
                    sayac++;
                }
                ///////////////////////////
                if (textBox6.Text == textBox7.Text)
                {
                    sayac++;
                }
                else if (textBox6.Text == textBox8.Text)
                {
                    sayac++;
                }

                else if (textBox6.Text == textBox9.Text)
                {
                    sayac++;
                }

                else if (textBox6.Text == textBox10.Text)
                {
                    sayac++;
                }

                else if (textBox6.Text == textBox11.Text)
                {
                    sayac++;
                }

                else if (textBox6.Text == textBox12.Text)
                {
                    sayac++;
                }
                //////////////////////////



                lblsonuc.Text = "DOĞRU TAHMİN SAYINIZ:" + sayac.ToString();



            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblsonucc.Text = la.ToString();
            for (int i = 0; i < 49; i++)
            {
                uzantı.Add(i);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        
            la = 8;
            lblsonucc.Text = la.ToString();
            uzantı.Clear();
            for (int a = 0; a < 49; a++)
            {
                uzantı.Add(a);
            }
        }
    }
}
