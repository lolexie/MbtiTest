using System;
using System.Windows.Forms;

namespace MbtiTest
{
    public partial class ResultForm : Form
    {
        QuestionBlock[] _blocks;
        public ResultForm(QuestionBlock[] blocks)
        {
            InitializeComponent();
            _blocks = blocks;
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            label1.Text = GetAbreviature();
        }

        private string GetAbreviature()
        {
            string abr = "";
            foreach(QuestionBlock block in _blocks)
            {
                abr += block.GetProfileType().Key;
            }
            return abr;
        }
    }
}
