using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TechnoWizz.Objects;

namespace TechnoWizz.ManualAddingForm.Add
{
    public partial class AddMaterialToProject : Form
    {
        public Material material;

        public AddMaterialToProject()
        {
            InitializeComponent();
        }

        private void AddMaterialToProject_Load(object sender, EventArgs e)
        {
            dataGridMaterials.DataSource = MainList.Materials;

            PopulateDataGrid();
        }

        private void PopulateDataGrid()
        {
            dataGridMaterials.Columns["Nazev"].HeaderText = "Název";
            dataGridMaterials.Columns["TypPripravku"].HeaderText = "Typ";

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn()
            {
                HeaderText = "Přidat",
                Text = "Přidat",
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

                material = new Material(sapValue, nameValue, typValue);

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
                    List<Material> searchedMaterials = new List<Material>();

                    btnSearch.Text = "Zpět";

                    foreach (Material material in MainList.Materials)
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
                dataGridMaterials.DataSource = MainList.Materials;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
