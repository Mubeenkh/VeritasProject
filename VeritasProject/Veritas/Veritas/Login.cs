using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veritas
{
    
    public partial class Login : Form
    {
        public static bool loginUser { get; set; } = false;
        public Login()
        {
            InitializeComponent();
            forgotButton2.Enabled = false;
        }

        private void startButtom_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox1.Text;
            string password = passwordTextBox2.Text;

            string fileName = "data\\" + $"{username}.txt";
            try
            {
                using (StreamReader reader = new StreamReader(fileName)) {
                    string line = reader.ReadLine();
                    string[] strings = line.Split(',');
                    if (strings[1]== password)
                    {
                        MessageBox.Show("You are now connected", "Yes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loginUser = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Incorect Password", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        forgotButton2.Enabled = true;
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Incorect Username", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void createAccountbutton1_Click(object sender, EventArgs e)
        {
            this.Close();
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox1.Text;
            ForgotPassword forgotPassword = new ForgotPassword(username);
            forgotPassword.Show();
            this.Close();
        }
    }
    
}
