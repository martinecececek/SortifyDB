using MaterialSkin.Controls;
using SortifyDB.Objects;
using System.Windows.Forms;

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

        public static List<Ms_Todo.TodoTask> TodoTask { get; set; }

        public MainForm()
        {
            InitializeComponent();
            /*this.AutoScaleMode = AutoScaleMode.Dpi;
            this.WindowState = FormWindowState.Maximized;
            this.ClientSize = new System.Drawing.Size(800, 400);*/
        }
    }
}
