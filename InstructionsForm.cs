using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MbtiTest
{
    public partial class InstructionsForm : Form
    {
        public InstructionsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            InitialForm initialForm = new InitialForm();
            initialForm.Show();
        }

        private void InstructionsForm_Load(object sender, EventArgs e)
        {
            instructionLabel1.Text = "Інструкція";
            instructionLabel2.Text = "Якщо ви знаєте свій психотип, то перейдіть в 'Каталог'. Там ви дізнаєтеся кольори, що вам підійдуть для приміщення.";
            instructionLabel3.Text = "Щоб розпочати тест натисніть 'Розпочати тест'.";
            instructionLabel4.Text = "В тесті 20 питань. Можна обрати лише одну відповідь, також можна повертатись до минулих питань.";
            instructionLabel5.Text = "Щоб завершити тест потрібно натиснути 'Завершити' і ви отримаєте результат.";
        }
    }
}
