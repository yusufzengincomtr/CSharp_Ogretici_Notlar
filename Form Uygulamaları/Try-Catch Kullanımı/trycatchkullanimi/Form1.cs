using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trycatchkullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int s1, s2, toplam = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int s1, s2, toplam = 0;
                s1 = Convert.ToInt32(txts1.Text);
                s2 = Convert.ToInt32(txts2.Text);
                toplam = s1 + s2;
                lblsonuc.Text = toplam.ToString();
            }
            catch (Exception hata)//Hatanın ne oldugunu gormek ıstedıgımızde kullanılır. //catch sade yazınca hatanın ne oldugunu goremeyız.
            {
                label1.Visible = true;
                label1.Text = " Sayı Girişi Yapınız " + hata.Message;
            }
            finally
            {
                s1 = 0;
                s2 = 0;
                toplam = 0;
                lblsonuc.Text = "İşlem Yapılamadı. ";

            }
        }


    }
}
