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
            
        }

        private void VeritasForm_Load(object sender, EventArgs e)
        {

            musicPlayer.URL = @"Polish Cow Full Version.wav";
            musicPlayer.settings.playCount = 9999;
            //musicPlayer.Ctlcontrols.stop();
            musicPlayer.Visible = false;
            musicPlayer.Ctlcontrols.play();
            musicPlayer.settings.volume = 50;
            //settingsDialog;
        }

        private void startButtom_Click(object sender, EventArgs e)
        {
            clickSound.Stop();
            clickSound.Play();
            CategoryForm categoryForm = new CategoryForm();
            Current.Hide();
            categoryForm.Show();
            
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            clickSound.Stop();
            clickSound.Play();
            settingsDialog.ShowDialog();

            //if (settingsDialog.ShowDialog() == DialogResult.OK)
            //{
                musicPlayer.settings.volume = settingsDialog.ValueVol * 10;
            //}
            //MessageBox.Show("Idk whats the point of this it was Mert and Leonellas idea");
        }

        private void devButton_Click(object sender, EventArgs e)
        {
            clickSound.Stop();
            clickSound.Play();

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

        private void musicPlayer_Enter(object sender, EventArgs e)
        {

        }
    }
}
