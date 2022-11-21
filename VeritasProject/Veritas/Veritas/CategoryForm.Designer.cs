namespace Veritas
{
    partial class CategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
            this.mathButton = new System.Windows.Forms.Button();
            this.EnglishButton = new System.Windows.Forms.Button();
            this.programmingButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.ExitCatButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mathButton
            // 
            this.mathButton.BackColor = System.Drawing.Color.Coral;
            this.mathButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mathButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mathButton.Location = new System.Drawing.Point(164, 93);
            this.mathButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mathButton.Name = "mathButton";
            this.mathButton.Size = new System.Drawing.Size(120, 42);
            this.mathButton.TabIndex = 0;
            this.mathButton.Text = "Math";
            this.mathButton.UseVisualStyleBackColor = false;
            this.mathButton.Click += new System.EventHandler(this.mathButton_Click);
            // 
            // EnglishButton
            // 
            this.EnglishButton.BackColor = System.Drawing.Color.Coral;
            this.EnglishButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnglishButton.Location = new System.Drawing.Point(164, 166);
            this.EnglishButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EnglishButton.Name = "EnglishButton";
            this.EnglishButton.Size = new System.Drawing.Size(120, 42);
            this.EnglishButton.TabIndex = 1;
            this.EnglishButton.Text = "English";
            this.EnglishButton.UseVisualStyleBackColor = false;
            this.EnglishButton.Click += new System.EventHandler(this.EnglishButton_Click);
            // 
            // programmingButton
            // 
            this.programmingButton.BackColor = System.Drawing.Color.Coral;
            this.programmingButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programmingButton.Location = new System.Drawing.Point(297, 166);
            this.programmingButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.programmingButton.Name = "programmingButton";
            this.programmingButton.Size = new System.Drawing.Size(119, 42);
            this.programmingButton.TabIndex = 2;
            this.programmingButton.Text = "Programming";
            this.programmingButton.UseVisualStyleBackColor = false;
            this.programmingButton.Click += new System.EventHandler(this.programmingButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.BackColor = System.Drawing.Color.Coral;
            this.historyButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyButton.Location = new System.Drawing.Point(297, 93);
            this.historyButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(120, 42);
            this.historyButton.TabIndex = 3;
            this.historyButton.Text = "History";
            this.historyButton.UseVisualStyleBackColor = false;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // ExitCatButton
            // 
            this.ExitCatButton.BackColor = System.Drawing.Color.OrangeRed;
            this.ExitCatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitCatButton.Location = new System.Drawing.Point(224, 224);
            this.ExitCatButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitCatButton.Name = "ExitCatButton";
            this.ExitCatButton.Size = new System.Drawing.Size(132, 41);
            this.ExitCatButton.TabIndex = 4;
            this.ExitCatButton.Text = "Back to main page";
            this.ExitCatButton.UseVisualStyleBackColor = false;
            this.ExitCatButton.Click += new System.EventHandler(this.ExitCatButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(542, 0);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(38, 22);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Viner Hand ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(86, 11);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(408, 78);
            this.categoryLabel.TabIndex = 14;
            this.categoryLabel.Text = "Pick the Subject";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(580, 356);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ExitCatButton);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.programmingButton);
            this.Controls.Add(this.EnglishButton);
            this.Controls.Add(this.mathButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mathButton;
        private System.Windows.Forms.Button EnglishButton;
        private System.Windows.Forms.Button programmingButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button ExitCatButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label categoryLabel;
    }
}