using MaterialSkin.Controls;
using Microsoft.Graph.Models;
using SortifyDB.Objects;

namespace SortifyDB
{
    public partial class MainForm : MaterialForm
    {
        //create lists of objects from sheets
        public static List<Material>? Materials { get; set; }
        public static List<KluzkyLak> KluzkeLaky { get; set; }
        public static List<Granulat> Granulaty { get; set; }
        public static List<CisiticAktivator> CisticeAktivatory { get; set; }
        public static List<Projekt> Projekty { get; set; }

        public static List<TodoTask> Tasks { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }
    }
}
