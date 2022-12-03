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
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // startButtom
            // 
            this.startButtom.BackColor = System.Drawing.Color.Tan;
            this.startButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButtom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButtom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButtom.Location = new System.Drawing.Point(54, 122);
            this.startButtom.Margin = new System.Windows.Forms.Padding(0);
            this.startButtom.Name = "startButtom";
            this.startButtom.Size = new System.Drawing.Size(371, 40);
            this.startButtom.TabIndex = 0;
            this.startButtom.Text = "Start";
            this.startButtom.UseVisualStyleBackColor = false;
            this.startButtom.Click += new System.EventHandler(this.startButtom_Click);
            // 
            // settingButton
            // 
            this.settingButton.BackColor = System.Drawing.Color.Tan;
            this.settingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingButton.Location = new System.Drawing.Point(54, 178);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(371, 40);
            this.settingButton.TabIndex = 1;
            this.settingButton.Text = "Settings";
            this.settingButton.UseVisualStyleBackColor = false;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // devButton
            // 
            this.devButton.BackColor = System.Drawing.Color.Tan;
            this.devButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.devButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devButton.Location = new System.Drawing.Point(54, 236);
            this.devButton.Name = "devButton";
            this.devButton.Size = new System.Drawing.Size(371, 40);
            this.devButton.TabIndex = 2;
            this.devButton.Text = "Developers";
            this.devButton.UseVisualStyleBackColor = false;
            this.devButton.Click += new System.EventHandler(this.devButton_Click);
            // 
            // veritasLabel
            // 
            this.veritasLabel.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veritasLabel.Location = new System.Drawing.Point(12, 35);
            this.veritasLabel.Name = "veritasLabel";
            this.veritasLabel.Size = new System.Drawing.Size(466, 84);
            this.veritasLabel.TabIndex = 3;
            this.veritasLabel.Text = "Veritas";
            this.veritasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.veritasLabel.Click += new System.EventHandler(this.veritasLabel_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Tan;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(54, 295);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(371, 40);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit Game";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // fullExitButton
            // 
            this.fullExitButton.BackColor = System.Drawing.Color.LightCoral;
            this.fullExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fullExitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.fullExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullExitButton.Font = new System.Drawing.Font("Myanmar Text", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullExitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fullExitButton.Location = new System.Drawing.Point(446, 0);
            this.fullExitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fullExitButton.Name = "fullExitButton";
            this.fullExitButton.Size = new System.Drawing.Size(44, 22);
            this.fullExitButton.TabIndex = 13;
            this.fullExitButton.Text = "X";
            this.fullExitButton.UseVisualStyleBackColor = false;
            this.fullExitButton.Click += new System.EventHandler(this.fullExitButton_Click);
            // 
            // musicPlayer
            // 
            this.musicPlayer.Enabled = true;
            this.musicPlayer.Location = new System.Drawing.Point(11, 373);
            this.musicPlayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.musicPlayer.Name = "musicPlayer";
            this.musicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("musicPlayer.OcxState")));
            this.musicPlayer.Size = new System.Drawing.Size(204, 58);
            this.musicPlayer.TabIndex = 14;
            // 
            // VeritasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(490, 360);
            this.Controls.Add(this.musicPlayer);
            this.Controls.Add(this.fullExitButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.veritasLabel);
            this.Controls.Add(this.devButton);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.startButtom);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VeritasForm";
            this.Text = "Veritas";
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
    }
}

