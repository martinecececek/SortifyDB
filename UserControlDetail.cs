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
        }

        private void ListDataGridVypis()
        {
            if (whatOpen == "M")
            {
                WriteMaterialDetail();
            }

            WriteProjectDetail();
        }

        private void WriteMaterialDetail()
        {
            Material material = MainForm.Materials.Find(x => x.SAP == findBy);

            dataGridProjectOutput.DataSource = material;

            #region add material data to dataGridProjectOutput by manually adding columns and rows

            DataGridViewTextBoxColumn sapColumn = new()
            {
                Name = "SAP",
                HeaderText = "SAP",
                DataPropertyName = "SAP"
            };
            dataGridProjectOutput.Columns.Add(sapColumn);

            DataGridViewTextBoxColumn nazevColumn = new()
            {
                Name = "Nazev",
                HeaderText = "Nazev",
                DataPropertyName = "Nazev"
            };
            dataGridProjectOutput.Columns.Add(nazevColumn);

            DataGridViewTextBoxColumn typPripravkuColumn = new()
            {
                Name = "TypPripravku",
                HeaderText = "TypPripravku",
                DataPropertyName = "TypPripravku"
            };
            dataGridProjectOutput.Columns.Add(typPripravkuColumn);

            #endregion

            switch (material.TypPripravku)
            {
                case "aktivátor/čistič":
                    dataGridMaterialOutput.DataSource = MainForm.CisticeAktivatory.Find(x => x.SAP == findBy);
                    break;
                case "polymer/lepidlo":
                    dataGridMaterialOutput.DataSource = MainForm.Granulaty.Find(x => x.SAP == findBy);
                    break;
                case "kluzný lak":
                    dataGridMaterialOutput.DataSource = MainForm.KluzkeLaky.Find(x => x.SAP == findBy);
                    break;
                default:
                    break;
            }
        }

        private void WriteProjectDetail()
        {
            Projekt projekt = MainForm.Projekty.Find(x => x.TL == findBy);

            dataGridProjectOutput.AutoGenerateColumns = false;

            #region add project data to dataGridProjectOutput by manually adding columns and rows

            DataGridViewTextBoxColumn tlColumn = new()
            {
                Name = "TL",
                HeaderText = "TL",
                DataPropertyName = "TL"
            };
            dataGridProjectOutput.Columns.Add(tlColumn);

            DataGridViewTextBoxColumn nazevColumn = new()
            {
                Name = "Nazev",
                HeaderText = "Nazev",
                DataPropertyName = "Nazev"
            };
            dataGridProjectOutput.Columns.Add(nazevColumn);

            DataGridViewTextBoxColumn zkracenyPopisColumn = new()
            {
                Name = "ZkracenyPopis",
                HeaderText = "ZkracenyPopis",
                DataPropertyName = "ZkracenyPopis"
            };
            dataGridProjectOutput.Columns.Add(zkracenyPopisColumn);

            DataGridViewTextBoxColumn skloColumn = new()
            {
                Name = "Sklo",
                HeaderText = "Sklo",
                DataPropertyName = "Sklo"
            };
            dataGridProjectOutput.Columns.Add(skloColumn);

            DataGridViewTextBoxColumn tempColumn = new()
            {
                Name = "Temp",
                HeaderText = "Temp",
                DataPropertyName = "Temp"
            };
            dataGridProjectOutput.Columns.Add(tempColumn);

            DataGridViewTextBoxColumn trhColumn = new()
            {
                Name = "Trh",
                HeaderText = "Trh",
                DataPropertyName = "Trh"
            };
            dataGridProjectOutput.Columns.Add(trhColumn);

            DataGridViewTextBoxColumn imdsColumn = new()
            {
                Name = "IMDS",
                HeaderText = "IMDS",
                DataPropertyName = "IMDS"
            };
            dataGridProjectOutput.Columns.Add(imdsColumn);


            #endregion

            dataGridMaterialOutput.DataSource = projekt.Materials;

            DataGridViewButtonColumn detailButtonColumn = new()
            {
                HeaderText = "Detail",
                Text = "Detail",
                UseColumnTextForButtonValue = true
            };
            dataGridMaterialOutput.Columns.Add(detailButtonColumn);

            dataGridMaterialOutput.CellClick += dataGridMaterialOutput_CellClick;
        }

        private void dataGridMaterialOutput_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MainUserControl mainUserControl = new();

            if (dataGridMaterialOutput.Columns[e.ColumnIndex].HeaderText == "Detail" && e.RowIndex >= 0)
            {
                string findingParemater = dataGridMaterialOutput.Rows[e.RowIndex].Cells[1].Value.ToString();

                mainUserControl.AddToHistory("Materials", findingParemater);

                mainUserControl.ChangeUI(new UserControlDetail(findingParemater, "M", panel));
            }
        }
    }
}
