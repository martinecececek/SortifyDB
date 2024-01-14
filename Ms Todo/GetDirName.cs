namespace SortifyDB.Ms_Todo
{
    public partial class GetDirName : Form
    {
        public GetDirName()
        {
            InitializeComponent();
        }

        public string dirName
        {
            get { return txtDirName.Text; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDirName.Text == "")
            {
                MessageBox.Show("Zadejte název složky", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
