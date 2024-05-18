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
                        new Question("Чи регулярно ви знаходите нових друзів?", new string[] {"Ні","Ближче за всього ні","Ближче за всього так","Так"}),
                        new Question("Чи легко ви можете підійти до людини, яка вам цікава, і почати з нею розмову?", new string[] { "Ні", "Ближче за всього ні", "Ближче за всього так", "Так"}),
                        new Question("Чи подобається вам брати участь у групових заходах?", new string[] {"Ні", "Ближче за всього ні", "Ближче за всього так", "Так" }),
                        new Question("Чи схильні ви привертати увагу людей до себе?", new string[] {"Ні", "Ближче за всього ні", "Ближче за всього так", "Так" }),
                        new Question("Зазвичай ви волієте бути поруч з іншими, а не наодинці?", new string[] {"Ні", "Ближче за всього ні", "Ближче за всього так", "Так" }),
                    }
                ),
                new QuestionBlock(
                    new Dictionary<string, string>() {
                    { "S", "Sensing"},
                    { "N", "Intuition"},
                    },
                    new Question[]{
                        new Question("Чи довіряєте ви більше фактам і конкретним данним, ніж вашій інтуїції?", new string[] {"Ні", "Ближче за всього ні", "Ближче за всього так", "Так"}),
                        new Question("Чи схильні ви до аналізу деталей і конкретних ситуацій, чи ви дивитесь на більш широкий контекст і можливі зв'язки між різними ідеями?", new string[] {"Ні", "Ближче за всього ні", "Ближче за всього так", "Так"}),
                        new Question("Чи важливіше для вас планувати крок за кроком, чи ви більше схильні до імпровізації і прийняття змін?", new string[] {"Ні", "Ближче за всього ні", "Ближче за всього так", "Так" }),
                        new Question("Чи частіше ви дієте на основі конкретних даних, ніж ґрунтуєтеся на власних догадках і відчуттях?", new string[] {"Ні", "Ближче за всього ні", "Ближче за всього так", "Так" }),
                        new Question("Чи подобається вам користуватися інструментами організації, такими як розклади та списки?", new string[] {"Ні", "Ближче за всього ні", "Ближче за всього так", "Так" }),
                    }
                ),
                new QuestionBlock(
                    new Dictionary<string, string>() {
                    { "T", "Thinking"},
                    { "F", "Feeling"},
                    },
                    new Question[]{
                        new Question("Чи ви більше керуєтеся логікою і об'єктивними критеріями при прийнятті рішень?", new string[] {"Ні", "Ближче за всього ні", "Ближче за всього так", "Так"}),
                        new Question("Чи важлива для вас конструктивна критика і аналіз проблем?", new string[] {"Ні", "Ближче за всього ні", "Ближче за всього так", "Так"}),
                        new Question("Чи схильні ви до аналізу ситуацій і раціональних обгрунтувань?", new string[] {"Ні", "Ближче за всього ні", "Ближче за всього так", "Так" }),
                        new Question("Чи ваші рішення зазвичай базуються на аналізі об'єктивних фактів?", new string[] {"Ні", "Ближче за всього ні", "Ближче за всього так", "Так" }),
                        new Question("Чи більше ви схильні довіряти своєму розуму, ніж своєму серцю?", new string[] {"Ні", "Ближче за всього ні", "Ближче за всього так", "Так" }),
                    }
                ),
                new QuestionBlock(
                    new Dictionary<string, string>() {
                    { "J", "Judging"},
                    { "P", "Perception"},
                    },
                    new Question[]{
                        new Question("Чи швидко ви вирішуєте завдання і виконуєте їх у встановлений термін?", new string[] {"Ні", "Ближче за всього ні", "Ближче за всього так", "Так" }),
                        new Question("Чи схильні ви більше до створення докладного плану перед початком проекту?", new string[] {"Ні", "Ближче за всього ні", "Ближче за всього так", "Так" }),
                        new Question("Чи волієте ви закінчити повсякденні справи, перш ніж дозволити собі розслабитися?", new string[] {"Ні", "Ближче за всього ні", "Ближче за всього так", "Так" }),
                        new Question("Чи починаєте ви нудьгувати або втрачаєти інтерес, коли дискусія стає надто теоретичною?", new string[] {"Ні", "Ближче за всього ні", "Ближче за всього так", "Так" }),
                        new Question("Чи рідко ви переосмислюєте свій вибір?", new string[] {"Ні", "Ближче за всього ні", "Ближче за всього так", "Так" }),
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
        private void CheckBoxClick(object sender, EventArgs e)
        {
            UncheckBox();
            CheckBox checkBox = (CheckBox)sender;
            checkBox.Checked = true;
        }
    }
}
