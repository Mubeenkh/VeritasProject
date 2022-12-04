using System;
using System.Collections;
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
    public partial class SettingsDialog : Form
    {
        public bool Sound { get; set; } = true;
        private ArrayList songs = new ArrayList() 
        {@"I m a barbie girl.wav", @"Polish Cow Full Version.wav" };

        public SettingsDialog()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private void volumeValue(object sender, EventArgs e)
        {
            VeritasForm.Current.musicPlayer.settings.volume = musicVolume.Value * 10;           
        }

        private void checkSound(object sender, EventArgs e)
        {
            Sound = !Sound;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            VeritasForm.Current.musicPlayer.URL = (string)songs[rnd.Next(0,2)];
        }
    }
}
