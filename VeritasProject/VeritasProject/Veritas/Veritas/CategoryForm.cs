using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veritas
{
    public partial class CategoryForm : Form
    {
        
        public CategoryForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ExitCatButton_Click(object sender, EventArgs e)
        {

            //VeritasForm veritasForm = new VeritasForm();
            //veritasForm.Show();
            VeritasForm.Current.Show();
            this.Close();
            
        }

        private void mathButton_Click(object sender, EventArgs e)
        {

        }

        private void historyButton_Click(object sender, EventArgs e)
        {

        }

        private void EnglishButton_Click(object sender, EventArgs e)
        {

        }

        private void programmingButton_Click(object sender, EventArgs e)
        {
            ProgQuestionForm progQuestionForm = new ProgQuestionForm();
            this.Close();
            //this.Hide();
            progQuestionForm.Show();

        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
