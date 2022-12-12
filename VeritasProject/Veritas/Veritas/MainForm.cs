using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Veritas
{
    public partial class VeritasForm : Form
    {
        public static VeritasForm Current {get; set;}
        SoundPlayer clickSound = new SoundPlayer(@"clickSound.wav");
        SettingsDialog settingsDialog = new SettingsDialog();

        //Setting up the the Main Page Animation --------------------------------------------------------------- Mert
        int titleCounter = 0;
        int titleLength = 0;
        string titleText;

        int titleCounter2 = 0;
        int titleLength2 = 0;
        string titleText2;

        int isTranslated = 0;

        public VeritasForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Current = this;
            clickSound = new SoundPlayer(@"clickSound.wav");
            
            //Title Animation ----------------------------------------------------------------------------------- Mert
            titleText = veritasLabel.Text;  //The Normal Font
            titleLength = titleText.Length;

            titleText2 = veritasLabel.Text;  //The Symbolised Font
            titleLength2 = titleText2.Length;
            veritasLabel.Text = "";

            timer1.Interval= 1000;
            timer1.Start(); //Starting the timer
            
            opacityTimer.Start();

            Login login = new Login();
            login.Show();
        }

        private void VeritasForm_Load(object sender, EventArgs e)
        {
            musicPlayer.URL = @"Polish Cow Full Version.wav";
            musicPlayer.settings.playCount = 9999;
            musicPlayer.Visible = false;
            musicPlayer.Ctlcontrols.play();
            musicPlayer.settings.volume = 50;
        }

        private void startButtom_Click(object sender, EventArgs e)
        {
            if (settingsDialog.Sound)
            {
                clickSound.Play();
            }
            CategoryForm categoryForm = new CategoryForm();
            Current.Hide();
            categoryForm.Show();
            
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            if (settingsDialog.Sound)
            {
                clickSound.Play();
            }
            settingsDialog.ShowDialog();
        }

        private void devButton_Click(object sender, EventArgs e)
        {
            if (settingsDialog.Sound)
            {
                clickSound.Play();
            }

            var text = "Mubeen Khan, Leonella Martel Levy, Mert Kairstan Salvador";
            MessageBox.Show(text, "Developers", MessageBoxButtons.OK,
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


        //Setting The time for animating the title screen ----------------------------------------------------- Mert
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isTranslated == 0)
            {
                veritasLabel.Font = new Font("Wingdings 3", veritasLabel.Font.Size, veritasLabel.Font.Style);
                veritasLabel.Text = titleText2.Substring(0, titleCounter2);
                ++titleCounter2;

                if (titleCounter2 > titleLength2)
                {
                    titleCounter2 = 0;
                    isTranslated = 1;
                }
            }
            else
            {
                veritasLabel.Font = new Font("Tw Cen MT", veritasLabel.Font.Size, veritasLabel.Font.Style);
                veritasLabel.Text = titleText.Substring(0, titleCounter);
                ++titleCounter;

                if (titleCounter > titleLength)
                {
                    titleCounter = 0;
                    isTranslated = 0;
                }
            }
        }

        //On load animation
        private void opacityTimer_Tick(object sender, EventArgs e)
        {
            if(Opacity == 1)
                opacityTimer.Stop();

            Opacity += .1;
        }

        //Hover Animations --------------------------------------------------------------------------------------- Mert
        private void startButtom_MouseHover(object sender, EventArgs e)
        {
            clearColor();
            clearBackground();

            startButtom.BackgroundImage = (Image)Properties.Resources.start;
            startButtom.ForeColor = Color.White;
        }

        private void settingButton_MouseHover(object sender, EventArgs e)
        {
            clearColor();
            clearBackground();

            settingButton.BackgroundImage = (Image)Properties.Resources.settings;
            settingButton.ForeColor = Color.White;
        }

        private void devButton_MouseHover(object sender, EventArgs e)
        {
            clearColor();
            clearBackground();

            devButton.BackgroundImage = (Image) Properties.Resources.coders;
            devButton.ForeColor = Color.White;
        }

        private void ExitButton_MouseHover(object sender, EventArgs e)
        {
            clearColor();
            clearBackground();

            ExitButton.BackgroundImage = (Image)Properties.Resources.exit;
            ExitButton.ForeColor = Color.White;
        }

        private void VeritasForm_MouseHover(object sender, EventArgs e)
        {
            clearColor();
            clearBackground();
        }

        public void clearColor()
        {
            startButtom.ForeColor = Color.Black;
            settingButton.ForeColor = Color.Black;
            devButton.ForeColor = Color.Black;
            ExitButton.ForeColor = Color.Black;
        }

        public void clearBackground()
        {
            startButtom.BackgroundImage = base.BackgroundImage;
            settingButton.BackgroundImage = base.BackgroundImage;
            devButton.BackgroundImage = base.BackgroundImage;
            ExitButton.BackgroundImage = base.BackgroundImage;
        }

        //---------------------- Mubeen ----------------------//
        private void uncheckLanguages()
        {
            englishToolStripMenuItem.Checked = false;
            frenchToolStripMenuItem.Checked = false;
            spanishToolStripMenuItem.Checked = false;
        }
        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uncheckLanguages();
            englishToolStripMenuItem.Checked = true;
            var changeLanguage = new ChangeLanguage();
            changeLanguage.UpdateConfig("language", "en");
            Application.Restart();
            
        }

        private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uncheckLanguages();
            frenchToolStripMenuItem.Checked = true;
            var changeLanguage = new ChangeLanguage();
            changeLanguage.UpdateConfig("language", "fr-CA");
            Application.Restart();
            
        }

        private void spanishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uncheckLanguages();
            spanishToolStripMenuItem.Checked = true;
            var changeLanguage = new ChangeLanguage();
            changeLanguage.UpdateConfig("language", "es");
            Application.Restart();
            
        }
    }
}
