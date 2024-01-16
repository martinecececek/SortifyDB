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

        public void ChangeUI(UserControl userControl, Panel panel)
        {
            panel.Controls.Clear();

            panel.Controls.Add(userControl);
        }

        #region basic buttons
        private void BtnProjekty_Click(object sender, EventArgs e)
        {
            AddToHistory("Projekty", "All");

            ChangeUI(new UserControlOutPut("P", panelMainShower), panelMainShower);
        }

        private void BtnMat_Click(object sender, EventArgs e)
        {
            AddToHistory("Materialy", "All");

            ChangeUI(new UserControlOutPut("M", panelMainShower), panelMainShower);
        }

        private void BtnCleanActive_Click(object sender, EventArgs e)
        {
            AddToHistory("CisticeAktivatory", "All");

            ChangeUI(new UserControlOutPut("C", panelMainShower), panelMainShower);
        }

        private void BtnVarnish_Click(object sender, EventArgs e)
        {
            AddToHistory("KluzkeLaky", "All");

            ChangeUI(new UserControlOutPut("K", panelMainShower), panelMainShower);
        }

        private void BtnGran_Click(object sender, EventArgs e)
        {
            AddToHistory("Granulaty", "All");

            ChangeUI(new UserControlOutPut("G", panelMainShower), panelMainShower);
        }
        #endregion

        #region history 

        private readonly Stack<KeyValuePair<string, string>> history = new();

        public void AddToHistory(string key, string value)
        {
            //TODO: finish and move -1 index

            if (history.Count > 10)
            {
                var temp = new Stack<KeyValuePair<string, string>>();

                for (int i = 0; i < 9; i++)
                {
                    temp.Push(history.Pop());
                }

                history.Pop();

                while (temp.Count > 0)
                {
                    history.Push(temp.Pop());
                }

            }


            history.Push(new KeyValuePair<string, string>(key, value));
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (history.Count == 0)
            {
                return;
            }

            switch (history.Last().Key)
            {
                case "Projekty":
                    {
                        if (history.Last().Value == "All")
                        {
                            ChangeUI(new UserControlOutPut("P", panelMainShower), panelMainShower);
                        }
                        else
                        {
                            ChangeUI(new UserControlDetail(history.Last().Value, "P", panelMainShower), panelMainShower);
                        }

                        break;
                    }
                case "Materialy":
                    {
                        if (history.Last().Value == "All")
                        {
                            ChangeUI(new UserControlOutPut("M", panelMainShower), panelMainShower);
                        }
                        else
                        {
                            ChangeUI(new UserControlDetail(history.Last().Value, "M", panelMainShower), panelMainShower);
                        }

                        break;
                    }
                case "CisticeAktivatory":
                    {
                        ChangeUI(new UserControlOutPut("C", panelMainShower), panelMainShower);

                        break;
                    }
                case "KluzkeLaky":
                    {
                        ChangeUI(new UserControlOutPut("K", panelMainShower), panelMainShower);

                        break;
                    }
                case "Granulaty":
                    {
                        ChangeUI(new UserControlOutPut("G", panelMainShower), panelMainShower);

                        break;
                    }
                default:
                    break;
            }

            var temp = new Stack<KeyValuePair<string, string>>();

            while (history.Count > 1)
            {
                temp.Push(history.Pop());
            }

            history.Pop();

            while (temp.Count > 0)
            {
                history.Push(temp.Pop());
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
