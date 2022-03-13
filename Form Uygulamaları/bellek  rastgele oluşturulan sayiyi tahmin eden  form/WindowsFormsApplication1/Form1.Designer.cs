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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblrast = new System.Windows.Forms.Label();
            this.lblhak = new System.Windows.Forms.Label();
            this.lblgoster = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sayı Gir :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "DENE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblrast
            // 
            this.lblrast.AutoSize = true;
            this.lblrast.Location = new System.Drawing.Point(377, 9);
            this.lblrast.Name = "lblrast";
            this.lblrast.Size = new System.Drawing.Size(91, 13);
            this.lblrast.TabIndex = 4;
            this.lblrast.Text = "RASTGELE SAYI";
            // 
            // lblhak
            // 
            this.lblhak.AutoSize = true;
            this.lblhak.Location = new System.Drawing.Point(326, 103);
            this.lblhak.Name = "lblhak";
            this.lblhak.Size = new System.Drawing.Size(29, 13);
            this.lblhak.TabIndex = 5;
            this.lblhak.Text = "HAK";
            // 
            // lblgoster
            // 
            this.lblgoster.AutoSize = true;
            this.lblgoster.Location = new System.Drawing.Point(326, 143);
            this.lblgoster.Name = "lblgoster";
            this.lblgoster.Size = new System.Drawing.Size(142, 13);
            this.lblgoster.TabIndex = 6;
            this.lblgoster.Text = "ACIKLAMA YÖNLENDİRME";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 125);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 227);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblgoster);
            this.Controls.Add(this.lblhak);
            this.Controls.Add(this.lblrast);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblrast;
        private System.Windows.Forms.Label lblhak;
        private System.Windows.Forms.Label lblgoster;
        private System.Windows.Forms.Panel panel1;
    }
}

