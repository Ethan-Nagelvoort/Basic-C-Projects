namespace project2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Guessb = new System.Windows.Forms.Button();
            this.exitb = new System.Windows.Forms.Button();
            this.newGameb = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(822, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guess the word";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(807, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 1;
            // 
            // Guessb
            // 
            this.Guessb.Location = new System.Drawing.Point(822, 151);
            this.Guessb.Name = "Guessb";
            this.Guessb.Size = new System.Drawing.Size(112, 34);
            this.Guessb.TabIndex = 2;
            this.Guessb.Text = "Guess";
            this.Guessb.UseVisualStyleBackColor = true;
            this.Guessb.Click += new System.EventHandler(this.Guessb_Click);
            // 
            // exitb
            // 
            this.exitb.Location = new System.Drawing.Point(928, 218);
            this.exitb.Name = "exitb";
            this.exitb.Size = new System.Drawing.Size(112, 34);
            this.exitb.TabIndex = 3;
            this.exitb.Text = "Exit";
            this.exitb.UseVisualStyleBackColor = true;
            this.exitb.Click += new System.EventHandler(this.exitb_Click);
            // 
            // newGameb
            // 
            this.newGameb.Location = new System.Drawing.Point(736, 218);
            this.newGameb.Name = "newGameb";
            this.newGameb.Size = new System.Drawing.Size(112, 34);
            this.newGameb.TabIndex = 4;
            this.newGameb.Text = "New Game";
            this.newGameb.UseVisualStyleBackColor = true;
            this.newGameb.Click += new System.EventHandler(this.newGameb_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 348);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(522, 31);
            this.textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.newGameb);
            this.Controls.Add(this.exitb);
            this.Controls.Add(this.Guessb);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Guessb;
        private System.Windows.Forms.Button exitb;
        private System.Windows.Forms.Button newGameb;
        private System.Windows.Forms.TextBox textBox2;
    }
}

