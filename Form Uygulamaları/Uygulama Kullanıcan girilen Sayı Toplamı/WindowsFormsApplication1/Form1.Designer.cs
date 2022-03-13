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
            this.label1 = new System.Windows.Forms.Label();
            this.txts1 = new System.Windows.Forms.TextBox();
            this.txts2 = new System.Windows.Forms.TextBox();
            this.btntoplam = new System.Windows.Forms.Button();
            this.lbltoplam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KULLANICIDAN ALINAN 2 SAYININ TOPLAMINI BULAN PROGRAM";
            // 
            // txts1
            // 
            this.txts1.Location = new System.Drawing.Point(75, 85);
            this.txts1.Name = "txts1";
            this.txts1.Size = new System.Drawing.Size(100, 20);
            this.txts1.TabIndex = 3;
            // 
            // txts2
            // 
            this.txts2.Location = new System.Drawing.Point(75, 128);
            this.txts2.Name = "txts2";
            this.txts2.Size = new System.Drawing.Size(100, 20);
            this.txts2.TabIndex = 4;
            // 
            // btntoplam
            // 
            this.btntoplam.Location = new System.Drawing.Point(217, 88);
            this.btntoplam.Name = "btntoplam";
            this.btntoplam.Size = new System.Drawing.Size(103, 23);
            this.btntoplam.TabIndex = 5;
            this.btntoplam.Text = "Sayıları Topla";
            this.btntoplam.UseVisualStyleBackColor = true;
            this.btntoplam.Click += new System.EventHandler(this.btntoplam_Click);
            // 
            // lbltoplam
            // 
            this.lbltoplam.AutoSize = true;
            this.lbltoplam.Location = new System.Drawing.Point(224, 135);
            this.lbltoplam.Name = "lbltoplam";
            this.lbltoplam.Size = new System.Drawing.Size(35, 13);
            this.lbltoplam.TabIndex = 6;
            this.lbltoplam.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "1.SAYI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "2.SAYI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 328);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltoplam);
            this.Controls.Add(this.btntoplam);
            this.Controls.Add(this.txts2);
            this.Controls.Add(this.txts1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txts1;
        private System.Windows.Forms.TextBox txts2;
        private System.Windows.Forms.Button btntoplam;
        private System.Windows.Forms.Label lbltoplam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

