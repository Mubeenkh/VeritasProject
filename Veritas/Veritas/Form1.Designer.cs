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
            this.startButtom = new System.Windows.Forms.Button();
            this.settingButton = new System.Windows.Forms.Button();
            this.devButton = new System.Windows.Forms.Button();
            this.veritasLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButtom
            // 
            this.startButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButtom.Location = new System.Drawing.Point(193, 169);
            this.startButtom.Name = "startButtom";
            this.startButtom.Size = new System.Drawing.Size(100, 40);
            this.startButtom.TabIndex = 0;
            this.startButtom.Text = "Start";
            this.startButtom.UseVisualStyleBackColor = true;
            this.startButtom.Click += new System.EventHandler(this.startButtom_Click);
            // 
            // settingButton
            // 
            this.settingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingButton.Location = new System.Drawing.Point(193, 225);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(100, 40);
            this.settingButton.TabIndex = 1;
            this.settingButton.Text = "Settings";
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // devButton
            // 
            this.devButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devButton.Location = new System.Drawing.Point(193, 281);
            this.devButton.Name = "devButton";
            this.devButton.Size = new System.Drawing.Size(100, 40);
            this.devButton.TabIndex = 2;
            this.devButton.Text = "Developers";
            this.devButton.UseVisualStyleBackColor = true;
            this.devButton.Click += new System.EventHandler(this.devButton_Click);
            // 
            // veritasLabel
            // 
            this.veritasLabel.Font = new System.Drawing.Font("Viner Hand ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veritasLabel.Location = new System.Drawing.Point(43, 33);
            this.veritasLabel.Name = "veritasLabel";
            this.veritasLabel.Size = new System.Drawing.Size(400, 120);
            this.veritasLabel.TabIndex = 3;
            this.veritasLabel.Text = "Veritas";
            this.veritasLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VeritasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(487, 360);
            this.Controls.Add(this.veritasLabel);
            this.Controls.Add(this.devButton);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.startButtom);
            this.Name = "VeritasForm";
            this.Text = "Veritas";
            this.Load += new System.EventHandler(this.VeritasForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButtom;
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.Button devButton;
        private System.Windows.Forms.Label veritasLabel;
    }
}

