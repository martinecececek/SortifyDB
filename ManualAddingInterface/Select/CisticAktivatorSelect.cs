using SortifyDB;
using SortifyDB.ManualAddingInterface;
using SortifyDB.Objects;
using TechnoWizz.ManualAddingForm.Edit;

namespace TechnoWizz.ManualAddingForm.Select
{
    public partial class CisticAktivatorSelect : UserControl
    {
        public CisticAktivatorSelect()
        {
            InitializeComponent();
        }

        private void CisticAktivatorSelect_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            dataGridCistice.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn nameColumn = new()
            {
                Name = "Nazev",
                DataPropertyName = "Nazev",
                HeaderText = "Název"
            };

            DataGridViewTextBoxColumn sapColumn = new()
            {
                Name = "sap",
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
                HeaderText = "Smazat",
                Text = "Smazat",
                UseColumnTextForButtonValue = true
            };

            dataGridCistice.Columns.Add(sapColumn);
            dataGridCistice.Columns.Add(nameColumn);
            dataGridCistice.Columns.Add(vyrobceColumn);

            dataGridCistice.Columns.Add(editButtonColumn);

            dataGridCistice.DataSource = MainForm.CisticeAktivatory;

            dataGridCistice.CellClick += CisticeDataGrid_CellClick;
        }

        private void CisticeDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridCistice.Columns[e.ColumnIndex].HeaderText == "Smazat" && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridCistice.Rows[e.RowIndex];

                string nameValue = (string)selectedRow.Cells["Nazev"].Value;
                string sapValue = (string)selectedRow.Cells["SAP"].Value;
                string vyrobceValue = (string)selectedRow.Cells["Vyrobce"].Value;

                foreach (CisiticAktivator cistic in MainForm.CisticeAktivatory)
                {
                    if (cistic.Nazev == nameValue &&
                        cistic.SAP == sapValue &&
                        cistic.Vyrobce == vyrobceValue)
                    {
                        textBoxSearch.Text = null;

                        MainManualAdding mainForm = new();

                        CisticAktivatorEdit editinglak = new(cistic);

                        Control currentControl = this;
                        while (currentControl != null)
                        {
                            if (currentControl is MainManualAdding main)
                            {
                                main.ChangeUI(editinglak);
                                break;
                            }
                            currentControl = currentControl.Parent; // Move up to the next parent control
                        }

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
                    List<CisiticAktivator> selected = new();

                    btnSearch.Text = "Zrušit";

                    foreach (CisiticAktivator cistic in MainForm.CisticeAktivatory)
                    {
                        if (cistic.Nazev == textBoxSearch.Text || cistic.SAP == textBoxSearch.Text || cistic.Pouziti == textBoxSearch.Text)
                        {
                            selected.Add(cistic);
                            break;
                        }
                    }

                    if (selected?.Count == null)
                    {
                        MessageBox.Show("Hledaný projekt nenalezen", "Projekt nenalezen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    dataGridCistice.DataSource = selected;
                }
            }
            else
            {
                btnSearch.Text = "Vyhledat";
                dataGridCistice.DataSource = MainForm.CisticeAktivatory;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainManualAdding mainForm = new();
            mainForm.ClearUserControl();
        }
    }
}
