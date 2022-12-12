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
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // loginButtom
            // 
            resources.ApplyResources(this.loginButtom, "loginButtom");
            this.loginButtom.BackColor = System.Drawing.Color.Tan;
            this.loginButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButtom.Name = "loginButtom";
            this.loginButtom.UseVisualStyleBackColor = false;
            this.loginButtom.Click += new System.EventHandler(this.startButtom_Click);
            // 
            // createAccountbutton1
            // 
            resources.ApplyResources(this.createAccountbutton1, "createAccountbutton1");
            this.createAccountbutton1.BackColor = System.Drawing.Color.Tan;
            this.createAccountbutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccountbutton1.Name = "createAccountbutton1";
            this.createAccountbutton1.UseVisualStyleBackColor = false;
            this.createAccountbutton1.Click += new System.EventHandler(this.createAccountbutton1_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // usernameTextBox1
            // 
            resources.ApplyResources(this.usernameTextBox1, "usernameTextBox1");
            this.usernameTextBox1.Name = "usernameTextBox1";
            // 
            // passwordTextBox2
            // 
            resources.ApplyResources(this.passwordTextBox2, "passwordTextBox2");
            this.passwordTextBox2.Name = "passwordTextBox2";
            // 
            // forgotButton2
            // 
            resources.ApplyResources(this.forgotButton2, "forgotButton2");
            this.forgotButton2.BackColor = System.Drawing.Color.Tan;
            this.forgotButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotButton2.Name = "forgotButton2";
            this.forgotButton2.UseVisualStyleBackColor = false;
            this.forgotButton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.Controls.Add(this.forgotButton2);
            this.Controls.Add(this.passwordTextBox2);
            this.Controls.Add(this.usernameTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.createAccountbutton1);
            this.Controls.Add(this.loginButtom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
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