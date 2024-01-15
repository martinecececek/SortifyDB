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

            dataGridOutput.DataSource = null;
        }

        private void ClearDataGrid()
        {
            if (dataGridOutput.DataSource != null)
            {
                dataGridOutput.Rows.Clear();
            }
        }

        private void BtnProjekty_Click(object sender, EventArgs e)
        {
            ClearDataGrid();

            dataGridOutput.DataSource = MainForm.Projekty;

            DataGridViewButtonColumn deleteButtonColumn = new()
            {
                HeaderText = "Detail",
                Text = "Detail",
                UseColumnTextForButtonValue = true
            };

            dataGridOutput.Columns.Add(deleteButtonColumn);

            dataGridOutput.CellClick += dataGridOutput_CellClick;
        }

        private void dataGridOutput_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridOutput.Columns[e.ColumnIndex].HeaderText == "Detail" && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridOutput.Rows[e.RowIndex];

                string tlValue = (string)selectedRow.Cells[1].Value;

                Projekt projekt = MainForm.Projekty.Find(x => x.TL == tlValue);

                ClearDataGrid();



            }
        }

        private void BtnMat_Click(object sender, EventArgs e)
        {
            ClearDataGrid();

            dataGridOutput.DataSource = MainForm.Materials;
        }

        private void BtnCleanActive_Click(object sender, EventArgs e)
        {
            ClearDataGrid();

            dataGridOutput.DataSource = MainForm.CisticeAktivatory;
        }

        private void BtnVarnish_Click(object sender, EventArgs e)
        {
            ClearDataGrid();

            dataGridOutput.DataSource = MainForm.KluzkeLaky;
        }

        private void BtnGran_Click(object sender, EventArgs e)
        {
            ClearDataGrid();

            dataGridOutput.DataSource = MainForm.Granulaty;
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
