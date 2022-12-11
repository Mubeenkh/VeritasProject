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

            if (VeritasForm.Current.musicPlayer.settings.volume > 0)
            {
                musicToolStripMenuItem.Checked = true;
            }

            opacityTimer.Start();
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
            MathQuestionForm mathQuestionForm = new MathQuestionForm();
            this.Close();
            mathQuestionForm.Show();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            HistoryQuestionForm historyQuestionForm = new HistoryQuestionForm();
            this.Close();
            historyQuestionForm.Show();
        }

        private void EnglishButton_Click(object sender, EventArgs e)
        {
            EnglishQuestionForm englishQuestionForm = new EnglishQuestionForm();
            this.Close();
            englishQuestionForm.Show();
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

        //---------------------- Mubeen ----------------------//

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();
            changeLanguage.UpdateConfig("language", "en");
            Application.Restart();
        }

        private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var changeLanguage = new ChangeLanguage();
            changeLanguage.UpdateConfig("language", "fr-CA");
            Application.Restart();
        }

        private void spanishToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var changeLanguage = new ChangeLanguage();
            changeLanguage.UpdateConfig("language", "es");
            Application.Restart();
        }

        private void opacityTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
                opacityTimer.Stop();

            Opacity += .1;
        }
    }
}
