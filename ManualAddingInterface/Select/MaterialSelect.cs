using SortifyDB;
using SortifyDB.ManualAddingInterface;
using SortifyDB.Objects;
using TechnoWizz.ManualAddingForm.Edit;

namespace TechnoWizz.ManualAddingForm.Select
{
    public partial class MaterialSelect : UserControl
    {
        public MaterialSelect()
        {
            InitializeComponent();
        }

        private void MaterialSelect_Load(object sender, System.EventArgs e)
        {
            dataGridMaterials.DataSource = MainForm.Materials;

            PopulateDataGrid();
        }

        private void PopulateDataGrid()
        {
            dataGridMaterials.Columns["Nazev"].HeaderText = "Název";
            dataGridMaterials.Columns["TypPripravku"].HeaderText = "Typ";

            DataGridViewButtonColumn deleteButtonColumn = new()
            {
                HeaderText = "Upravit",
                Text = "Upravit",
                UseColumnTextForButtonValue = true
            };

            dataGridMaterials.Columns.Add(deleteButtonColumn);

            dataGridMaterials.CellClick += MaterialDataGrid_CellClick;
        }

        private void MaterialDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridMaterials.Columns[e.ColumnIndex].HeaderText == "Upravit" && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridMaterials.Rows[e.RowIndex];

                string sapValue = (string)selectedRow.Cells["SAP"].Value;
                string nameValue = (string)selectedRow.Cells["Nazev"].Value;
                string typValue = (string)selectedRow.Cells["TypPripravku"].Value;

                MaterialEdit editingMaterial = new(new Material(sapValue, nameValue, typValue));


                MainManualAdding mainForm = new();

                txtBoxSearch.Text = string.Empty;
                mainForm.ChangeUI(editingMaterial);

            }
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            MainManualAdding mainForm = new();
            mainForm.ClearUserControl();
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            if (btnSearch.Text == "Vyhledat")
            {
                if (txtBoxSearch.Text == string.Empty)
                {
                    MessageBox.Show("Zadejte nějaký výraz pro vyhledání", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    List<Material> searchedMaterials = new();

                    btnSearch.Text = "Zpět";

                    foreach (Material material in MainForm.Materials)
                    {
                        if (material.SAP.Contains(txtBoxSearch.Text) || material.Nazev.Contains(txtBoxSearch.Text))
                        {
                            searchedMaterials.Add(material);
                        }
                    }

                    if (searchedMaterials.Count == 0)
                    {
                        MessageBox.Show("Nebyly nalezeny žádné výsledky", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    dataGridMaterials.DataSource = searchedMaterials;
                }
            }
            else
            {
                btnSearch.Text = "Vyhledat";
                dataGridMaterials.DataSource = MainForm.Materials;
            }
        }
    }
}
