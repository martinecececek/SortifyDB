using SortifyDB;
using SortifyDB.DatabaseConnect;
using SortifyDB.ManualAddingInterface;
using SortifyDB.Objects;


namespace TechnoWizz.ManualAddingForm.Delete
{
    public partial class GranulatDelete : UserControl
    {
        public GranulatDelete()
        {
            InitializeComponent();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void GranulatDelete_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            dataGridGranulat.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn nameColumn = new()
            {
                Name = "Nazev",
                DataPropertyName = "Nazev",
                HeaderText = "Název"
            };

            DataGridViewTextBoxColumn sapColumn = new()
            {
                Name = "SAP",
                DataPropertyName = "SAP",
                HeaderText = "SAP"
            };

            DataGridViewTextBoxColumn vyrobceColumn = new()
            {
                Name = "Vyrobce",
                DataPropertyName = "Vyrobce",
                HeaderText = "Vyrobce",
            };

            DataGridViewButtonColumn editButtonColumn = new()
            {
                HeaderText = "Upravit",
                Text = "Upravit",
                UseColumnTextForButtonValue = true
            };

            dataGridGranulat.Columns.Add(nameColumn);
            dataGridGranulat.Columns.Add(sapColumn);
            dataGridGranulat.Columns.Add(vyrobceColumn);

            dataGridGranulat.Columns.Add(editButtonColumn);

            dataGridGranulat.DataSource = MainForm.Granulaty;

            dataGridGranulat.CellClick += GranulatyDataGrid_CellClick;
        }

        private void GranulatyDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridGranulat.Columns[e.ColumnIndex].HeaderText == "Upravit" && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridGranulat.Rows[e.RowIndex];

                string nameValue = (string)selectedRow.Cells["Nazev"].Value;
                string sapValue = (string)selectedRow.Cells["SAP"].Value;
                string vyrobceValue = (string)selectedRow.Cells["Vyrobce"].Value;

                foreach (Granulat lak in MainForm.Granulaty)
                {
                    if (lak.Nazev == nameValue &&
                        lak.SAP == sapValue &&
                        lak.Vyrobce == vyrobceValue)
                    {
                        textBoxSearch.Text = null;

                        DialogResult dialogResult = MessageBox.Show("Opravdu chcete zrušit přidávání materiálu?", "Zrušit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            MainManualAdding mainManualForm = new();

                            DeleteItem(lak);

                            MessageBox.Show("Projekt byl úspěšně smazán", "Smazán", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            mainManualForm.ClearUserControl();
                        }
                    }
                }
            }
        }

        private void DeleteItem(Granulat granulat)
        {

            MainForm.Granulaty.Remove(granulat);



            #region delete from db  

            DatabaseConnection databaseConnection = new();

            databaseConnection.DeleteGranulat(granulat.Nazev);

            #endregion
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (btnSearch.Text == "Vyhledat")
            {
                if (textBoxSearch.Text == null)
                {
                    MessageBox.Show("Pokud chete vyhledat projekt vyhledávací pole nemůže být prázdné", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    List<Granulat> selectedGranulaty = new();

                    btnSearch.Text = "Zrušit";

                    foreach (Granulat item in MainForm.Granulaty)
                    {
                        if (item.Nazev == textBoxSearch.Text || item.SAP == textBoxSearch.Text || item.Vyrobce == textBoxSearch.Text)
                        {
                            selectedGranulaty.Add(item);
                            break;
                        }
                    }

                    if (selectedGranulaty?.Count == null)
                    {
                        MessageBox.Show("Hledaný projekt nenalezen", "Projekt nenalezen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    dataGridGranulat.DataSource = selectedGranulaty;
                }
            }
            else
            {
                btnSearch.Text = "Vyhledat";
                dataGridGranulat.DataSource = MainForm.Granulaty;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            MainManualAdding mainForm = new();
            mainForm.ClearUserControl();
        }
    }
}
