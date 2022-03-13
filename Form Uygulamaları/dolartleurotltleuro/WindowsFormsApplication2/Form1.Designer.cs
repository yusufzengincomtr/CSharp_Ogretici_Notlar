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
            this.b = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.rbtldolar = new System.Windows.Forms.RadioButton();
            this.rbdolartl = new System.Windows.Forms.RadioButton();
            this.rbtleuro = new System.Windows.Forms.RadioButton();
            this.rbeurotl = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttutar = new System.Windows.Forms.TextBox();
            this.btncevir = new System.Windows.Forms.Button();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.b.Location = new System.Drawing.Point(51, 23);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(88, 26);
            this.b.TabIndex = 0;
            this.b.Text = "DOLAR";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.a.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.a.Location = new System.Drawing.Point(184, 23);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(76, 26);
            this.a.TabIndex = 1;
            this.a.Text = "EURO";
            this.a.Click += new System.EventHandler(this.label2_Click);
            // 
            // rbtldolar
            // 
            this.rbtldolar.AutoSize = true;
            this.rbtldolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtldolar.Location = new System.Drawing.Point(356, 69);
            this.rbtldolar.Name = "rbtldolar";
            this.rbtldolar.Size = new System.Drawing.Size(106, 24);
            this.rbtldolar.TabIndex = 4;
            this.rbtldolar.TabStop = true;
            this.rbtldolar.Text = "TL-DOLAR";
            this.rbtldolar.UseVisualStyleBackColor = true;
            // 
            // rbdolartl
            // 
            this.rbdolartl.AutoSize = true;
            this.rbdolartl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbdolartl.Location = new System.Drawing.Point(356, 106);
            this.rbdolartl.Name = "rbdolartl";
            this.rbdolartl.Size = new System.Drawing.Size(106, 24);
            this.rbdolartl.TabIndex = 5;
            this.rbdolartl.TabStop = true;
            this.rbdolartl.Text = "DOLAR-TL";
            this.rbdolartl.UseVisualStyleBackColor = true;
            // 
            // rbtleuro
            // 
            this.rbtleuro.AutoSize = true;
            this.rbtleuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtleuro.Location = new System.Drawing.Point(356, 140);
            this.rbtleuro.Name = "rbtleuro";
            this.rbtleuro.Size = new System.Drawing.Size(97, 24);
            this.rbtleuro.TabIndex = 6;
            this.rbtleuro.TabStop = true;
            this.rbtleuro.Text = "TL-EURO";
            this.rbtleuro.UseVisualStyleBackColor = true;
            this.rbtleuro.CheckedChanged += new System.EventHandler(this.rbeurotl_CheckedChanged);
            // 
            // rbeurotl
            // 
            this.rbeurotl.AutoSize = true;
            this.rbeurotl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbeurotl.Location = new System.Drawing.Point(356, 176);
            this.rbeurotl.Name = "rbeurotl";
            this.rbeurotl.Size = new System.Drawing.Size(97, 24);
            this.rbeurotl.TabIndex = 7;
            this.rbeurotl.TabStop = true;
            this.rbeurotl.Text = "EURO-TL";
            this.rbeurotl.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "ALIŞ: 5";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(185, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "ALIŞ: 6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(52, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "TUTAR GİRİNİZ";
            // 
            // txttutar
            // 
            this.txttutar.Location = new System.Drawing.Point(56, 178);
            this.txttutar.Name = "txttutar";
            this.txttutar.Size = new System.Drawing.Size(139, 20);
            this.txttutar.TabIndex = 11;
            this.txttutar.TextChanged += new System.EventHandler(this.txttutar_TextChanged);
            // 
            // btncevir
            // 
            this.btncevir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncevir.Location = new System.Drawing.Point(56, 204);
            this.btncevir.Name = "btncevir";
            this.btncevir.Size = new System.Drawing.Size(139, 30);
            this.btncevir.TabIndex = 12;
            this.btncevir.Text = "ÇEVİR";
            this.btncevir.UseVisualStyleBackColor = true;
            this.btncevir.Click += new System.EventHandler(this.btncevir_Click);
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsonuc.Location = new System.Drawing.Point(365, 210);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(77, 24);
            this.lblsonuc.TabIndex = 13;
            this.lblsonuc.Text = "SONUÇ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(53, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "SATIŞ: 6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(186, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "SATIŞ: 7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 269);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.btncevir);
            this.Controls.Add(this.txttutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbeurotl);
            this.Controls.Add(this.rbtleuro);
            this.Controls.Add(this.rbdolartl);
            this.Controls.Add(this.rbtldolar);
            this.Controls.Add(this.a);
            this.Controls.Add(this.b);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.RadioButton rbtldolar;
        private System.Windows.Forms.RadioButton rbdolartl;
        private System.Windows.Forms.RadioButton rbtleuro;
        private System.Windows.Forms.RadioButton rbeurotl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttutar;
        private System.Windows.Forms.Button btncevir;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

