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
        int sayi,rastsayi,hak=3;

        private void Form1_Load(object sender, EventArgs e)
        {
            lblhak.Text = hak.ToString();
            Random rastgele = new Random();
            rastsayi = rastgele.Next(0, 10);
            lblrast.Text = rastsayi.ToString(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(textBox1.Text);
            lblhak.Text = hak.ToString();

            if (sayi==rastsayi)
            {
             
                lblgoster.Text = "Tebrikler";
                hak--;
                lblhak.Text = "KALAN DENEME SAYISI: "+hak.ToString();
                lblhak.Visible = false;
                panel1.Visible = false;
                MessageBox.Show("Çıkmak için KAPAT butonuna tıkla");
            }
            else
            {
                if (sayi<rastsayi)
                {
                    lblgoster.Text = "DAHA BÜYÜK SAYI GİRİNİZ:";
                    hak--;
                    lblhak.Text = "KALAN DENEME SAYISI: " + hak.ToString();
                    textBox1.Clear();
                }
                else if (sayi>rastsayi)
                {
                    lblgoster.Text = "DAHA KÜÇÜK SAYI GİRİNİZ:";
                    hak--;
                    lblhak.Text = "KALAN DENEME SAYISI: " + hak.ToString();
                    textBox1.Clear();
                }
                if (hak==0)
                {
                    lblhak.Text = "DENEME HAKKINIZ KALMADI";
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    MessageBox.Show("Deneme Hakkınız Kalmadı Çıkmak için KAPAT butonuna tıkla");
                }
            }
                   
        }
    }
}
