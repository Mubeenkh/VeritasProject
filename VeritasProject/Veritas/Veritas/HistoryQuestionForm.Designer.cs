namespace Veritas
{
    partial class HistoryQuestionForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryQuestionForm));
            this.endLabel = new System.Windows.Forms.Label();
            this.pointLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.fourthRadioButton = new System.Windows.Forms.RadioButton();
            this.thirdRadioButton = new System.Windows.Forms.RadioButton();
            this.secondRadioButton = new System.Windows.Forms.RadioButton();
            this.firstRadioButton = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.questionGroupBox = new System.Windows.Forms.GroupBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.timeLimit = new System.Windows.Forms.Timer(this.components);
            this.animateAnswer = new System.Windows.Forms.Timer(this.components);
            this.questionGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // endLabel
            // 
            resources.ApplyResources(this.endLabel, "endLabel");
            this.endLabel.Name = "endLabel";
            // 
            // pointLabel
            // 
            resources.ApplyResources(this.pointLabel, "pointLabel");
            this.pointLabel.ForeColor = System.Drawing.Color.Black;
            this.pointLabel.Name = "pointLabel";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.LightCoral;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.ExitButton, "ExitButton");
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // fourthRadioButton
            // 
            resources.ApplyResources(this.fourthRadioButton, "fourthRadioButton");
            this.fourthRadioButton.ForeColor = System.Drawing.Color.Black;
            this.fourthRadioButton.Name = "fourthRadioButton";
            this.fourthRadioButton.Tag = "4";
            this.fourthRadioButton.UseVisualStyleBackColor = true;
            this.fourthRadioButton.CheckedChanged += new System.EventHandler(this.checkedAnswerEvent);
            // 
            // thirdRadioButton
            // 
            resources.ApplyResources(this.thirdRadioButton, "thirdRadioButton");
            this.thirdRadioButton.ForeColor = System.Drawing.Color.Black;
            this.thirdRadioButton.Name = "thirdRadioButton";
            this.thirdRadioButton.Tag = "3";
            this.thirdRadioButton.UseVisualStyleBackColor = true;
            this.thirdRadioButton.CheckedChanged += new System.EventHandler(this.checkedAnswerEvent);
            // 
            // secondRadioButton
            // 
            resources.ApplyResources(this.secondRadioButton, "secondRadioButton");
            this.secondRadioButton.ForeColor = System.Drawing.Color.Black;
            this.secondRadioButton.Name = "secondRadioButton";
            this.secondRadioButton.Tag = "2";
            this.secondRadioButton.UseVisualStyleBackColor = true;
            this.secondRadioButton.CheckedChanged += new System.EventHandler(this.checkedAnswerEvent);
            // 
            // firstRadioButton
            // 
            resources.ApplyResources(this.firstRadioButton, "firstRadioButton");
            this.firstRadioButton.ForeColor = System.Drawing.Color.Black;
            this.firstRadioButton.Name = "firstRadioButton";
            this.firstRadioButton.Tag = "1";
            this.firstRadioButton.UseVisualStyleBackColor = true;
            this.firstRadioButton.CheckedChanged += new System.EventHandler(this.checkedAnswerEvent);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Tan;
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.submitButton, "submitButton");
            this.submitButton.Name = "submitButton";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Tan;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.backButton, "backButton");
            this.backButton.Name = "backButton";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // questionGroupBox
            // 
            this.questionGroupBox.BackColor = System.Drawing.Color.White;
            this.questionGroupBox.Controls.Add(this.questionLabel);
            resources.ApplyResources(this.questionGroupBox, "questionGroupBox");
            this.questionGroupBox.Name = "questionGroupBox";
            this.questionGroupBox.TabStop = false;
            // 
            // questionLabel
            // 
            resources.ApplyResources(this.questionLabel, "questionLabel");
            this.questionLabel.Name = "questionLabel";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.backToMainMenuToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musicToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            // 
            // musicToolStripMenuItem
            // 
            this.musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            resources.ApplyResources(this.musicToolStripMenuItem, "musicToolStripMenuItem");
            this.musicToolStripMenuItem.Click += new System.EventHandler(this.musicToolStripMenuItem_Click);
            // 
            // backToMainMenuToolStripMenuItem
            // 
            this.backToMainMenuToolStripMenuItem.Name = "backToMainMenuToolStripMenuItem";
            resources.ApplyResources(this.backToMainMenuToolStripMenuItem, "backToMainMenuToolStripMenuItem");
            this.backToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.backToMainMenuToolStripMenuItem_Click);
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.timeLeftLabel, "timeLeftLabel");
            this.timeLeftLabel.ForeColor = System.Drawing.Color.Black;
            this.timeLeftLabel.Name = "timeLeftLabel";
            // 
            // timeLimit
            // 
            this.timeLimit.Enabled = true;
            this.timeLimit.Interval = 1000;
            this.timeLimit.Tick += new System.EventHandler(this.timeLimit_Tick);
            // 
            // animateAnswer
            // 
            this.animateAnswer.Enabled = true;
            this.animateAnswer.Interval = 800;
            this.animateAnswer.Tick += new System.EventHandler(this.animateAnswer_Tick);
            // 
            // HistoryQuestionForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.timeLeftLabel);
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
            this.Name = "HistoryQuestionForm";
            this.questionGroupBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label pointLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.RadioButton fourthRadioButton;
        private System.Windows.Forms.RadioButton thirdRadioButton;
        private System.Windows.Forms.RadioButton secondRadioButton;
        private System.Windows.Forms.RadioButton firstRadioButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox questionGroupBox;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToMainMenuToolStripMenuItem;
        private System.Windows.Forms.Label timeLeftLabel;
        private System.Windows.Forms.Timer timeLimit;
        private System.Windows.Forms.Timer animateAnswer;
    }
}