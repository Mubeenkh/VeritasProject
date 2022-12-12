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
    public partial class ViewAddForm : Form
    {

        String filePathName = "";

        public ViewAddForm()
        {
            InitializeComponent();
            readButton.Enabled = true;
            writeButton.Enabled = false;
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(Path.GetFullPath("" + filePathName + "")))
            {
                string readText = sr.ReadToEnd();
                fileRichTextBox.Text = readText;
            }

            if (fileRichTextBox.Text == "")
            {
                writeButton.Enabled = false;
            }
            else
            {
                writeButton.Enabled = true;
            }
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(Path.GetFullPath("" + filePathName + "")))
            {
                string addText = fileRichTextBox.Text;
                sw.Write(addText);

            }
        }


        public void getFilePath(String path)
        {
            filePathName = path;
            filePathTextBox.Text = path;
        }

    }
}
