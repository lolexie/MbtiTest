using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace MbtiTest
{
    public partial class CatalogForm : Form
    {
        public CatalogForm()
        {
            InitializeComponent();
            var psychotypes = PsychotypeProperties.GetAll();
            for (int i = 0; i < psychotypes.Count - 1; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["psychotype"].Value= psychotypes.ElementAt(i).Key;
                dataGridView1.Rows[i].Cells["color1"].Style.BackColor = ColorTranslator.FromHtml(psychotypes.ElementAt(i).Value[0]);
                dataGridView1.Rows[i].Cells["color2"].Style.BackColor = ColorTranslator.FromHtml(psychotypes.ElementAt(i).Value[1]);
                dataGridView1.Rows[i].Cells["color3"].Style.BackColor = ColorTranslator.FromHtml(psychotypes.ElementAt(i).Value[2]);
            }
        }
    }
}
