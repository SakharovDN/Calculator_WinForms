namespace Calculator_WinForms
{
    partial class MainForm
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
            this.zeroButton = new System.Windows.Forms.Button();
            this.pointButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.secondButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.backspaceButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.equationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zeroButton
            // 
            this.zeroButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zeroButton.Location = new System.Drawing.Point(109, 336);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(91, 50);
            this.zeroButton.TabIndex = 1;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // pointButton
            // 
            this.pointButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pointButton.Location = new System.Drawing.Point(12, 336);
            this.pointButton.Name = "pointButton";
            this.pointButton.Size = new System.Drawing.Size(91, 50);
            this.pointButton.TabIndex = 17;
            this.pointButton.Text = ",";
            this.pointButton.UseVisualStyleBackColor = true;
            this.pointButton.Click += new System.EventHandler(this.pointButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equalButton.Location = new System.Drawing.Point(206, 336);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(91, 50);
            this.equalButton.TabIndex = 18;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plusButton.Location = new System.Drawing.Point(303, 336);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(91, 50);
            this.plusButton.TabIndex = 19;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oneButton.Location = new System.Drawing.Point(12, 280);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(91, 50);
            this.oneButton.TabIndex = 20;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // secondButton
            // 
            this.secondButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondButton.Location = new System.Drawing.Point(109, 280);
            this.secondButton.Name = "secondButton";
            this.secondButton.Size = new System.Drawing.Size(91, 50);
            this.secondButton.TabIndex = 21;
            this.secondButton.Text = "2";
            this.secondButton.UseVisualStyleBackColor = true;
            this.secondButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.threeButton.Location = new System.Drawing.Point(206, 280);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(91, 50);
            this.threeButton.TabIndex = 22;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subtractButton.Location = new System.Drawing.Point(303, 280);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(91, 50);
            this.subtractButton.TabIndex = 23;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiplyButton.Location = new System.Drawing.Point(303, 224);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(91, 50);
            this.multiplyButton.TabIndex = 24;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sixButton.Location = new System.Drawing.Point(206, 224);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(91, 50);
            this.sixButton.TabIndex = 25;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fiveButton.Location = new System.Drawing.Point(109, 224);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(91, 50);
            this.fiveButton.TabIndex = 26;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fourButton.Location = new System.Drawing.Point(12, 224);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(91, 50);
            this.fourButton.TabIndex = 27;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sevenButton.Location = new System.Drawing.Point(12, 168);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(91, 50);
            this.sevenButton.TabIndex = 28;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eightButton.Location = new System.Drawing.Point(109, 168);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(91, 50);
            this.eightButton.TabIndex = 29;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nineButton.Location = new System.Drawing.Point(206, 168);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(91, 50);
            this.nineButton.TabIndex = 30;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.digitButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divideButton.Location = new System.Drawing.Point(303, 168);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(91, 50);
            this.divideButton.TabIndex = 31;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // backspaceButton
            // 
            this.backspaceButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backspaceButton.Location = new System.Drawing.Point(303, 112);
            this.backspaceButton.Name = "backspaceButton";
            this.backspaceButton.Size = new System.Drawing.Size(91, 50);
            this.backspaceButton.TabIndex = 32;
            this.backspaceButton.Text = "<-";
            this.backspaceButton.UseVisualStyleBackColor = true;
            this.backspaceButton.Click += new System.EventHandler(this.backspaceButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Location = new System.Drawing.Point(206, 112);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(91, 50);
            this.cancelButton.TabIndex = 33;
            this.cancelButton.Text = "C";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(12, 55);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(48, 59);
            this.resultLabel.TabIndex = 34;
            this.resultLabel.Text = "0";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // equationLabel
            // 
            this.equationLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.equationLabel.AutoSize = true;
            this.equationLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equationLabel.Location = new System.Drawing.Point(12, 30);
            this.equationLabel.Name = "equationLabel";
            this.equationLabel.Size = new System.Drawing.Size(0, 25);
            this.equationLabel.TabIndex = 35;
            this.equationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 396);
            this.Controls.Add(this.equationLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.backspaceButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.secondButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.pointButton);
            this.Controls.Add(this.zeroButton);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button zeroButton;
        private Button pointButton;
        private Button equalButton;
        private Button plusButton;
        private Button oneButton;
        private Button secondButton;
        private Button threeButton;
        private Button subtractButton;
        private Button multiplyButton;
        private Button sixButton;
        private Button fiveButton;
        private Button fourButton;
        private Button sevenButton;
        private Button eightButton;
        private Button nineButton;
        private Button divideButton;
        private Button backspaceButton;
        private Button cancelButton;
        private Label resultLabel;
        private Label equationLabel;
    }
}