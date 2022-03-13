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
            this.label2 = new System.Windows.Forms.Label();
            this.txts1 = new System.Windows.Forms.TextBox();
            this.btnsonuc = new System.Windows.Forms.Button();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TEXTBOXA GİRİLEN SAYI TEKSE LABELDE TEK ÇİFTSE ÇİFT YAZDIRIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sayı";
            // 
            // txts1
            // 
            this.txts1.Location = new System.Drawing.Point(78, 86);
            this.txts1.Name = "txts1";
            this.txts1.Size = new System.Drawing.Size(100, 20);
            this.txts1.TabIndex = 2;
            // 
            // btnsonuc
            // 
            this.btnsonuc.Location = new System.Drawing.Point(90, 137);
            this.btnsonuc.Name = "btnsonuc";
            this.btnsonuc.Size = new System.Drawing.Size(75, 23);
            this.btnsonuc.TabIndex = 3;
            this.btnsonuc.Text = "Tekmi Çiftmi";
            this.btnsonuc.UseVisualStyleBackColor = true;
            this.btnsonuc.Click += new System.EventHandler(this.btnsonuc_Click);
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(222, 142);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(45, 13);
            this.lblsonuc.TabIndex = 4;
            this.lblsonuc.Text = "SONUC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 198);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.btnsonuc);
            this.Controls.Add(this.txts1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txts1;
        private System.Windows.Forms.Button btnsonuc;
        private System.Windows.Forms.Label lblsonuc;
    }
}

