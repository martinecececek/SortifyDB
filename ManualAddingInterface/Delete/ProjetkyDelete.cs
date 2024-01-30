using SortifyDB;
using SortifyDB.ManualAddingInterface;
using SortifyDB.Objects;


namespace TechnoWizz.ManualAddingForm.Delete
{
    public partial class ProjetkyDelete : UserControl
    {
        public ProjetkyDelete()
        {
            InitializeComponent();
        }

        private void ProjetkyDelete_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            dataGridProject.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn tlColumn = new()
            {
                Name = "tlColumn",
                HeaderText = "Tl",
                DataPropertyName = "TL",
            };
            dataGridProject.Columns.Add(tlColumn);

            DataGridViewTextBoxColumn nameColumn = new()
            {
                Name = "nameColumn",
                HeaderText = "Název",
                DataPropertyName = "Název",
            };
            dataGridProject.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn imdsColumn = new()
            {
                Name = "imdsColumn",
                HeaderText = "IMDS",
                DataPropertyName = "IMDS",
            };
            dataGridProject.Columns.Add(imdsColumn);

            DataGridViewButtonColumn btnColumn = new()
            {
                HeaderText = "Smazat",
                Text = "Smazat",
                UseColumnTextForButtonValue = true
            };
            dataGridProject.Columns.Add(btnColumn);

            dataGridProject.DataSource = MainForm.Projekty;

            dataGridProject.CellClick += ProjectDataGrid_CellClick;
        }

        private void ProjectDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridProject.Columns[e.ColumnIndex].HeaderText == "Smazat" && e.RowIndex >= 0)
            {

                DataGridViewRow selectedRow = dataGridProject.Rows[e.RowIndex];

                string tlValue = (string)selectedRow.Cells["tlColumn"].Value;

                Projekt projekt = MainForm.Projekty.Find(x => x.TL == tlValue);

                MainForm.Projekty.Remove(projekt);


                Control currentControl = this;
                while (currentControl != null)
                {
                    if (currentControl is MainManualAdding main)
                    {
                        main.ClearUserControl();
                        break; // Exit the loop once the MainManualAdding form is found and actions are performed
                    }
                    currentControl = currentControl.Parent; // Move up to the next parent control
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (btnSearch.Text == "Vyhledat")
            {
                if (dataGridProject.Text == null)
                {
                    MessageBox.Show("Pokud chete vyhledat projekt vyhledávací pole nemůže být prázdné", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    List<Projekt> selectedProjects = new();

                    btnSearch.Text = "Zrušit";

                    foreach (Projekt item in MainForm.Projekty)
                    {
                        if (item.TL == textBoxSearch.Text || item.Nazev == textBoxSearch.Text || item.IMDS == textBoxSearch.Text)
                        {
                            selectedProjects.Add(item);
                            break;
                        }
                    }

                    if (selectedProjects?.Count == null)
                    {
                        MessageBox.Show("Hledaný projekt nenalezen", "Projekt nenalezen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    dataGridProject.DataSource = selectedProjects;
                }
            }
            else
            {
                btnSearch.Text = "Vyhledat";
                dataGridProject.DataSource = MainForm.Projekty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainManualAdding mainForm = new();
            mainForm.ClearUserControl();
        }
    }
}
