namespace READ_IT_LOUD
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Browsebutton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.readbutton = new System.Windows.Forms.Button();
            this.pausebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Browse to FILE";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Browsebutton
            // 
            this.Browsebutton.Location = new System.Drawing.Point(95, 123);
            this.Browsebutton.Name = "Browsebutton";
            this.Browsebutton.Size = new System.Drawing.Size(96, 23);
            this.Browsebutton.TabIndex = 2;
            this.Browsebutton.Text = "Browse";
            this.Browsebutton.UseVisualStyleBackColor = true;
            this.Browsebutton.Click += new System.EventHandler(this.Browsebutton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // readbutton
            // 
            this.readbutton.Location = new System.Drawing.Point(81, 173);
            this.readbutton.Name = "readbutton";
            this.readbutton.Size = new System.Drawing.Size(110, 23);
            this.readbutton.TabIndex = 3;
            this.readbutton.Text = "READ IT BRO";
            this.readbutton.UseVisualStyleBackColor = true;
            this.readbutton.Click += new System.EventHandler(this.readbutton_Click);
            // 
            // pausebutton
            // 
            this.pausebutton.Location = new System.Drawing.Point(95, 202);
            this.pausebutton.Name = "pausebutton";
            this.pausebutton.Size = new System.Drawing.Size(75, 23);
            this.pausebutton.TabIndex = 4;
            this.pausebutton.Text = "pause";
            this.pausebutton.UseVisualStyleBackColor = true;
            this.pausebutton.Click += new System.EventHandler(this.pausebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CancelButton = this.Browsebutton;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pausebutton);
            this.Controls.Add(this.readbutton);
            this.Controls.Add(this.Browsebutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "LET ME READ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Browsebutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button readbutton;
        private System.Windows.Forms.Button pausebutton;
    }
}

