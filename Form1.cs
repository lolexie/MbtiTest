using MbtiTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MbtiTest
{
    public partial class Form1 : Form
    {
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

        private int currentQuestion = 0;
        public Form1()
        {
            InitializeComponent();
            ChangeQuestion();



        }
        public void ChangeQuestion()
        {
            
            QuestionBlock block = QuestionBlocks[0];
            Question[] questions = block.GetQuestions();
            questionTextLabel.Text = questions[currentQuestion].GetText();
            questionNumberLabel.Text = (currentQuestion + 1).ToString();
            firstAnswerLabel.Text = questions[currentQuestion].GetAnswers()[0];
            secondAnswerLabel.Text = questions[currentQuestion].GetAnswers()[1];
            thirdAnswerLabel.Text = questions[currentQuestion].GetAnswers()[2];
            fourthAnswerLabel.Text = questions[currentQuestion].GetAnswers()[3];
            fifthAnswerLabel.Text = questions[currentQuestion].GetAnswers()[4];
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

        private void nextButton_Click(object sender, EventArgs e)
        {
            currentQuestion++;
            ChangeQuestion();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            currentQuestion--;
            ChangeQuestion();
        }
        private void LoadQuestion() 
        {

        }
    }
}
