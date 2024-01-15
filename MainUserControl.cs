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

        public void ChangeUI(UserControl userControl)
        {
            panelMainShower.Controls.Clear();

            panelMainShower.Controls.Add(userControl);
        }

        #region basic buttons
        private void BtnProjekty_Click(object sender, EventArgs e)
        {
            AddToHistory("Projekty", "All");

            ChangeUI(new UserControlOutPut("P", panelMainShower));
        }

        private void BtnMat_Click(object sender, EventArgs e)
        {
            AddToHistory("Materialy", "All");

            ChangeUI(new UserControlOutPut("M", panelMainShower));
        }

        private void BtnCleanActive_Click(object sender, EventArgs e)
        {
            AddToHistory("CisticeAktivatory", "All");

            ChangeUI(new UserControlOutPut("C", panelMainShower));
        }

        private void BtnVarnish_Click(object sender, EventArgs e)
        {
            AddToHistory("KluzkeLaky", "All");

            ChangeUI(new UserControlOutPut("K", panelMainShower));
        }

        private void BtnGran_Click(object sender, EventArgs e)
        {
            AddToHistory("Granulaty", "All");

            ChangeUI(new UserControlOutPut("G", panelMainShower));
        }
        #endregion

        #region history 

        private readonly Dictionary<string, string> history = [];

        public void AddToHistory(string key, string value)
        {
            if (history.Count > 10)
            {
                history.Remove(history.First().Key);
            }

            if (history.ContainsKey(key))
            {
                history.Remove(key);
            }

            history.Add(key, value);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            switch (history.Last().Key)
            {
                case "Projekty":
                    {
                        if (history.Last().Value == "All")
                        {
                            ChangeUI(new UserControlOutPut("P", panelMainShower));
                        }
                        else
                        {
                            ChangeUI(new UserControlDetail(history.Last().Value, "P", panelMainShower));
                        }

                        break;
                    }
                case "Materialy":
                    {
                        if (history.Last().Value == "All")
                        {
                            ChangeUI(new UserControlOutPut("M", panelMainShower));
                        }
                        else
                        {
                            ChangeUI(new UserControlDetail(history.Last().Value, "M", panelMainShower));
                        }

                        break;
                    }
                case "CisticeAktivatory":
                    {
                        ChangeUI(new UserControlOutPut("C", panelMainShower));

                        break;
                    }
                case "KluzkeLaky":
                    {
                        ChangeUI(new UserControlOutPut("K", panelMainShower));

                        break;
                    }
                case "Granulaty":
                    {
                        ChangeUI(new UserControlOutPut("G", panelMainShower));

                        break;
                    }
                default:
                    break;
            }
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

        }

        private void BtnParser_Click(object sender, EventArgs e)
        {
            PdfParsing.ParsePDF();
        }
        #endregion
    }
}
