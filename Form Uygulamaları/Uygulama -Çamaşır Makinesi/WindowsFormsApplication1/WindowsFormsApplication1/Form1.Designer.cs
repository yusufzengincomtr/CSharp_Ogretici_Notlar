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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chkelktr = new System.Windows.Forms.CheckBox();
            this.chkçmşr = new System.Windows.Forms.CheckBox();
            this.chksu = new System.Windows.Forms.CheckBox();
            this.chkekstra = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.rbeyaz3dk = new System.Windows.Forms.RadioButton();
            this.rbrenk2dk = new System.Windows.Forms.RadioButton();
            this.rbnarin1dk = new System.Windows.Forms.RadioButton();
            this.lbldurum = new System.Windows.Forms.Label();
            this.lblzaman = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // chkelktr
            // 
            this.chkelktr.AutoSize = true;
            this.chkelktr.BackColor = System.Drawing.Color.LightGray;
            this.chkelktr.Location = new System.Drawing.Point(260, 221);
            this.chkelktr.Name = "chkelktr";
            this.chkelktr.Size = new System.Drawing.Size(80, 17);
            this.chkelktr.TabIndex = 0;
            this.chkelktr.Text = "Elektrik Var";
            this.chkelktr.UseVisualStyleBackColor = false;
            // 
            // chkçmşr
            // 
            this.chkçmşr.AutoSize = true;
            this.chkçmşr.BackColor = System.Drawing.Color.LightGray;
            this.chkçmşr.Location = new System.Drawing.Point(260, 263);
            this.chkçmşr.Name = "chkçmşr";
            this.chkçmşr.Size = new System.Drawing.Size(116, 17);
            this.chkçmşr.TabIndex = 1;
            this.chkçmşr.Text = "Çamaşırlar Konuldu";
            this.chkçmşr.UseVisualStyleBackColor = false;
            // 
            // chksu
            // 
            this.chksu.AutoSize = true;
            this.chksu.BackColor = System.Drawing.Color.LightGray;
            this.chksu.Location = new System.Drawing.Point(260, 240);
            this.chksu.Name = "chksu";
            this.chksu.Size = new System.Drawing.Size(67, 17);
            this.chksu.TabIndex = 2;
            this.chksu.Text = "Su Açıldı";
            this.chksu.UseVisualStyleBackColor = false;
            // 
            // chkekstra
            // 
            this.chkekstra.AutoSize = true;
            this.chkekstra.BackColor = System.Drawing.SystemColors.ControlDark;
            this.chkekstra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkekstra.Location = new System.Drawing.Point(277, 107);
            this.chkekstra.Name = "chkekstra";
            this.chkekstra.Size = new System.Drawing.Size(139, 17);
            this.chkekstra.TabIndex = 3;
            this.chkekstra.Text = "Ekstra Durulama (30sn.)";
            this.chkekstra.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "Başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "Resetle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(128, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Durdur";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // rbeyaz3dk
            // 
            this.rbeyaz3dk.AutoSize = true;
            this.rbeyaz3dk.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rbeyaz3dk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbeyaz3dk.Location = new System.Drawing.Point(270, 54);
            this.rbeyaz3dk.Name = "rbeyaz3dk";
            this.rbeyaz3dk.Size = new System.Drawing.Size(92, 17);
            this.rbeyaz3dk.TabIndex = 7;
            this.rbeyaz3dk.Text = "Beyazlar (3dk)";
            this.rbeyaz3dk.UseVisualStyleBackColor = false;
            // 
            // rbrenk2dk
            // 
            this.rbrenk2dk.AutoSize = true;
            this.rbrenk2dk.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rbrenk2dk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbrenk2dk.Location = new System.Drawing.Point(323, 90);
            this.rbrenk2dk.Name = "rbrenk2dk";
            this.rbrenk2dk.Size = new System.Drawing.Size(93, 17);
            this.rbrenk2dk.TabIndex = 8;
            this.rbrenk2dk.Text = "Renkliler (2dk)";
            this.rbrenk2dk.UseVisualStyleBackColor = false;
            // 
            // rbnarin1dk
            // 
            this.rbnarin1dk.AutoSize = true;
            this.rbnarin1dk.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rbnarin1dk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbnarin1dk.Location = new System.Drawing.Point(338, 73);
            this.rbnarin1dk.Name = "rbnarin1dk";
            this.rbnarin1dk.Size = new System.Drawing.Size(88, 17);
            this.rbnarin1dk.TabIndex = 9;
            this.rbnarin1dk.Text = "Narinler (1dk)";
            this.rbnarin1dk.UseVisualStyleBackColor = false;
            // 
            // lbldurum
            // 
            this.lbldurum.AutoSize = true;
            this.lbldurum.BackColor = System.Drawing.Color.Black;
            this.lbldurum.ForeColor = System.Drawing.Color.Red;
            this.lbldurum.Location = new System.Drawing.Point(445, 82);
            this.lbldurum.Name = "lbldurum";
            this.lbldurum.Size = new System.Drawing.Size(19, 13);
            this.lbldurum.TabIndex = 10;
            this.lbldurum.Text = "__";
            // 
            // lblzaman
            // 
            this.lblzaman.AutoSize = true;
            this.lblzaman.BackColor = System.Drawing.Color.Black;
            this.lblzaman.ForeColor = System.Drawing.Color.Red;
            this.lblzaman.Location = new System.Drawing.Point(445, 69);
            this.lblzaman.Name = "lblzaman";
            this.lblzaman.Size = new System.Drawing.Size(19, 13);
            this.lblzaman.TabIndex = 11;
            this.lblzaman.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(665, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Program Seçim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(665, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Program Durumu";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(617, 606);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblzaman);
            this.Controls.Add(this.lbldurum);
            this.Controls.Add(this.rbnarin1dk);
            this.Controls.Add(this.rbrenk2dk);
            this.Controls.Add(this.rbeyaz3dk);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkekstra);
            this.Controls.Add(this.chksu);
            this.Controls.Add(this.chkçmşr);
            this.Controls.Add(this.chkelktr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkelktr;
        private System.Windows.Forms.CheckBox chkçmşr;
        private System.Windows.Forms.CheckBox chksu;
        private System.Windows.Forms.CheckBox chkekstra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton rbeyaz3dk;
        private System.Windows.Forms.RadioButton rbrenk2dk;
        private System.Windows.Forms.RadioButton rbnarin1dk;
        private System.Windows.Forms.Label lbldurum;
        private System.Windows.Forms.Label lblzaman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}

