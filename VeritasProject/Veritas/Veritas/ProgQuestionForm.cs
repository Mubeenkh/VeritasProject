using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veritas
{
    public partial class ProgQuestionForm : Form
    {
        int rightAnswer;
        int currentQuestion = 1;
        int totalQuestions;
        int tagNum;
        int point = 0;
        
        public ProgQuestionForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            trivia(currentQuestion);
            totalQuestions = 2;
            if (VeritasForm.Current.musicPlayer.settings.volume > 0)
            {
                musicToolStripMenuItem.Checked = true;
            }

        }

        private void checkedAnswerEvent(object sender, EventArgs e)
        {
            //checks which radio button was clicked and gets the tag that was placed on it
            //the tag is a string so its better to convert it int
            var senderObject = (RadioButton)sender;
            tagNum = Convert.ToInt32(senderObject.Tag);

        }

        private async void submitButton_Click(object sender, EventArgs e)
        {
            
            if(tagNum == rightAnswer )
            {
                //point systems
                point++;
                pointLabel.Text = $"Point: {point}/{totalQuestions}";
                uncheckingRadioButtons();

            }

            if(currentQuestion == totalQuestions)
            {
                //MessageBox.Show("Weeee, you may restart or click back to return to the category page" 
                //+ $"\nPoints: {point}/{totalQuestions}");
                uncheckingRadioButtons();
                pointLabel.Text = $"Point: {point}/{totalQuestions}";

                //endLabel.Text = "Weeee, you may restart or click back to return to the category page";

                questionLabel.Text = "Weeee!!! the Game will restart by itself, " +
                                     "you can click Back to return to the Category page";

                
                await Task.Delay(1000); //resets everything after 3 seconds
                //Thread.Sleep(3000);
                resetTrivia();
            }

            uncheckingRadioButtons();

            pointLabel.Text = $"Point: {point}/{totalQuestions}";
            currentQuestion++;
            trivia(currentQuestion); 
            
        }
        public void resetTrivia()
        {
            currentQuestion = 0;
            trivia(currentQuestion);
            point = 0;
            endLabel.Text = "";
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
            switch (questionNumber)
            {
                case 1:

                    questionLabel.Text = "What it 1 + 1";

                    firstRadioButton.Text = "100000";   //tag 1
                    secondRadioButton.Text = "2";       //tag 2   
                    thirdRadioButton.Text = "-2";       //tag 3
                    fourthRadioButton.Text = "The amount of brain cells left"; //tag 4

                    //rightAnswer should be the same number as the radioButton Tag
                    rightAnswer = 4;

                    break;

                case 2:
                    questionLabel.Text = "Who's Merts favorite student?";

                    firstRadioButton.Text = "Mubeen";     //tag 1
                    secondRadioButton.Text = "Mert";    //tag 2
                    thirdRadioButton.Text = "Leonella";    //tag 3
                    fourthRadioButton.Text = "Valentin"; //tag 4

                    //rightAnswer should be the same number as the radioButton Tag
                    rightAnswer = 2;

                    break;
                //add more cases for more questions
                //when you add more questions you will also have to increase the total number of questions
                
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
    }
}
