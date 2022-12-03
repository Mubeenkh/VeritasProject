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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeritasForm));
            this.startButtom = new System.Windows.Forms.Button();
            this.settingButton = new System.Windows.Forms.Button();
            this.devButton = new System.Windows.Forms.Button();
            this.veritasLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.fullExitButton = new System.Windows.Forms.Button();
            this.musicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // startButtom
            // 
            this.startButtom.BackColor = System.Drawing.Color.Coral;
            resources.ApplyResources(this.startButtom, "startButtom");
            this.startButtom.Name = "startButtom";
            this.startButtom.UseVisualStyleBackColor = false;
            this.startButtom.Click += new System.EventHandler(this.startButtom_Click);
            // 
            // settingButton
            // 
            this.settingButton.BackColor = System.Drawing.Color.Coral;
            resources.ApplyResources(this.settingButton, "settingButton");
            this.settingButton.Name = "settingButton";
            this.settingButton.UseVisualStyleBackColor = false;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // devButton
            // 
            this.devButton.BackColor = System.Drawing.Color.Coral;
            resources.ApplyResources(this.devButton, "devButton");
            this.devButton.Name = "devButton";
            this.devButton.UseVisualStyleBackColor = false;
            this.devButton.Click += new System.EventHandler(this.devButton_Click);
            // 
            // veritasLabel
            // 
            resources.ApplyResources(this.veritasLabel, "veritasLabel");
            this.veritasLabel.Name = "veritasLabel";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.OrangeRed;
            resources.ApplyResources(this.ExitButton, "ExitButton");
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // fullExitButton
            // 
            this.fullExitButton.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.fullExitButton, "fullExitButton");
            this.fullExitButton.Name = "fullExitButton";
            this.fullExitButton.UseVisualStyleBackColor = false;
            this.fullExitButton.Click += new System.EventHandler(this.fullExitButton_Click);
            // 
            // musicPlayer
            // 
            resources.ApplyResources(this.musicPlayer, "musicPlayer");
            this.musicPlayer.Name = "musicPlayer";
            this.musicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("musicPlayer.OcxState")));
            // 
            // languageComboBox
            // 
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            resources.GetString("languageComboBox.Items"),
            resources.GetString("languageComboBox.Items1"),
            resources.GetString("languageComboBox.Items2")});
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // VeritasForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.musicPlayer);
            this.Controls.Add(this.fullExitButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.veritasLabel);
            this.Controls.Add(this.devButton);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.startButtom);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VeritasForm";
            this.Load += new System.EventHandler(this.VeritasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButtom;
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.Button devButton;
        private System.Windows.Forms.Label veritasLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button fullExitButton;
        public AxWMPLib.AxWindowsMediaPlayer musicPlayer;
        private System.Windows.Forms.ComboBox languageComboBox;
    }
}

