using SortifyDB.ManualAddingInterface;
using SortifyDB.Ms_Todo;
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


        }

        public void ChangeUI(UserControl userControl, Panel panel)
        {
            panel.Controls.Clear();
            userControl.Location = new Point(5, 5);
            panel.Controls.Add(userControl);
        }

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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (searchBox.Text == string.Empty)
            {
                //TODO: finish
                MessageBox.Show("Zadejte hledaný výraz");
                return;
            }

            //check if searchBox.Text is in any of granulaty
            if (MainForm.Granulaty.Any(granulat => granulat.Nazev == searchBox.Text ||
                                                   granulat.Vyrobce == searchBox.Text ||
                                                   granulat.Typ == searchBox.Text))
            {





            }

            //check if searchBox.Text is in any of kluzke laky
            if (MainForm.KluzkeLaky.Any(lak => lak.Nazev == searchBox.Text ||
                                               lak.Vyrobce == searchBox.Text))
            {

            }

            //check if searchBox.Text is in any of cistice aktivatory
            if (MainForm.CisticeAktivatory.Any(cistice => cistice.Nazev == searchBox.Text ||
                                                          cistice.Vyrobce == searchBox.Text))
            {

            }

            //check if searchBox.Text is in any of projects
            if (MainForm.Projekty.Any(projekt => projekt.Nazev == searchBox.Text ||
                                                 projekt.TL == searchBox.Text ||
                                                 projekt.IMDS == searchBox.Text))
            {

            }

            //check if searchBox.Text is in any of materials
            if (MainForm.Materials.Any(material => material.Nazev == searchBox.Text ||
                                                   material.SAP == searchBox.Text))
            {



            }

        }

        #region open 3th party 
        private void BtnMainFormsAdd_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new();
            mainForm.ChangeUI(new MainManualAdding());
        }

        private void BtnParser_Click(object sender, EventArgs e)
        {
            PdfParsing.ParsePDF();
        }
        #endregion


    }



}
