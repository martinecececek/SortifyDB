namespace SortifyDB.PDF_parser
{
    public partial class GetPreviousTL : Form
    {
        public GetPreviousTL()
        {
            InitializeComponent();
        }

        public string TL;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                TL = textBox1.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Nebylo zadáno číslo TL!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
