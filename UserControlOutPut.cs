using SortifyDB.Objects;

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

        public UserControlOutPut(string typVypsaniListu, Panel vys, MainUserControl mainUserControl)
        {
            InitializeComponent();

            this.typVypsaniListu = typVypsaniListu;
            this.mainUserControl = mainUserControl;
            panel = vys;

            ListDataGridVypis();

            dataGridUCOutput.ReadOnly = true;
        }

        private void UserControlOutPut_Load(object sender, EventArgs e)
        {
            dataGridUCOutput.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridUCOutput.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        private readonly MainUserControl mainUserControl;
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
            try
            {
                if (dataGridUCOutput.Columns[e.ColumnIndex].HeaderText == "Detail" && e.RowIndex >= -1)
                {
                    string findingParemater = dataGridUCOutput.Rows[e.RowIndex].Cells[1].Value.ToString();

                    mainUserControl.AddToHistory("Projekty", findingParemater.ToString());
                    mainUserControl.ChangeUI(new UserControlDetail(findingParemater, "P", panel, mainUserControl), panel);
                }
            }
            catch
            {
                return;
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
                HeaderText = "Typ přípravku",
                DataPropertyName = "TypPripravku"
            };
            dataGridUCOutput.Columns.Add(tempColumn);

            DataGridViewButtonColumn detailButtonColumn = new()
            {
                HeaderText = "Detail",
                Name = "Detail",
            };



            dataGridUCOutput.Columns.Add(detailButtonColumn);

            dataGridUCOutput.CellClick += dataGridOutputMaterial_CellClick;

            dataGridUCOutput.DataSource = MainForm.Materials;

            dataGridUCOutput.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dataGridUCOutput_DataBindingComplete);

        }

        private void dataGridUCOutput_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridUCOutput.Rows)
                {
                    if (row.IsNewRow) continue; // Skip the new row placeholder

                    var typPripravkuValue = row.Cells["TypPripravku"].Value?.ToString().Trim();

                    // Debugging
                    Console.WriteLine($"Row: {row.Index}, TypPripravku: {typPripravkuValue}");

                    if (typPripravkuValue == "díl" || typPripravkuValue == "inkoust" ||
                        typPripravkuValue == "ředidlo" || typPripravkuValue == "primer")
                    {
                        row.Cells["Detail"].Value = "X";
                    }
                    else
                    {
                        row.Cells["Detail"].Value = "Detail";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in DataBindingComplete: " + ex.Message);
            }
        }

        private void dataGridOutputMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridUCOutput.Columns[e.ColumnIndex].HeaderText == "Detail" && e.RowIndex > -1)
                {
                    DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dataGridUCOutput.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    string buttonText = buttonCell.Value.ToString();

                    if (buttonText == "X")
                    {
                        MessageBox.Show("Tento typ materiálu nemá detail", "Detail neexistuje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    string findingParemater = dataGridUCOutput.Rows[e.RowIndex].Cells[1].Value.ToString();

                    mainUserControl.AddToHistory("Materialy", findingParemater);

                    mainUserControl.ChangeUI(new UserControlDetail(findingParemater, "M", panel, mainUserControl), panel);
                }
            }
            catch
            {
                return;
            }
        }
        #endregion

        #region Cistice show metods + detail button
        private void CleanActivesMet()
        {
            ClearDataGrid();

            dataGridUCOutput.AutoGenerateColumns = false;
            dataGridUCOutput.DataSource = MainForm.CisticeAktivatory;

            #region columns

            DataGridViewTextBoxColumn sapColumn = new()
            {
                Name = "SAP",
                HeaderText = "SAP",
                DataPropertyName = "SAP"
            };
            dataGridUCOutput.Columns.Add(sapColumn);

            DataGridViewTextBoxColumn nazevColumn = new()
            {
                Name = "Nazev",
                HeaderText = "Nazev",
                DataPropertyName = "Nazev"
            };
            dataGridUCOutput.Columns.Add(nazevColumn);

            DataGridViewTextBoxColumn jeAktivniColumn = new()
            {
                Name = "JeAktivni",
                HeaderText = "JeAktivni",
                DataPropertyName = "JeAktivni"
            };
            dataGridUCOutput.Columns.Add(jeAktivniColumn);

            DataGridViewTextBoxColumn vyrobceColumn = new()
            {
                Name = "Vyrobce",
                HeaderText = "Vyrobce",
                DataPropertyName = "Vyrobce"
            };
            dataGridUCOutput.Columns.Add(vyrobceColumn);

            DataGridViewTextBoxColumn pouzitiColumn = new()
            {
                Name = "Pouziti",
                HeaderText = "Pouziti",
                DataPropertyName = "Pouziti"
            };
            dataGridUCOutput.Columns.Add(pouzitiColumn);

            DataGridViewTextBoxColumn nevhodneKombinaceColumn = new()
            {
                Name = "NevhodneKombinace",
                HeaderText = "NevhodneKombinace",
                DataPropertyName = "NevhodneKombinace"
            };
            dataGridUCOutput.Columns.Add(nevhodneKombinaceColumn);

            DataGridViewTextBoxColumn slozeniDleColumn = new()
            {
                Name = "SlozeniDle",
                HeaderText = "SlozeniDle",
                DataPropertyName = "SlozeniDle"
            };
            dataGridUCOutput.Columns.Add(slozeniDleColumn);

            DataGridViewButtonColumn detailButtonColumn = new()
            {
                HeaderText = "Detail",
                Text = "Detail",
                Name = "Detail",
                UseColumnTextForButtonValue = true
            };
            dataGridUCOutput.Columns.Add(detailButtonColumn);

            #endregion

            dataGridUCOutput.CellClick += dataGridOutputCistice_CellClick;
        }

        private void dataGridOutputCistice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridUCOutput.Columns[e.ColumnIndex].HeaderText == "Detail" && e.RowIndex > -1)
                {
                    string findingParemater = dataGridUCOutput.Rows[e.RowIndex].Cells[0].Value.ToString();

                    mainUserControl.AddToHistory("CisticeAktivatory", findingParemater);

                    mainUserControl.ChangeUI(new UserControlDetail(findingParemater, "C", panel, mainUserControl), panel);
                }
            }
            catch
            {
                return;
            }
        }

        #endregion

        #region KluzkyLak show methods + detail button

        private void VarnishMet()
        {
            ClearDataGrid();

            dataGridUCOutput.AutoGenerateColumns = false;
            dataGridUCOutput.DataSource = MainForm.KluzkeLaky;

            #region columns

            DataGridViewTextBoxColumn sapColumn = new()
            {
                Name = "SAP",
                HeaderText = "SAP",
                DataPropertyName = "SAP"
            };
            dataGridUCOutput.Columns.Add(sapColumn);

            DataGridViewTextBoxColumn nazevColumn = new()
            {
                Name = "Nazev",
                HeaderText = "Nazev",
                DataPropertyName = "Nazev"
            };
            dataGridUCOutput.Columns.Add(nazevColumn);

            DataGridViewTextBoxColumn jeAktivniColumn = new()
            {
                Name = "JeAktivni",
                HeaderText = "JeAktivni",
                DataPropertyName = "JeAktivni"
            };
            dataGridUCOutput.Columns.Add(jeAktivniColumn);

            DataGridViewTextBoxColumn vyrobceColumn = new()
            {
                Name = "Vyrobce",
                HeaderText = "Vyrobce",
                DataPropertyName = "Vyrobce"
            };
            dataGridUCOutput.Columns.Add(vyrobceColumn);

            DataGridViewTextBoxColumn pouzitiColumn = new()
            {
                Name = "Pouziti",
                HeaderText = "Pouziti",
                DataPropertyName = "Pouziti"
            };
            dataGridUCOutput.Columns.Add(pouzitiColumn);

            DataGridViewTextBoxColumn nevhodneKombinaceColumn = new()
            {
                Name = "NevhodneKombinace",
                HeaderText = "NevhodneKombinace",
                DataPropertyName = "NevhodneKombinace"
            };
            dataGridUCOutput.Columns.Add(nevhodneKombinaceColumn);

            DataGridViewTextBoxColumn slozeniDleColumn = new()
            {
                Name = "SlozeniDle",
                HeaderText = "SlozeniDle",
                DataPropertyName = "SlozeniDle"
            };
            dataGridUCOutput.Columns.Add(slozeniDleColumn);

            DataGridViewButtonColumn detailButtonColumn = new()
            {
                HeaderText = "Detail",
                Name = "Detail",
                Text = "Detail",
                UseColumnTextForButtonValue = true
            };
            dataGridUCOutput.Columns.Add(detailButtonColumn);

            #endregion

            dataGridUCOutput.CellClick += dataGridOutputVarnish_CellClick;
        }

        private void dataGridOutputVarnish_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridUCOutput.Columns[e.ColumnIndex].HeaderText == "Detail" && e.RowIndex > -1)
                {
                    string findingParemater = dataGridUCOutput.Rows[e.RowIndex].Cells[0].Value.ToString();

                    mainUserControl.AddToHistory("KluzkeLaky", findingParemater);

                    mainUserControl.ChangeUI(new UserControlDetail(findingParemater, "K", panel, mainUserControl), panel);
                }
            }
            catch
            {
                return;
            }
        }

        #endregion

        #region granulaty show methods + detail button

        private void GranMet()
        {
            ClearDataGrid();

            dataGridUCOutput.AutoGenerateColumns = false;
            dataGridUCOutput.DataSource = MainForm.Granulaty;

            #region columns
            DataGridViewTextBoxColumn sapColumn = new()
            {
                Name = "SAP",
                HeaderText = "SAP",
                DataPropertyName = "SAP"
            };
            dataGridUCOutput.Columns.Add(sapColumn);

            DataGridViewTextBoxColumn nazevColumn = new()
            {
                Name = "Nazev",
                HeaderText = "Nazev",
                DataPropertyName = "Nazev"
            };
            dataGridUCOutput.Columns.Add(nazevColumn);

            DataGridViewTextBoxColumn typColumn = new()
            {
                Name = "Typ",
                HeaderText = "Typ",
                DataPropertyName = "Typ"
            };
            dataGridUCOutput.Columns.Add(typColumn);

            DataGridViewTextBoxColumn xkColumn = new()
            {
                Name = "Xk",
                HeaderText = "Xk",
                DataPropertyName = "Xk"
            };
            dataGridUCOutput.Columns.Add(xkColumn);

            DataGridViewTextBoxColumn jeAktivniColumn = new()
            {
                Name = "JeAktivni",
                HeaderText = "JeAktivni",
                DataPropertyName = "JeAktivni"
            };
            dataGridUCOutput.Columns.Add(jeAktivniColumn);

            DataGridViewTextBoxColumn vyrobceColumn = new()
            {
                Name = "Vyrobce",
                HeaderText = "Vyrobce",
                DataPropertyName = "Vyrobce"
            };
            dataGridUCOutput.Columns.Add(vyrobceColumn);

            DataGridViewTextBoxColumn pouzitiColumn = new()
            {
                Name = "Pouziti",
                HeaderText = "Pouziti",
                DataPropertyName = "Pouziti"
            };
            dataGridUCOutput.Columns.Add(pouzitiColumn);

            DataGridViewTextBoxColumn kombinaceSColumn = new()
            {
                Name = "KombinaceS",
                HeaderText = "KombinaceS",
                DataPropertyName = "KombinaceS"
            };
            dataGridUCOutput.Columns.Add(kombinaceSColumn);

            DataGridViewTextBoxColumn cisteniColumn = new()
            {
                Name = "Cisteni",
                HeaderText = "Cisteni",
                DataPropertyName = "Cisteni"
            };
            dataGridUCOutput.Columns.Add(cisteniColumn);

            DataGridViewTextBoxColumn nevhodneKombinaceColumn = new()
            {
                Name = "NevhodneKombinace",
                HeaderText = "NevhodneKombinace",
                DataPropertyName = "NevhodneKombinace"
            };
            dataGridUCOutput.Columns.Add(nevhodneKombinaceColumn);

            DataGridViewTextBoxColumn slozeniDleColumn = new()
            {
                Name = "SlozeniDle",
                HeaderText = "SlozeniDle",
                DataPropertyName = "SlozeniDle"
            };
            dataGridUCOutput.Columns.Add(slozeniDleColumn);

            DataGridViewButtonColumn detailButtonColumn = new()
            {
                HeaderText = "Detail",
                Name = "Detail",
                Text = "Detail",
                UseColumnTextForButtonValue = true
            };
            dataGridUCOutput.Columns.Add(detailButtonColumn);

            #endregion

            dataGridUCOutput.CellClick += dataGridOutputGranulat_CellClick;
        }

        private void dataGridOutputGranulat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridUCOutput.Columns[e.ColumnIndex].HeaderText == "Detail" && e.RowIndex > -1)
                {
                    string findingParemater = dataGridUCOutput.Rows[e.RowIndex].Cells[0].Value.ToString();

                    mainUserControl.AddToHistory("Granulaty", findingParemater);

                    mainUserControl.ChangeUI(new UserControlDetail(findingParemater, "G", panel, mainUserControl), panel);
                }
            }
            catch
            {
                return;
            }
        }

        #endregion

        #region search methods

        public void WriteProjektsFromSearch(List<Projekt> list)
        {
            ClearDataGrid();

            dataGridUCOutput.DataSource = list;

            #region columns
            DataGridViewButtonColumn deleteButtonColumn = new()
            {
                HeaderText = "Detail",
                Text = "Detail",
                UseColumnTextForButtonValue = true
            };
            dataGridUCOutput.Columns.Add(deleteButtonColumn);
            #endregion

            dataGridUCOutput.CellClick += dataGridOutputProject_CellClick;
        }

        public void WriteMaterialsFromSearch(List<Material> list)
        {
            ClearDataGrid();

            dataGridUCOutput.DataSource = list;

            #region columns
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
                HeaderText = "Typ přípravku",
                DataPropertyName = "TypPripravku"
            };
            dataGridUCOutput.Columns.Add(tempColumn);

            DataGridViewButtonColumn detailButtonColumn = new()
            {
                HeaderText = "Detail",
                Name = "Detail",
            };
            dataGridUCOutput.Columns.Add(detailButtonColumn);
            #endregion

            dataGridUCOutput.CellClick += dataGridOutputProject_CellClick;
        }

        public void WriteLakyFromSearch(List<KluzkyLak> list)
        {
            ClearDataGrid();

            dataGridUCOutput.AutoGenerateColumns = false;
            dataGridUCOutput.DataSource = list;

            #region columns

            DataGridViewTextBoxColumn sapColumn = new()
            {
                Name = "SAP",
                HeaderText = "SAP",
                DataPropertyName = "SAP"
            };
            dataGridUCOutput.Columns.Add(sapColumn);

            DataGridViewTextBoxColumn nazevColumn = new()
            {
                Name = "Nazev",
                HeaderText = "Nazev",
                DataPropertyName = "Nazev"
            };
            dataGridUCOutput.Columns.Add(nazevColumn);

            DataGridViewTextBoxColumn jeAktivniColumn = new()
            {
                Name = "JeAktivni",
                HeaderText = "JeAktivni",
                DataPropertyName = "JeAktivni"
            };
            dataGridUCOutput.Columns.Add(jeAktivniColumn);

            DataGridViewTextBoxColumn vyrobceColumn = new()
            {
                Name = "Vyrobce",
                HeaderText = "Vyrobce",
                DataPropertyName = "Vyrobce"
            };
            dataGridUCOutput.Columns.Add(vyrobceColumn);

            DataGridViewTextBoxColumn pouzitiColumn = new()
            {
                Name = "Pouziti",
                HeaderText = "Pouziti",
                DataPropertyName = "Pouziti"
            };
            dataGridUCOutput.Columns.Add(pouzitiColumn);

            DataGridViewTextBoxColumn nevhodneKombinaceColumn = new()
            {
                Name = "NevhodneKombinace",
                HeaderText = "NevhodneKombinace",
                DataPropertyName = "NevhodneKombinace"
            };
            dataGridUCOutput.Columns.Add(nevhodneKombinaceColumn);

            DataGridViewTextBoxColumn slozeniDleColumn = new()
            {
                Name = "SlozeniDle",
                HeaderText = "SlozeniDle",
                DataPropertyName = "SlozeniDle"
            };
            dataGridUCOutput.Columns.Add(slozeniDleColumn);

            DataGridViewButtonColumn detailButtonColumn = new()
            {
                HeaderText = "Detail",
                Name = "Detail",
                Text = "Detail",
                UseColumnTextForButtonValue = true
            };
            dataGridUCOutput.Columns.Add(detailButtonColumn);

            #endregion

            dataGridUCOutput.CellClick += dataGridOutputVarnish_CellClick;
        }

        public void WriteGranulatyFromSearch(List<Granulat> list)
        {
            ClearDataGrid();

            dataGridUCOutput.AutoGenerateColumns = false;
            dataGridUCOutput.DataSource = list;

            #region columns
            DataGridViewTextBoxColumn sapColumn = new()
            {
                Name = "SAP",
                HeaderText = "SAP",
                DataPropertyName = "SAP"
            };
            dataGridUCOutput.Columns.Add(sapColumn);

            DataGridViewTextBoxColumn nazevColumn = new()
            {
                Name = "Nazev",
                HeaderText = "Nazev",
                DataPropertyName = "Nazev"
            };
            dataGridUCOutput.Columns.Add(nazevColumn);

            DataGridViewTextBoxColumn typColumn = new()
            {
                Name = "Typ",
                HeaderText = "Typ",
                DataPropertyName = "Typ"
            };
            dataGridUCOutput.Columns.Add(typColumn);

            DataGridViewTextBoxColumn xkColumn = new()
            {
                Name = "Xk",
                HeaderText = "Xk",
                DataPropertyName = "Xk"
            };
            dataGridUCOutput.Columns.Add(xkColumn);

            DataGridViewTextBoxColumn jeAktivniColumn = new()
            {
                Name = "JeAktivni",
                HeaderText = "JeAktivni",
                DataPropertyName = "JeAktivni"
            };
            dataGridUCOutput.Columns.Add(jeAktivniColumn);

            DataGridViewTextBoxColumn vyrobceColumn = new()
            {
                Name = "Vyrobce",
                HeaderText = "Vyrobce",
                DataPropertyName = "Vyrobce"
            };
            dataGridUCOutput.Columns.Add(vyrobceColumn);

            DataGridViewTextBoxColumn pouzitiColumn = new()
            {
                Name = "Pouziti",
                HeaderText = "Pouziti",
                DataPropertyName = "Pouziti"
            };
            dataGridUCOutput.Columns.Add(pouzitiColumn);

            DataGridViewTextBoxColumn kombinaceSColumn = new()
            {
                Name = "KombinaceS",
                HeaderText = "KombinaceS",
                DataPropertyName = "KombinaceS"
            };
            dataGridUCOutput.Columns.Add(kombinaceSColumn);

            DataGridViewTextBoxColumn cisteniColumn = new()
            {
                Name = "Cisteni",
                HeaderText = "Cisteni",
                DataPropertyName = "Cisteni"
            };
            dataGridUCOutput.Columns.Add(cisteniColumn);

            DataGridViewTextBoxColumn nevhodneKombinaceColumn = new()
            {
                Name = "NevhodneKombinace",
                HeaderText = "NevhodneKombinace",
                DataPropertyName = "NevhodneKombinace"
            };
            dataGridUCOutput.Columns.Add(nevhodneKombinaceColumn);

            DataGridViewTextBoxColumn slozeniDleColumn = new()
            {
                Name = "SlozeniDle",
                HeaderText = "SlozeniDle",
                DataPropertyName = "SlozeniDle"
            };
            dataGridUCOutput.Columns.Add(slozeniDleColumn);

            DataGridViewButtonColumn detailButtonColumn = new()
            {
                HeaderText = "Detail",
                Name = "Detail",
                Text = "Detail",
                UseColumnTextForButtonValue = true
            };
            dataGridUCOutput.Columns.Add(detailButtonColumn);

            #endregion

            dataGridUCOutput.CellClick += dataGridOutputGranulat_CellClick;
        }

        public void WriteCisticeFromSearch(List<CisiticAktivator> list)
        {
            ClearDataGrid();

            dataGridUCOutput.AutoGenerateColumns = false;
            dataGridUCOutput.DataSource = list;

            #region columns

            DataGridViewTextBoxColumn sapColumn = new()
            {
                Name = "SAP",
                HeaderText = "SAP",
                DataPropertyName = "SAP"
            };
            dataGridUCOutput.Columns.Add(sapColumn);

            DataGridViewTextBoxColumn nazevColumn = new()
            {
                Name = "Nazev",
                HeaderText = "Nazev",
                DataPropertyName = "Nazev"
            };
            dataGridUCOutput.Columns.Add(nazevColumn);

            DataGridViewTextBoxColumn jeAktivniColumn = new()
            {
                Name = "JeAktivni",
                HeaderText = "JeAktivni",
                DataPropertyName = "JeAktivni"
            };
            dataGridUCOutput.Columns.Add(jeAktivniColumn);

            DataGridViewTextBoxColumn vyrobceColumn = new()
            {
                Name = "Vyrobce",
                HeaderText = "Vyrobce",
                DataPropertyName = "Vyrobce"
            };
            dataGridUCOutput.Columns.Add(vyrobceColumn);

            DataGridViewTextBoxColumn pouzitiColumn = new()
            {
                Name = "Pouziti",
                HeaderText = "Pouziti",
                DataPropertyName = "Pouziti"
            };
            dataGridUCOutput.Columns.Add(pouzitiColumn);

            DataGridViewTextBoxColumn nevhodneKombinaceColumn = new()
            {
                Name = "NevhodneKombinace",
                HeaderText = "NevhodneKombinace",
                DataPropertyName = "NevhodneKombinace"
            };
            dataGridUCOutput.Columns.Add(nevhodneKombinaceColumn);

            DataGridViewTextBoxColumn slozeniDleColumn = new()
            {
                Name = "SlozeniDle",
                HeaderText = "SlozeniDle",
                DataPropertyName = "SlozeniDle"
            };
            dataGridUCOutput.Columns.Add(slozeniDleColumn);

            DataGridViewButtonColumn detailButtonColumn = new()
            {
                HeaderText = "Detail",
                Text = "Detail",
                Name = "Detail",
                UseColumnTextForButtonValue = true
            };
            dataGridUCOutput.Columns.Add(detailButtonColumn);

            #endregion

            dataGridUCOutput.CellClick += dataGridOutputCistice_CellClick;
        }
        #endregion

    }
}
