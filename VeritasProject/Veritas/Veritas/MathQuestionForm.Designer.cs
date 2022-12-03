namespace Veritas
{
    partial class MathQuestionForm
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.endLabel = new System.Windows.Forms.Label();
            this.pointLabel = new System.Windows.Forms.Label();
            this.fourthRadioButton = new System.Windows.Forms.RadioButton();
            this.thirdRadioButton = new System.Windows.Forms.RadioButton();
            this.secondRadioButton = new System.Windows.Forms.RadioButton();
            this.firstRadioButton = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.questionGroupBox = new System.Windows.Forms.GroupBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.questionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(708, 2);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(51, 27);
            this.ExitButton.TabIndex = 34;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // endLabel
            // 
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.Location = new System.Drawing.Point(204, 480);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(325, 43);
            this.endLabel.TabIndex = 33;
            this.endLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pointLabel
            // 
            this.pointLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointLabel.Location = new System.Drawing.Point(588, 329);
            this.pointLabel.Name = "pointLabel";
            this.pointLabel.Size = new System.Drawing.Size(116, 33);
            this.pointLabel.TabIndex = 32;
            this.pointLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fourthRadioButton
            // 
            this.fourthRadioButton.AutoSize = true;
            this.fourthRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.fourthRadioButton.Location = new System.Drawing.Point(60, 441);
            this.fourthRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fourthRadioButton.Name = "fourthRadioButton";
            this.fourthRadioButton.Size = new System.Drawing.Size(17, 16);
            this.fourthRadioButton.TabIndex = 31;
            this.fourthRadioButton.Tag = "4";
            this.fourthRadioButton.UseVisualStyleBackColor = true;
            // 
            // thirdRadioButton
            // 
            this.thirdRadioButton.AutoSize = true;
            this.thirdRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.thirdRadioButton.Location = new System.Drawing.Point(60, 403);
            this.thirdRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thirdRadioButton.Name = "thirdRadioButton";
            this.thirdRadioButton.Size = new System.Drawing.Size(17, 16);
            this.thirdRadioButton.TabIndex = 30;
            this.thirdRadioButton.Tag = "3";
            this.thirdRadioButton.UseVisualStyleBackColor = true;
            // 
            // secondRadioButton
            // 
            this.secondRadioButton.AutoSize = true;
            this.secondRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.secondRadioButton.Location = new System.Drawing.Point(60, 364);
            this.secondRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secondRadioButton.Name = "secondRadioButton";
            this.secondRadioButton.Size = new System.Drawing.Size(17, 16);
            this.secondRadioButton.TabIndex = 29;
            this.secondRadioButton.Tag = "2";
            this.secondRadioButton.UseVisualStyleBackColor = true;
            // 
            // firstRadioButton
            // 
            this.firstRadioButton.AutoSize = true;
            this.firstRadioButton.Checked = true;
            this.firstRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.firstRadioButton.Location = new System.Drawing.Point(60, 329);
            this.firstRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstRadioButton.Name = "firstRadioButton";
            this.firstRadioButton.Size = new System.Drawing.Size(17, 16);
            this.firstRadioButton.TabIndex = 28;
            this.firstRadioButton.TabStop = true;
            this.firstRadioButton.Tag = "1";
            this.firstRadioButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(36, 480);
            this.submitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(135, 43);
            this.submitButton.TabIndex = 27;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(570, 480);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(135, 43);
            this.backButton.TabIndex = 26;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // questionGroupBox
            // 
            this.questionGroupBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.questionGroupBox.Controls.Add(this.questionLabel);
            this.questionGroupBox.Location = new System.Drawing.Point(36, 34);
            this.questionGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.questionGroupBox.Name = "questionGroupBox";
            this.questionGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.questionGroupBox.Size = new System.Drawing.Size(668, 274);
            this.questionGroupBox.TabIndex = 25;
            this.questionGroupBox.TabStop = false;
            // 
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.Color.White;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(74, 77);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(540, 117);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MathQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(758, 553);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.pointLabel);
            this.Controls.Add(this.fourthRadioButton);
            this.Controls.Add(this.thirdRadioButton);
            this.Controls.Add(this.secondRadioButton);
            this.Controls.Add(this.firstRadioButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.questionGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MathQuestionForm";
            this.Text = "MathQuestionForm";
            this.questionGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label pointLabel;
        private System.Windows.Forms.RadioButton fourthRadioButton;
        private System.Windows.Forms.RadioButton thirdRadioButton;
        private System.Windows.Forms.RadioButton secondRadioButton;
        private System.Windows.Forms.RadioButton firstRadioButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox questionGroupBox;
        private System.Windows.Forms.Label questionLabel;
    }
}