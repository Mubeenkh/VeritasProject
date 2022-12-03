namespace Veritas
{
    partial class ProgQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgQuestionForm));
            this.questionGroupBox = new System.Windows.Forms.GroupBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.firstRadioButton = new System.Windows.Forms.RadioButton();
            this.secondRadioButton = new System.Windows.Forms.RadioButton();
            this.thirdRadioButton = new System.Windows.Forms.RadioButton();
            this.fourthRadioButton = new System.Windows.Forms.RadioButton();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pointLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionGroupBox
            // 
            this.questionGroupBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.questionGroupBox.Controls.Add(this.questionLabel);
            this.questionGroupBox.Location = new System.Drawing.Point(61, 43);
            this.questionGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.questionGroupBox.Name = "questionGroupBox";
            this.questionGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.questionGroupBox.Size = new System.Drawing.Size(668, 274);
            this.questionGroupBox.TabIndex = 0;
            this.questionGroupBox.TabStop = false;
            // 
            // questionLabel
            // 
            this.questionLabel.BackColor = System.Drawing.Color.White;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(64, 74);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(540, 117);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(595, 489);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(135, 43);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(61, 489);
            this.submitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(135, 43);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // firstRadioButton
            // 
            this.firstRadioButton.AutoSize = true;
            this.firstRadioButton.Checked = true;
            this.firstRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.firstRadioButton.Location = new System.Drawing.Point(85, 338);
            this.firstRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstRadioButton.Name = "firstRadioButton";
            this.firstRadioButton.Size = new System.Drawing.Size(17, 16);
            this.firstRadioButton.TabIndex = 8;
            this.firstRadioButton.TabStop = true;
            this.firstRadioButton.Tag = "1";
            this.firstRadioButton.UseVisualStyleBackColor = true;
            this.firstRadioButton.CheckedChanged += new System.EventHandler(this.checkedAnswerEvent);
            // 
            // secondRadioButton
            // 
            this.secondRadioButton.AutoSize = true;
            this.secondRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.secondRadioButton.Location = new System.Drawing.Point(85, 373);
            this.secondRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.secondRadioButton.Name = "secondRadioButton";
            this.secondRadioButton.Size = new System.Drawing.Size(17, 16);
            this.secondRadioButton.TabIndex = 9;
            this.secondRadioButton.Tag = "2";
            this.secondRadioButton.UseVisualStyleBackColor = true;
            this.secondRadioButton.CheckedChanged += new System.EventHandler(this.checkedAnswerEvent);
            // 
            // thirdRadioButton
            // 
            this.thirdRadioButton.AutoSize = true;
            this.thirdRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.thirdRadioButton.Location = new System.Drawing.Point(85, 412);
            this.thirdRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thirdRadioButton.Name = "thirdRadioButton";
            this.thirdRadioButton.Size = new System.Drawing.Size(17, 16);
            this.thirdRadioButton.TabIndex = 10;
            this.thirdRadioButton.Tag = "3";
            this.thirdRadioButton.UseVisualStyleBackColor = true;
            this.thirdRadioButton.CheckedChanged += new System.EventHandler(this.checkedAnswerEvent);
            // 
            // fourthRadioButton
            // 
            this.fourthRadioButton.AutoSize = true;
            this.fourthRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.fourthRadioButton.Location = new System.Drawing.Point(85, 450);
            this.fourthRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fourthRadioButton.Name = "fourthRadioButton";
            this.fourthRadioButton.Size = new System.Drawing.Size(17, 16);
            this.fourthRadioButton.TabIndex = 11;
            this.fourthRadioButton.Tag = "4";
            this.fourthRadioButton.UseVisualStyleBackColor = true;
            this.fourthRadioButton.CheckedChanged += new System.EventHandler(this.checkedAnswerEvent);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(741, -1);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(51, 27);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pointLabel
            // 
            this.pointLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointLabel.Location = new System.Drawing.Point(613, 338);
            this.pointLabel.Name = "pointLabel";
            this.pointLabel.Size = new System.Drawing.Size(116, 33);
            this.pointLabel.TabIndex = 13;
            this.pointLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endLabel
            // 
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.Location = new System.Drawing.Point(229, 489);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(325, 43);
            this.endLabel.TabIndex = 14;
            this.endLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.backToMainMenuToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.helpToolStripMenuItem.Text = "Help?";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musicToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // musicToolStripMenuItem
            // 
            this.musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            this.musicToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.musicToolStripMenuItem.Text = "Music";
            this.musicToolStripMenuItem.Click += new System.EventHandler(this.soundToolStripMenuItem_Click);
            // 
            // backToMainMenuToolStripMenuItem
            // 
            this.backToMainMenuToolStripMenuItem.Name = "backToMainMenuToolStripMenuItem";
            this.backToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.backToMainMenuToolStripMenuItem.Text = "Back to Main Menu";
            // 
            // ProgQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(791, 559);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.pointLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.fourthRadioButton);
            this.Controls.Add(this.thirdRadioButton);
            this.Controls.Add(this.secondRadioButton);
            this.Controls.Add(this.firstRadioButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.questionGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProgQuestionForm";
            this.Text = "QuestionFormBase";
            this.questionGroupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox questionGroupBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.RadioButton firstRadioButton;
        private System.Windows.Forms.RadioButton secondRadioButton;
        private System.Windows.Forms.RadioButton thirdRadioButton;
        private System.Windows.Forms.RadioButton fourthRadioButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label pointLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToMainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
    }
}