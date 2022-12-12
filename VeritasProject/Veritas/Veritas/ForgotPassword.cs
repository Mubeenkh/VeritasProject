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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Veritas
{
    public partial class ForgotPassword : Form
    {
        private string usernameCurrent;
        public ForgotPassword(string username)
        {
            InitializeComponent();
            usernameCurrent = username;
            searchQuestion();
            passwordTextBox2.Enabled = false;
        }

        public void searchQuestion()
        {
            string fileName = "data\\" + $"{usernameCurrent}.txt";
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line = reader.ReadLine();
                    string[] strings = line.Split(',');
                    usernameTextBox1.Text = strings[0];
                    questionTextBox2.Text = strings[2];

                }
            }
            catch (IOException)
            {
                MessageBox.Show("A problem occur that is not supposed to", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createButton2_Click(object sender, EventArgs e)
        {
            string fileName = "data\\" + $"{usernameCurrent}.txt";
            string answer = answerTextBox1.Text;
            string newFile;

            try
            {
                
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line = reader.ReadLine();
                    string[] strings = line.Split(',');
                    newFile = $"{strings[0]},{passwordTextBox2.Text},{strings[2]},{strings[3]}";
                        
                        
                }
                using (StreamWriter fileWriter = new StreamWriter(fileName))
                {
                    fileWriter.Write(newFile);
                    fileWriter.Close();
                    MessageBox.Show("Your password has been modify", "Good",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login login = new Login();
                    login.Show();
                    this.Close();
                }
            }
            catch (IOException)
            {
                MessageBox.Show("A problem occur that is not supposed to", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fileName = "data\\" + $"{usernameCurrent}.txt";
            string answer = answerTextBox1.Text;
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line = reader.ReadLine();
                    string[] strings = line.Split(',');
                    if (strings[3] == answer)
                    {
                        MessageBox.Show("You can now modify your password", "Good",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        passwordTextBox2.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Incorect Answer", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("A problem occur that is not supposed to" +fileName, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
