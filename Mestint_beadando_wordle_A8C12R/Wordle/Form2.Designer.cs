namespace Wordle
{
    partial class Form2
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
            this.trialerrorBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.trialerrorrestartBtn = new System.Windows.Forms.Button();
            this.endresultTxtbox = new System.Windows.Forms.TextBox();
            this.backtrackBtn = new System.Windows.Forms.Button();
            this.depthfirstBtn = new System.Windows.Forms.Button();
            this.breadthfirstBtn = new System.Windows.Forms.Button();
            this.astarBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(250, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(328, 63);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.startTxtbox_TextChanged);
            // 
            // trialerrorBtn
            // 
            this.trialerrorBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trialerrorBtn.Location = new System.Drawing.Point(30, 22);
            this.trialerrorBtn.Name = "trialerrorBtn";
            this.trialerrorBtn.Size = new System.Drawing.Size(137, 39);
            this.trialerrorBtn.TabIndex = 1;
            this.trialerrorBtn.Text = "Trial and Error";
            this.trialerrorBtn.UseVisualStyleBackColor = true;
            this.trialerrorBtn.Click += new System.EventHandler(this.trialerrorBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(250, 237);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(328, 101);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.solvingRichTxt_TextChanged);
            // 
            // trialerrorrestartBtn
            // 
            this.trialerrorrestartBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trialerrorrestartBtn.Location = new System.Drawing.Point(30, 90);
            this.trialerrorrestartBtn.Name = "trialerrorrestartBtn";
            this.trialerrorrestartBtn.Size = new System.Drawing.Size(137, 53);
            this.trialerrorrestartBtn.TabIndex = 3;
            this.trialerrorrestartBtn.Text = "Trial and Error with Restart";
            this.trialerrorrestartBtn.UseVisualStyleBackColor = true;
            this.trialerrorrestartBtn.Click += new System.EventHandler(this.trialerrorrestartBtn_Click);
            // 
            // endresultTxtbox
            // 
            this.endresultTxtbox.Enabled = false;
            this.endresultTxtbox.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endresultTxtbox.Location = new System.Drawing.Point(250, 396);
            this.endresultTxtbox.Name = "endresultTxtbox";
            this.endresultTxtbox.ReadOnly = true;
            this.endresultTxtbox.Size = new System.Drawing.Size(328, 63);
            this.endresultTxtbox.TabIndex = 4;
            this.endresultTxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.endresultTxtbox.TextChanged += new System.EventHandler(this.endresultTxtbox_TextChanged);
            // 
            // backtrackBtn
            // 
            this.backtrackBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backtrackBtn.Location = new System.Drawing.Point(30, 171);
            this.backtrackBtn.Name = "backtrackBtn";
            this.backtrackBtn.Size = new System.Drawing.Size(137, 39);
            this.backtrackBtn.TabIndex = 5;
            this.backtrackBtn.Text = "Backtrack";
            this.backtrackBtn.UseVisualStyleBackColor = true;
            this.backtrackBtn.Click += new System.EventHandler(this.backtrackBtn_Click);
            // 
            // depthfirstBtn
            // 
            this.depthfirstBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthfirstBtn.Location = new System.Drawing.Point(30, 237);
            this.depthfirstBtn.Name = "depthfirstBtn";
            this.depthfirstBtn.Size = new System.Drawing.Size(137, 39);
            this.depthfirstBtn.TabIndex = 6;
            this.depthfirstBtn.Text = "Depth First";
            this.depthfirstBtn.UseVisualStyleBackColor = true;
            this.depthfirstBtn.Click += new System.EventHandler(this.depthfirstBtn_Click);
            // 
            // breadthfirstBtn
            // 
            this.breadthfirstBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breadthfirstBtn.Location = new System.Drawing.Point(30, 299);
            this.breadthfirstBtn.Name = "breadthfirstBtn";
            this.breadthfirstBtn.Size = new System.Drawing.Size(137, 39);
            this.breadthfirstBtn.TabIndex = 7;
            this.breadthfirstBtn.Text = "Breadth First";
            this.breadthfirstBtn.UseVisualStyleBackColor = true;
            this.breadthfirstBtn.Click += new System.EventHandler(this.breadthfirstBtn_Click);
            // 
            // astarBtn
            // 
            this.astarBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.astarBtn.Location = new System.Drawing.Point(30, 361);
            this.astarBtn.Name = "astarBtn";
            this.astarBtn.Size = new System.Drawing.Size(137, 39);
            this.astarBtn.TabIndex = 8;
            this.astarBtn.Text = "A*";
            this.astarBtn.UseVisualStyleBackColor = true;
            this.astarBtn.Click += new System.EventHandler(this.astarBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(30, 557);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(137, 39);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(30, 499);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(137, 39);
            this.resetBtn.TabIndex = 10;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.resultLabel.Location = new System.Drawing.Point(202, 499);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultLabel.Size = new System.Drawing.Size(15, 22);
            this.resultLabel.TabIndex = 11;
            this.resultLabel.Text = " ";
            this.resultLabel.Click += new System.EventHandler(this.resultLabel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(676, 609);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.astarBtn);
            this.Controls.Add(this.breadthfirstBtn);
            this.Controls.Add(this.depthfirstBtn);
            this.Controls.Add(this.backtrackBtn);
            this.Controls.Add(this.endresultTxtbox);
            this.Controls.Add(this.trialerrorrestartBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.trialerrorBtn);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form2";
            this.Text = "§";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button trialerrorBtn;
        private System.Windows.Forms.Button trialerrorrestartBtn;
        private System.Windows.Forms.Button backtrackBtn;
        private System.Windows.Forms.Button depthfirstBtn;
        private System.Windows.Forms.Button breadthfirstBtn;
        private System.Windows.Forms.Button astarBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label resultLabel;
        internal System.Windows.Forms.TextBox endresultTxtbox;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.RichTextBox richTextBox1;
    }
}