using SortifyDB;
using SortifyDB.DatabaseConnect;
using SortifyDB.ManualAddingInterface;
using SortifyDB.Objects;


namespace TechnoWizz.ManualAddingForm.Add
{
    public partial class GranulatAdd : UserControl
    {
        public GranulatAdd()
        {
            InitializeComponent();
        }

        private readonly Dictionary<string, string> KeyValuePairs = new();

        private void GranulatAdd_Load(object sender, EventArgs e)
        {
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.AutoGenerateColumns = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool CheckTextBoxes()
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

            if (CheckTextBoxes())
            {
                //get data from datagrid
                Dictionary<string, string> keyValuePairs = new();

                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    if (row.Cells[1].Value != null)
                    {
                        keyValuePairs[row.Cells[0].Value.ToString()] = row.Cells[1].Value.ToString();
                    }
                }


                Granulat granulat = new(sap: txtBoxSAP.Text,
                                        nazev: txtBoxName.Text,
                                        typ: txtBoxTyp.Text,
                                        xk: txtBoxxK.Text,
                                        jeAktivni: txtBoxAktivni.Text,
                                        vyrobce: txtBoxVyrobce.Text,
                                        pouziti: txtBoxPouziti.Text,
                                        kombinaveS: txtBoxKombinace.Text,
                                        cisteni: txtBoxCisteni.Text,
                                        nevhodneKombinace: txtBoxNevhodKomb.Text,
                                        slozeniDle: txtBoxSlozeni.Text,
                                        slozeni: keyValuePairs);


                MainForm.Granulaty.Add(granulat);

                DatabaseConnection databaseConnection = new();

                databaseConnection.PushGranulatToDatabase(granulat);
            }
            else
            {
                MessageBox.Show("Vyplňte všechny údaje!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bool CheckTextBoxes()
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

            if (CheckTextBoxes())
            {
                MainManualAdding mainManualForm = new();

                mainManualForm.ClearUserControl();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Opravdu chcete zrušit přidávání materiálu?", "Zrušit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    MainManualAdding mainManualForm = new();

                    mainManualForm.ClearUserControl();
                }
            }
        }
    }
}
