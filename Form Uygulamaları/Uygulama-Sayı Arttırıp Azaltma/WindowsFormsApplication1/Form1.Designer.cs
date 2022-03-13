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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnart = new System.Windows.Forms.Button();
            this.btnaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnart
            // 
            this.btnart.Location = new System.Drawing.Point(39, 95);
            this.btnart.Name = "btnart";
            this.btnart.Size = new System.Drawing.Size(48, 30);
            this.btnart.TabIndex = 1;
            this.btnart.Text = "Arttır";
            this.btnart.UseVisualStyleBackColor = true;
            this.btnart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnaz
            // 
            this.btnaz.Location = new System.Drawing.Point(103, 95);
            this.btnaz.Name = "btnaz";
            this.btnaz.Size = new System.Drawing.Size(49, 30);
            this.btnaz.TabIndex = 2;
            this.btnaz.Text = "Azalt";
            this.btnaz.UseVisualStyleBackColor = true;
            this.btnaz.Click += new System.EventHandler(this.btnaz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnaz);
            this.Controls.Add(this.btnart);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnart;
        private System.Windows.Forms.Button btnaz;
    }
}

