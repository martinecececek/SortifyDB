namespace SortifyDB.PDF_parser
{
    public partial class MainPdfParserForm : Form
    {
        public MainPdfParserForm()
        {
            InitializeComponent();
        }

        public string pdfPath;
        public string addEdit;

        private void MainPdfParserForm_Load(object sender, EventArgs e)
        {
            pdfPath = GetDataFromFileDialog();
        }

        private string GetDataFromFileDialog()
        {
            OpenFileDialog openFileDialog = new()
            {
                InitialDirectory = "C:\\",
                Title = "Select a PDF file",
                Filter = "PDF Files|*.pdf|All Files|*.*",
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file's path
                return openFileDialog.FileName;
            }

            return string.Empty;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            addEdit = "edit";
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addEdit = "add";
            this.Close();
        }
    }
}
