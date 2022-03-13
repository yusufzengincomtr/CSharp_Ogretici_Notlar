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
            this.chktp = new System.Windows.Forms.CheckBox();
            this.chmzk = new System.Windows.Forms.CheckBox();
            this.lbldurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chktp
            // 
            this.chktp.AutoSize = true;
            this.chktp.Location = new System.Drawing.Point(29, 54);
            this.chktp.Name = "chktp";
            this.chktp.Size = new System.Drawing.Size(49, 17);
            this.chktp.TabIndex = 0;
            this.chktp.Text = "kitap";
            this.chktp.UseVisualStyleBackColor = true;
            this.chktp.CheckedChanged += new System.EventHandler(this.chktp_CheckedChanged);
            // 
            // chmzk
            // 
            this.chmzk.AutoSize = true;
            this.chmzk.Location = new System.Drawing.Point(29, 109);
            this.chmzk.Name = "chmzk";
            this.chmzk.Size = new System.Drawing.Size(54, 17);
            this.chmzk.TabIndex = 1;
            this.chmzk.Text = "Müzik";
            this.chmzk.UseVisualStyleBackColor = true;
            // 
            // lbldurum
            // 
            this.lbldurum.AutoSize = true;
            this.lbldurum.Location = new System.Drawing.Point(152, 109);
            this.lbldurum.Name = "lbldurum";
            this.lbldurum.Size = new System.Drawing.Size(35, 13);
            this.lbldurum.TabIndex = 2;
            this.lbldurum.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbldurum);
            this.Controls.Add(this.chmzk);
            this.Controls.Add(this.chktp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chktp;
        private System.Windows.Forms.CheckBox chmzk;
        private System.Windows.Forms.Label lbldurum;
    }
}

