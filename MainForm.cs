using MaterialSkin.Controls;
using SortifyDB.Objects;

namespace SortifyDB
{
    public partial class MainForm : MaterialForm
    {
        //create lists of objects from sheets
        public static List<Material> Materials { get; set; } = [];
        public static List<KluzkyLak> KluzkeLaky { get; set; } = [];
        public static List<Granulat> Granulaty { get; set; } = [];
        public static List<CisiticAktivator> CisticeAktivatory { get; set; } = [];
        public static List<Projekt> Projekty { get; set; } = [];

        public static List<Ms_Todo.TodoTask> TodoTask { get; set; } = [];

        public MainForm()
        {
            InitializeComponent();
            /*this.AutoScaleMode = AutoScaleMode.Dpi;
            this.WindowState = FormWindowState.Maximized;
            this.ClientSize = new System.Drawing.Size(800, 400);*/

        }

        public bool done = false;

        private void MainForm_Load(object sender, EventArgs e)
        {
            #region dummy data

            #region materials dummy data
            string[] dummyData = ["aktivátor/èistiè", "díl", "polymer/lepidlo", "primer", "kluzný lak", "inkoust", "øedidlo"];

            Random random = new();

            for (int i = 0; i < 21; i++)
            {
                Material material = new("SAP" + i, "Nazev" + i, dummyData[random.Next(0, dummyData.Length)]);
                Materials.Add(material);
            }
            #endregion

            #region projekty dummy data

            for (int i = 0; i < 4; i++)
            {
                List<Material> materials = new();

                for (int j = 0; j < 3; j++)
                {
                    materials.Add(Materials[random.Next(0, Materials.Count)]);
                }

                Projekt projekt = new(i.ToString(), "Nazev" + i, materials, "ZkracenyPopis" + i, "Sklo" + i, "Temp" + i, "Trh" + i, "IMDS" + i);
                Projekty.Add(projekt);
            }

            #endregion

            #region granulaty dummy data

            for (int i = 0; i < 4; i++)
            {
                Dictionary<string, string> slozeni = new();
                for (int j = 0; j < 17; j++)
                {
                    slozeni.Add("Nazev" + j, "Procenta" + j);
                }

                Granulaty.Add(new("SAP" + i, "Nazev" + i, "Typ" + i, "Xk" + i, "JeAktivni" + i, "Vyrobce" + i, "Pouziti" + i, "KombinaceS" + i, "Cisteni" + i, "NevhodneKombinace" + i, "SlozeniDle" + i, slozeni));
            }

            #endregion

            #region kluzke laky dummy data

            for (int i = 0; i < 5; i++)
            {

                Dictionary<string, string> slozeni = new();
                for (int j = 0; j < 14; j++)
                {
                    slozeni.Add("Nazev" + j, "Procenta" + j);
                }

                KluzkeLaky.Add(new("SAP" + i, "Nazev" + i, "JeAktivni" + i, "Vyrobce" + i, "Pouziti" + i, "NevhodneKombinace" + i, "SlozeniDle" + i, slozeni));
            }

            #endregion

            #region cistice aktivatory dummy data

            for (int i = 0; i < 5; i++)
            {

                Dictionary<string, string> slozeni = new();
                for (int j = 0; j < 13; j++)
                {
                    slozeni.Add("Nazev" + j, "Procenta" + j);
                }

                CisticeAktivatory.Add(new("SAP" + i, "Nazev" + i, "JeAktivni" + i, "Vyrobce" + i, "Pouziti" + i, "NevhodneKombinace" + i, "SlozeniDle" + i, slozeni));
            }

            #endregion

            #endregion
        }
    }
}
