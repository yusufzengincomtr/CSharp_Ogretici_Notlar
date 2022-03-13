using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=BAHATTINPC\\SQL_2014;Initial Catalog=milyoner;Integrated Security=True");
        void soru1()
        {
            if (baglantı.State==ConnectionState.Closed)
            {
                baglantı.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglantı;
                cmd.CommandText = "SELECT *FROM soru where s_no=1 ";
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    sorumuz.Text=dr["s1"].ToString();
                    button1.Text =dr["asık"].ToString();
                    button2.Text =dr["bsık"].ToString();
                    button3.Text =dr["csık"].ToString();
                    button4.Text =dr["dsık"].ToString();
                    lblcevap.Text =dr["cevap"].ToString();
                }
                baglantı.Close();
            }
        }
        void soru2()
        {
            if (baglantı.State == ConnectionState.Closed)
            {
                baglantı.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglantı;
                cmd.CommandText = "SELECT *FROM soru where s_no=2";
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    sorumuz.Text =  dr["s1"].ToString();
                    button1.Text = dr["asık"].ToString();
                    button2.Text = dr["bsık"].ToString();
                    button3.Text = dr["csık"].ToString();
                    button4.Text = dr["dsık"].ToString();
                    lblcevap.Text = dr["cevap"].ToString();
                }
                baglantı.Close();
            }
        }
        void soru3()
        {
            if (baglantı.State == ConnectionState.Closed)
            {
                baglantı.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglantı;
                cmd.CommandText = "SELECT *FROM soru where s_no=3";
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    sorumuz.Text = dr["s1"].ToString();
                    button1.Text = dr["asık"].ToString();
                    button2.Text = dr["bsık"].ToString();
                    button3.Text = dr["csık"].ToString();
                    button4.Text = dr["dsık"].ToString();
                    lblcevap.Text = dr["cevap"].ToString();
                }
                baglantı.Close();
            }
        }
        void soru4()
        {
            if (baglantı.State == ConnectionState.Closed)
            {
                baglantı.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglantı;
                cmd.CommandText = "SELECT *FROM soru where s_no=4";
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    sorumuz.Text =  dr["s1"].ToString();
                    button1.Text = dr["asık"].ToString();
                    button2.Text = dr["bsık"].ToString();
                    button3.Text = dr["csık"].ToString();
                    button4.Text = dr["dsık"].ToString();
                    lblcevap.Text = dr["cevap"].ToString();
                }
                baglantı.Close();
            }
        }
        void soru5()
        {
            if (baglantı.State == ConnectionState.Closed)
            {
                baglantı.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglantı;
                cmd.CommandText = "SELECT *FROM soru where s_no=5";
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    sorumuz.Text =  dr["s1"].ToString();
                    button1.Text = dr["asık"].ToString();
                    button2.Text = dr["bsık"].ToString();
                    button3.Text = dr["csık"].ToString();
                    button4.Text = dr["dsık"].ToString();
                    lblcevap.Text = dr["cevap"].ToString();
                }
                baglantı.Close();
            }
        }
        void soru6()
        {
            if (baglantı.State == ConnectionState.Closed)
            {
                baglantı.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglantı;
                cmd.CommandText = "SELECT *FROM soru where s_no=6";
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    sorumuz.Text = dr["s1"].ToString();
                    button1.Text = dr["asık"].ToString();
                    button2.Text = dr["bsık"].ToString();
                    button3.Text = dr["csık"].ToString();
                    button4.Text = dr["dsık"].ToString();
                    lblcevap.Text = dr["cevap"].ToString();
                }
                baglantı.Close();
            }
        }

        void dogru()
        {

            if (dcvp==1)
            {
                besyuz.BackColor = Color.Lime;
                kazanc = 0;
            }
            if (dcvp==2)
            {
                bın.BackColor = Color.Lime;
                kazanc = 1000;
            }
            if (dcvp==3)
            {
                ıkıbın.BackColor = Color.Lime;
                kazanc = 1000;
            }
            if (dcvp==4)
            {
                ucbın.BackColor = Color.Lime;
                kazanc = 1000;
            }
            if (dcvp == 5)
            {
                besbın.BackColor = Color.Lime;
                kazanc = 1000;
            }
            if (dcvp == 6)
            {
                yedıbın.BackColor = Color.Lime;
                kazanc = 1000;
            }
            if (dcvp == 7)
            {
                onbesbın.BackColor = Color.Lime;
                kazanc = 15000;
            }
            if (dcvp == 8)
            {
                otuzbın.BackColor = Color.Lime;
                kazanc = 15000;
            }

        }
        void yanlıs()
        {
            dcvp = 0;
            besyuz.BackColor = Color.Transparent;
            bın.BackColor = Color.Transparent;
            ıkıbın.BackColor = Color.Transparent;
            ucbın.BackColor = Color.Transparent;
            besbın.BackColor = Color.Transparent;
            yedıbın.BackColor = Color.Transparent;
            onbesbın.BackColor = Color.Transparent;
        }
        void bitis()
        {
            if (bın.BackColor!=Color.Lime)
            {
                gnlpanel.Visible = false;
                panel2.Visible = true;
                lblsonuc.Text = "Malesef Para Kazanamadınız.";
            }
            if(bın.BackColor == Color.Lime)
            {
                gnlpanel.Visible = false;
                panel2.Visible = true;
                lblsonuc.Text = "Tebrikler"+kazanc.ToString()+" Lira Kazandınız.";
            }
            if (onbesbın.BackColor==Color.Lime)
            {
                gnlpanel.Visible = false;
                panel2.Visible = true;
                lblsonuc.Text = "Tebrikler" + kazanc.ToString() + " Lira Kazandınız.";
            }
        }
        
        int dcvp;
        int kazanc;
        int soru=1;
        void sorular()
        {
            button4.Visible = true;
            button3.Visible = true;
            button2.Visible = true;
            soru++;
            if (soru==2)
            {
                soru2();
            }
            if (soru == 3)
            {
                soru3();
            }
            if (soru==4)
            {
                soru4();
            }
            if (soru==5)
            {
                soru5();
            }
            if (soru==6)
            {
                soru6();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            soru1();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           //timer1.Start();
            if (button1.Text==lblcevap.Text)
            {
                dcvp++;
                dogru();
                MessageBox.Show("Tebrikler Doğru Bildiniz Bir Sonraki Soruya Geçiyorsunuz.");
                sorular();
           //  timer1.Stop();
            }
            else
            {
                MessageBox.Show("Malesef Yanlış Cevap Tekrar Deneyiniz.");
                bitis();
                yanlıs();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == lblcevap.Text)
            {
                dcvp++;
                dogru();
                MessageBox.Show("Tebrikler Doğru Bildiniz Bir Sonraki Soruya Geçiyorsunuz.");
                sorular();
            }
            else
            {
                MessageBox.Show("Malesef Yanlış Cevap Tekrar Deneyiniz.");
                bitis();
                yanlıs();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {

            if (button4.Text == lblcevap.Text)
            {
                dcvp++;
                dogru();
                MessageBox.Show("Tebrikler Doğru Bildiniz Bir Sonraki Soruya Geçiyorsunuz.");
                sorular();
            }
            else
            {
                MessageBox.Show("Malesef Yanlış Cevap Tekrar Deneyiniz.");
                bitis();
                yanlıs();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == lblcevap.Text)
            {
                dcvp++;
                dogru();
                MessageBox.Show("Tebrikler Doğru Bildiniz Bir Sonraki Soruya Geçiyorsunuz.");
                sorular();
                
            }
            else
            {
                MessageBox.Show("Malesef Yanlış Cevap Tekrar Deneyiniz.");
                bitis();
                yanlıs();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            button3.Visible = true;
            button2.Visible = true;
            button8.Visible = true;
            gnlpanel.Visible = true;
            button5.Visible = true;
            soru1();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            if (lblcevap.Text==button1.Text)
            {
                button3.Visible = false;
                button4.Visible = false;
            }
            if (lblcevap.Text == button2.Text)
            {
                button3.Visible = false;
                button4.Visible = false;
            }
            if (lblcevap.Text == button3.Text)
            {
                button2.Visible = false;
                button4.Visible = false;
            }
            if (lblcevap.Text == button4.Text)
            {
                button3.Visible = false;
                button2.Visible = false;
            }
        }
        int say;
        Random rnd = new Random();
        private void button8_Click(object sender, EventArgs e)
        {
            button8.Visible = false;
            panel3.Visible = true;
            pictureBox1.Visible = false;
            if (lblcevap.Text == button1.Text)
            {
                lbla.Width = rnd.Next(25, 70);
                lblb.Width = rnd.Next(5, 30);
                lblc.Width = rnd.Next(5, 30);
                lbld.Width = rnd.Next(5, 30);
                lbljoker.Text = "Seyircilerimizin Çoğunluğu A Şıkkını Seçmiş Durumda";
            }
            if (lblcevap.Text == button2.Text)
            {
                lbla.Width = rnd.Next(5, 30);
                lblb.Width = rnd.Next(25, 75);
                lblc.Width = rnd.Next(5, 30);
                lbld.Width = rnd.Next(5, 30);
                lbljoker.Text = "Seyircilerimizin Çoğunluğu B Şıkkını Seçmiş Durumda";
            }
            if (lblcevap.Text == button3.Text)
            {
                lbla.Width = rnd.Next(5, 30);
                lblb.Width = rnd.Next(5, 30);
                lblc.Width = rnd.Next(25, 75);
                lbld.Width = rnd.Next(5, 30);
                lbljoker.Text = "Seyircilerimizin Çoğunluğu C Şıkkını Seçmiş Durumda";
            }
            if (lblcevap.Text == button4.Text)
            {
                lbla.Width = rnd.Next(5, 30);
                lbld.Width = rnd.Next(25, 75);
                lblc.Width = rnd.Next(5, 30);
                lblb.Width = rnd.Next(5, 30);
                lbljoker.Text = "Seyircilerimizin Çoğunluğu D Şıkkını Seçmiş Durumda";
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            pictureBox1.Visible = true;
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //say++;
            //timer1.Interval = 750;
            //label2.Text = say.ToString();
            //if (say<3)
            //{
            //    button1.BackColor = Color.DarkOrange;
            //}
            //if (say>4 && lblcevap.Text == button1.Text)
            //{
            //    dogru();
            //    button1.BackColor = Color.Lime;
            //}
            //else
            //{
            //    bitis();
            //    yanlıs();
            //}
            //if (say==6)
            //{
            //    button1.BackColor = Color.Transparent;
            //    sorular();
            //    timer1.Stop();
            //    say = 0;
            //}
        }
    }
}
