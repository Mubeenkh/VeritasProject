namespace Veritas
{
    partial class VeritasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeritasForm));
            this.startButtom = new System.Windows.Forms.Button();
            this.settingButton = new System.Windows.Forms.Button();
            this.devButton = new System.Windows.Forms.Button();
            this.veritasLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.fullExitButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.opacityTimer = new System.Windows.Forms.Timer(this.components);
            this.musicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.languagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frenchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spanishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButtom
            // 
            this.startButtom.BackColor = System.Drawing.Color.Tan;
            this.startButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.startButtom, "startButtom");
            this.startButtom.Name = "startButtom";
            this.startButtom.UseVisualStyleBackColor = false;
            this.startButtom.Click += new System.EventHandler(this.startButtom_Click);
            this.startButtom.MouseHover += new System.EventHandler(this.startButtom_MouseHover);
            // 
            // settingButton
            // 
            this.settingButton.BackColor = System.Drawing.Color.Tan;
            this.settingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.settingButton, "settingButton");
            this.settingButton.Name = "settingButton";
            this.settingButton.UseVisualStyleBackColor = false;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            this.settingButton.MouseHover += new System.EventHandler(this.settingButton_MouseHover);
            // 
            // devButton
            // 
            this.devButton.BackColor = System.Drawing.Color.Tan;
            this.devButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.devButton, "devButton");
            this.devButton.Name = "devButton";
            this.devButton.UseVisualStyleBackColor = false;
            this.devButton.Click += new System.EventHandler(this.devButton_Click);
            this.devButton.MouseHover += new System.EventHandler(this.devButton_MouseHover);
            // 
            // veritasLabel
            // 
            resources.ApplyResources(this.veritasLabel, "veritasLabel");
            this.veritasLabel.Name = "veritasLabel";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Tan;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.ExitButton, "ExitButton");
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseHover += new System.EventHandler(this.ExitButton_MouseHover);
            // 
            // fullExitButton
            // 
            this.fullExitButton.BackColor = System.Drawing.Color.LightCoral;
            this.fullExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fullExitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            resources.ApplyResources(this.fullExitButton, "fullExitButton");
            this.fullExitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fullExitButton.Name = "fullExitButton";
            this.fullExitButton.UseVisualStyleBackColor = false;
            this.fullExitButton.Click += new System.EventHandler(this.fullExitButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // opacityTimer
            // 
            this.opacityTimer.Enabled = true;
            this.opacityTimer.Interval = 50;
            this.opacityTimer.Tick += new System.EventHandler(this.opacityTimer_Tick);
            // 
            // musicPlayer
            // 
            resources.ApplyResources(this.musicPlayer, "musicPlayer");
            this.musicPlayer.Name = "musicPlayer";
            this.musicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("musicPlayer.OcxState")));
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languagesToolStripMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // languagesToolStripMenuItem
            // 
            this.languagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.frenchToolStripMenuItem,
            this.spanishToolStripMenuItem});
            this.languagesToolStripMenuItem.Name = "languagesToolStripMenuItem";
            resources.ApplyResources(this.languagesToolStripMenuItem, "languagesToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // frenchToolStripMenuItem
            // 
            this.frenchToolStripMenuItem.Name = "frenchToolStripMenuItem";
            resources.ApplyResources(this.frenchToolStripMenuItem, "frenchToolStripMenuItem");
            this.frenchToolStripMenuItem.Click += new System.EventHandler(this.frenchToolStripMenuItem_Click);
            // 
            // spanishToolStripMenuItem
            // 
            this.spanishToolStripMenuItem.Name = "spanishToolStripMenuItem";
            resources.ApplyResources(this.spanishToolStripMenuItem, "spanishToolStripMenuItem");
            this.spanishToolStripMenuItem.Click += new System.EventHandler(this.spanishToolStripMenuItem_Click);
            // 
            // VeritasForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.musicPlayer);
            this.Controls.Add(this.fullExitButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.veritasLabel);
            this.Controls.Add(this.devButton);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.startButtom);
            this.Controls.Add(this.menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "VeritasForm";
            this.Opacity = 0D;
            this.Load += new System.EventHandler(this.VeritasForm_Load);
            this.MouseHover += new System.EventHandler(this.VeritasForm_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.Button devButton;
        private System.Windows.Forms.Label veritasLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button fullExitButton;
        public AxWMPLib.AxWindowsMediaPlayer musicPlayer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer opacityTimer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem languagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frenchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spanishToolStripMenuItem;
        private System.Windows.Forms.Button startButtom;
    }
}

