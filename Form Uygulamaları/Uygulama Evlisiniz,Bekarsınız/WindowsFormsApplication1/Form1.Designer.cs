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
            this.evli = new System.Windows.Forms.RadioButton();
            this.lbldurum = new System.Windows.Forms.Label();
            this.bekar = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // evli
            // 
            this.evli.AutoSize = true;
            this.evli.Location = new System.Drawing.Point(35, 119);
            this.evli.Name = "evli";
            this.evli.Size = new System.Drawing.Size(41, 17);
            this.evli.TabIndex = 0;
            this.evli.Text = "evli";
            this.evli.UseVisualStyleBackColor = true;
            this.evli.CheckedChanged += new System.EventHandler(this.evli_CheckedChanged);
            this.evli.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // lbldurum
            // 
            this.lbldurum.AutoSize = true;
            this.lbldurum.Location = new System.Drawing.Point(154, 92);
            this.lbldurum.Name = "lbldurum";
            this.lbldurum.Size = new System.Drawing.Size(35, 13);
            this.lbldurum.TabIndex = 1;
            this.lbldurum.Text = "label1";
            this.lbldurum.Click += new System.EventHandler(this.label1_Click);
            // 
            // bekar
            // 
            this.bekar.AutoSize = true;
            this.bekar.Location = new System.Drawing.Point(35, 75);
            this.bekar.Name = "bekar";
            this.bekar.Size = new System.Drawing.Size(52, 17);
            this.bekar.TabIndex = 2;
            this.bekar.Text = "bekar";
            this.bekar.UseVisualStyleBackColor = true;
            this.bekar.CheckedChanged += new System.EventHandler(this.bekar_CheckedChanged);
            this.bekar.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bekar);
            this.Controls.Add(this.lbldurum);
            this.Controls.Add(this.evli);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton evli;
        private System.Windows.Forms.Label lbldurum;
        private System.Windows.Forms.RadioButton bekar;
    }
}

