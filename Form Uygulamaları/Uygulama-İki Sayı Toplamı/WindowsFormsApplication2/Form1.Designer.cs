namespace WindowsFormsApplication2
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
            this.btntop = new System.Windows.Forms.Button();
            this.txts2 = new System.Windows.Forms.TextBox();
            this.txts1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.lblsonucc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btntop
            // 
            this.btntop.Location = new System.Drawing.Point(70, 117);
            this.btntop.Name = "btntop";
            this.btntop.Size = new System.Drawing.Size(75, 23);
            this.btntop.TabIndex = 0;
            this.btntop.Text = "TOPLA";
            this.btntop.UseVisualStyleBackColor = true;
            this.btntop.Click += new System.EventHandler(this.button1_Click);
            // 
            // txts2
            // 
            this.txts2.Location = new System.Drawing.Point(60, 79);
            this.txts2.Name = "txts2";
            this.txts2.Size = new System.Drawing.Size(100, 20);
            this.txts2.TabIndex = 1;
            // 
            // txts1
            // 
            this.txts1.Location = new System.Drawing.Point(60, 36);
            this.txts1.Name = "txts1";
            this.txts1.Size = new System.Drawing.Size(100, 20);
            this.txts1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sayı 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sayı 2:";
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(91, 178);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(0, 13);
            this.lblsonuc.TabIndex = 5;
            // 
            // lblsonucc
            // 
            this.lblsonucc.AutoSize = true;
            this.lblsonucc.Location = new System.Drawing.Point(82, 178);
            this.lblsonucc.Name = "lblsonucc";
            this.lblsonucc.Size = new System.Drawing.Size(36, 13);
            this.lblsonucc.TabIndex = 6;
            this.lblsonucc.Text = "sonuc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblsonucc);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txts1);
            this.Controls.Add(this.txts2);
            this.Controls.Add(this.btntop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntop;
        private System.Windows.Forms.TextBox txts2;
        private System.Windows.Forms.TextBox txts1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label lblsonucc;
    }
}

