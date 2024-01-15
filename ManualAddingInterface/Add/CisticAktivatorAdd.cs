
using SortifyDB.DatabaseConnect;
using SortifyDB.ManualAddingInterface;
using SortifyDB.Objects;

namespace TechnoWizz.ManualAddingForm.Add
{
    public partial class CisticAktivatorAdd : UserControl
    {
        public CisticAktivatorAdd()
        {
            InitializeComponent();
        }

        private Dictionary<string, string> KeyValuePairs = new Dictionary<string, string>();
        private void CisticAktivatorAdd_Load(object sender, EventArgs e)
        {
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.AutoGenerateColumns = false;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
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
                Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    if (row.Cells[1].Value != null)
                    {
                        keyValuePairs[row.Cells[0].Value.ToString()] = row.Cells[1].Value.ToString();
                    }
                }


                CisiticAktivator Cistic = new(sap: txtBoxSAP.Text,
                                                             nazev: txtBoxName.Text,
                                                             jeAktivni: txtBoxAktivni.Text,
                                                             vyrobce: txtBoxVyrobce.Text,
                                                             pouziti: txtBoxPouziti.Text,
                                                             nevhodneKombinace: txtBoxNevhodKomb.Text,
                                                             slozeniDle: txtBoxSlozeniDle.Text,
                                                             slozeni: keyValuePairs);



                DatabaseConnection databaseConnection = new();

                databaseConnection.PushCisticAktivatorToDatabase(Cistic);


            }
            else
            {
                MessageBox.Show("Vyplňte všechny údaje!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
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
                DialogResult dialogResult = MessageBox.Show("Opravdu chcete zrušit přidávání granulátu?", "Zrušit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    MainManualAdding mainManualForm = new();

                    mainManualForm.ClearUserControl();
                }
            }
        }
    }
}
