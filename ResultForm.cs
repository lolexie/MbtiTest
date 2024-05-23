using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
            abbreviatureLabel.Text = GetAbreviature();
            descriptionLabel.Text = PsychotypeProperties.GetDescription(GetAbreviature());
            FillColorBoxes();
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
        private void FillColorBoxes()
        {
            string[] colors = PsychotypeProperties.GetColors(GetAbreviature());
            List<PictureBox> colorBoxes = Controls.OfType<PictureBox>().ToList();
            for(int i = 0; i < colorBoxes.Count; i++)
            {
                colorBoxes[i].BackColor = ColorTranslator.FromHtml(colors[i]);  
            }
        }
    }
}
