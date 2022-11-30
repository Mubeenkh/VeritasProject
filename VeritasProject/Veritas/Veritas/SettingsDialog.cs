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
    public partial class SettingsDialog : Form
    {
        public int ValueVol { get; set; }

        public SettingsDialog()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SettingsDialog_Load(object sender, EventArgs e)
        {

        }

        private void submitSettings_Click(object sender, EventArgs e)
        {
            ValueVol = musicVolume.Value;
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void volumeValue(object sender, EventArgs e)
        {
            submitSettings.Text = "Modify";
        }
    }
}
