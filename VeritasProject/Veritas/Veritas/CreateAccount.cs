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
    public partial class CreateAccount : Form
    {
        private StreamWriter fileWriter;

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox1.Text;
            string password = passwordTextBox2.Text;
            string question = questionTextBox2.Text;
            string answer = answerTextBox1.Text;

            string fileName = "data\\" + $"{username}.txt";
            try
            {
                fileWriter = new StreamWriter(fileName);
                fileWriter.WriteLine(
                            $"{username},{password}," +
                            $"{question},{answer}");

                fileWriter.Close();
                MessageBox.Show("The account has been created!", "Hell yeah",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Login login = new Login();
                login.Show();
            }
            catch (IOException)
            {
                MessageBox.Show("Error Writing to File", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Format", "Error",
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
