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
    public partial class EnglishQuestionForm : Form
    {
        public EnglishQuestionForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            if (VeritasForm.Current.musicPlayer.settings.volume > 0)
            {
                musicToolStripMenuItem.Checked = true;
            }
        }
        private void musicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (musicToolStripMenuItem.Checked)
            {
                VeritasForm.Current.musicPlayer.settings.volume = 0;
            }
            else if (!musicToolStripMenuItem.Checked)
            {
                VeritasForm.Current.musicPlayer.settings.volume = 50;
            }
            musicToolStripMenuItem.Checked = !musicToolStripMenuItem.Checked;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }

        

        private void backToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
