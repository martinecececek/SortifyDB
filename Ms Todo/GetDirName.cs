namespace SortifyDB.Ms_Todo
{
    public partial class GetDirName : Form
    {
        public GetDirName()
        {
            InitializeComponent();
        }

        public string dirName;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDirName.Text == "")
            {
                dirName = "Tasks";
                this.Close();
            }
            else
            {
                dirName = txtDirName.Text;
                this.Close();
            }
        }
    }
}
