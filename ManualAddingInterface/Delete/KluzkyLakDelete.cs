using SortifyDB;
using SortifyDB.DatabaseConnect;
using SortifyDB.ManualAddingInterface;
using SortifyDB.Objects;


namespace TechnoWizz.ManualAddingForm.Delete
{
    public partial class KluzkyLakDelete : UserControl
    {
        public KluzkyLakDelete()
        {
            InitializeComponent();
        }

        private void KluzkyLakDelete_Load(object sender, EventArgs e)
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

            dataGridLak.Columns.Add(nameColumn);
            dataGridLak.Columns.Add(sapColumn);
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

        private void DeleteItem(KluzkyLak lak)
        {

            MainForm.KluzkeLaky.Remove(lak);

            #region delete from db  

            DatabaseConnection databaseConnection = new();

            databaseConnection.DeleteKluzkyLak(lak.Nazev);

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

        private void button1_Click(object sender, EventArgs e)
        {
            MainManualAdding mainForm = new();
            mainForm.ClearUserControl();
        }
    }
}
