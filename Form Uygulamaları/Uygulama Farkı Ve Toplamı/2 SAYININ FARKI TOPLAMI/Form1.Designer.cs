namespace _2_SAYININ_FARKI_TOPLAMI
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
            this.btnişlem = new System.Windows.Forms.Button();
            this.txts2 = new System.Windows.Forms.TextBox();
            this.txts1 = new System.Windows.Forms.TextBox();
            this.rbtoplam = new System.Windows.Forms.RadioButton();
            this.rbfark = new System.Windows.Forms.RadioButton();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnişlem
            // 
            this.btnişlem.Location = new System.Drawing.Point(71, 152);
            this.btnişlem.Name = "btnişlem";
            this.btnişlem.Size = new System.Drawing.Size(75, 23);
            this.btnişlem.TabIndex = 0;
            this.btnişlem.Text = "İŞLEM YAP";
            this.btnişlem.UseVisualStyleBackColor = true;
            this.btnişlem.Click += new System.EventHandler(this.btnişlem_Click);
            // 
            // txts2
            // 
            this.txts2.Location = new System.Drawing.Point(71, 97);
            this.txts2.Name = "txts2";
            this.txts2.Size = new System.Drawing.Size(100, 20);
            this.txts2.TabIndex = 1;
            // 
            // txts1
            // 
            this.txts1.Location = new System.Drawing.Point(71, 62);
            this.txts1.Name = "txts1";
            this.txts1.Size = new System.Drawing.Size(100, 20);
            this.txts1.TabIndex = 2;
            // 
            // rbtoplam
            // 
            this.rbtoplam.AutoSize = true;
            this.rbtoplam.Location = new System.Drawing.Point(191, 62);
            this.rbtoplam.Name = "rbtoplam";
            this.rbtoplam.Size = new System.Drawing.Size(111, 17);
            this.rbtoplam.TabIndex = 3;
            this.rbtoplam.TabStop = true;
            this.rbtoplam.Text = "SAYILARI TOPLA";
            this.rbtoplam.UseVisualStyleBackColor = true;
            // 
            // rbfark
            // 
            this.rbfark.AutoSize = true;
            this.rbfark.Location = new System.Drawing.Point(191, 98);
            this.rbfark.Name = "rbfark";
            this.rbfark.Size = new System.Drawing.Size(69, 17);
            this.rbfark.TabIndex = 4;
            this.rbfark.TabStop = true;
            this.rbfark.Text = "FARK AL";
            this.rbfark.UseVisualStyleBackColor = true;
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(188, 162);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(45, 13);
            this.lblsonuc.TabIndex = 5;
            this.lblsonuc.Text = "SONUC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "SAYI 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "SAYI 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 297);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.rbfark);
            this.Controls.Add(this.rbtoplam);
            this.Controls.Add(this.txts1);
            this.Controls.Add(this.txts2);
            this.Controls.Add(this.btnişlem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnişlem;
        private System.Windows.Forms.TextBox txts2;
        private System.Windows.Forms.TextBox txts1;
        private System.Windows.Forms.RadioButton rbtoplam;
        private System.Windows.Forms.RadioButton rbfark;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

