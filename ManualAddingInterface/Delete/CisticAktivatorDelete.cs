using SortifyDB;
using SortifyDB.DatabaseConnect;
using SortifyDB.ManualAddingInterface;
using SortifyDB.Objects;

namespace TechnoWizz.ManualAddingForm.Delete
{
    public partial class CisticAktivatorDelete : UserControl
    {
        public CisticAktivatorDelete()
        {
            InitializeComponent();
        }

        private void CisticAktivatorDelete_Load(object sender, EventArgs e)
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

            DataGridViewButtonColumn deleteButtonColumn = new()
            {
                HeaderText = "Upravit",
                Text = "Upravit",
                UseColumnTextForButtonValue = true
            };

            dataGridCistice.Columns.Add(sapColumn);
            dataGridCistice.Columns.Add(nameColumn);
            dataGridCistice.Columns.Add(vyrobceColumn);

            dataGridCistice.Columns.Add(deleteButtonColumn);

            dataGridCistice.DataSource = MainForm.CisticeAktivatory;

            dataGridCistice.CellClick += CisticeDataGrid_CellClick;
        }

        private void CisticeDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridCistice.Columns[e.ColumnIndex].HeaderText == "Upravit" && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridCistice.Rows[e.RowIndex];

                string nameValue = (string)selectedRow.Cells["Nazev"].Value;
                string pouzitiValue = (string)selectedRow.Cells["SAP"].Value;
                string vyrobceValue = (string)selectedRow.Cells["Vyrobce"].Value;

                foreach (CisiticAktivator cistic in MainForm.CisticeAktivatory)
                {
                    if (cistic.Nazev == nameValue &&
                        cistic.Pouziti == pouzitiValue &&
                        cistic.Vyrobce == vyrobceValue)
                    {
                        textBoxSearch.Text = null;

                        DialogResult dialogResult = MessageBox.Show("Opravdu chcete zrušit přidávání materiálu?", "Zrušit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            MainManualAdding mainManualForm = new();

                            DeleteItem(cistic);

                            MessageBox.Show("Projekt byl úspěšně smazán", "Smazán", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Control currentControl = this;
                            while (currentControl != null)
                            {
                                if (currentControl is MainManualAdding main)
                                {
                                    MessageBox.Show("Parent is MainManualAdding", "Smazán", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    main.ClearUserControl();
                                    break; // Exit the loop once the MainManualAdding form is found and actions are performed
                                }
                                currentControl = currentControl.Parent; // Move up to the next parent control
                            }
                        }
                    }
                }
            }
        }

        private void DeleteItem(CisiticAktivator cistic)
        {
            MainForm.CisticeAktivatory.Remove(cistic);

            #region delete from db  

            DatabaseConnection databaseConnection = new();

            databaseConnection.DeleteCisticAktivator(cistic.Nazev);

            #endregion
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
                        if (cistic.Nazev == textBoxSearch.Text || cistic.Vyrobce == textBoxSearch.Text || cistic.Pouziti == textBoxSearch.Text)
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
