namespace Calculator
{
    partial class SYCalculator
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
            this.equalButton = new System.Windows.Forms.Button();
            this.additionButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.mulitplyButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // equalButton
            // 
            this.equalButton.Location = new System.Drawing.Point(126, 219);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(34, 23);
            this.equalButton.TabIndex = 0;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // additionButton
            // 
            this.additionButton.Location = new System.Drawing.Point(126, 178);
            this.additionButton.Name = "additionButton";
            this.additionButton.Size = new System.Drawing.Size(36, 23);
            this.additionButton.TabIndex = 2;
            this.additionButton.Text = "+";
            this.additionButton.UseVisualStyleBackColor = true;
            this.additionButton.Click += new System.EventHandler(this.OperatorButtonClick);
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(124, 148);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(36, 23);
            this.minusButton.TabIndex = 3;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.OperatorButtonClick);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(124, 117);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(36, 23);
            this.divideButton.TabIndex = 4;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.OperatorButtonClick);
            // 
            // mulitplyButton
            // 
            this.mulitplyButton.Location = new System.Drawing.Point(126, 88);
            this.mulitplyButton.Name = "mulitplyButton";
            this.mulitplyButton.Size = new System.Drawing.Size(36, 23);
            this.mulitplyButton.TabIndex = 5;
            this.mulitplyButton.Text = "*";
            this.mulitplyButton.UseVisualStyleBackColor = true;
            this.mulitplyButton.Click += new System.EventHandler(this.OperatorButtonClick);
            // 
            // decimalButton
            // 
            this.decimalButton.Location = new System.Drawing.Point(84, 219);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(36, 23);
            this.decimalButton.TabIndex = 6;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // zeroButton
            // 
            this.zeroButton.Location = new System.Drawing.Point(2, 219);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(75, 23);
            this.zeroButton.TabIndex = 7;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // oneButton
            // 
            this.oneButton.Location = new System.Drawing.Point(2, 178);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(34, 23);
            this.oneButton.TabIndex = 8;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // fourButton
            // 
            this.fourButton.Location = new System.Drawing.Point(2, 149);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(34, 23);
            this.fourButton.TabIndex = 9;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // sevenButton
            // 
            this.sevenButton.Location = new System.Drawing.Point(2, 118);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(34, 23);
            this.sevenButton.TabIndex = 10;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(2, 89);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "<-";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.Location = new System.Drawing.Point(43, 117);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(34, 23);
            this.eightButton.TabIndex = 12;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // fiveButton
            // 
            this.fiveButton.Location = new System.Drawing.Point(43, 149);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(34, 23);
            this.fiveButton.TabIndex = 13;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // twoButton
            // 
            this.twoButton.Location = new System.Drawing.Point(43, 178);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(34, 23);
            this.twoButton.TabIndex = 14;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // nineButton
            // 
            this.nineButton.Location = new System.Drawing.Point(84, 118);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(34, 23);
            this.nineButton.TabIndex = 15;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // sixButton
            // 
            this.sixButton.Location = new System.Drawing.Point(84, 148);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(34, 23);
            this.sixButton.TabIndex = 16;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // threeButton
            // 
            this.threeButton.Location = new System.Drawing.Point(84, 178);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(34, 23);
            this.threeButton.TabIndex = 17;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(83, 89);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(35, 23);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "CE";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // displayBox
            // 
            this.displayBox.Location = new System.Drawing.Point(2, 25);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(158, 20);
            this.displayBox.TabIndex = 19;
            // 
            // SYCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 254);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.decimalButton);
            this.Controls.Add(this.mulitplyButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.additionButton);
            this.Controls.Add(this.equalButton);
            this.Name = "SYCalculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button additionButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button mulitplyButton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox displayBox;
    }
}

