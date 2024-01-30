using SortifyDB.Objects;

namespace SortifyDB
{
    public partial class UserControlDetail : UserControl
    {
        public UserControlDetail(string findBy, string whatOpen, Panel panel, MainUserControl mainUserControl)
        {
            InitializeComponent();

            this.findBy = findBy;
            this.whatOpen = whatOpen;
            this.panel = panel;
            this.mainUserControl = mainUserControl;
        }

        private readonly Panel panel;

        private readonly MainUserControl mainUserControl;
        private readonly string findBy;
        private readonly string whatOpen;
        private void UserControlDetail_Load(object sender, EventArgs e)
        {
            ListDataGridVypis();

            dataGridMainOutput.ReadOnly = true;
            dataGridDetailOutput.ReadOnly = true;

            dataGridMainOutput.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridDetailOutput.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridMainOutput.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridDetailOutput.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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
                case "K":
                    WriteKluzkyLakDetail();
                    break;
                case "C":
                    WriteCisticeDetail();
                    break;
                default:
                    break;
            }
        }

        #region write granulat detail

        private void WriteGranulat()
        {
            dataGridMainOutput.AutoGenerateColumns = false;

            Granulat? granulat = MainForm.Granulaty.Find(x => x.SAP == findBy);

            if (granulat == null)
            {
                MessageBox.Show("Granulát nebyl nalezen", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);

                mainUserControl.ChangeUI(new UserControlOutPut("G", panel, mainUserControl), panel);

                return;
            }

            List<Granulat> granulats = [granulat];

            BindingSource source = new();
            source.DataSource = granulats;
            dataGridMainOutput.DataSource = source;

            #region add granulat data to dataGridProjectOutput by manually adding columns and rows
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

            DataGridViewTextBoxColumn typColumn = new()
            {
                Name = "Typ",
                HeaderText = "Typ",
                DataPropertyName = "Typ"
            };
            dataGridMainOutput.Columns.Add(typColumn);

            DataGridViewTextBoxColumn xkColumn = new()
            {
                Name = "Xk",
                HeaderText = "Xk",
                DataPropertyName = "Xk"
            };
            dataGridMainOutput.Columns.Add(xkColumn);

            DataGridViewTextBoxColumn jeAktivniColumn = new()
            {
                Name = "JeAktivni",
                HeaderText = "JeAktivni",
                DataPropertyName = "JeAktivni"
            };
            dataGridMainOutput.Columns.Add(jeAktivniColumn);

            DataGridViewTextBoxColumn vyrobceColumn = new()
            {
                Name = "Vyrobce",
                HeaderText = "Vyrobce",
                DataPropertyName = "Vyrobce"
            };
            dataGridMainOutput.Columns.Add(vyrobceColumn);

            DataGridViewTextBoxColumn pouzitiColumn = new()
            {
                Name = "Pouziti",
                HeaderText = "Pouziti",
                DataPropertyName = "Pouziti"
            };
            dataGridMainOutput.Columns.Add(pouzitiColumn);

            DataGridViewTextBoxColumn kombinaceSColumn = new()
            {
                Name = "KombinaceS",
                HeaderText = "KombinaceS",
                DataPropertyName = "KombinaceS"
            };
            dataGridMainOutput.Columns.Add(kombinaceSColumn);

            DataGridViewTextBoxColumn cisteniColumn = new()
            {
                Name = "Cisteni",
                HeaderText = "Cisteni",
                DataPropertyName = "Cisteni"
            };
            dataGridMainOutput.Columns.Add(cisteniColumn);

            DataGridViewTextBoxColumn nevhodneKombinaceColumn = new()
            {
                Name = "NevhodneKombinace",
                HeaderText = "NevhodneKombinace",
                DataPropertyName = "NevhodneKombinace"
            };
            dataGridMainOutput.Columns.Add(nevhodneKombinaceColumn);

            DataGridViewTextBoxColumn slozeniDleColumn = new()
            {
                Name = "SlozeniDle",
                HeaderText = "SlozeniDle",
                DataPropertyName = "SlozeniDle"
            };
            dataGridMainOutput.Columns.Add(slozeniDleColumn);

            #endregion

            #region add slozeni to dataGridDetailOutputOutput by manually adding columns and rows

            dataGridDetailOutput.AutoGenerateColumns = false;

            Dictionary<string, string> slozeni = granulat.Slozeni;

            BindingSource bindingSource = new();
            bindingSource.DataSource = slozeni;
            dataGridDetailOutput.DataSource = bindingSource;

            dataGridDetailOutput.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Chemikálie",
                DataPropertyName = "Key"
            });

            dataGridDetailOutput.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Obsah %",
                DataPropertyName = "Value"
            });

            #endregion

            labelUCDetailMainName.Text = "Granulát:";
            labelUCDetailContains.Text = "Složení:";
        }

        #endregion

        #region write kluzky detail

        private void WriteKluzkyLakDetail()
        {
            dataGridMainOutput.AutoGenerateColumns = false;

            KluzkyLak lak = MainForm.KluzkeLaky.Find(x => x.SAP == findBy);

            List<KluzkyLak> laks = [lak];

            BindingSource source = new();
            source.DataSource = laks;
            dataGridMainOutput.DataSource = source;

            #region add lak data to dataGridProjectOutput by manually adding columns and rows


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

            DataGridViewTextBoxColumn jeAktivniColumn = new()
            {
                Name = "JeAktivni",
                HeaderText = "JeAktivni",
                DataPropertyName = "JeAktivni"
            };
            dataGridMainOutput.Columns.Add(jeAktivniColumn);

            DataGridViewTextBoxColumn vyrobceColumn = new()
            {
                Name = "Vyrobce",
                HeaderText = "Vyrobce",
                DataPropertyName = "Vyrobce"
            };
            dataGridMainOutput.Columns.Add(vyrobceColumn);

            DataGridViewTextBoxColumn pouzitiColumn = new()
            {
                Name = "Pouziti",
                HeaderText = "Pouziti",
                DataPropertyName = "Pouziti"
            };
            dataGridMainOutput.Columns.Add(pouzitiColumn);

            DataGridViewTextBoxColumn nevhodneKombinaceColumn = new()
            {
                Name = "NevhodneKombinace",
                HeaderText = "NevhodneKombinace",
                DataPropertyName = "NevhodneKombinace"
            };
            dataGridMainOutput.Columns.Add(nevhodneKombinaceColumn);

            DataGridViewTextBoxColumn slozeniDleColumn = new()
            {
                Name = "SlozeniDle",
                HeaderText = "SlozeniDle",
                DataPropertyName = "SlozeniDle"
            };
            dataGridMainOutput.Columns.Add(slozeniDleColumn);

            #endregion

            #region add slozeni to dataGridDetailOutputOutput by manually adding columns and rows

            dataGridDetailOutput.AutoGenerateColumns = false;

            Dictionary<string, string> slozeni = lak.Slozeni;

            BindingSource bindingSource = new();
            bindingSource.DataSource = slozeni;
            dataGridDetailOutput.DataSource = bindingSource;

            dataGridDetailOutput.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Chemikálie",
                DataPropertyName = "Key"
            });

            dataGridDetailOutput.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Obsah %",
                DataPropertyName = "Value"
            });

            #endregion

            labelUCDetailMainName.Text = "Kluzký lak:";
            labelUCDetailContains.Text = "Složení:";

        }

        #endregion

        #region write CisticeAktivatory detail

        private void WriteCisticeDetail()
        {
            dataGridMainOutput.AutoGenerateColumns = false;

            CisiticAktivator? cisiticAktivator = MainForm.CisticeAktivatory.Find(x => x.SAP == findBy);

            if (cisiticAktivator == null)
            {
                MessageBox.Show("Čistič/aktivátor nebyl nalezen", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);

                mainUserControl.ChangeUI(new UserControlOutPut("C", panel, mainUserControl), panel);

                return;
            }

            List<CisiticAktivator> cisiticAktivators = [cisiticAktivator];

            BindingSource source = new();
            source.DataSource = cisiticAktivators;
            dataGridMainOutput.DataSource = source;

            #region add cisticeAktivator data to dataGridProjectOutput by manually adding columns and rows

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

            DataGridViewTextBoxColumn jeAktivniColumn = new()
            {
                Name = "JeAktivni",
                HeaderText = "JeAktivni",
                DataPropertyName = "JeAktivni"
            };
            dataGridMainOutput.Columns.Add(jeAktivniColumn);

            DataGridViewTextBoxColumn vyrobceColumn = new()
            {
                Name = "Vyrobce",
                HeaderText = "Vyrobce",
                DataPropertyName = "Vyrobce"
            };
            dataGridMainOutput.Columns.Add(vyrobceColumn);

            DataGridViewTextBoxColumn pouzitiColumn = new()
            {
                Name = "Pouziti",
                HeaderText = "Pouziti",
                DataPropertyName = "Pouziti"
            };
            dataGridMainOutput.Columns.Add(pouzitiColumn);

            DataGridViewTextBoxColumn nevhodneKombinaceColumn = new()
            {
                Name = "NevhodneKombinace",
                HeaderText = "NevhodneKombinace",
                DataPropertyName = "NevhodneKombinace"
            };
            dataGridMainOutput.Columns.Add(nevhodneKombinaceColumn);

            DataGridViewTextBoxColumn slozeniDleColumn = new()
            {
                Name = "SlozeniDle",
                HeaderText = "SlozeniDle",
                DataPropertyName = "SlozeniDle"
            };
            dataGridMainOutput.Columns.Add(slozeniDleColumn);

            #endregion

            #region add slozeni to dataGridDetailOutputOutput by manually adding columns and rows

            dataGridDetailOutput.AutoGenerateColumns = false;

            Dictionary<string, string> slozeni = cisiticAktivator.Slozeni;

            BindingSource bindingSource = new();
            bindingSource.DataSource = slozeni;
            dataGridDetailOutput.DataSource = bindingSource;

            dataGridDetailOutput.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Chemikálie",
                DataPropertyName = "Key"
            });

            dataGridDetailOutput.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Obsah %",
                DataPropertyName = "Value"
            });

            #endregion

            labelUCDetailMainName.Text = "Čistič/aktivátor:";
            labelUCDetailContains.Text = "Složení:";
        }

        #endregion

        #region material detail

        private void WriteMaterialDetail()
        {
            Material? material = MainForm.Materials.Find(x => x.SAP == findBy);

            dataGridMainOutput.AutoGenerateColumns = false;

            #region add material data to dataGridProjectOutput by manually adding columns and rows

            List<Material> materials = [material];
            dataGridMainOutput.DataSource = materials;

            dataGridMainOutput.AutoGenerateColumns = false;

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

            labelUCDetailMainName.Text = "Materiál:";

            switch (material.TypPripravku)
            {
                case "aktivátor/čistič":
                    {
                        dataGridDetailOutput.AutoGenerateColumns = false;

                        CisiticAktivator? cisiticAktivator = MainForm.CisticeAktivatory.Find(x => x.SAP == findBy);

                        dataGridDetailOutput.AutoGenerateColumns = false;

                        List<CisiticAktivator> cisiticAktivators = [cisiticAktivator];

                        BindingSource source = new();
                        source.DataSource = cisiticAktivators;
                        dataGridDetailOutput.DataSource = source;

                        #region columns

                        DataGridViewTextBoxColumn sapColumnDetail = new()
                        {
                            Name = "SAP",
                            HeaderText = "SAP",
                            DataPropertyName = "SAP"
                        };
                        dataGridDetailOutput.Columns.Add(sapColumnDetail);

                        DataGridViewTextBoxColumn nazevColumnDetail = new()
                        {
                            Name = "Nazev",
                            HeaderText = "Nazev",
                            DataPropertyName = "Nazev"
                        };
                        dataGridDetailOutput.Columns.Add(nazevColumnDetail);

                        DataGridViewTextBoxColumn jeAktivniColumn = new()
                        {
                            Name = "JeAktivni",
                            HeaderText = "JeAktivni",
                            DataPropertyName = "JeAktivni"
                        };
                        dataGridDetailOutput.Columns.Add(jeAktivniColumn);

                        DataGridViewTextBoxColumn vyrobceColumn = new()
                        {
                            Name = "Vyrobce",
                            HeaderText = "Vyrobce",
                            DataPropertyName = "Vyrobce"
                        };
                        dataGridDetailOutput.Columns.Add(vyrobceColumn);

                        DataGridViewTextBoxColumn pouzitiColumn = new()
                        {
                            Name = "Pouziti",
                            HeaderText = "Pouziti",
                            DataPropertyName = "Pouziti"
                        };
                        dataGridDetailOutput.Columns.Add(pouzitiColumn);

                        DataGridViewTextBoxColumn nevhodneKombinaceColumn = new()
                        {
                            Name = "NevhodneKombinace",
                            HeaderText = "NevhodneKombinace",
                            DataPropertyName = "NevhodneKombinace"
                        };
                        dataGridDetailOutput.Columns.Add(nevhodneKombinaceColumn);

                        DataGridViewTextBoxColumn slozeniDleColumn = new()
                        {
                            Name = "SlozeniDle",
                            HeaderText = "SlozeniDle",
                            DataPropertyName = "SlozeniDle"
                        };
                        dataGridDetailOutput.Columns.Add(slozeniDleColumn);

                        DataGridViewButtonColumn detailButtonColumn = new()
                        {
                            HeaderText = "Detail",
                            Name = "Detail",
                            Text = "Detail",
                            UseColumnTextForButtonValue = true
                        };
                        dataGridDetailOutput.Columns.Add(detailButtonColumn);

                        #endregion

                        labelUCDetailContains.Text = "Čistič/aktivátor:";

                        dataGridDetailOutput.CellClick += dataGridDetailVarnish_CellClick;

                        break;
                    }
                case "polymer/lepidlo":
                    {
                        dataGridDetailOutput.AutoGenerateColumns = false;

                        Granulat? granulat = MainForm.Granulaty.Find(x => x.SAP == findBy);

                        List<Granulat> granulats = [granulat];

                        BindingSource source = new();
                        source.DataSource = granulats;
                        dataGridDetailOutput.DataSource = source;

                        #region columns
                        DataGridViewTextBoxColumn sapColumnDetail = new()
                        {
                            Name = "SAP",
                            HeaderText = "SAP",
                            DataPropertyName = "SAP"
                        };
                        dataGridDetailOutput.Columns.Add(sapColumnDetail);

                        DataGridViewTextBoxColumn nazevColumnDetail = new()
                        {
                            Name = "Nazev",
                            HeaderText = "Nazev",
                            DataPropertyName = "Nazev"
                        };
                        dataGridDetailOutput.Columns.Add(nazevColumnDetail);

                        DataGridViewTextBoxColumn typColumn = new()
                        {
                            Name = "Typ",
                            HeaderText = "Typ",
                            DataPropertyName = "Typ"
                        };
                        dataGridDetailOutput.Columns.Add(typColumn);

                        DataGridViewTextBoxColumn xkColumn = new()
                        {
                            Name = "Xk",
                            HeaderText = "Xk",
                            DataPropertyName = "Xk"
                        };
                        dataGridDetailOutput.Columns.Add(xkColumn);

                        DataGridViewTextBoxColumn jeAktivniColumn = new()
                        {
                            Name = "JeAktivni",
                            HeaderText = "JeAktivni",
                            DataPropertyName = "JeAktivni"
                        };
                        dataGridDetailOutput.Columns.Add(jeAktivniColumn);

                        DataGridViewTextBoxColumn vyrobceColumn = new()
                        {
                            Name = "Vyrobce",
                            HeaderText = "Vyrobce",
                            DataPropertyName = "Vyrobce"
                        };
                        dataGridDetailOutput.Columns.Add(vyrobceColumn);

                        DataGridViewTextBoxColumn pouzitiColumn = new()
                        {
                            Name = "Pouziti",
                            HeaderText = "Pouziti",
                            DataPropertyName = "Pouziti"
                        };
                        dataGridDetailOutput.Columns.Add(pouzitiColumn);

                        DataGridViewTextBoxColumn kombinaceSColumn = new()
                        {
                            Name = "KombinaceS",
                            HeaderText = "KombinaceS",
                            DataPropertyName = "KombinaceS"
                        };
                        dataGridDetailOutput.Columns.Add(kombinaceSColumn);

                        DataGridViewTextBoxColumn cisteniColumn = new()
                        {
                            Name = "Cisteni",
                            HeaderText = "Cisteni",
                            DataPropertyName = "Cisteni"
                        };
                        dataGridDetailOutput.Columns.Add(cisteniColumn);

                        DataGridViewTextBoxColumn nevhodneKombinaceColumn = new()
                        {
                            Name = "NevhodneKombinace",
                            HeaderText = "NevhodneKombinace",
                            DataPropertyName = "NevhodneKombinace"
                        };
                        dataGridDetailOutput.Columns.Add(nevhodneKombinaceColumn);

                        DataGridViewTextBoxColumn slozeniDleColumn = new()
                        {
                            Name = "SlozeniDle",
                            HeaderText = "SlozeniDle",
                            DataPropertyName = "SlozeniDle"
                        };
                        dataGridDetailOutput.Columns.Add(slozeniDleColumn);

                        DataGridViewButtonColumn detailButtonColumn = new()
                        {
                            HeaderText = "Detail",
                            Name = "Detail",
                            Text = "Detail",
                            UseColumnTextForButtonValue = true
                        };
                        dataGridDetailOutput.Columns.Add(detailButtonColumn);

                        #endregion

                        labelUCDetailContains.Text = "Granulát:";

                        dataGridDetailOutput.CellClick += dataGridDetailGranulat_CellClick;

                        break;
                    }
                case "kluzný lak":
                    {
                        dataGridDetailOutput.AutoGenerateColumns = false;

                        KluzkyLak? lak = MainForm.KluzkeLaky.Find(x => x.SAP == findBy);

                        List<KluzkyLak> kluzkyLaks = [lak];

                        BindingSource source = new();
                        source.DataSource = kluzkyLaks;
                        dataGridDetailOutput.DataSource = source;

                        #region columns

                        DataGridViewTextBoxColumn sapColumnDetail = new()
                        {
                            Name = "SAP",
                            HeaderText = "SAP",
                            DataPropertyName = "SAP"
                        };
                        dataGridDetailOutput.Columns.Add(sapColumnDetail);

                        DataGridViewTextBoxColumn nazevColumnDetail = new()
                        {
                            Name = "Nazev",
                            HeaderText = "Nazev",
                            DataPropertyName = "Nazev"
                        };
                        dataGridDetailOutput.Columns.Add(nazevColumnDetail);

                        DataGridViewTextBoxColumn jeAktivniColumn = new()
                        {
                            Name = "JeAktivni",
                            HeaderText = "JeAktivni",
                            DataPropertyName = "JeAktivni"
                        };
                        dataGridDetailOutput.Columns.Add(jeAktivniColumn);

                        DataGridViewTextBoxColumn vyrobceColumn = new()
                        {
                            Name = "Vyrobce",
                            HeaderText = "Vyrobce",
                            DataPropertyName = "Vyrobce"
                        };
                        dataGridDetailOutput.Columns.Add(vyrobceColumn);

                        DataGridViewTextBoxColumn pouzitiColumn = new()
                        {
                            Name = "Pouziti",
                            HeaderText = "Pouziti",
                            DataPropertyName = "Pouziti"
                        };
                        dataGridDetailOutput.Columns.Add(pouzitiColumn);

                        DataGridViewTextBoxColumn nevhodneKombinaceColumn = new()
                        {
                            Name = "NevhodneKombinace",
                            HeaderText = "NevhodneKombinace",
                            DataPropertyName = "NevhodneKombinace"
                        };
                        dataGridDetailOutput.Columns.Add(nevhodneKombinaceColumn);

                        DataGridViewTextBoxColumn slozeniDleColumn = new()
                        {
                            Name = "SlozeniDle",
                            HeaderText = "SlozeniDle",
                            DataPropertyName = "SlozeniDle"
                        };
                        dataGridDetailOutput.Columns.Add(slozeniDleColumn);

                        DataGridViewButtonColumn detailButtonColumn = new()
                        {
                            HeaderText = "Detail",
                            Name = "Detail",
                            UseColumnTextForButtonValue = true
                        };
                        dataGridDetailOutput.Columns.Add(detailButtonColumn);

                        #endregion

                        labelUCDetailContains.Text = "Kluzký lak:";

                        dataGridDetailOutput.CellClick += dataGridOutputVarnish_CellClick;

                        break;
                    }
                default:
                    break;
            }
        }

        #region detail button handler

        private void dataGridDetailVarnish_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridDetailOutput.Columns[e.ColumnIndex].HeaderText == "Detail" && e.RowIndex > -1)
                {
                    string findingParemater = dataGridDetailOutput.Rows[e.RowIndex].Cells[1].Value.ToString();

                    mainUserControl.AddToHistory("CisticeAktivatory", findingParemater);

                    mainUserControl.ChangeUI(new UserControlDetail(findingParemater, "K", panel, mainUserControl), panel);
                }
            }
            catch
            {
                return;
            }
        }

        private void dataGridDetailGranulat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridDetailOutput.Columns[e.ColumnIndex].HeaderText == "Detail" && e.RowIndex > -1)
                {
                    string findingParemater = dataGridDetailOutput.Rows[e.RowIndex].Cells[1].Value.ToString();

                    mainUserControl.AddToHistory("Granulaty", findingParemater);

                    mainUserControl.ChangeUI(new UserControlDetail(findingParemater, "G", panel, mainUserControl), panel);
                }
            }
            catch
            {
                return;
            }
        }

        private void dataGridOutputVarnish_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridDetailOutput.Columns[e.ColumnIndex].HeaderText == "Detail" && e.RowIndex > -1)
                {
                    string findingParemater = dataGridDetailOutput.Rows[e.RowIndex].Cells[1].Value.ToString();

                    mainUserControl.AddToHistory("CisticeAktivatory", findingParemater);

                    mainUserControl.ChangeUI(new UserControlDetail(findingParemater, "G", panel, mainUserControl), panel);
                }
            }
            catch
            {
                return;
            }
        }

        #endregion

        #endregion

        #region project detail
        private void WriteProjectDetail()
        {
            Projekt projekt = MainForm.Projekty.Find(x => x.TL == findBy);

            List<Projekt> projekts = [projekt];

            dataGridMainOutput.AutoGenerateColumns = false;

            BindingSource source = new();
            source.DataSource = projekts;
            dataGridMainOutput.DataSource = source;


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
                HeaderText = "Název",
                DataPropertyName = "Nazev"
            };
            dataGridMainOutput.Columns.Add(nazevColumn);

            DataGridViewTextBoxColumn zkracenyPopisColumn = new()
            {
                Name = "ZkracenyPopis",
                HeaderText = "Zkrácený popis",
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

            BindingSource source1 = new();
            source1.DataSource = projekts;
            dataGridDetailOutput.DataSource = source1;

            DataGridViewButtonColumn detailButtonColumn = new()
            {
                HeaderText = "Detail",
                Name = "Detail"
            };
            dataGridDetailOutput.Columns.Add(detailButtonColumn);

            dataGridDetailOutput.CellClick += dataGridMaterialOutput_CellClick;

            dataGridDetailOutput.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(dataGridUCOutput_DataBindingComplete);

            labelUCDetailMainName.Text = "Projekt:";
            labelUCDetailContains.Text = "Materiály:";
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
            try
            {
                if (dataGridDetailOutput.Columns[e.ColumnIndex].HeaderText == "Detail" && e.RowIndex > -1)
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

                    mainUserControl.ChangeUI(new UserControlDetail(findingParemater, "M", panel, mainUserControl), panel);
                }

            }
            catch
            {
                return;
            }
        }
        #endregion

        #endregion
    }
}
