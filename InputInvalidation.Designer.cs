namespace IC6_KS_InvalidInputWithMessageBoxError
{
    partial class InputInvalidationForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exam1TextBox = new System.Windows.Forms.TextBox();
            this.exam2TextBox = new System.Windows.Forms.TextBox();
            this.finalExamTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.examAverageLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.exam1ErrorLabel = new System.Windows.Forms.Label();
            this.exam2ErrorLabel = new System.Windows.Forms.Label();
            this.finalExamErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exam 1 Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exam 2 Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Final Exam Score:";
            // 
            // exam1TextBox
            // 
            this.exam1TextBox.Location = new System.Drawing.Point(382, 72);
            this.exam1TextBox.Name = "exam1TextBox";
            this.exam1TextBox.Size = new System.Drawing.Size(100, 20);
            this.exam1TextBox.TabIndex = 0;
            // 
            // exam2TextBox
            // 
            this.exam2TextBox.Location = new System.Drawing.Point(382, 141);
            this.exam2TextBox.Name = "exam2TextBox";
            this.exam2TextBox.Size = new System.Drawing.Size(100, 20);
            this.exam2TextBox.TabIndex = 1;
            // 
            // finalExamTextBox
            // 
            this.finalExamTextBox.Location = new System.Drawing.Point(382, 207);
            this.finalExamTextBox.Name = "finalExamTextBox";
            this.finalExamTextBox.Size = new System.Drawing.Size(100, 20);
            this.finalExamTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "(out of 90)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "(out of 90)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "(out of 120)";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(252, 269);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Exam Average (%)";
            // 
            // examAverageLabel
            // 
            this.examAverageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.examAverageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examAverageLabel.Location = new System.Drawing.Point(214, 338);
            this.examAverageLabel.Name = "examAverageLabel";
            this.examAverageLabel.Size = new System.Drawing.Size(168, 50);
            this.examAverageLabel.TabIndex = 11;
            this.examAverageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(158, 418);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(382, 418);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // exam1ErrorLabel
            // 
            this.exam1ErrorLabel.AutoSize = true;
            this.exam1ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.exam1ErrorLabel.Location = new System.Drawing.Point(379, 105);
            this.exam1ErrorLabel.Name = "exam1ErrorLabel";
            this.exam1ErrorLabel.Size = new System.Drawing.Size(167, 13);
            this.exam1ErrorLabel.TabIndex = 14;
            this.exam1ErrorLabel.Text = "Score must be between 0 and 90.";
            // 
            // exam2ErrorLabel
            // 
            this.exam2ErrorLabel.AutoSize = true;
            this.exam2ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.exam2ErrorLabel.Location = new System.Drawing.Point(379, 164);
            this.exam2ErrorLabel.Name = "exam2ErrorLabel";
            this.exam2ErrorLabel.Size = new System.Drawing.Size(167, 13);
            this.exam2ErrorLabel.TabIndex = 15;
            this.exam2ErrorLabel.Text = "Score must be between 0 and 90.";
            // 
            // finalExamErrorLabel
            // 
            this.finalExamErrorLabel.AutoSize = true;
            this.finalExamErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.finalExamErrorLabel.Location = new System.Drawing.Point(379, 241);
            this.finalExamErrorLabel.Name = "finalExamErrorLabel";
            this.finalExamErrorLabel.Size = new System.Drawing.Size(173, 13);
            this.finalExamErrorLabel.TabIndex = 16;
            this.finalExamErrorLabel.Text = "Score must be between 0 and 120.";
            // 
            // InputInvalidationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 496);
            this.Controls.Add(this.finalExamErrorLabel);
            this.Controls.Add(this.exam2ErrorLabel);
            this.Controls.Add(this.exam1ErrorLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.examAverageLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.finalExamTextBox);
            this.Controls.Add(this.exam2TextBox);
            this.Controls.Add(this.exam1TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InputInvalidationForm";
            this.Text = "Input Validation";
            this.Load += new System.EventHandler(this.InputInvalidationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox exam1TextBox;
        private System.Windows.Forms.TextBox exam2TextBox;
        private System.Windows.Forms.TextBox finalExamTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label examAverageLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label exam1ErrorLabel;
        private System.Windows.Forms.Label exam2ErrorLabel;
        private System.Windows.Forms.Label finalExamErrorLabel;
    }
}

