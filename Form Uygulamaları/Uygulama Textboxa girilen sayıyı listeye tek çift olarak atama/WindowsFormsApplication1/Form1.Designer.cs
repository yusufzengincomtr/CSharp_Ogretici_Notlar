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
            this.liste = new System.Windows.Forms.ListBox();
            this.txts1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnaktar = new System.Windows.Forms.Button();
            this.liste2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // liste
            // 
            this.liste.FormattingEnabled = true;
            this.liste.Location = new System.Drawing.Point(293, 60);
            this.liste.Name = "liste";
            this.liste.Size = new System.Drawing.Size(120, 95);
            this.liste.TabIndex = 0;
            // 
            // txts1
            // 
            this.txts1.Location = new System.Drawing.Point(16, 60);
            this.txts1.Name = "txts1";
            this.txts1.Size = new System.Drawing.Size(100, 20);
            this.txts1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TEXTBOX A GİRİLEN SAYILARI LİSTBOXA AKTARAN PROGRAM";
            // 
            // btnaktar
            // 
            this.btnaktar.Location = new System.Drawing.Point(146, 60);
            this.btnaktar.Name = "btnaktar";
            this.btnaktar.Size = new System.Drawing.Size(92, 26);
            this.btnaktar.TabIndex = 3;
            this.btnaktar.Text = "aktar";
            this.btnaktar.UseVisualStyleBackColor = true;
            this.btnaktar.Click += new System.EventHandler(this.btnaktar_Click);
            // 
            // liste2
            // 
            this.liste2.FormattingEnabled = true;
            this.liste2.Location = new System.Drawing.Point(536, 60);
            this.liste2.Name = "liste2";
            this.liste2.Size = new System.Drawing.Size(120, 95);
            this.liste2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 343);
            this.Controls.Add(this.liste2);
            this.Controls.Add(this.btnaktar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txts1);
            this.Controls.Add(this.liste);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox liste;
        private System.Windows.Forms.TextBox txts1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaktar;
        private System.Windows.Forms.ListBox liste2;
    }
}

