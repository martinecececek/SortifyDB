using SortifyDB;
using SortifyDB.DatabaseConnect;
using SortifyDB.ManualAddingInterface;
using SortifyDB.Objects;
using TechnoWizz.ManualAddingForm.Select;


namespace TechnoWizz.ManualAddingForm.Edit
{
    public partial class KluzkyLakEdit : UserControl
    {
        public KluzkyLakEdit(KluzkyLak kluzkyLak)
        {
            InitializeComponent();

            KluzkyLak = kluzkyLak;
        }

        public KluzkyLak KluzkyLak { get; set; }

        private readonly Dictionary<string, string> KeyValuePairs = new();
        private void KluzkyLakEdit_Load(object sender, System.EventArgs e)
        {
            lakSlozeni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            lakSlozeni.AutoGenerateColumns = false;

            txtBoxName.Text = KluzkyLak.Nazev;
            txtBoxSAP.Text = KluzkyLak.SAP;
            txtBoxAktivni.Text = KluzkyLak.JeAktivni;
            txtBoxVyrobce.Text = KluzkyLak.Vyrobce;
            txtBoxPouziti.Text = KluzkyLak.Pouziti;
            txtBoxNevhodKomb.Text = KluzkyLak.NevhodneKombinace;
            txtBoxSlozDle.Text = KluzkyLak.SlozeniDle;

            foreach (KeyValuePair<string, string> keyValuePair in KluzkyLak.Slozeni)
            {
                lakSlozeni.Rows.Add(keyValuePair.Key, keyValuePair.Value);
            }
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {

        }

        private void BtnSave_Click_1(object sender, System.EventArgs e)
        {
            //get data from datagrid
            Dictionary<string, string> keyValuePairs = new();

            foreach (DataGridViewRow dataGridRow in lakSlozeni.Rows)
            {
                if (dataGridRow.Cells[1].Value != null)
                {
                    keyValuePairs[dataGridRow.Cells[0].Value.ToString()] = dataGridRow.Cells[1].Value.ToString();
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

            #region update main list
            int index = MainForm.KluzkeLaky.FindIndex(x => x.Nazev == KluzkyLak.Nazev);

            if (index != -1)
            {
                MainForm.KluzkeLaky[index] = lak;
            }
            #endregion

            DatabaseConnection databaseConnection = new();

            databaseConnection.UpdateKluzkyLak(lak);

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

        private void BtnCancel_Click(object sender, System.EventArgs e)
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
                Control currentControl = this;
                while (currentControl != null)
                {
                    if (currentControl is MainManualAdding main)
                    {
                        main.ChangeUI(new GranulatySelect());
                        break; // Exit the loop once the MainManualAdding form is found and actions are performed
                    }
                    currentControl = currentControl.Parent; // Move up to the next parent control
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Opravdu chcete zrušit přidávání granulátu?", "Zrušit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    Control currentControl = this;
                    while (currentControl != null)
                    {
                        if (currentControl is MainManualAdding main)
                        {
                            main.ChangeUI(new GranulatySelect());
                            break; // Exit the loop once the MainManualAdding form is found and actions are performed
                        }
                        currentControl = currentControl.Parent; // Move up to the next parent control
                    }
                }
            }
        }
    }
}
