namespace Wordle
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
            this.algoritmusosBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // algoritmusosBtn
            // 
            this.algoritmusosBtn.BackColor = System.Drawing.Color.LightCoral;
            this.algoritmusosBtn.Font = new System.Drawing.Font("Old English Text MT", 20F, System.Drawing.FontStyle.Bold);
            this.algoritmusosBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.algoritmusosBtn.Location = new System.Drawing.Point(25, 38);
            this.algoritmusosBtn.Name = "algoritmusosBtn";
            this.algoritmusosBtn.Size = new System.Drawing.Size(208, 161);
            this.algoritmusosBtn.TabIndex = 0;
            this.algoritmusosBtn.Text = "Megoldás algoritmussal";
            this.algoritmusosBtn.UseVisualStyleBackColor = false;
            this.algoritmusosBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(269, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 161);
            this.button2.TabIndex = 1;
            this.button2.Text = "Önálló megoldás";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(188, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kilépés";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(507, 275);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.algoritmusosBtn);
            this.Name = "Form1";
            this.Text = "Word ladder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button algoritmusosBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

