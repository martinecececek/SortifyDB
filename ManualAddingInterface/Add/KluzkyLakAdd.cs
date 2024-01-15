using SortifyDB;
using SortifyDB.DatabaseConnect;
using SortifyDB.ManualAddingInterface;
using SortifyDB.Objects;


namespace TechnoWizz.ManualAddingForm.Add
{
    public partial class KluzkyLakAdd : UserControl
    {
        public KluzkyLakAdd()
        {
            InitializeComponent();
        }


        private readonly Dictionary<string, string> KeyValuePairs = new();
        private void KluzkyLakAdd_Load(object sender, System.EventArgs e)
        {
            lakSlozeni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lakSlozeni.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            lakSlozeni.AutoGenerateColumns = false;

            //TODO: add 
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, System.EventArgs e)
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

                foreach (DataGridViewRow row in lakSlozeni.Rows)
                {
                    if (row.Cells[1].Value != null)
                    {
                        keyValuePairs[row.Cells[0].Value.ToString()] = row.Cells[1].Value.ToString();
                    }
                }

                KluzkyLak lak = new(sap: txtBoxSAP.Text,
                                    nazev: txtBoxName.Text,
                                    jeAktivni: txtBoxAktivni.Text,
                                    vyrobce: txtBoxVyrobce.Text,
                                    pouziti: txtBoxPouziti.Text,
                                    nevhodneKombinace: txtBoxNevhodKomb.Text,
                                    slozeniDle: txtBoxSlozDle.Text,
                                    slozeni: keyValuePairs);

                MainForm.KluzkeLaky.Add(lak);

                DatabaseConnection databaseConnection = new();

                databaseConnection.PushKluzkyLakToDatabase(lak);

            }
            else
            {
                MessageBox.Show("Vyplňte všechny údaje!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
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
