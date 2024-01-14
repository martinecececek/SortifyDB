using SortifyDB;
using SortifyDB.DatabaseConnect;
using SortifyDB.ManualAddingInterface;
using SortifyDB.Objects;
using TechnoWizz.ManualAddingForm.Edit;


namespace TechnoWizz.ManualAddingForm.Delete
{
    public partial class MaterialDelete : UserControl
    {
        public MaterialDelete()
        {
            InitializeComponent();
        }

        private void MaterialDelete_Load(object sender, EventArgs e)
        {
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

                DialogResult dialogResult = MessageBox.Show("Opravdu chcete zrušit přidávání materiálu?", "Zrušit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    MainManualAdding mainManualForm = new();

                    DeleteItem(new Material(sapValue, nameValue, typValue));

                    MessageBox.Show("Projekt byl úspěšně smazán", "Smazán", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    mainManualForm.ClearUserControl();
                }
            }
        }

        private void DeleteItem(Material material)
        {

            MainForm.Materials.Remove(material);


            #region delete from db  

            DatabaseConnection databaseConnection = new();

            databaseConnection.DeleteMaterial(material.SAP);

            #endregion
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
