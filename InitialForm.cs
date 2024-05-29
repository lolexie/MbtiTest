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
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
        }

        private void startTheTest_Click(object sender, EventArgs e)
        {
            Hide();
            TestForm testForm = new TestForm();
            testForm.Show();
        }

        private void catalogButton_Click(object sender, EventArgs e)
        {
            Hide();
            CatalogForm catalogForm = new CatalogForm();
            catalogForm.Show();
        }

        private void instructionButton_Click(object sender, EventArgs e)
        {
            Hide();
            InstructionsForm instructionsForm = new InstructionsForm();
            instructionsForm.Show();
        }
    }
}
