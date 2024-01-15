using SortifyDB.Objects;
using SortifyDB.PDF_parser;

namespace SortifyDB
{
    public partial class MainUserControl : UserControl
    {
        //Vzled
        public MainUserControl()
        {
            InitializeComponent();
        }

        private void BtnProjekty_Click(object sender, EventArgs e)
        {
            panelMainShower.Controls.Clear();
            panelMainShower.Controls.Add(new UserControlOutPut(0,panelMainShower));
            
        }

        private void BtnMat_Click(object sender, EventArgs e)
        {
            panelMainShower.Controls.Clear();
            panelMainShower.Controls.Add(new UserControlOutPut(1, panelMainShower));
        }

        private void BtnCleanActive_Click(object sender, EventArgs e)
        {
            panelMainShower.Controls.Clear();
            panelMainShower.Controls.Add(new UserControlOutPut(2, panelMainShower));
        }

        private void BtnVarnish_Click(object sender, EventArgs e)
        {
            panelMainShower.Controls.Clear();
            panelMainShower.Controls.Add(new UserControlOutPut(3, panelMainShower));
        }

        private void BtnGran_Click(object sender, EventArgs e)
        {
            panelMainShower.Controls.Clear();
            panelMainShower.Controls.Add(new UserControlOutPut(4, panelMainShower));
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }

        private void BtnMainFormsAdd_Click(object sender, EventArgs e)
        {

        }

        private void BtnParser_Click(object sender, EventArgs e)
        {
            PdfParsing.ParsePDF();
        }
    }
}
