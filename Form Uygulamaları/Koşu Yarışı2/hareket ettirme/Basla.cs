using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hareket_ettirme
{
    public partial class Basla : Form
    {
        public Basla()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            timer1.Start();
            progressBar1.Visible = true;
            label1.Visible = true;
        }
    
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            progressBar1.Value += 2;
            timer1.Interval = 45;
            label1.Text = progressBar1.Value.ToString() + "% Yükleniyor...";
            if (progressBar1.Value==100)
            {
                timer1.Stop();
                MessageBox.Show("Yükleme Tamamlandı Oyunumuza Başlıyorsunuz");
                Form1 git = new Form1();
                git.Show();
                this.Hide();
                
            }
        }

        private void Basla_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            label1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
