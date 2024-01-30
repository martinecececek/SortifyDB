using SortifyDB;
using SortifyDB.ManualAddingInterface;
using SortifyDB.Objects;
using TechnoWizz.ManualAddingForm.Edit;

namespace TechnoWizz.ManualAddingForm.Select
{
    public partial class GranulatySelect : UserControl
    {
        public GranulatySelect()
        {
            InitializeComponent();
        }

        private void GranulatySelect_Load(object sender, EventArgs e)
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

            dataGridGranulat.Columns.Add(sapColumn);
            dataGridGranulat.Columns.Add(nameColumn);
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

                        MainManualAdding mainForm = new();

                        GranulatEdit editingGranulat = new(lak);
                        mainForm.ChangeUI(editingGranulat);

                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
                        if (item.Nazev == textBoxSearch.Text || item.Pouziti == textBoxSearch.Text || item.Vyrobce == textBoxSearch.Text)
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainManualAdding mainManualAdding = new();
            mainManualAdding.ClearUserControl();
        }

    }
}
