using SortifyDB.Cbtn;
using SortifyDB.ManualAddingInterface;
using SortifyDB.Ms_Todo;
using SortifyDB.Objects;
using SortifyDB.PDF_parser;

namespace SortifyDB
{
    public partial class MainUserControl : UserControl
    {
        //Vzled
        public MainUserControl()
        {
            InitializeComponent();
        }

        private void MainUserControl_Load(object sender, EventArgs e)
        {
            MsTodoAPI.ExecuteAsync();

            if (MsTodoAPI.GraphClient != null)
            {
                CreateButtons();
            }

        }

        public void ChangeUI(UserControl userControl, Panel panel)
        {
            panel.Controls.Clear();
            userControl.Location = new Point(5, 5);
            panel.Controls.Add(userControl);
        }

        #region ToDo Buttons

        private void CreateButtons()
        {
            flowLayoutPanelToDo.Controls.Clear();
            int buttonWidth = 190;
            int buttonHeight = 60;
            int spacing = 10;
            int startXst = 10;
            int startX = startXst;
            int startY = 10;

            foreach (TodoTask tasks in MainForm.TodoTask)
            {
                CBtn buttonXToDo = new();
                buttonXToDo.Text = tasks.Title;
                buttonXToDo.Width = buttonWidth;
                buttonXToDo.Height = buttonHeight;
                buttonXToDo.Location = new System.Drawing.Point(startX, startY);
                buttonXToDo.BackColor = Color.FromArgb(0, 142, 255);
                buttonXToDo.BackgroundColor = Color.FromArgb(0, 142, 255);
                buttonXToDo.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold);
                startX += buttonWidth + spacing;

                CBtn buttonYToDo = new();
                buttonYToDo.Text = "Označit jako hotové";
                buttonYToDo.Width = buttonWidth;
                buttonYToDo.Height = buttonHeight;
                buttonYToDo.Location = new System.Drawing.Point(startX, startY);
                buttonYToDo.BackColor = Color.FromArgb(0, 142, 255);
                buttonYToDo.BackgroundColor = Color.FromArgb(0, 142, 255);
                buttonYToDo.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold);
                //buttonXToDo.Click += MsTodoAPI.TodoTaskCompleted(tasks); // pls jediné co udělat.

                flowLayoutPanelToDo.Controls.Add(buttonXToDo);
                flowLayoutPanelToDo.Controls.Add(buttonYToDo);

