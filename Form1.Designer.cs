namespace Git_prac
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
            this.btnJean = new System.Windows.Forms.Button();
            this.btnCharlMax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJean
            // 
            this.btnJean.Location = new System.Drawing.Point(33, 32);
            this.btnJean.Name = "btnJean";
            this.btnJean.Size = new System.Drawing.Size(75, 23);
            this.btnJean.TabIndex = 0;
            this.btnJean.Text = "Jéan";
            this.btnJean.UseVisualStyleBackColor = true;
            this.btnJean.Click += new System.EventHandler(this.btnJean_Click);
            // 
            // btnCharlMax
            // 
            this.btnCharlMax.Location = new System.Drawing.Point(316, 293);
            this.btnCharlMax.Name = "btnCharlMax";
            this.btnCharlMax.Size = new System.Drawing.Size(75, 23);
            this.btnCharlMax.TabIndex = 1;
            this.btnCharlMax.Text = "Charl";
            this.btnCharlMax.UseVisualStyleBackColor = true;
            this.btnCharlMax.Click += new System.EventHandler(this.btnCharlMax_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 338);
            this.Controls.Add(this.btnCharlMax);
            this.Controls.Add(this.btnJean);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJean;
        private System.Windows.Forms.Button btnCharlMax;
    }
}

