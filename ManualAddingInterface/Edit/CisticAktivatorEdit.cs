using SortifyDB;
using SortifyDB.DatabaseConnect;
using SortifyDB.ManualAddingInterface;
using SortifyDB.Objects;
using TechnoWizz.ManualAddingForm.Select;

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

        private readonly Dictionary<string, string> KeyValuePairs = [];
        private void CisticAktivatorEdit_Load(object sender, System.EventArgs e)
        {
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.AutoGenerateColumns = false;

            //add data to textboxes
            txtBoxName.Text = CisticAktivator.Nazev;
            txtBoxSAP.Text = CisticAktivator.SAP;
            txtBoxAktivni.Text = CisticAktivator.JeAktivni;
            txtBoxVyrobce.Text = CisticAktivator.Vyrobce;
            txtBoxPouziti.Text = CisticAktivator.Pouziti;
            txtBoxNevhodKomb.Text = CisticAktivator.NevhodneKombinace;
            txtBoxSlozeniDle.Text = CisticAktivator.SlozeniDle;


            foreach (KeyValuePair<string, string> keyValuePair in CisticAktivator.Slozeni)
            {
                dataGrid.Rows.Add(keyValuePair.Key, keyValuePair.Value);
            }
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
            Dictionary<string, string> keyValuePairs = [];

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

            Control currentControl = this;
            while (currentControl != null)
            {
                if (currentControl is MainManualAdding main)
                {
                    main.ChangeUI(new CisticAktivatorSelect());
                    break; // Exit the loop once the MainManualAdding form is found and actions are performed
                }
                currentControl = currentControl.Parent; // Move up to the next parent control
            }
        }
    }
}
