namespace Veritas
{
    partial class SettingsDialog
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
            this.musicVolume = new System.Windows.Forms.TrackBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.submitSettings = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.musicVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // musicVolume
            // 
            this.musicVolume.Location = new System.Drawing.Point(194, 28);
            this.musicVolume.Name = "musicVolume";
            this.musicVolume.Size = new System.Drawing.Size(104, 56);
            this.musicVolume.TabIndex = 0;
            this.musicVolume.Value = 5;
            this.musicVolume.Scroll += new System.EventHandler(this.volumeValue);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Music Volume";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // submitSettings
            // 
            this.submitSettings.Location = new System.Drawing.Point(119, 130);
            this.submitSettings.Name = "submitSettings";
            this.submitSettings.Size = new System.Drawing.Size(75, 23);
            this.submitSettings.TabIndex = 6;
            this.submitSettings.Text = "It\'s ok! ";
            this.submitSettings.UseVisualStyleBackColor = true;
            this.submitSettings.Click += new System.EventHandler(this.submitSettings_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(49, 93);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(68, 20);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Sound";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 179);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.submitSettings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.musicVolume);
            this.Name = "SettingsDialog";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.musicVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitSettings;
        public System.Windows.Forms.TrackBar musicVolume;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}