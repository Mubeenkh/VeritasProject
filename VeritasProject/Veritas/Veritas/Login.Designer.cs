namespace Veritas
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginButtom = new System.Windows.Forms.Button();
            this.createAccountbutton1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usernameTextBox1 = new System.Windows.Forms.TextBox();
            this.passwordTextBox2 = new System.Windows.Forms.TextBox();
            this.forgotButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 36F);
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16F);
            this.label2.Location = new System.Drawing.Point(98, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please login to have all the access";
            // 
            // loginButtom
            // 
            this.loginButtom.BackColor = System.Drawing.Color.Tan;
            this.loginButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButtom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButtom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.loginButtom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginButtom.Location = new System.Drawing.Point(104, 275);
            this.loginButtom.Margin = new System.Windows.Forms.Padding(0);
            this.loginButtom.Name = "loginButtom";
            this.loginButtom.Size = new System.Drawing.Size(319, 44);
            this.loginButtom.TabIndex = 2;
            this.loginButtom.Text = "Login";
            this.loginButtom.UseVisualStyleBackColor = false;
            this.loginButtom.Click += new System.EventHandler(this.startButtom_Click);
            // 
            // createAccountbutton1
            // 
            this.createAccountbutton1.BackColor = System.Drawing.Color.Tan;
            this.createAccountbutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccountbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccountbutton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.createAccountbutton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.createAccountbutton1.Location = new System.Drawing.Point(104, 335);
            this.createAccountbutton1.Margin = new System.Windows.Forms.Padding(0);
            this.createAccountbutton1.Name = "createAccountbutton1";
            this.createAccountbutton1.Size = new System.Drawing.Size(319, 47);
            this.createAccountbutton1.TabIndex = 3;
            this.createAccountbutton1.Text = "Create account";
            this.createAccountbutton1.UseVisualStyleBackColor = false;
            this.createAccountbutton1.Click += new System.EventHandler(this.createAccountbutton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16F);
            this.label3.Location = new System.Drawing.Point(26, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16F);
            this.label4.Location = new System.Drawing.Point(31, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password:";
            // 
            // usernameTextBox1
            // 
            this.usernameTextBox1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16F);
            this.usernameTextBox1.Location = new System.Drawing.Point(156, 154);
            this.usernameTextBox1.Name = "usernameTextBox1";
            this.usernameTextBox1.Size = new System.Drawing.Size(337, 36);
            this.usernameTextBox1.TabIndex = 6;
            // 
            // passwordTextBox2
            // 
            this.passwordTextBox2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16F);
            this.passwordTextBox2.Location = new System.Drawing.Point(156, 212);
            this.passwordTextBox2.Name = "passwordTextBox2";
            this.passwordTextBox2.PasswordChar = '●';
            this.passwordTextBox2.Size = new System.Drawing.Size(337, 36);
            this.passwordTextBox2.TabIndex = 7;
            // 
            // forgotButton2
            // 
            this.forgotButton2.BackColor = System.Drawing.Color.Tan;
            this.forgotButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgotButton2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.forgotButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.forgotButton2.Location = new System.Drawing.Point(104, 397);
            this.forgotButton2.Margin = new System.Windows.Forms.Padding(0);
            this.forgotButton2.Name = "forgotButton2";
            this.forgotButton2.Size = new System.Drawing.Size(319, 47);
            this.forgotButton2.TabIndex = 8;
            this.forgotButton2.Text = "Password Forgot";
            this.forgotButton2.UseVisualStyleBackColor = false;
            this.forgotButton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(525, 476);
            this.Controls.Add(this.forgotButton2);
            this.Controls.Add(this.passwordTextBox2);
            this.Controls.Add(this.usernameTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createAccountbutton1);
            this.Controls.Add(this.loginButtom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginButtom;
        private System.Windows.Forms.Button createAccountbutton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernameTextBox1;
        private System.Windows.Forms.TextBox passwordTextBox2;
        private System.Windows.Forms.Button forgotButton2;
    }
}