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
            this.listeSehirler = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listeSehirler
            // 
            this.listeSehirler.FormattingEnabled = true;
            this.listeSehirler.Items.AddRange(new object[] {
            "IĞDIR",
            "ORDU",
            "İSTANBUL"});
            this.listeSehirler.Location = new System.Drawing.Point(28, 48);
            this.listeSehirler.Name = "listeSehirler";
            this.listeSehirler.Size = new System.Drawing.Size(121, 21);
            this.listeSehirler.TabIndex = 0;
            this.listeSehirler.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.listeSehirler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox listeSehirler;
    }
}

