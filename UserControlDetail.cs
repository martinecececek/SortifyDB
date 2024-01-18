using SortifyDB.Objects;

namespace SortifyDB
{
    public partial class UserControlDetail : UserControl
    {
        public UserControlDetail(string findBy, string whatOpen, Panel panel)
        {
            InitializeComponent();

            this.findBy = findBy;
            this.whatOpen = whatOpen;
            this.panel = panel;
        }

        readonly Panel panel;

        private readonly string findBy;
        private readonly string whatOpen;
        private void UserControlDetail_Load(object sender, EventArgs e)
        {
            ListDataGridVypis();

            dataGridMainOutput.ReadOnly = true;
            dataGridDetailOutput.ReadOnly = true;
        }

        private void ListDataGridVypis()
        {
            if (whatOpen == "M")
            {
                labelUCDetailMainName.Text = "Materiál";
                labelUCDetailContains.Text = "Chemikálie";
                WriteMaterialDetail();
                return;
            }
            labelUCDetailMainName.Text = "Projekt";
            labelUCDetailContains.Text = "Materiály";

            WriteProjectDetail();
        }

        private void WriteMaterialDetail()
        {
            Material material = MainForm.Materials.Find(x => x.SAP == findBy);

            dataGridMainOutput.DataSource = material;

            #region add material data to dataGridProjectOutput by manually adding columns and rows

            DataGridViewTextBoxColumn sapColumn = new()
            {
                Name = "SAP",
                HeaderText = "SAP",
                DataPropertyName = "SAP"
            };
            dataGridMainOutput.Columns.Add(sapColumn);

            DataGridViewTextBoxColumn nazevColumn = new()
            {
                Name = "Nazev",
                HeaderText = "Nazev",
                DataPropertyName = "Nazev"
            };
            dataGridMainOutput.Columns.Add(nazevColumn);

            DataGridViewTextBoxColumn typPripravkuColumn = new()
            {
                Name = "TypPripravku",
                HeaderText = "TypPripravku",
                DataPropertyName = "TypPripravku"
            };
            dataGridMainOutput.Columns.Add(typPripravkuColumn);

            #endregion

            switch (material.TypPripravku)
            {
                case "aktivátor/čistič":
                    dataGridDetailOutput.DataSource = MainForm.CisticeAktivatory.Find(x => x.SAP == findBy);
                    break;
                case "polymer/lepidlo":
                    dataGridDetailOutput.DataSource = MainForm.Granulaty.Find(x => x.SAP == findBy);
                    break;
                case "kluzný lak":
                    dataGridDetailOutput.DataSource = MainForm.KluzkeLaky.Find(x => x.SAP == findBy);
                    break;
                default:
                    break;
            }
        }

        private void WriteProjectDetail()
        {
            Projekt projekt = MainForm.Projekty.Find(x => x.TL == findBy);

            dataGridMainOutput.AutoGenerateColumns = false;
            dataGridMainOutput.DataSource = projekt;

            #region add project data to dataGridProjectOutput by manually adding columns and rows

            DataGridViewTextBoxColumn tlColumn = new()
            {
                Name = "TL",
                HeaderText = "TL",
                DataPropertyName = "TL"
            };
            dataGridMainOutput.Columns.Add(tlColumn);

            DataGridViewTextBoxColumn nazevColumn = new()
            {
                Name = "Nazev",
                HeaderText = "Nazev",
                DataPropertyName = "Nazev"
            };
            dataGridMainOutput.Columns.Add(nazevColumn);

            DataGridViewTextBoxColumn zkracenyPopisColumn = new()
            {
                Name = "ZkracenyPopis",
                HeaderText = "ZkracenyPopis",
                DataPropertyName = "ZkracenyPopis"
            };
            dataGridMainOutput.Columns.Add(zkracenyPopisColumn);

            DataGridViewTextBoxColumn skloColumn = new()
            {
                Name = "Sklo",
                HeaderText = "Sklo",
                DataPropertyName = "Sklo"
            };
            dataGridMainOutput.Columns.Add(skloColumn);

            DataGridViewTextBoxColumn tempColumn = new()
            {
                Name = "Temp",
                HeaderText = "Temp",
                DataPropertyName = "Temp"
            };
            dataGridMainOutput.Columns.Add(tempColumn);

            DataGridViewTextBoxColumn trhColumn = new()
            {
                Name = "Trh",
                HeaderText = "Trh",
                DataPropertyName = "Trh"
            };
            dataGridMainOutput.Columns.Add(trhColumn);

            DataGridViewTextBoxColumn imdsColumn = new()
            {
                Name = "IMDS",
                HeaderText = "IMDS",
                DataPropertyName = "IMDS"
            };
            dataGridMainOutput.Columns.Add(imdsColumn);


            #endregion

            dataGridDetailOutput.DataSource = projekt.Materials;

            DataGridViewButtonColumn detailButtonColumn = new()
            {
                HeaderText = "Detail",
                Text = "Detail",
                UseColumnTextForButtonValue = true
            };
            dataGridDetailOutput.Columns.Add(detailButtonColumn);

            dataGridDetailOutput.CellClick += dataGridMaterialOutput_CellClick;
        }

        private void dataGridMaterialOutput_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MainUserControl mainUserControl = new();

            if (dataGridDetailOutput.Columns[e.ColumnIndex].HeaderText == "Detail" && e.RowIndex > 0)
            {
                string findingParemater = dataGridDetailOutput.Rows[e.RowIndex].Cells[1].Value.ToString();

                mainUserControl.AddToHistory("Materials", findingParemater);

                mainUserControl.ChangeUI(new UserControlDetail(findingParemater, "M", panel), panel);
            }
        }
    }
}
