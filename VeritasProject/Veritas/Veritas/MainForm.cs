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

namespace Veritas
{
    public partial class VeritasForm : Form
    {
        public static VeritasForm Current {get; set;}
        SoundPlayer clickSound = new SoundPlayer(@"clickSound.wav");
        SettingsDialog settingsDialog = new SettingsDialog();
        public VeritasForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Current = this;
            clickSound = new SoundPlayer(@"clickSound.wav");

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

            var text = "Just Mubeen(me) For Now, nahhh and me too";
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
    }
}
