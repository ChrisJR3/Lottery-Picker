namespace Lottery_Picker
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
            this.lotteryLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLabel = new System.Windows.Forms.Label();
            this.winningNumberLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lotteryLabel
            // 
            this.lotteryLabel.BackColor = System.Drawing.Color.Red;
            this.lotteryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lotteryLabel.ForeColor = System.Drawing.Color.White;
            this.lotteryLabel.Location = new System.Drawing.Point(0, 0);
            this.lotteryLabel.Name = "lotteryLabel";
            this.lotteryLabel.Size = new System.Drawing.Size(671, 89);
            this.lotteryLabel.TabIndex = 0;
            this.lotteryLabel.Text = "Rams Lottery Number Generator";
            this.lotteryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(171, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 53);
            this.label2.TabIndex = 1;
            this.label2.Text = "Press the button below to generate your winning 6/49 numbers!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLabel
            // 
            this.labelLabel.AutoSize = true;
            this.labelLabel.BackColor = System.Drawing.Color.White;
            this.labelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelLabel.Location = new System.Drawing.Point(223, 319);
            this.labelLabel.Name = "labelLabel";
            this.labelLabel.Size = new System.Drawing.Size(213, 24);
            this.labelLabel.TabIndex = 2;
            this.labelLabel.Text = "Your Winning Numbers:";
            // 
            // winningNumberLabel
            // 
            this.winningNumberLabel.BackColor = System.Drawing.Color.White;
            this.winningNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winningNumberLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.winningNumberLabel.Location = new System.Drawing.Point(223, 343);
            this.winningNumberLabel.Name = "winningNumberLabel";
            this.winningNumberLabel.Size = new System.Drawing.Size(213, 24);
            this.winningNumberLabel.TabIndex = 3;
            this.winningNumberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.ForeColor = System.Drawing.Color.White;
            this.generateButton.Location = new System.Drawing.Point(273, 251);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(96, 32);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.winningNumberLabel);
            this.Controls.Add(this.labelLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lotteryLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lotteryLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLabel;
        private System.Windows.Forms.Label winningNumberLabel;
        private System.Windows.Forms.Button generateButton;
    }
}

