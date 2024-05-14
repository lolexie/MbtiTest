using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MbtiTest
{
    public partial class TestForm : Form
    {
        int[] answers = new int[20];
        QuestionBlock[] questionBlocks = new QuestionBlock[]
                        {
                new QuestionBlock(
                    new Dictionary<string, string>() {
                    { "I", "Introvert"},
                    { "E", "Extravert"},
                    },
                    new Question[]{
                        new Question("Пит 1", new string[] {"В1","В2","В3","В4"}),
                        new Question("Пит 2", new string[] { "В6", "В2", "В3", "В4"}),
                        new Question("Пит 3", new string[] { "В7", "В2", "В3", "В4"}),
                        new Question("Пит 4", new string[] { "В8", "В2", "В3", "В4"}),
                        new Question("Пит 5", new string[] { "В9", "В2", "В3", "В4"}),
                    }
                ),
                new QuestionBlock(
                    new Dictionary<string, string>() {
                    { "S", "Sensing"},
                    { "N", "Intuition"},
                    },
                    new Question[]{
                        new Question("Пит 6", new string[] {"В6","В2","В3","В4"}),
                        new Question("Пит 7", new string[] {"В1","В2","В3","В4"}),
                        new Question("Пит 8", new string[] {"В7","В2","В3","В4"}),
                        new Question("Пит 9", new string[] {"В8","В2","В3","В4"}),
                        new Question("Пит 10", new string[] {"В9","В2","В3","В4"}),
                    }
                ),
                new QuestionBlock(
                    new Dictionary<string, string>() {
                    { "T", "Thinking"},
                    { "F", "Feeling"},
                    },
                    new Question[]{
                        new Question("Пит 11", new string[] {"В1","В2","В3","В4"}),
                        new Question("Пит 12", new string[] {"В6","В2","В3","В4"}),
                        new Question("Пит 13", new string[] {"В7","В2","В3","В4"}),
                        new Question("Пит 14", new string[] {"В8","В2","В3","В4"}),
                        new Question("Пит 15", new string[] {"В9","В2","В3","В4"}),
                    }
                ),
                new QuestionBlock(
                    new Dictionary<string, string>() {
                    { "J", "Judging"},
                    { "P", "Perception"},
                    },
                    new Question[]{
                        new Question("Пит 16", new string[] {"В1","В2","В3","В4"}),
                        new Question("Пит 17", new string[] {"В6","В2","В3","В4"}),
                        new Question("Пит 18", new string[] {"В7","В2","В3","В4"}),
                        new Question("Пит 19", new string[] {"В8","В2","В3","В4"}),
                        new Question("Пит 20", new string[] {"В9","В2","В3","В4"}),
                    }
                ),
                        };
        QuestionBlock block;
        Question[] questions;
        private int currentBlock = 0;
        private int currentQuestion = 0;

        public TestForm()
        {
            InitializeComponent();
            ChangeQuestion();
        }

        private void ChangeBlock()
        {
            currentQuestion = 0;
            currentBlock++;
            ChangeQuestion();
        }

        public void ChangeQuestion()
        {
            UncheckBox();
            block = questionBlocks[currentBlock];
            questions = block.GetQuestions();
            questionTextLabel.Text = questions[currentQuestion].GetText();
            questionNumberLabel.Text = (currentQuestion + 1).ToString();
            firstAnswerLabel.Text = questions[currentQuestion].GetAnswers()[0];
            secondAnswerLabel.Text = questions[currentQuestion].GetAnswers()[1];
            thirdAnswerLabel.Text = questions[currentQuestion].GetAnswers()[2];
            fourthAnswerLabel.Text = questions[currentQuestion].GetAnswers()[3];
            CheckBox();
            UpdatePaginationButtons();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var block = questionBlocks[currentBlock];
            block.PushAnswer(GetChosenAnswerNumber(), currentQuestion);
            if (currentQuestion == block.GetQuestions().Length - 1)
            {
                if (currentBlock == questionBlocks.Length - 1)
                {
                    UpdatePaginationButtons();
                }
                else
                {
                    ChangeBlock();
                }
            }
            else
            {
                currentQuestion++;
                ChangeQuestion();
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            currentQuestion--;
            ChangeQuestion();
        }

        private int GetChosenAnswerNumber()
        {
            if (firstAnswerCheckBox.Checked)
                return 1;
            if (secondAnswerCheckBox.Checked)
                return 2;
            if (thirdAnswerCheckBox.Checked)
                return 3;
            if (fourthAnswerCheckBox.Checked)
                return 4;
            return -1;
        }

        private void UncheckBox()
        {
            foreach (CheckBox box in Controls.OfType<CheckBox>())
            {
                box.Checked = false;
            }
        }

        private void CheckBox()
        {
            switch (answers[currentQuestion])
            {
                case 1: firstAnswerCheckBox.Checked = true; break;
                case 2: secondAnswerCheckBox.Checked = true; break;
                case 3: thirdAnswerCheckBox.Checked = true; break;
                case 4: fourthAnswerCheckBox.Checked = true; break;
            }
        }

        private void UpdatePaginationButtons()
        {
            if (currentBlock == 0 && currentQuestion == 0)
            {
                previousButton.Enabled = false;
            }
            else previousButton.Enabled = true;
            if (currentBlock == questionBlocks.Length - 1 && currentQuestion == questionBlocks[currentBlock].GetQuestions().Length - 1)
            {
                nextButton.Text = "Finish";
                nextButton.Click += FinishTest;
            }
            else
            {
                nextButton.Text = "Next";
                nextButton.Enabled = true;
            }
        }

        private void FinishTest(object sender, EventArgs e)
        {
            Hide();
            ResultForm resultForm = new ResultForm(questionBlocks);
            resultForm.Show();
        }
    }
}
