using SortifyDB;
using SortifyDB.DatabaseConnect;
using SortifyDB.ManualAddingInterface;
using SortifyDB.Objects;


namespace TechnoWizz.ManualAddingForm.Add
{
    public partial class MaterialAdd : UserControl
    {

        public MaterialAdd()
        {
            InitializeComponent();
        }

        private void MaterialAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtBoxNazev.Text == string.Empty && txtBoxSap.Text == string.Empty && btnSelecterTyp.Text == btnSelecterPlaceholder)
            {
                MainManualAdding mainManualForm = new();

                mainManualForm.ClearUserControl();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Opravdu chcete zrušit přidávání materiálu?", "Zrušit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    MainManualAdding mainManualForm = new();

                    mainManualForm.ClearUserControl();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //metod
            #region check if there is empty textboxes

            bool CheckTextoboxes()
            {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        if (c.Text == "")
                        {
                            MessageBox.Show("Žádné textové pole nemůže být prázdné", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }

                return true;
            }

            #endregion

            if (CheckTextoboxes() == true && btnSelecterTyp.Text != btnSelecterPlaceholder)
            {
                //add into list to work with it

                Material material = new(txtBoxSap.Text, txtBoxNazev.Text, btnSelecterTyp.Text);

                MainForm.Materials.Add(material);


                DatabaseConnection databaseConnection = new();
                _ = databaseConnection.PushMaterialToDatabase(material);

                MessageBox.Show("Materiál byl úspěšně přidán", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainManualAdding mainManualForm = new();
                mainManualForm.ClearUserControl();
            }
            else
            {
                MessageBox.Show("Vyplňte všechny údaje!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Check all btns

        private void CheckAllBtns()
        {

            if (dilSelected == true)
            {
                InvertColors(btnDil);
                btnDil.Text = "Díl";

                dilSelected = false;
            }

            if (polymerSelected == true)
            {
                InvertColors(btnPolymer);
                btnPolymer.Text = "Polymer";

                polymerSelected = false;
            }

            if (primerSelected == true)
            {
                InvertColors(btnPrimer);
                btnPrimer.Text = "Primer";

                primerSelected = false;
            }

            if (aktivatorSelected == true)
            {
                InvertColors(btnAktivator);
                btnAktivator.Text = "Aktivátor";

                aktivatorSelected = false;
            }

            if (lakSelected == true)
            {
                InvertColors(btnLak);
                btnLak.Text = "Kluzký lak";

                lakSelected = false;
            }

            if (redidloSelected == true)
            {
                InvertColors(btnRedidlo);
                btnRedidlo.Text = "Ředidlo";

                redidloSelected = false;
            }

            if (inkoustSelected == true)
            {
                InvertColors(btnInkoust);
                btnInkoust.Text = "Inkoust";

                inkoustSelected = false;
            }

        }

        #endregion

        #region Typ select

        private readonly string ZrusitPlaceholder = "Zrušit";
        private readonly string btnSelecterPlaceholder = "Vyberte typ materiálu";

        private void InvertColors(Button button)
        {
            if (button.BackColor == Color.White)
            {
                CheckAllBtns();

                button.BackColor = Color.FromArgb(0, 38, 255);
                button.ForeColor = Color.White;
            }
            else
            {
                button.BackColor = Color.White;
                button.ForeColor = Color.FromArgb(0, 38, 255);
            }
        }

        bool dilSelected = false;
        private void btnDíl_Click(object sender, EventArgs e)
        {
            string btnDilText = "Díl";

            if (btnSelecterTyp.Text == btnDilText)
            {
                CheckAllBtns();

                InvertColors(btnDil);

                btnSelecterTyp.Text = btnDilText;
                btnDil.Text = ZrusitPlaceholder;

            }
            else
            {
                InvertColors(btnDil);

                btnSelecterTyp.Text = btnDilText;
                btnDil.Text = btnDilText;
            }

            TypTimer.Start();
        }


        private bool polymerSelected = false;
        private void btnPolymer_Click(object sender, EventArgs e)
        {
            string btnPolymerText = "Polymer";

            if (polymerSelected == false)
            {
                CheckAllBtns();

                InvertColors(btnPolymer);

                btnPolymer.Text = ZrusitPlaceholder;
                btnSelecterTyp.Text = btnPolymerText;

                polymerSelected = true;
            }
            else
            {
                InvertColors(btnPolymer);

                btnPolymer.Text = btnPolymerText;
                btnSelecterTyp.Text = btnSelecterPlaceholder;

                polymerSelected = false;
            }

            TypTimer.Start();
        }

        private bool primerSelected = false;
        private void btnPrimer_Click(object sender, EventArgs e)
        {
            string btnPrimerText = "Primer";

            if (primerSelected == false)
            {
                CheckAllBtns();

                InvertColors(btnPrimer);

                btnPrimer.Text = ZrusitPlaceholder;
                btnSelecterTyp.Text = btnPrimerText;

                primerSelected = true;
            }
            else
            {
                InvertColors(btnPrimer);

                btnPrimer.Text = btnPrimerText;
                btnSelecterTyp.Text = btnSelecterPlaceholder;

                primerSelected = false;
            }

            TypTimer.Start();
        }

        private bool aktivatorSelected = false;
        private void btnAktivator_Click(object sender, EventArgs e)
        {
            string btnAktivatorText = "Aktivátor";

            if (aktivatorSelected == false)
            {
                CheckAllBtns();

                InvertColors(btnAktivator);

                btnAktivator.Text = ZrusitPlaceholder;
                btnSelecterTyp.Text = btnAktivatorText;

                aktivatorSelected = true;
            }
            else
            {
                InvertColors(btnAktivator);

                btnAktivator.Text = btnAktivatorText;
                btnSelecterTyp.Text = btnSelecterPlaceholder;

                aktivatorSelected = false;
            }

            TypTimer.Start();
        }

        private bool lakSelected = false;
        private void btnLak_Click(object sender, EventArgs e)
        {
            string btnLakText = "Kluzký lak";

            if (lakSelected == false)
            {
                CheckAllBtns();

                InvertColors(btnLak);

                btnLak.Text = ZrusitPlaceholder;
                btnSelecterTyp.Text = btnLakText;

                lakSelected = true;
            }
            else
            {
                InvertColors(btnLak);

                btnLak.Text = btnLakText;
                btnSelecterTyp.Text = btnSelecterPlaceholder;

                lakSelected = false;
            }

            TypTimer.Start();
        }

        private bool redidloSelected = false;
        private void btnRedidlo_Click(object sender, EventArgs e)
        {
            string btnRedidloText = "Ředidlo";

            if (redidloSelected == false)
            {
                CheckAllBtns();

                InvertColors(btnRedidlo);

                btnRedidlo.Text = ZrusitPlaceholder;
                btnSelecterTyp.Text = btnRedidloText;

                redidloSelected = true;
            }
            else
            {
                InvertColors(btnRedidlo);

                btnRedidlo.Text = btnRedidloText;
                btnSelecterTyp.Text = btnSelecterPlaceholder;

                redidloSelected = false;
            }

            TypTimer.Start();
        }

        private bool inkoustSelected = false;
        private void btnInkoust_Click(object sender, EventArgs e)
        {
            string btnInkoustText = "Inkoust";

            if (inkoustSelected == false)
            {
                CheckAllBtns();

                InvertColors(btnInkoust);

                btnInkoust.Text = ZrusitPlaceholder;
                btnSelecterTyp.Text = btnInkoustText;

                inkoustSelected = true;
            }
            else
            {
                InvertColors(btnInkoust);

                btnInkoust.Text = btnInkoustText;
                btnSelecterTyp.Text = btnSelecterPlaceholder;

                inkoustSelected = false;
            }

            TypTimer.Start();
        }
        #endregion

        #region expand and collapse
        private bool expanded = false;
        private void TypTimer_Tick(object sender, EventArgs e)
        {
            if (expanded == false)
            {
                typContainer.Height += 10;
                if (typContainer.Height >= 400)
                {
                    TypTimer.Stop();
                    expanded = true;
                }
            }
            else
            {
                typContainer.Height -= 10;
                if (typContainer.Height <= 50)
                {
                    TypTimer.Stop();
                    expanded = false;
                }
            }

            TypTimer.Start();
        }

        private void btnSelecterTyp_Click(object sender, EventArgs e)
        {
            TypTimer.Start();
        }

        #endregion
    }
}
