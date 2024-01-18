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
            switch (whatOpen)
            {
                case "M":
                    WriteMaterialDetail();
                    break;
                case "P":
                    WriteProjectDetail();
                    break;
                case "G":
                    WriteGranulat();
                    break;
            }
        }

        #region write granulat detail

        private void WriteGranulat()
        {
            dataGridMainOutput.AutoGenerateColumns = false;

            Granulat granulat = MainForm.Granulaty.Find(x => x.SAP == findBy);

            #region add granulat data to dataGridProjectOutput by manually adding columns and rows
            DataGridViewTextBoxColumn sapColumn = new()
            {
                Name = "SAP",
                HeaderText = "SAP",
                DataPropertyName = "SAP"
            };

            DataGridViewTextBoxColumn nazevColumn = new()
            {
                Name = "Nazev",
                HeaderText = "Nazev",
                DataPropertyName = "Nazev"
            };

            DataGridViewTextBoxColumn typColumn = new()
            {
                Name = "Typ",
                HeaderText = "Typ",
                DataPropertyName = "Typ"
            };

            DataGridViewTextBoxColumn xkColumn = new()
            {
                Name = "Xk",
                HeaderText = "Xk",
                DataPropertyName = "Xk"
            };


            DataGridViewTextBoxColumn jeAktivniColumn = new()
            {
                Name = "JeAktivni",
                HeaderText = "JeAktivni",
                DataPropertyName = "JeAktivni"
            };

            DataGridViewTextBoxColumn vyrobceColumn = new()
            {
                Name = "Vyrobce",
                HeaderText = "Vyrobce",
                DataPropertyName = "Vyrobce"
            };

            DataGridViewTextBoxColumn pouzitiColumn = new()
            {
                Name = "Pouziti",
                HeaderText = "Pouziti",
                DataPropertyName = "Pouziti"
            };

            DataGridViewTextBoxColumn kombinaceSColumn = new()
            {
                Name = "KombinaceS",
                HeaderText = "KombinaceS",
                DataPropertyName = "KombinaceS"
            };

            DataGridViewTextBoxColumn cisteniColumn = new()
            {
                Name = "Cisteni",
                HeaderText = "Cisteni",
                DataPropertyName = "Cisteni"
            };

            DataGridViewTextBoxColumn nevhodneKombinaceColumn = new()
            {
                Name = "NevhodneKombinace",
                HeaderText = "NevhodneKombinace",
                DataPropertyName = "NevhodneKombinace"
            };

            DataGridViewTextBoxColumn slozeniDleColumn = new()
            {
                Name = "SlozeniDle",
                HeaderText = "SlozeniDle",
                DataPropertyName = "SlozeniDle"
            };

            dataGridMainOutput.Columns.Add(sapColumn);
            dataGridMainOutput.Columns.Add(nazevColumn);
            dataGridMainOutput.Columns.Add(typColumn);
            dataGridMainOutput.Columns.Add(xkColumn);
            dataGridMainOutput.Columns.Add(jeAktivniColumn);
            dataGridMainOutput.Columns.Add(vyrobceColumn);
            dataGridMainOutput.Columns.Add(pouzitiColumn);
            dataGridMainOutput.Columns.Add(kombinaceSColumn);
            dataGridMainOutput.Columns.Add(cisteniColumn);
            dataGridMainOutput.Columns.Add(nevhodneKombinaceColumn);
            dataGridMainOutput.Columns.Add(slozeniDleColumn);

            dataGridMainOutput.DataSource = granulat;

            #endregion

            #region add slozeni to dataGridDetailOutputOutput by manually adding columns and rows

            Dictionary<string, string> slozeni = granulat.Slozeni;

            foreach (var pair in slozeni)
            {
                dataGridDetailOutput.Rows.Add(pair.Key, pair.Value);
            }
            labelUCDetailMainName.Text = "Projekt";
            labelUCDetailContains.Text = "Materiály";

            #endregion

        }

        #endregion

        //TODO: finish this
        #region material detail

        private void WriteMaterialDetail()
        {
            Material material = MainForm.Materials.Find(x => x.SAP == findBy);

            #region add material data to dataGridProjectOutput by manually adding columns and rows

            dataGridMainOutput.DataSource = material;

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
                    {
                        dataGridDetailOutput.AutoGenerateColumns = true;

                        CisiticAktivator cisiticAktivator = MainForm.CisticeAktivatory.Find(x => x.SAP == findBy);

                        MessageBox.Show(cisiticAktivator.Nazev);

                        dataGridDetailOutput.DataSource = cisiticAktivator;

                        break;
                    }
                case "polymer/lepidlo":
                    {
                        dataGridDetailOutput.AutoGenerateColumns = true;

                        Granulat granulat = MainForm.Granulaty.Find(x => x.SAP == findBy);

                        dataGridDetailOutput.DataSource = granulat;

                        break;
                    }
                case "kluzný lak":
                    {
                        dataGridDetailOutput.AutoGenerateColumns = true;

                        KluzkyLak lak = MainForm.KluzkeLaky.Find(x => x.SAP == findBy);

                        dataGridDetailOutput.DataSource = lak;

                        break;
                    }
                default:
                    break;
            }
        }

        #endregion

        #region project detail
        private void WriteProjectDetail()
        {
            Projekt projekt = MainForm.Projekty.Find(x => x.TL == findBy);

            dataGridMainOutput.AutoGenerateColumns = false;

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

            dataGridDetailOutput.DataSource = projekt;
            #endregion

            dataGridDetailOutput.DataSource = projekt.Materials;

            DataGridViewButtonColumn detailButtonColumn = new()
            {
                HeaderText = "Detail",
                Name = "Detail"
            };
            dataGridDetailOutput.Columns.Add(detailButtonColumn);

            dataGridDetailOutput.CellClick += dataGridMaterialOutput_CellClick;

            dataGridDetailOutput.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dataGridUCOutput_DataBindingComplete);
        }

        #region x or detail button
        private void dataGridUCOutput_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridDetailOutput.Rows)
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

        #endregion

        #region material detail
        private void dataGridMaterialOutput_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MainUserControl mainUserControl = new();

            if (dataGridDetailOutput.Columns[e.ColumnIndex].HeaderText == "Detail" && e.RowIndex > 0)
            {
                if (dataGridDetailOutput.Columns[e.ColumnIndex].HeaderText == "Detail" && e.RowIndex > 0)
                {
                    DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dataGridDetailOutput.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    string buttonText = buttonCell.Value.ToString();

                    if (buttonText == "X")
                    {
                        MessageBox.Show("Tento typ materiálu nemá detail", "Detail neexistuje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    string findingParemater = dataGridDetailOutput.Rows[e.RowIndex].Cells[1].Value.ToString();

                    mainUserControl.AddToHistory("Materialy", findingParemater);

                    mainUserControl.ChangeUI(new UserControlDetail(findingParemater, "M", panel), panel);
                }
            }
            else
            {
                return;
            }
        }

        #endregion

        #endregion
    }
}
