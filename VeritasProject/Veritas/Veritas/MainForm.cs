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
    public partial class VeritasForm : Form
    {
        
        public VeritasForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void VeritasForm_Load(object sender, EventArgs e)
        {

        }

        private void startButtom_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            this.Hide();
            categoryForm.Show();
            
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Idk whats the point of this it was Mert and Leonellas idea");
        }

        private void devButton_Click(object sender, EventArgs e)
        {
            var text = "Just Mubeen(me) For Now";
            MessageBox.Show(text, "Developers",MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            
        }

        private void fullExitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
