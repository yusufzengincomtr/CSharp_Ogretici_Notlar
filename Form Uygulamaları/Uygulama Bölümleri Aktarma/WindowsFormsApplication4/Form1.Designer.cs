namespace WindowsFormsApplication4
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
            this.btnaktar = new System.Windows.Forms.Button();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.muhasebe = new System.Windows.Forms.RadioButton();
            this.adalet = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ulastırma = new System.Windows.Forms.RadioButton();
            this.bilisim = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnaktar
            // 
            this.btnaktar.Location = new System.Drawing.Point(164, 142);
            this.btnaktar.Name = "btnaktar";
            this.btnaktar.Size = new System.Drawing.Size(75, 23);
            this.btnaktar.TabIndex = 14;
            this.btnaktar.Text = "AKTAR";
            this.btnaktar.UseVisualStyleBackColor = true;
            this.btnaktar.Click += new System.EventHandler(this.btnaktar_Click);
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(286, 147);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(35, 13);
            this.lblsonuc.TabIndex = 13;
            this.lblsonuc.Text = "label2";
            // 
            // muhasebe
            // 
            this.muhasebe.AutoSize = true;
            this.muhasebe.Location = new System.Drawing.Point(39, 210);
            this.muhasebe.Name = "muhasebe";
            this.muhasebe.Size = new System.Drawing.Size(85, 17);
            this.muhasebe.TabIndex = 12;
            this.muhasebe.TabStop = true;
            this.muhasebe.Text = "MUHASEBE";
            this.muhasebe.UseVisualStyleBackColor = true;
            // 
            // adalet
            // 
            this.adalet.AutoSize = true;
            this.adalet.Location = new System.Drawing.Point(39, 167);
            this.adalet.Name = "adalet";
            this.adalet.Size = new System.Drawing.Size(67, 17);
            this.adalet.TabIndex = 11;
            this.adalet.TabStop = true;
            this.adalet.Text = "ADALET";
            this.adalet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(79, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Seçili Radyo butonunu textini Aktar";
            // 
            // ulastırma
            // 
            this.ulastırma.AutoSize = true;
            this.ulastırma.Location = new System.Drawing.Point(39, 123);
            this.ulastırma.Name = "ulastırma";
            this.ulastırma.Size = new System.Drawing.Size(87, 17);
            this.ulastırma.TabIndex = 9;
            this.ulastırma.TabStop = true;
            this.ulastırma.Text = "ULAŞTIRMA";
            this.ulastırma.UseVisualStyleBackColor = true;
            // 
            // bilisim
            // 
            this.bilisim.AutoSize = true;
            this.bilisim.Location = new System.Drawing.Point(39, 81);
            this.bilisim.Name = "bilisim";
            this.bilisim.Size = new System.Drawing.Size(63, 17);
            this.bilisim.TabIndex = 8;
            this.bilisim.TabStop = true;
            this.bilisim.Text = "BİLİŞİM";
            this.bilisim.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 373);
            this.Controls.Add(this.btnaktar);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.muhasebe);
            this.Controls.Add(this.adalet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ulastırma);
            this.Controls.Add(this.bilisim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaktar;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.RadioButton muhasebe;
        private System.Windows.Forms.RadioButton adalet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton ulastırma;
        private System.Windows.Forms.RadioButton bilisim;
    }
}