                startY += buttonHeight + spacing;
                startX = startXst;
            }
        }


        #endregion

        #region basic buttons
        private void BtnProjekty_Click(object sender, EventArgs e)
        {
            AddToHistory("Projekty", "All");

            ChangeUI(new UserControlOutPut("P", panelMainShower, this), panelMainShower);
        }

        private void BtnMat_Click(object sender, EventArgs e)
        {
            AddToHistory("Materialy", "All");

            ChangeUI(new UserControlOutPut("M", panelMainShower, this), panelMainShower);
        }

        private void BtnCleanActive_Click(object sender, EventArgs e)
        {
            AddToHistory("CisticeAktivatory", "All");

            ChangeUI(new UserControlOutPut("C", panelMainShower, this), panelMainShower);
        }

        private void BtnVarnish_Click(object sender, EventArgs e)
        {
            AddToHistory("KluzkeLaky", "All");

            ChangeUI(new UserControlOutPut("K", panelMainShower, this), panelMainShower);
        }

        private void BtnGran_Click(object sender, EventArgs e)
        {
            AddToHistory("Granulaty", "All");

            ChangeUI(new UserControlOutPut("G", panelMainShower, this), panelMainShower);
        }
        #endregion

        #region history 

        public List<KeyValuePair<string, string>> history = new();

        public void AddToHistory(string key, string value)
        {

            if (history.Count > 10)
            {
                history.Remove(history.First());
            }

            history.Add(new KeyValuePair<string, string>(key, value));

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (history.Count.Equals(0))
            {
                return;
            }

            switch (history.Last().Key)
            {
                case "Projekty":
                    {

                        if (history.Last().Value == "All")
                        {
                            ChangeUI(new UserControlOutPut("P", panelMainShower, this), panelMainShower);
                            break;
                        }

                        ChangeUI(new UserControlDetail(history.Last().Value, "P", panelMainShower, this), panelMainShower);

                        break;
                    }
                case "Materialy":
                    {
                        if (history.Last().Value == "All")
                        {
                            ChangeUI(new UserControlOutPut("M", panelMainShower, this), panelMainShower);
                            break;
                        }

                        ChangeUI(new UserControlDetail(history.Last().Value, "P", panelMainShower, this), panelMainShower);


                        break;
                    }
                case "CisticeAktivatory":
                    {
                        if (history.Last().Value == "All")
                        {
                            ChangeUI(new UserControlOutPut("C", panelMainShower, this), panelMainShower);
                            break;
                        }

                        ChangeUI(new UserControlDetail(history.Last().Value, "P", panelMainShower, this), panelMainShower);

                        break;
                    }
                case "KluzkeLaky":
                    {
                        if (history.Last().Value == "All")
                        {
                            ChangeUI(new UserControlOutPut("K", panelMainShower, this), panelMainShower);
                            break;
                        }

                        ChangeUI(new UserControlDetail(history.Last().Value, "P", panelMainShower, this), panelMainShower);

                        break;
                    }
                case "Granulaty":
                    {
                        if (history.Last().Value == "All")
                        {
                            ChangeUI(new UserControlOutPut("G", panelMainShower, this), panelMainShower);
                            break;
                        }

                        ChangeUI(new UserControlDetail(history.Last().Value, "P", panelMainShower, this), panelMainShower);

                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            history.Remove(history.Last());
        }

        #endregion

        #region search
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (searchBox.Text == string.Empty)
            {
                //TODO: finish
                MessageBox.Show("Zadejte hledaný výraz");
                return;
            }

            if (checkBoxProjects.Checked)
            {
                List<Projekt> projetky = SearchInProjects();

                if (projetky.Count == 0)
                {
                    MessageBox.Show("Projekt nebyl nalezen", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                AddToHistory("Projekty", searchBox.Text);

                UserControlOutPut userControlOutPut = new("P", panelMainShower, this);

                ChangeUI(userControlOutPut, panelMainShower);

                userControlOutPut.WriteProjektsFromSearch(projetky);
            }


            if (checkBoxMaterials.Checked)
            {
                List<Material> materials = SearchInMaterials();

                if (materials.Count == 0)
                {
                    MessageBox.Show("Material nebyl nalezen", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                UserControlOutPut userControlOutPut = new("M", panelMainShower, this);

                ChangeUI(userControlOutPut, panelMainShower);

                userControlOutPut.WriteMaterialsFromSearch(materials);
            }

            if (checkBoxCleanActive.Checked)
            {
                List<CisiticAktivator> cisiticAktivators = SearchInCistice();

                if (cisiticAktivators.Count == 0)
                {
                    MessageBox.Show("Čistič nebyl nalezen", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                UserControlOutPut userControlOutPut = new("C", panelMainShower, this);

                ChangeUI(userControlOutPut, panelMainShower);

                userControlOutPut.WriteCisticeFromSearch(cisiticAktivators);
            }

            if (checkBoxVarnish.Checked)
            {
                List<KluzkyLak> kluzkyLaks = SearchInVarnish();

                if (kluzkyLaks.Count == 0)
                {
                    MessageBox.Show("Lak nebyl nalezen", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                UserControlOutPut userControlOutPut = new("K", panelMainShower, this);

                ChangeUI(userControlOutPut, panelMainShower);

                userControlOutPut.WriteLakyFromSearch(kluzkyLaks);
            }

            if (checkBoxGran.Checked)
            {
                List<Granulat> granulats = SearchInGranulat();

                if (granulats.Count == 0)
                {
                    MessageBox.Show("Granulat nebyl nalezen", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                UserControlOutPut userControlOutPut = new("G", panelMainShower, this);

                ChangeUI(userControlOutPut, panelMainShower);

                userControlOutPut.WriteGranulatyFromSearch(granulats);
            }

        }

        #region search in
        private List<Projekt> SearchInProjects()
        {
            List<Projekt> projects = [];

            foreach (Projekt projekt in MainForm.Projekty)
            {
                if (projekt.Nazev.ToLower() == searchBox.Text.ToLower() ||
                    projekt.TL.ToLower() == searchBox.Text.ToLower() ||
                    projekt.IMDS == searchBox.Text)
                {
                    projects.Add(projekt);
                }
            }

            return projects;
        }

        private List<Material> SearchInMaterials()
        {
            List<Material> materials = [];

            foreach (Material material in MainForm.Materials)
            {
                if (material.Nazev.ToLower() == searchBox.Text.ToLower() ||
                    material.SAP == searchBox.Text)
                {
                    materials.Add(material);
                }
            }

            return materials;
        }

        private List<CisiticAktivator> SearchInCistice()
        {
            List<CisiticAktivator> cisiticAktivators = [];

            foreach (CisiticAktivator cisiticAktivator in MainForm.CisticeAktivatory)
            {
                if (cisiticAktivator.Nazev.ToLower() == searchBox.Text.ToLower() ||
                    cisiticAktivator.SAP == searchBox.Text)
                {
                    cisiticAktivators.Add(cisiticAktivator);
                }
            }

            return cisiticAktivators;
        }

        private List<KluzkyLak> SearchInVarnish()
        {
            List<KluzkyLak> kluzkeLaks = [];

            foreach (KluzkyLak kluzkeLak in MainForm.KluzkeLaky)
            {
                if (kluzkeLak.Nazev.ToLower() == searchBox.Text.ToLower() ||
                                       kluzkeLak.SAP == searchBox.Text)
                {
                    kluzkeLaks.Add(kluzkeLak);
                }
            }

            return kluzkeLaks;
        }

        private List<Granulat> SearchInGranulat()
        {
            List<Granulat> granulats = [];

            foreach (Granulat granulat in MainForm.Granulaty)
            {
                if (granulat.Nazev.ToLower() == searchBox.Text.ToLower() ||
                                       granulat.SAP == searchBox.Text)
                {
                    granulats.Add(granulat);
                }
            }

            return granulats;
        }

        #endregion

        #region check boxes
        private void checkBoxProjects_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMaterials.Checked)
            {
                checkBoxMaterials.Checked = false;
            }

            if (checkBoxCleanActive.Checked)
            {
                checkBoxCleanActive.Checked = false;
            }

            if (checkBoxVarnish.Checked)
            {
                checkBoxVarnish.Checked = false;
            }

            if (checkBoxGran.Checked)
            {
                checkBoxGran.Checked = false;
            }
        }

        private void checkBoxMaterials_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxProjects.Checked)
            {
                checkBoxProjects.Checked = false;
            }

            if (checkBoxCleanActive.Checked)
            {
                checkBoxCleanActive.Checked = false;
            }

            if (checkBoxVarnish.Checked)
            {
                checkBoxVarnish.Checked = false;
            }

            if (checkBoxGran.Checked)
            {
                checkBoxGran.Checked = false;
            }
        }

        private void checkBoxCleanActive_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxProjects.Checked)
            {
                checkBoxProjects.Checked = false;
            }

            if (checkBoxMaterials.Checked)
            {
                checkBoxMaterials.Checked = false;
            }

            if (checkBoxVarnish.Checked)
            {
                checkBoxVarnish.Checked = false;
            }

            if (checkBoxGran.Checked)
            {
                checkBoxGran.Checked = false;
            }
        }

        private void checkBoxVarnish_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxProjects.Checked)
            {
                checkBoxProjects.Checked = false;
            }

            if (checkBoxMaterials.Checked)
            {
                checkBoxMaterials.Checked = false;
            }

            if (checkBoxCleanActive.Checked)
            {
                checkBoxCleanActive.Checked = false;
            }

            if (checkBoxGran.Checked)
            {
                checkBoxGran.Checked = false;
            }
        }

        private void checkBoxGran_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxProjects.Checked)
            {
                checkBoxProjects.Checked = false;
            }

            if (checkBoxMaterials.Checked)
            {
                checkBoxMaterials.Checked = false;
            }

            if (checkBoxCleanActive.Checked)
            {
                checkBoxCleanActive.Checked = false;
            }

            if (checkBoxVarnish.Checked)
            {
                checkBoxVarnish.Checked = false;
            }
        }
        #endregion

        #endregion

        #region open 3th party 
        private void BtnMainFormsAdd_Click(object sender, EventArgs e)
        {
            ChangeMainFormUI(new MainManualAdding());
        }

        private void ChangeMainFormUI(UserControl userControl)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            if (mainForm != null)
            {
                mainForm.Controls.Clear();

                userControl.Location = new Point(0, 65);

                mainForm.Controls.Add(userControl);
            }
        }

        private void BtnParser_Click(object sender, EventArgs e)
        {
            PdfParsing.ParsePDF();
        }
        #endregion



    }
}
