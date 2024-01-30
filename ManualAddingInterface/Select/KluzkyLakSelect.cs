using SortifyDB;
using SortifyDB.ManualAddingInterface;
using SortifyDB.Objects;
using TechnoWizz.ManualAddingForm.Edit;

namespace TechnoWizz.ManualAddingForm.Select
{
    public partial class KluzkyLakSelect : UserControl
    {
        public KluzkyLakSelect()
        {
            InitializeComponent();
        }

        private void KluzkyLakSelect_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            dataGridLak.AutoGenerateColumns = false;

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

            dataGridLak.Columns.Add(sapColumn);
            dataGridLak.Columns.Add(nameColumn);
            dataGridLak.Columns.Add(vyrobceColumn);

            dataGridLak.Columns.Add(editButtonColumn);

            dataGridLak.DataSource = MainForm.KluzkeLaky;

            dataGridLak.CellClick += LakyDataGrid_CellClick;
        }

        private void LakyDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridLak.Columns[e.ColumnIndex].HeaderText == "Upravit" && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridLak.Rows[e.RowIndex];

                string nameValue = (string)selectedRow.Cells["Nazev"].Value;
                string sapValue = (string)selectedRow.Cells["SAP"].Value;
                string vyrobceValue = (string)selectedRow.Cells["Vyrobce"].Value;

                foreach (KluzkyLak lak in MainForm.KluzkeLaky)
                {
                    if (lak.Nazev == nameValue &&
                        lak.SAP == sapValue &&
                        lak.Vyrobce == vyrobceValue)
                    {
                        textBoxSearch.Text = null;

                        MainManualAdding mainManualAdding = new();

                        KluzkyLakEdit editinglak = new(lak);

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
                    List<KluzkyLak> selectedProjects = new();

                    btnSearch.Text = "Zrušit";

                    foreach (KluzkyLak item in MainForm.KluzkeLaky)
                    {
                        if (item.Nazev == textBoxSearch.Text || item.Vyrobce == textBoxSearch.Text || item.Pouziti == textBoxSearch.Text)
                        {
                            selectedProjects.Add(item);
                            break;
                        }
                    }

                    if (selectedProjects?.Count == null)
                    {
                        MessageBox.Show("Hledaný projekt nenalezen", "Projekt nenalezen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    dataGridLak.DataSource = selectedProjects;
                }
            }
            else
            {
                btnSearch.Text = "Vyhledat";
                dataGridLak.DataSource = MainForm.KluzkeLaky;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainManualAdding mainManualAdding = new();
            mainManualAdding.ClearUserControl();
        }
    }
}
