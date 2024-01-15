namespace SortifyDB
{
    public partial class UserControlOutPut : UserControl
    {
        /// <summary>
        /// P = Projekty
        /// M = Materiály
        /// C = Čističe/Aktivátory
        /// K = Kluzké laky
        /// G = Granuláty
        /// </summary>

        public UserControlOutPut(string typVypsaniListu, Panel vys)
        {
            InitializeComponent();

            this.typVypsaniListu = typVypsaniListu;
            panel = vys;

            ListDataGridVypis();
        }

        readonly Panel panel;
        private readonly string typVypsaniListu;

        private void ClearDataGrid()
        {
            if (dataGridUCOutput.DataSource != null)
            {
                dataGridUCOutput.DataSource = null;
                dataGridUCOutput.Rows.Clear();
            }
        }

        private void ListDataGridVypis()
        {
            switch (typVypsaniListu)
            {
                case "P":
                    ProjektyMet();
                    break;
                case "M":
                    MaterialsMet();
                    break;
                case "C":
                    CleanActivesMet();
                    break;
                case "K":
                    VarnishMet();
                    break;
                case "G":
                    GranMet();
                    break;
            }
        }

        #region projects show methods + detail button
        private void ProjektyMet()
        {
            ClearDataGrid();

            dataGridUCOutput.DataSource = MainForm.Projekty;

            DataGridViewButtonColumn deleteButtonColumn = new()
            {
                HeaderText = "Detail",
                Text = "Detail",
                UseColumnTextForButtonValue = true
            };

            dataGridUCOutput.Columns.Add(deleteButtonColumn);

            dataGridUCOutput.CellClick += dataGridOutputProject_CellClick;
        }

        private void dataGridOutputProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MainUserControl mainUserControl = new();

            if (dataGridUCOutput.Columns[e.ColumnIndex].HeaderText == "Detail" && e.RowIndex >= 0)
            {
                string findingParemater = dataGridUCOutput.Rows[e.RowIndex].Cells[1].Value.ToString();

                mainUserControl.AddToHistory("Projekty", findingParemater);

                mainUserControl.ChangeUI(new UserControlDetail(findingParemater, "P", panel));
            }
        }
        #endregion

        #region materials show methods + detail button
        private void MaterialsMet()
        {
            ClearDataGrid();

            DataGridViewTextBoxColumn sapColumn = new()
            {
                Name = "SAP",
                HeaderText = "SAP",
                DataPropertyName = "SAP"
            };
            dataGridUCOutput.Columns.Add(sapColumn);

            DataGridViewTextBoxColumn skloColumn = new()
            {
                Name = "Nazev",
                HeaderText = "Název",
                DataPropertyName = "Nazev"
            };
            dataGridUCOutput.Columns.Add(skloColumn);

            DataGridViewTextBoxColumn tempColumn = new()
            {
                Name = "TypPripravku",
                HeaderText = "TypPripravku",
                DataPropertyName = "TypPripravku"
            };
            dataGridUCOutput.Columns.Add(tempColumn);

            DataGridViewButtonColumn deleteButtonColumn = new()
            {
                HeaderText = "Detail",
                Text = "Detail",
                UseColumnTextForButtonValue = true
            };

            dataGridUCOutput.Columns.Add(deleteButtonColumn);

            dataGridUCOutput.CellClick += dataGridOutputMaterial_CellClick;

            dataGridUCOutput.DataSource = MainForm.Materials;
        }

        private void dataGridOutputMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //TODO: fix this bcs the if statement will not execute

            MainUserControl mainUserControl = new();

            if (dataGridUCOutput.Columns[e.ColumnIndex].HeaderText == "Detail" && e.RowIndex > 0)
            {
                string findingParemater = dataGridUCOutput.Rows[e.RowIndex].Cells[1].Value.ToString();

                mainUserControl.AddToHistory("Materialy", findingParemater);

                mainUserControl.ChangeUI(new UserControlDetail(findingParemater, "M", panel));
            }
        }
        #endregion

        #region regular show methods
        private void CleanActivesMet()
        {
            ClearDataGrid();

            //TODO: fix this bcs need to write the Dictionary

            dataGridUCOutput.DataSource = MainForm.CisticeAktivatory;
        }

        private void VarnishMet()
        {
            ClearDataGrid();

            //TODO: fix this bcs need to write the Dictionary

            dataGridUCOutput.DataSource = MainForm.KluzkeLaky;
        }

        private void GranMet()
        {
            ClearDataGrid();

            //TODO: fix this bcs need to write the Dictionary

            dataGridUCOutput.DataSource = MainForm.Granulaty;
        }
        #endregion

    }
}
