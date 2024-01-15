using SortifyDB;
using SortifyDB.DatabaseConnect;
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

                string tlValue = (string)selectedRow.Cells["TL"].Value;
                string nameValue = (string)selectedRow.Cells["Nazev"].Value;
                string imdsValue = (string)selectedRow.Cells["IMDS"].Value;

                int positioInList;
                try
                {
                    positioInList = int.Parse(tlValue);
                }
                catch
                {
                    positioInList = -1;
                }

                if (positioInList != -1 &&
                    MainForm.Projekty[positioInList].TL == tlValue &&
                    MainForm.Projekty[positioInList].Nazev == nameValue &&
                    MainForm.Projekty[positioInList].IMDS == imdsValue)
                {
                    textBoxSearch.Text = null;

                    MainManualAdding mainForm = new();

                    mainForm.ClearUserControl();

                }
                else
                {
                    foreach (Projekt project in MainForm.Projekty)
                    {
                        if (project.TL == tlValue &&
                            project.Nazev == nameValue &&
                            project.IMDS == imdsValue)
                        {


                            DialogResult dialogResult = MessageBox.Show("Opravdu chcete zrušit přidávání materiálu?", "Zrušit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (dialogResult == DialogResult.Yes)
                            {
                                MainManualAdding mainManualForm = new();

                                DeleteItem(project);

                                MessageBox.Show("Projekt byl úspěšně smazán", "Smazán", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                mainManualForm.ClearUserControl();
                            }
                        }
                    }
                }
            }
        }

        private void DeleteItem(Projekt project)
        {

            MainForm.Projekty.Remove(project);

            #region delete from db  

            DatabaseConnection databaseConnection = new();

            databaseConnection.DeleteProject(project.TL);

            databaseConnection.DeleteProjectMaterial(project.TL);

            #endregion
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
