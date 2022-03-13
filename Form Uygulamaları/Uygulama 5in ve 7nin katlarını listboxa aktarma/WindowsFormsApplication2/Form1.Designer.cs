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
            this.l1 = new System.Windows.Forms.ListBox();
            this.l2 = new System.Windows.Forms.ListBox();
            this.btnaktar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.FormattingEnabled = true;
            this.l1.Location = new System.Drawing.Point(30, 68);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(120, 95);
            this.l1.TabIndex = 0;
            // 
            // l2
            // 
            this.l2.FormattingEnabled = true;
            this.l2.Location = new System.Drawing.Point(180, 68);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(120, 95);
            this.l2.TabIndex = 1;
            // 
            // btnaktar
            // 
            this.btnaktar.Location = new System.Drawing.Point(130, 207);
            this.btnaktar.Name = "btnaktar";
            this.btnaktar.Size = new System.Drawing.Size(75, 23);
            this.btnaktar.TabIndex = 2;
            this.btnaktar.Text = "AKTAR";
            this.btnaktar.UseVisualStyleBackColor = true;
            this.btnaktar.Click += new System.EventHandler(this.btnaktar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "BUTONA TIKLAYINCA 0-100 ARASINDAKİ SAYILARDAN 5İN KATLARINI L1 E \r\n7NİN KATLARINI" +
    " L2 YE AKTARIN.\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 376);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnaktar);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox l1;
        private System.Windows.Forms.ListBox l2;
        private System.Windows.Forms.Button btnaktar;
        private System.Windows.Forms.Label label1;
    }
}

