using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Veritas
{
    public partial class MathQuestionForm : Form
    {
        int rightAnswer = 0;
        int currentQuestion = 0;
        int totalQuestions = 0;
        int tagNum = 0;
        int point = 0;

        public MathQuestionForm()
        {
            InitializeComponent();
            //this.StartPosition = FormStartPosition.CenterScreen;

            trivia(currentQuestion);

            totalQuestions = getNumberOfQuestions();

            if (VeritasForm.Current.musicPlayer.settings.volume > 0)
            {
                musicToolStripMenuItem.Checked = true;
            }

            pointLabel.Text = $"Point: {point}/{totalQuestions}";

            MessageBox.Show("Language: " + getSystemLanguage());
        }

        //Checks whats language the Game is currently set to
        public String getSystemLanguage()
        {
            String SystemLanguage = "";

            var xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement xmlElement in xmlDoc.DocumentElement)
            {
                if (xmlElement.Name.Equals("appSettings"))
                {
                    foreach (XmlNode xNode in xmlElement.ChildNodes)
                    {
                        if (xNode.Attributes[0].Value.Equals("language"))
                        {
                            SystemLanguage = xNode.Attributes[1].Value + "";
                        }
                    }
                }
            }
            return SystemLanguage;
        }

        //Gets Size of the ArrayList so we can know how many Questions we will have
        public int getNumberOfQuestions()
        {
            int numberOfQuestions = 0;
            List<Questions> jsonQuestions = new List<Questions>();

            using (StreamReader sr = new StreamReader(Path.GetFullPath("..\\..\\MathQuestions_" + getSystemLanguage() + ".json")))
            {
                string json = sr.ReadToEnd();
                jsonQuestions = JsonConvert.DeserializeObject<List<Questions>>(json);
            }

            numberOfQuestions = jsonQuestions.Count;
            return numberOfQuestions;
        }

        //Checks which RadioButton is "Checked" using their Tag Number
        private void checkedAnswerEvent(object sender, EventArgs e)
        {
            //the tag is a string so its better to convert it int
            var senderObject = (RadioButton)sender;
            tagNum = Convert.ToInt32(senderObject.Tag);

        }

        public String getEndMessage()
        {
            String message = "";

            if (getSystemLanguage() == "en")
            {
                message = "Congratulations you finished the Quiz";
            }

            if (getSystemLanguage() == "fr-CA")
            {
                message = "Félicitations, vous avez terminé le quiz";
            }

            if (getSystemLanguage() == "es")
            {
                message = "Felicidades has terminado el Quiz";
            }

            return message;
        }

        async private void submitButton_Click(object sender, EventArgs e)
        {
            if (tagNum == rightAnswer)
            {

                //point systems
                point++;
                pointLabel.Text = $"Point: {point}/{totalQuestions}";

                currentQuestion++;

                uncheckingRadioButtons();
                trivia(currentQuestion);

            }
            else
            {
                uncheckingRadioButtons();

                pointLabel.Text = $"Point: {point}/{totalQuestions}";

                currentQuestion++;
                trivia(currentQuestion);
            }

            if (currentQuestion == totalQuestions)
            {

                uncheckingRadioButtons();

                questionLabel.Text = getEndMessage();

                submitButton.Enabled = false;
                await Task.Delay(500); //resets everything after 3 seconds

                resetTrivia();
                currentQuestion = 0;
                pointLabel.Text = $"Point: {point}/{totalQuestions}";

                Thread.Sleep(2000);
                pointLabel.Text = $"Point: {0}/{totalQuestions}";

                submitButton.Enabled = true;
            }
        }

        public void resetTrivia()
        {
            int reset = 0;
            trivia(reset);

            this.point = 0;
            //endLabel.Text = "";
        }

        public void uncheckingRadioButtons()
        {
            firstRadioButton.Checked = false;
            secondRadioButton.Checked = false;
            thirdRadioButton.Checked = false;
            fourthRadioButton.Checked = false;
        }

        private void trivia(int questionNumber)
        {
            List<Questions> jsonQuestions = new List<Questions>();

            using (StreamReader sr = new StreamReader(Path.GetFullPath("..\\..\\MathQuestions_" + getSystemLanguage() + ".json")))
            {
                string json = sr.ReadToEnd();
                jsonQuestions = JsonConvert.DeserializeObject<List<Questions>>(json);
            }

            if (questionNumber <= getNumberOfQuestions() - 1)
            {
                questionLabel.Text = jsonQuestions[questionNumber].Quiz;
                firstRadioButton.Text = jsonQuestions[questionNumber].TagOne;   //tag 1
                secondRadioButton.Text = jsonQuestions[questionNumber].TagTwo;       //tag 2   
                thirdRadioButton.Text = jsonQuestions[questionNumber].TagTree;       //tag 3
                fourthRadioButton.Text = jsonQuestions[questionNumber].TagFour; //tag 4

                rightAnswer = jsonQuestions[questionNumber].AnswerTag; //rightAnswer should be the same number as the radioButton Tag

            }
            else
            {
                questionNumber = 0;
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

        private void backToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
