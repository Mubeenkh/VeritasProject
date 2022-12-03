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
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.questionGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionGroupBox
            // 
            this.questionGroupBox.BackColor = System.Drawing.Color.White;
            this.questionGroupBox.Controls.Add(this.questionLabel);
            this.questionGroupBox.Location = new System.Drawing.Point(11, 47);
            this.questionGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.questionGroupBox.Name = "questionGroupBox";
            this.questionGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.questionGroupBox.Size = new System.Drawing.Size(571, 186);
            this.questionGroupBox.TabIndex = 0;
            this.questionGroupBox.TabStop = false;
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Centaur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(4, 0);
            this.questionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(567, 184);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Tan;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(11, 398);
            this.backButton.Margin = new System.Windows.Forms.Padding(0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(101, 35);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Tan;
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(481, 398);
            this.submitButton.Margin = new System.Windows.Forms.Padding(0);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(101, 35);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // firstRadioButton
            // 
            this.firstRadioButton.AutoSize = true;
            this.firstRadioButton.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.firstRadioButton.Location = new System.Drawing.Point(46, 366);
            this.firstRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.firstRadioButton.Name = "firstRadioButton";
            this.firstRadioButton.Size = new System.Drawing.Size(14, 13);
            this.firstRadioButton.TabIndex = 8;
            this.firstRadioButton.Tag = "1";
            this.firstRadioButton.UseVisualStyleBackColor = true;
            this.firstRadioButton.CheckedChanged += new System.EventHandler(this.checkedAnswerEvent);
            // 
            // secondRadioButton
            // 
            this.secondRadioButton.AutoSize = true;
            this.secondRadioButton.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.secondRadioButton.Location = new System.Drawing.Point(363, 330);
            this.secondRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.secondRadioButton.Name = "secondRadioButton";
            this.secondRadioButton.Size = new System.Drawing.Size(14, 13);
            this.secondRadioButton.TabIndex = 9;
            this.secondRadioButton.Tag = "2";
            this.secondRadioButton.UseVisualStyleBackColor = true;
            this.secondRadioButton.CheckedChanged += new System.EventHandler(this.checkedAnswerEvent);
            // 
            // thirdRadioButton
            // 
            this.thirdRadioButton.AutoSize = true;
            this.thirdRadioButton.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.thirdRadioButton.Location = new System.Drawing.Point(363, 366);
            this.thirdRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.thirdRadioButton.Name = "thirdRadioButton";
            this.thirdRadioButton.Size = new System.Drawing.Size(14, 13);
            this.thirdRadioButton.TabIndex = 10;
            this.thirdRadioButton.Tag = "3";
            this.thirdRadioButton.UseVisualStyleBackColor = true;
            this.thirdRadioButton.CheckedChanged += new System.EventHandler(this.checkedAnswerEvent);
            // 
            // fourthRadioButton
            // 
            this.fourthRadioButton.AutoSize = true;
            this.fourthRadioButton.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourthRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fourthRadioButton.Location = new System.Drawing.Point(46, 330);
            this.fourthRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fourthRadioButton.Name = "fourthRadioButton";
            this.fourthRadioButton.Size = new System.Drawing.Size(14, 13);
            this.fourthRadioButton.TabIndex = 11;
            this.fourthRadioButton.Tag = "4";
            this.fourthRadioButton.UseVisualStyleBackColor = true;
            this.fourthRadioButton.CheckedChanged += new System.EventHandler(this.checkedAnswerEvent);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.LightCoral;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Myanmar Text", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(556, -1);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(38, 22);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pointLabel
            // 
            this.pointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pointLabel.Location = new System.Drawing.Point(11, 247);
            this.pointLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pointLabel.Name = "pointLabel";
            this.pointLabel.Size = new System.Drawing.Size(87, 27);
            this.pointLabel.TabIndex = 13;
            this.pointLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pointLabel.Click += new System.EventHandler(this.pointLabel_Click);
            // 
            // endLabel
            // 
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.Location = new System.Drawing.Point(188, 398);
            this.endLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(244, 35);
            this.endLabel.TabIndex = 14;
            this.endLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.endLabel.Click += new System.EventHandler(this.endLabel_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.backToMainMenuToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.helpToolStripMenuItem.Text = "Help?";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musicToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // musicToolStripMenuItem
            // 
            this.musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            this.musicToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.musicToolStripMenuItem.Text = "Music";
            this.musicToolStripMenuItem.Click += new System.EventHandler(this.soundToolStripMenuItem_Click);
            // 
            // backToMainMenuToolStripMenuItem
            // 
            this.backToMainMenuToolStripMenuItem.Name = "backToMainMenuToolStripMenuItem";
            this.backToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.backToMainMenuToolStripMenuItem.Text = "Back to Main Menu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(593, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ProgQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(593, 454);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProgQuestionForm";
            this.Text = "QuestionFormBase";
            this.Load += new System.EventHandler(this.ProgQuestionForm_Load);
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
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToMainMenuToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}