namespace Hill_Cipher
{
    partial class MainProgram
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
            this.Word = new System.Windows.Forms.TextBox();
            this.WordLabel = new System.Windows.Forms.Label();
            this.ResultLabel_Upper = new System.Windows.Forms.Label();
            this.Result_Upper = new System.Windows.Forms.Label();
            this.Result_Lower = new System.Windows.Forms.Label();
            this.ResultLabel_Lower = new System.Windows.Forms.Label();
            this.Result_Dualcase = new System.Windows.Forms.Label();
            this.ResultLabel_Dualcase = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultLabel_All = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Word
            // 
            this.Word.Location = new System.Drawing.Point(12, 30);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(280, 23);
            this.Word.TabIndex = 0;
            this.Word.TextChanged += new System.EventHandler(this.submit_Click);
            // 
            // WordLabel
            // 
            this.WordLabel.AutoSize = true;
            this.WordLabel.Location = new System.Drawing.Point(12, 12);
            this.WordLabel.Name = "WordLabel";
            this.WordLabel.Size = new System.Drawing.Size(113, 15);
            this.WordLabel.TabIndex = 1;
            this.WordLabel.Text = "Your word/sentence";
            // 
            // ResultLabel_Upper
            // 
            this.ResultLabel_Upper.AutoSize = true;
            this.ResultLabel_Upper.Location = new System.Drawing.Point(12, 100);
            this.ResultLabel_Upper.Name = "ResultLabel_Upper";
            this.ResultLabel_Upper.Size = new System.Drawing.Size(104, 15);
            this.ResultLabel_Upper.TabIndex = 2;
            this.ResultLabel_Upper.Text = "Result (uppercase)";
            // 
            // Result_Upper
            // 
            this.Result_Upper.AutoSize = true;
            this.Result_Upper.Location = new System.Drawing.Point(12, 115);
            this.Result_Upper.Name = "Result_Upper";
            this.Result_Upper.Size = new System.Drawing.Size(16, 15);
            this.Result_Upper.TabIndex = 3;
            this.Result_Upper.Text = "...";
            // 
            // Result_Lower
            // 
            this.Result_Lower.AutoSize = true;
            this.Result_Lower.Location = new System.Drawing.Point(12, 165);
            this.Result_Lower.Name = "Result_Lower";
            this.Result_Lower.Size = new System.Drawing.Size(16, 15);
            this.Result_Lower.TabIndex = 5;
            this.Result_Lower.Text = "...";
            // 
            // ResultLabel_Lower
            // 
            this.ResultLabel_Lower.AutoSize = true;
            this.ResultLabel_Lower.Location = new System.Drawing.Point(12, 150);
            this.ResultLabel_Lower.Name = "ResultLabel_Lower";
            this.ResultLabel_Lower.Size = new System.Drawing.Size(102, 15);
            this.ResultLabel_Lower.TabIndex = 4;
            this.ResultLabel_Lower.Text = "Result (lowercase)";
            // 
            // Result_Dualcase
            // 
            this.Result_Dualcase.AutoSize = true;
            this.Result_Dualcase.Location = new System.Drawing.Point(12, 215);
            this.Result_Dualcase.Name = "Result_Dualcase";
            this.Result_Dualcase.Size = new System.Drawing.Size(16, 15);
            this.Result_Dualcase.TabIndex = 7;
            this.Result_Dualcase.Text = "...";
            // 
            // ResultLabel_Dualcase
            // 
            this.ResultLabel_Dualcase.AutoSize = true;
            this.ResultLabel_Dualcase.Location = new System.Drawing.Point(12, 200);
            this.ResultLabel_Dualcase.Name = "ResultLabel_Dualcase";
            this.ResultLabel_Dualcase.Size = new System.Drawing.Size(96, 15);
            this.ResultLabel_Dualcase.TabIndex = 6;
            this.ResultLabel_Dualcase.Text = "Result (dualcase)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "...";
            // 
            // ResultLabel_All
            // 
            this.ResultLabel_All.AutoSize = true;
            this.ResultLabel_All.Location = new System.Drawing.Point(12, 250);
            this.ResultLabel_All.Name = "ResultLabel_All";
            this.ResultLabel_All.Size = new System.Drawing.Size(174, 15);
            this.ResultLabel_All.TabIndex = 9;
            this.ResultLabel_All.Text = "Result (characters and symbols)";
            // 
            // MainProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultLabel_All);
            this.Controls.Add(this.Result_Dualcase);
            this.Controls.Add(this.ResultLabel_Dualcase);
            this.Controls.Add(this.Result_Lower);
            this.Controls.Add(this.ResultLabel_Lower);
            this.Controls.Add(this.Result_Upper);
            this.Controls.Add(this.ResultLabel_Upper);
            this.Controls.Add(this.WordLabel);
            this.Controls.Add(this.Word);
            this.MinimumSize = new System.Drawing.Size(480, 360);
            this.Name = "MainProgram";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Word;
        private System.Windows.Forms.Label WordLabel;
        private System.Windows.Forms.Label ResultLabel_Upper;
        private System.Windows.Forms.Label Result_Upper;
        private System.Windows.Forms.Label Result_Lower;
        private System.Windows.Forms.Label ResultLabel_Lower;
        private System.Windows.Forms.Label Result_Dualcase;
        private System.Windows.Forms.Label ResultLabel_Dualcase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ResultLabel_All;
    }
}
