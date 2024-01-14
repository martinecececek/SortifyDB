using SortifyDB;
using SortifyDB.DatabaseConnect;
using SortifyDB.ManualAddingInterface;
using SortifyDB.Objects;
using TechnoWizz.ManualAddingForm.Select;


namespace TechnoWizz.ManualAddingForm.Add
{
    public partial class ProjectAdd : UserControl
    {
        public ProjectAdd()
        {
            InitializeComponent();
        }

        List<Material> materials = new();

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            #region check all textboxes
            bool CheckTextBoxes()
            {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        if (string.IsNullOrEmpty(c.Text))
                        {
                            MessageBox.Show("Žádné textové pole nemůže být prázdné", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                return true;
            }

            bool CheckMaterials()
            {
                if (materialsContainers.Controls.Count == 0)
                {
                    MessageBox.Show("Projekt neobsahuje žádné materiály", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }

            #endregion

            if (CheckTextBoxes() && CheckMaterials())
            {
                #region Find materials

                List<Material> materials = new();

                foreach (Control c in materialsContainers.Controls)
                {
                    if (c is Button)
                    {
                        foreach (Material mat in MainForm.Materials)
                        {
                            if (mat.Nazev == c.Text)
                            {
                                materials.Add(mat);
                            }
                        }
                    }
                }

                #endregion

                Projekt project = new(txtBoxTL.Text, txtBoxName.Text, materials, txtBoxDes.Text, txtBoxGlass.Text, txtBoxLamp.Text, txtBoxTrh.Text, txtBoxIMDS.Text);




                #region push to database

                DatabaseConnection db = new();

                db.PushProjectToDatabase(project);

                #endregion

                MessageBox.Show("Projekt byl úspěšně přidán", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainManualAdding mainManualForm = new();

                mainManualForm.ClearUserControl();
            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            ProjektySelect projektySelect = new();

            MainManualAdding mainManualForm = new();
            mainManualForm.ChangeUI(projektySelect);
        }

        private void UpdateContainer()
        {
            materialsContainers.Controls.Clear();

            if (materials.Count > 0)
            {
                materialsContainers.Controls.Clear();

                foreach (Material material in materials)
                {
                    Button button = new()
                    {
                        Text = material.Nazev,
                        Width = 100,
                        Height = 50
                    };

                    materialsContainers.Controls.Add(button);
                }
            }
        }

        private void btnAddMaterial_Click(object sender, System.EventArgs e)
        {
            AddMaterialToProject addMaterialToProject = new();
            addMaterialToProject.ShowDialog();

            if (addMaterialToProject.material != null)
            {
                materials.Add(addMaterialToProject.material);
            }

            UpdateContainer();
        }

        private void bntDeleteMaterial_Click(object sender, System.EventArgs e)
        {
            DeleteMaterialFromProject deleteMaterialFromProject = new();
            deleteMaterialFromProject.ShowDialog();

            if (deleteMaterialFromProject.materials != null)
            {
                materials = deleteMaterialFromProject.materials;
            }

            UpdateContainer();
        }
    }
}
