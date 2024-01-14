using SortifyDB;
using SortifyDB.Objects;

namespace TechnoWizz.ManualAddingForm.Add
{
    public partial class DeleteMaterialFromProject : Form
    {
        public DeleteMaterialFromProject()
        {
            InitializeComponent();

            this.materials = materials;
        }

        public List<Material> materials;

        private void DeleteMaterialFromProject_Load(object sender, EventArgs e)
        {
            dataGridMaterials.DataSource = materials;

            PopulateDataGrid();
        }

        private void PopulateDataGrid()
        {
            dataGridMaterials.Columns["Nazev"].HeaderText = "Název";
            dataGridMaterials.Columns["TypPripravku"].HeaderText = "Typ";

            DataGridViewButtonColumn deleteButtonColumn = new()
            {
                HeaderText = "Odebrat",
                Text = "Odebrat",
                UseColumnTextForButtonValue = true
            };

            dataGridMaterials.Columns.Add(deleteButtonColumn);

            dataGridMaterials.CellClick += MaterialDataGrid_CellClick;
        }

        private void MaterialDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridMaterials.Columns[e.ColumnIndex].HeaderText == "Přidat" && e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridMaterials.Rows[e.RowIndex];

                string sapValue = (string)selectedRow.Cells["SAP"].Value;
                string nameValue = (string)selectedRow.Cells["Nazev"].Value;
                string typValue = (string)selectedRow.Cells["TypPripravku"].Value;

                Material material = new(sapValue, nameValue, typValue);

                materials.Remove(material);

                this.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
