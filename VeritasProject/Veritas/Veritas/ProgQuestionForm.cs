using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Veritas
{
    public partial class ProgQuestionForm : Form
    {
        int rightAnswer = 0;
        int currentQuestion = 0;
        int totalQuestions = 0;
        int tagNum = 0;
        int point = 0;

        public ProgQuestionForm()
        {
            InitializeComponent();
            //this.StartPosition = FormStartPosition.CenterScreen;

            trivia(currentQuestion);

            //totalQuestions = 2;
            totalQuestions = getNumberOfQuestions();

            if (VeritasForm.Current.musicPlayer.settings.volume > 0)
            {
                musicToolStripMenuItem.Checked = true;
            }

            pointLabel.Text = $"Point: {point}/{totalQuestions}";

            MessageBox.Show("Language: " + getSystemLanguage());

        }

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

        public int getNumberOfQuestions()
        {
            int numberOfQuestions = 0;
            List<Questions> jsonQuestions = new List<Questions>();

            //if(getSystemLanguage() == "en")
            //{
                using (StreamReader sr = new StreamReader(Path.GetFullPath("..\\..\\ProgQuestions_" + getSystemLanguage() + ".json")))
                {
                    string json = sr.ReadToEnd();
                    jsonQuestions = JsonConvert.DeserializeObject<List<Questions>>(json);

                }

            //}
            //if( getSystemLanguage() == "es")
            //{
            //    using (StreamReader sr = new StreamReader(Path.GetFullPath("..\\..\\ProgQuestions_" + getSystemLanguage() + ".json")))
            //    {
            //        string json = sr.ReadToEnd();
            //        jsonQuestions = JsonConvert.DeserializeObject<List<Questions>>(json);

            //    }
            //}
            //if( getSystemLanguage() == "fr-CA")
            //{
            //    using (StreamReader sr = new StreamReader(Path.GetFullPath("..\\..\\ProgQuestions_" + getSystemLanguage() + ".json")))
            //    {
            //        string json = sr.ReadToEnd();
            //        jsonQuestions = JsonConvert.DeserializeObject<List<Questions>>(json);
            //    }
            //}
            
            numberOfQuestions = jsonQuestions.Count;

            return numberOfQuestions;
        }

        private void checkedAnswerEvent(object sender, EventArgs e)
        {
            //checks which radio button was clicked and gets the tag that was placed on it
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

        private async void submitButton_Click(object sender, EventArgs e)
        {
            //------------------------------------------------------------------------------------------ Mert
            //Reset Timer on Click
            timerLimit = 60;

            //MessageBox.Show("tagNumber: " + tagNum + "  , RightAnswer: " + rightAnswer);

            //---------------------- Mubeen ----------------------//
            if (tagNum == rightAnswer)
            {
                //------------------------------------------------------------------------------------------ Mert
                //Animate the if Answer is Right
                isAnswerCorrect = true;
                animateAnswer.Start();

                //---------------------- Mubeen ----------------------//
                uncheckingRadioButtons();
                //point systems
                point++;

                pointLabel.Text = $"Point: {point}/{totalQuestions}";

                //MessageBox.Show("tagNumber: " + tagNum + "  , RightAnswer: " + rightAnswer + "\nIF Right Answer Clicked: " + point +
                //                 "Current Question: " + currentQuestion);
                currentQuestion++;

                
                trivia(currentQuestion);

            }
            else
            {
                //------------------------------------------------------------------------------------------ Mert
                isAnswerCorrect = false;
                animateAnswer.Start();

                //---------------------- Mubeen ----------------------//
                uncheckingRadioButtons();

                pointLabel.Text = $"Point: {point}/{totalQuestions}";

                //MessageBox.Show("tagNumber: " + tagNum + "  , RightAnswer: " + rightAnswer + "\nELSE Right Answer Clicked: " + point +
                //                 "Current Question: " + currentQuestion);

                currentQuestion++;
                trivia(currentQuestion);
            }
            if (currentQuestion == totalQuestions)
            {
                //---------------------------------------------------------------------------------------------------- Mert
                //Stop the Timer if Player has finished answering all questions and Reset timer back to 60 secs
                timeLimit.Stop();
                timerLimit = 60;

                //---------------------- Mubeen ----------------------//
                uncheckingRadioButtons();

                questionLabel.Text = getEndMessage();

                submitButton.Enabled = false;
                await Task.Delay(500); //resets everything after 3 seconds

                resetTrivia();
                currentQuestion = 0;
                pointLabel.Text = $"Point: {0}/{totalQuestions}";

                Thread.Sleep(2000);
                submitButton.Enabled = true;
            }

        }
        public void resetTrivia()
        {
            int reset = 0;
            trivia(reset);

            this.point = 0;
            //endLabel.Text = "";
            //MessageBox.Show("reset Right Answer Clicked: " + point);

            //---------------------------------------------------------------------------------------------------- Mert
            //Restarting the timer
            timeLimit.Start();
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

            using (StreamReader sr = new StreamReader(Path.GetFullPath("..\\..\\ProgQuestions_" + getSystemLanguage() + ".json")))
            {
                string json = sr.ReadToEnd();
                jsonQuestions = JsonConvert.DeserializeObject<List<Questions>>(json);
            }

            //int i = questionNumber;
            
            if (questionNumber <= getNumberOfQuestions() - 1)
            {
                questionLabel.Text = jsonQuestions[questionNumber].Quiz;
                firstRadioButton.Text = jsonQuestions[questionNumber].TagOne;   //tag 1
                secondRadioButton.Text = jsonQuestions[questionNumber].TagTwo;       //tag 2   
                thirdRadioButton.Text = jsonQuestions[questionNumber].TagTree;       //tag 3
                fourthRadioButton.Text = jsonQuestions[questionNumber].TagFour; //tag 4
                                                                                
                rightAnswer = jsonQuestions[questionNumber].AnswerTag; //rightAnswer should be the same number as the radioButton Tag
                //rightAnswer = jsonQuestions[i].AnswerTag;
                //MessageBox.Show("Count= " + i);

            }
            else
            {
                questionNumber = 0;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
            this.Close();

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void clickSound(object sender, EventArgs e)
        {

        }

        private void soundToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ProgQuestionForm_Load(object sender, EventArgs e)
        {

        }

        private void endLabel_Click(object sender, EventArgs e)
        {

        }

        private void pointLabel_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void backToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //---------------------------------------------------------------------------------------------------------- Mert
        //Breathing animation
        //Right or Wrong Answers Animation Setup
        int animateAnswerLength = 2;
        Boolean isAnswerCorrect = false;
        int timerLimit = 60;

        private void timeLimit_Tick(object sender, EventArgs e)
        {
            timeLeftLabel.Text = "Time: " + timerLimit-- + " Seconds";
            if (timerLimit == 0)
            {
                isAnswerCorrect = false;
                animateAnswer.Start();

                //Move to the next question Setup
                currentQuestion++;

                //Uncheck the radio buttons
                uncheckingRadioButtons();
                trivia(currentQuestion);

                //Reset timer on Next Question
                timerLimit = 60;
            }
        }

        private void animateAnswer_Tick(object sender, EventArgs e)
        {
            animateAnswerLength--;

            //Animate per 1 seconds Tick and animate based on timer
            if (isAnswerCorrect && animateAnswerLength % 2 == 1)
            {
                this.BackColor = Color.DarkGreen;
            }
            else if (!isAnswerCorrect && animateAnswerLength % 2 == 1)
            {
                this.BackColor = Color.IndianRed;
            }
            if (animateAnswerLength == 0)
            {
                this.BackColor = Color.Bisque;
            }

            //Stop timer animation after 2 seconds
            if (animateAnswerLength == 0)
            {
                //Stop the timer
                animateAnswer.Stop();

                //Reset the animation length back to 2 seconds
                animateAnswerLength = 2;
            }
        }
    }
}
