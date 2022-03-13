namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblsure = new System.Windows.Forms.Label();
            this.rbaylık = new System.Windows.Forms.RadioButton();
            this.rbücret = new System.Windows.Forms.RadioButton();
            this.btndoldur = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbldoldurma = new System.Windows.Forms.Label();
            this.btnıdo = new System.Windows.Forms.Button();
            this.btnmetrobus = new System.Windows.Forms.Button();
            this.btnotobus = new System.Windows.Forms.Button();
            this.lblsüre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblkredi = new System.Windows.Forms.Label();
            this.rbücretsiz = new System.Windows.Forms.RadioButton();
            this.rbnormal = new System.Windows.Forms.RadioButton();
            this.rbögrt = new System.Windows.Forms.RadioButton();
            this.rbögr = new System.Windows.Forms.RadioButton();
            this.lblcesit = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblsure
            // 
            this.lblsure.AutoSize = true;
            this.lblsure.Location = new System.Drawing.Point(418, 23);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(34, 13);
            this.lblsure.TabIndex = 35;
            this.lblsure.Text = "00:00";
            // 
            // rbaylık
            // 
            this.rbaylık.AutoSize = true;
            this.rbaylık.Location = new System.Drawing.Point(143, 86);
            this.rbaylık.Name = "rbaylık";
            this.rbaylık.Size = new System.Drawing.Size(47, 17);
            this.rbaylık.TabIndex = 34;
            this.rbaylık.TabStop = true;
            this.rbaylık.Text = "Aylık";
            this.rbaylık.UseVisualStyleBackColor = true;
            // 
            // rbücret
            // 
            this.rbücret.AutoSize = true;
            this.rbücret.Location = new System.Drawing.Point(30, 86);
            this.rbücret.Name = "rbücret";
            this.rbücret.Size = new System.Drawing.Size(90, 17);
            this.rbücret.TabIndex = 33;
            this.rbücret.TabStop = true;
            this.rbücret.Text = "Ücret Dolumu";
            this.rbücret.UseVisualStyleBackColor = true;
            // 
            // btndoldur
            // 
            this.btndoldur.Location = new System.Drawing.Point(252, 33);
            this.btndoldur.Name = "btndoldur";
            this.btndoldur.Size = new System.Drawing.Size(83, 34);
            this.btndoldur.TabIndex = 32;
            this.btndoldur.Text = "DOLDUR";
            this.btndoldur.UseVisualStyleBackColor = true;
            this.btndoldur.Click += new System.EventHandler(this.btndoldur_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 31;
            // 
            // lbldoldurma
            // 
            this.lbldoldurma.AutoSize = true;
            this.lbldoldurma.Location = new System.Drawing.Point(12, 39);
            this.lbldoldurma.Name = "lbldoldurma";
            this.lbldoldurma.Size = new System.Drawing.Size(114, 13);
            this.lbldoldurma.TabIndex = 30;
            this.lbldoldurma.Text = "Akbili Doldurma Kredisi";
            // 
            // btnıdo
            // 
            this.btnıdo.Location = new System.Drawing.Point(265, 108);
            this.btnıdo.Name = "btnıdo";
            this.btnıdo.Size = new System.Drawing.Size(88, 37);
            this.btnıdo.TabIndex = 29;
            this.btnıdo.Text = "Metro/IDO";
            this.btnıdo.UseVisualStyleBackColor = true;
            this.btnıdo.Click += new System.EventHandler(this.btnıdo_Click);
            // 
            // btnmetrobus
            // 
            this.btnmetrobus.Location = new System.Drawing.Point(142, 108);
            this.btnmetrobus.Name = "btnmetrobus";
            this.btnmetrobus.Size = new System.Drawing.Size(90, 37);
            this.btnmetrobus.TabIndex = 28;
            this.btnmetrobus.Text = "Metrobüs";
            this.btnmetrobus.UseVisualStyleBackColor = true;
            this.btnmetrobus.Click += new System.EventHandler(this.btnmetrobus_Click);
            // 
            // btnotobus
            // 
            this.btnotobus.Location = new System.Drawing.Point(15, 108);
            this.btnotobus.Name = "btnotobus";
            this.btnotobus.Size = new System.Drawing.Size(97, 37);
            this.btnotobus.TabIndex = 27;
            this.btnotobus.Text = "Otobüs";
            this.btnotobus.UseVisualStyleBackColor = true;
            this.btnotobus.Click += new System.EventHandler(this.btnotobus_Click);
            // 
            // lblsüre
            // 
            this.lblsüre.AutoSize = true;
            this.lblsüre.Location = new System.Drawing.Point(380, 23);
            this.lblsüre.Name = "lblsüre";
            this.lblsüre.Size = new System.Drawing.Size(32, 13);
            this.lblsüre.TabIndex = 26;
            this.lblsüre.Text = "Süre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 25;
            // 
            // lblkredi
            // 
            this.lblkredi.AutoSize = true;
            this.lblkredi.Location = new System.Drawing.Point(26, 57);
            this.lblkredi.Name = "lblkredi";
            this.lblkredi.Size = new System.Drawing.Size(57, 13);
            this.lblkredi.TabIndex = 24;
            this.lblkredi.Text = "Akbil Kredi";
            // 
            // rbücretsiz
            // 
            this.rbücretsiz.AutoSize = true;
            this.rbücretsiz.Location = new System.Drawing.Point(298, 19);
            this.rbücretsiz.Name = "rbücretsiz";
            this.rbücretsiz.Size = new System.Drawing.Size(63, 17);
            this.rbücretsiz.TabIndex = 23;
            this.rbücretsiz.TabStop = true;
            this.rbücretsiz.Text = "Ücretsiz";
            this.rbücretsiz.UseVisualStyleBackColor = true;
            // 
            // rbnormal
            // 
            this.rbnormal.AutoSize = true;
            this.rbnormal.Location = new System.Drawing.Point(234, 19);
            this.rbnormal.Name = "rbnormal";
            this.rbnormal.Size = new System.Drawing.Size(58, 17);
            this.rbnormal.TabIndex = 22;
            this.rbnormal.TabStop = true;
            this.rbnormal.Text = "Normal";
            this.rbnormal.UseVisualStyleBackColor = true;
            // 
            // rbögrt
            // 
            this.rbögrt.AutoSize = true;
            this.rbögrt.Location = new System.Drawing.Point(157, 19);
            this.rbögrt.Name = "rbögrt";
            this.rbögrt.Size = new System.Drawing.Size(71, 17);
            this.rbögrt.TabIndex = 21;
            this.rbögrt.TabStop = true;
            this.rbögrt.Text = "Öğretmen";
            this.rbögrt.UseVisualStyleBackColor = true;
            // 
            // rbögr
            // 
            this.rbögr.AutoSize = true;
            this.rbögr.Location = new System.Drawing.Point(89, 19);
            this.rbögr.Name = "rbögr";
            this.rbögr.Size = new System.Drawing.Size(62, 17);
            this.rbögr.TabIndex = 20;
            this.rbögr.TabStop = true;
            this.rbögr.Text = "Öğrenci";
            this.rbögr.UseVisualStyleBackColor = true;
            // 
            // lblcesit
            // 
            this.lblcesit.AutoSize = true;
            this.lblcesit.Location = new System.Drawing.Point(12, 23);
            this.lblcesit.Name = "lblcesit";
            this.lblcesit.Size = new System.Drawing.Size(61, 13);
            this.lblcesit.TabIndex = 19;
            this.lblcesit.Text = "Akbil Çeşidi";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbldoldurma);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.btndoldur);
            this.groupBox1.Controls.Add(this.rbaylık);
            this.groupBox1.Controls.Add(this.rbücret);
            this.groupBox1.Location = new System.Drawing.Point(15, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 131);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 312);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblsure);
            this.Controls.Add(this.btnıdo);
            this.Controls.Add(this.btnmetrobus);
            this.Controls.Add(this.btnotobus);
            this.Controls.Add(this.lblsüre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblkredi);
            this.Controls.Add(this.rbücretsiz);
            this.Controls.Add(this.rbnormal);
            this.Controls.Add(this.rbögrt);
            this.Controls.Add(this.rbögr);
            this.Controls.Add(this.lblcesit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsure;
        private System.Windows.Forms.RadioButton rbaylık;
        private System.Windows.Forms.RadioButton rbücret;
        private System.Windows.Forms.Button btndoldur;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbldoldurma;
        private System.Windows.Forms.Button btnıdo;
        private System.Windows.Forms.Button btnmetrobus;
        private System.Windows.Forms.Button btnotobus;
        private System.Windows.Forms.Label lblsüre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblkredi;
        private System.Windows.Forms.RadioButton rbücretsiz;
        private System.Windows.Forms.RadioButton rbnormal;
        private System.Windows.Forms.RadioButton rbögrt;
        private System.Windows.Forms.RadioButton rbögr;
        private System.Windows.Forms.Label lblcesit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

