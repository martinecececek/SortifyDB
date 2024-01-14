using SortifyDB.DatabaseConnect;
using SortifyDB.Objects;


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
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {

        }
    }
}
