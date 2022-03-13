namespace WindowsFormsApplication3
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
            this.btnekle = new System.Windows.Forms.Button();
            this.btnaktar = new System.Windows.Forms.Button();
            this.l1 = new System.Windows.Forms.ListBox();
            this.l2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(159, 60);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 1;
            this.btnekle.Text = "ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnaktar
            // 
            this.btnaktar.Location = new System.Drawing.Point(159, 147);
            this.btnaktar.Name = "btnaktar";
            this.btnaktar.Size = new System.Drawing.Size(75, 23);
            this.btnaktar.TabIndex = 2;
            this.btnaktar.Text = ">>";
            this.btnaktar.UseVisualStyleBackColor = true;
            this.btnaktar.Click += new System.EventHandler(this.btnaktar_Click);
            // 
            // l1
            // 
            this.l1.FormattingEnabled = true;
            this.l1.Location = new System.Drawing.Point(33, 129);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(120, 95);
            this.l1.TabIndex = 3;
//            this.l1.SelectedIndexChanged += new System.EventHandler(this.l1_SelectedIndexChanged);
            // 
            // l2
            // 
            this.l2.FormattingEnabled = true;
            this.l2.Location = new System.Drawing.Point(240, 129);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(120, 95);
            this.l2.TabIndex = 4;
          //  this.l2.SelectedIndexChanged += new System.EventHandler(this.l2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 325);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.btnaktar);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnaktar;
        private System.Windows.Forms.ListBox l1;
        private System.Windows.Forms.ListBox l2;
    }
}

