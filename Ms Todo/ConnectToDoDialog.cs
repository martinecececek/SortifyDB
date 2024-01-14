namespace SortifyDB.Ms_Todo
{
    public partial class ConnectToDoDialog : Form
    {
        public ConnectToDoDialog()
        {
            InitializeComponent();
        }

        public bool ShowAgain
        {
            get { return checkBoxShowAgain.Checked; }
        }

        public bool connect;

        private void bntAno_Click(object sender, EventArgs e)
        {
            connect = true;
            this.Close();
        }

        private void btnNe_Click_1(object sender, EventArgs e)
        {

            connect = false;
            this.Close();
        }

        private void checkBoxShowAgain_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
