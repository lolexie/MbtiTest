using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MbtiTest
{
    public partial class TestForm : Form
    {
        int[] answers = new int[20];
        QuestionBlock[] QuestionBlocks = new QuestionBlock[]
                        {
                new QuestionBlock(
                    new Dictionary<string, string>() {
                    { "I", "Introvert"},
                    { "E", "Extravert"},
                    },
                    new Question[]{
                        new Question("Пит 1", new string[] {"В1","В2","В3","В4","В5",}),
                        new Question("Пит 2", new string[] { "В6", "В2", "В3", "В4", "В5", }),
                        new Question("Пит 3", new string[] { "В7", "В2", "В3", "В4", "В5", }),
                        new Question("Пит 4", new string[] { "В8", "В2", "В3", "В4", "В5", }),
                        new Question("Пит 5", new string[] { "В9", "В2", "В3", "В4", "В5", }),
                    }
                ),
                new QuestionBlock(
                    new Dictionary<string, string>() {
                    { "S", "Sensoric"},
                    { "N", "Intuitic"},
                    },
                    new Question[]{
                        new Question("Пит 6", new string[] {"В1","В2","В3","В4","В5",}),
                        new Question("Пит 7", new string[] {"В6","В2","В3","В4","В5",}),
                        new Question("Пит 8", new string[] {"В7","В2","В3","В4","В5",}),
                        new Question("Пит 9", new string[] {"В8","В2","В3","В4","В5",}),
                        new Question("Пит 10", new string[] {"В9","В2","В3","В4","В5",}),
                    }
                ),
                        };
        QuestionBlock block;
        Question[] questions;
        private int currentQuestion = 0;

        public TestForm()
        {
            InitializeComponent();
            ChangeQuestion();
        }

        public void ChangeQuestion()
        {
            UncheckRadio();
            block = QuestionBlocks[0];
            questions = block.GetQuestions();
            questionTextLabel.Text = questions[currentQuestion].GetText();
            questionNumberLabel.Text = (currentQuestion + 1).ToString();
            firstAnswerLabel.Text = questions[currentQuestion].GetAnswers()[0];
            secondAnswerLabel.Text = questions[currentQuestion].GetAnswers()[1];
            thirdAnswerLabel.Text = questions[currentQuestion].GetAnswers()[2];
            fourthAnswerLabel.Text = questions[currentQuestion].GetAnswers()[3];
            fifthAnswerLabel.Text = questions[currentQuestion].GetAnswers()[4];

            CheckRadio();
            UpdatePaginationButtons();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            answers[currentQuestion] = GetChosenAnswerNumber();
            currentQuestion++;
            ChangeQuestion();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            currentQuestion--;
            ChangeQuestion();

        }

        private int GetChosenAnswerNumber()
        {
            if (firstAnswerRadio.Checked)
                return 1;
            if (secondAnswerRadio.Checked)
                return 2;
            if (thirdAnswerRadio.Checked)
                return 3;
            if (fourthAnswerRadio.Checked)
                return 4;
            if (fifthAnswerRadio.Checked)
                return 5;
            return -1;
        }

        private void UncheckRadio()
        {
            foreach (RadioButton radio in Controls.OfType<RadioButton>())
            {
                radio.Checked = false;
            }
        }

        private void CheckRadio()
        {
            switch (answers[currentQuestion])
            {
                case 1: firstAnswerRadio.Checked = true; break;
                case 2: secondAnswerRadio.Checked = true; break;
                case 3: thirdAnswerRadio.Checked = true; break;
                case 4: fourthAnswerRadio.Checked = true; break;
                case 5: fifthAnswerRadio.Checked = true; break;
            }
        }

        private void UpdatePaginationButtons()
        {
            if (currentQuestion == 0)
            {
                previousButton.Enabled = false;
            }
            else previousButton.Enabled = true;
            if (currentQuestion == questions.Length - 1)
            {
                nextButton.Enabled = false;
            }
            else nextButton.Enabled = true;
        }
    }
}
