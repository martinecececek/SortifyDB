using SortifyDB;
using SortifyDB.DatabaseConnect;
using SortifyDB.ManualAddingInterface;
using SortifyDB.Objects;

namespace TechnoWizz.ManualAddingForm.Edit
{
    public partial class CisticAktivatorEdit : UserControl
    {
        public CisticAktivatorEdit(CisiticAktivator cisticAktivator)
        {
            InitializeComponent();

            this.CisticAktivator = cisticAktivator;
        }
        public CisiticAktivator CisticAktivator { get; set; }


        private readonly Dictionary<string, string> KeyValuePairs = new();
        private void CisticAktivatorEdit_Load(object sender, System.EventArgs e)
        {
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.AutoGenerateColumns = false;

            //TODO: add
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {

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
                DialogResult dialogResult = MessageBox.Show("Opravdu chcete zrušit přidávání granulátu?", "Zrušit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    MainManualAdding mainManualForm = new();

                    mainManualForm.ClearUserControl();
                }
            }
        }

        private void btnSave_Click_1(object sender, System.EventArgs e)
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

            if (!CheckTextBoxes())
            {
                MessageBox.Show("Některé textové boxy nejsou vyplněné!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //get data from datagrid
            Dictionary<string, string> keyValuePairs = new();

            foreach (DataGridViewRow dataGridRow in dataGrid.Rows)
            {
                if (dataGridRow.Cells[1].Value != null)
                {
                    keyValuePairs[dataGridRow.Cells[0].Value.ToString()] = dataGridRow.Cells[1].Value.ToString();
                }
            }

            CisiticAktivator cistic = new(sap: txtBoxSAP.Text,
                                                         nazev: txtBoxName.Text,
                                                         jeAktivni: txtBoxAktivni.Text,
                                                         vyrobce: txtBoxVyrobce.Text,
                                                         pouziti: txtBoxPouziti.Text,
                                                         nevhodneKombinace: txtBoxNevhodKomb.Text,
                                                         slozeniDle: txtBoxSlozeniDle.Text,
                                                         slozeni: keyValuePairs);

            #region update main list
            int index = MainForm.CisticeAktivatory.FindIndex(x => x.Nazev == CisticAktivator.Nazev);

            if (index != -1)
            {
                MainForm.CisticeAktivatory[index] = cistic;
            }
            #endregion


            DatabaseConnection databaseConnection = new();

            databaseConnection.UpdateCisticAktivator(cistic);
        }
    }
}
