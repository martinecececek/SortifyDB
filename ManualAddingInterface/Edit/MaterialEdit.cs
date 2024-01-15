using SortifyDB.DatabaseConnect;
using SortifyDB.ManualAddingInterface;
using SortifyDB.Objects;
using TechnoWizz.ManualAddingForm.Select;

namespace TechnoWizz.ManualAddingForm.Edit
{
    public partial class MaterialEdit : UserControl
    {
        public MaterialEdit(Material material)
        {
            InitializeComponent();

            Material = material;
        }

        public Material Material { get; set; }

        private void MaterialEdit_Load(object sender, System.EventArgs e)
        {
            txtBoxSap.Text = Material.SAP;

            txtBoxNazev.Text = Material.Nazev;

            switch (Material.TypPripravku)
            {
                case "Díl":
                    BtnDíl_Click(sender, e);
                    break;
                case "Polymer":
                    BtnPolymer_Click(sender, e);
                    break;
                case "Primer":
                    BtnPrimer_Click(sender, e);
                    break;
                case "Aktivátor":
                    BtnAktivator_Click(sender, e);
                    break;
                case "Kluzký lak":
                    BtnLak_Click(sender, e);
                    break;
                case "Ředidlo":
                    BtnRedidlo_Click(sender, e);
                    break;
                case "Inkoust":
                    BtnInkoust_Click(sender, e);
                    break;
            }

        }

        private void BtnSave_Click(object sender, System.EventArgs e)
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


                #region push into database

                DatabaseConnection dbC = new();
                dbC.UpdateMaterial(material);

                #endregion

                MessageBox.Show("Materiál byl úspěšně přidán", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = string.Empty;
                    }
                }

                MainManualAdding mainManualForm = new();
                MaterialSelect materialSelect = new();

                mainManualForm.ChangeUI(materialSelect);
            }

            return;
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
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
        private void BtnDíl_Click(object sender, EventArgs e)
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
        }


        private bool polymerSelected = false;
        private void BtnPolymer_Click(object sender, EventArgs e)
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


        }

        private bool primerSelected = false;
        private void BtnPrimer_Click(object sender, EventArgs e)
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

        }

        private bool aktivatorSelected = false;
        private void BtnAktivator_Click(object sender, EventArgs e)
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
        }

        private bool lakSelected = false;
        private void BtnLak_Click(object sender, EventArgs e)
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
        }

        private bool redidloSelected = false;
        private void BtnRedidlo_Click(object sender, EventArgs e)
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
        }

        private bool inkoustSelected = false;
        private void BtnInkoust_Click(object sender, EventArgs e)
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
        }
        #endregion

        private void BtnSelecterTyp_Click(object sender, EventArgs e)
        {
            typTimer.Start();
        }

        bool expand = false;
        private void TypTimer_Tick(object sender, EventArgs e)
        {
            if (expand == false)
            {
                typContainer.Height += 10;
                if (typContainer.Height >= 400)
                {
                    typTimer.Stop();
                    expand = true;
                }
            }
            else
            {
                typContainer.Height -= 10;
                if (typContainer.Height <= 50)
                {
                    typTimer.Stop();
                    expand = false;
                }
            }
        }
    }
}
