using SortifyDB.DatabaseConnect;
using SortifyDB.ManualAddingInterface;
using SortifyDB.Objects;
using TechnoWizz.ManualAddingForm.Select;


namespace TechnoWizz.ManualAddingForm.Edit
{
    public partial class GranulatEdit : UserControl
    {
        public GranulatEdit(Granulat granulat)
        {
            InitializeComponent();

            this.Granulat = granulat;
        }

        private Granulat Granulat { get; set; }

        private readonly Dictionary<string, string> KeyValuePairs = new();
        private void GranulatEdit_Load(object sender, System.EventArgs e)
        {
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.AutoGenerateColumns = false;

            txtBoxName.Text = Granulat.Nazev;
            txtBoxSAP.Text = Granulat.SAP;
            txtBoxTyp.Text = Granulat.Typ;
            txtBoxxK.Text = Granulat.Xk;
            txtBoxAktivni.Text = Granulat.JeAktivni;
            txtBoxVyrobce.Text = Granulat.Vyrobce;
            txtBoxPouziti.Text = Granulat.Pouziti;
            txtBoxKombinace.Text = Granulat.KombinaceS;
            txtBoxCisteni.Text = Granulat.Cisteni;
            txtBoxNevhodKomb.Text = Granulat.NevhodneKombinace;
            txtBoxSlozeni.Text = Granulat.SlozeniDle;

            foreach (KeyValuePair<string, string> keyValuePair in Granulat.Slozeni)
            {
                dataGrid.Rows.Add(keyValuePair.Key, keyValuePair.Value);
            }

        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            Dictionary<string, string> keyValuePairs = new();

            foreach (DataGridViewRow dwRow in dataGrid.Rows)
            {
                if (dwRow.Cells[1].Value != null)
                {
                    keyValuePairs[dwRow.Cells[0].Value.ToString()] = dwRow.Cells[1].Value.ToString();
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



            DatabaseConnection databaseConnection = new();

            databaseConnection.UpdateGranulat(granulat);

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

        private void btnCancel_Click(object sender, System.EventArgs e)
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
