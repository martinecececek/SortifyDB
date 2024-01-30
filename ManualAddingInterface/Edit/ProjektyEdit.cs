using SortifyDB;
using SortifyDB.ManualAddingInterface;
using SortifyDB.Objects;
using TechnoWizz.ManualAddingForm.Select;

namespace TechnoWizz.ManualAddingForm.Edit
{
    public partial class ProjektyEdit : UserControl
    {
        public ProjektyEdit(Projekt project)
        {
            InitializeComponent();

            _projekt = project;
        }

        private Projekt _projekt { get; set; }

        private void ProjektyEdit_Load(object sender, EventArgs e)
        {

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Font = new Font("Microsoft Sans Serif", 25);
                }
            }

            txtIMDS.Text = _projekt.IMDS;
            txtName.Text = _projekt.Nazev;
            txtPopis.Text = _projekt.ZkracenyPopis;
            txtSklo.Text = _projekt.Sklo;
            txtTemp.Text = _projekt.Temp;
            txtTrh.Text = _projekt.Trh;
            txtTrh.Text = _projekt.Trh;
            txtTL.Text = _projekt.TL;

            foreach (Material material in _projekt.Materials)
            {
                Button button = new();
                button.Text = material.Nazev;
                button.Dock = DockStyle.Top;
                button.Name = material.SAP;
                button.Height = 100;
                button.Font = new Font("Microsoft Sans Serif", 25);
                button.Width = materialsContainers.Width;
                button.Margin = new Padding(0, 0, 0, 10);

                materialsContainers.Controls.Add(button);

                button.Click += Button_Click;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            MainManualAdding mainManualAdding = new();

            Material material = MainForm.Materials.Find(x => x.SAP == ((Button)sender).Name);

            mainManualAdding.ChangeUI(new MaterialEdit(material));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool ChecktextBoxes()
            {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        if (c.Text == "")
                        {
                            return false;
                        }
                    }
                }

                return true;
            }

            if (ChecktextBoxes())
            {
                MainForm.Projekty.Remove(_projekt);

                List<Material> materials = new();
                foreach (Control control in materialsContainers.Controls)
                {
                    if (control is Button)
                    {
                        Button button = (Button)control;

                        Material material = MainForm.Materials.Find(x => x.SAP == button.Name);

                        materials.Add(material);
                    }
                }



                Projekt projekt = new(tl: txtTL.Text, nazev: txtName.Text, materials: materials, zkracenyPopis: txtPopis.Text,
                                      sklo: txtSklo.Text, temp: txtTemp.Text, trh: txtTrh.Text, imds: txtIMDS.Text);

                MainForm.Projekty.Add(projekt);

                MainManualAdding mainManualAdding = new();
                mainManualAdding.ChangeUI(new ProjektySelect());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainManualAdding mainManualAdding = new();
            mainManualAdding.ChangeUI(new ProjektySelect());
        }
        //TODO: Add code & visual here
    }
}
