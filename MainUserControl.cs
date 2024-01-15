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

        private void ChangeUI<T>(UserControl userControl, List<T> list)
        {
            panel4.Controls.Clear();

            panel4.Controls.Add(userControl);
        }


        private readonly Dictionary<string, string> history = [];

        private void AddToHistory(string key, string value)
        {
            if (history.Count > 10)
            {
                history.Remove(history.First().Key);
            }


            history.Add(key, value);
        }

        private void BtnProjekty_Click(object sender, EventArgs e)
        {
            AddToHistory("Projekty", "All");


        }

        private void BtnMat_Click(object sender, EventArgs e)
        {
            AddToHistory("Materialy", "All");
        }

        private void BtnCleanActive_Click(object sender, EventArgs e)
        {
            AddToHistory("CisticeAktivatory", "All");
        }

        private void BtnVarnish_Click(object sender, EventArgs e)
        {
            AddToHistory("KluzkeLaky", "All");
        }

        private void BtnGran_Click(object sender, EventArgs e)
        {
            AddToHistory("Granulaty", "All");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            switch (history.Last().Key)
            {
                case "Projekty":
                    {
                        if (history.Last().Value == "All")
                        {

                        }
                        else
                        {

                        }

                        break;
                    }
                case "Materialy":
                    {
                        if (history.Last().Value == "All")
                        {

                        }
                        else
                        {

                        }

                        break;
                    }
                case "CisticeAktivatory":
                    {


                        break;
                    }
                case "KluzkeLaky":
                    {


                        break;
                    }
                case "Granulaty":
                    {


                        break;
                    }
                default:
                    break;
            }



        }

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

        private void BtnMainFormsAdd_Click(object sender, EventArgs e)
        {

        }

        private void BtnParser_Click(object sender, EventArgs e)
        {
            PdfParsing.ParsePDF();
        }
    }
}
