using SortifyDB.ManualAddingInterface.Add;

namespace SortifyDB.ManualAddingInterface
{
    public partial class MainManualAdding : UserControl
    {
        public MainManualAdding()
        {
            InitializeComponent();
        }

        public void ChangeUI(UserControl uc)
        {
            bool CheckUserControlTxtBox()
            {
                foreach (Control c in mainContainer.Controls)
                {
                    if (c is UserControl)
                    {
                        foreach (Control c2 in c.Controls)
                        {
                            if (c2 is TextBox)
                            {
                                if (!string.IsNullOrEmpty(c2.Text))
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }

                return true;
            }

            bool OpenResponseDialog()
            {
                DialogResult dialogResult = MessageBox.Show("Chcete uložit aktuální data?", "Uložit data", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    return true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    return false;
                }

                return false;
            }

            if (mainContainer.Controls != null)
            {
                mainContainer.Controls.Add(uc);
            }

            if (!CheckUserControlTxtBox())
            {
                this.Enabled = false;

                if (OpenResponseDialog())
                {
                    this.Enabled = true;

                    mainContainer.Controls.Clear();
                    mainContainer.Controls.Add(uc);
                }
                else
                {
                    this.Enabled = true;
                }
            }
            else
            {
                mainContainer.Controls.Clear();
                mainContainer.Controls.Add(uc);
            }

        }

        public void ClearUserControl()
        {
            mainContainer.Controls.Clear();
        }

        #region material
        private bool materialExpand = false;
        private void materialTimer_Tick(object sender, EventArgs e)
        {
            if (materialExpand == false)
            {
                materialConatainer.Height += 10;
                if (materialConatainer.Height >= 395)
                {
                    materialTimer.Stop();

                    materialExpand = true;
                }
            }
            else
            {
                materialConatainer.Height -= 10;
                if (materialConatainer.Height <= 100)
                {
                    materialTimer.Stop();

                    materialExpand = false;
                }
            }
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            materialTimer.Start();
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            ChangeUI(new MaterialAdd());
            materialTimer.Start();
        }

        private void btnEditMaterial_Click(object sender, EventArgs e)
        {

            materialTimer.Start();
        }

        private void btnDeleteMaterial_Click(object sender, EventArgs e)
        {

            materialTimer.Start();
        }

        #endregion

        #region project
        private bool projectExpand = false;
        private void projectTimer_Tick(object sender, EventArgs e)
        {
            if (projectExpand == false)
            {
                projectContainer.Height += 10;
                if (projectContainer.Height >= 395)
                {
                    projectTimer.Stop();

                    projectExpand = true;
                }
            }
            else
            {
                projectContainer.Height -= 10;
                if (projectContainer.Height <= 100)
                {
                    projectTimer.Stop();

                    projectExpand = false;
                }
            }
        }

        private void btnAddProjekt_Click(object sender, EventArgs e)
        {

            projectTimer.Start();
        }

        private void btnEditProjekt_Click(object sender, EventArgs e)
        {

            projectTimer.Start();
        }

        private void btnDeleteProjekt_Click(object sender, EventArgs e)
        {

            projectTimer.Start();
        }

        #endregion

        #region granulat    

        private bool granulatExpand = false;
        private void granulatyTimer_Tick(object sender, EventArgs e)
        {
            if (granulatExpand == false)
            {
                granulatContainer.Height += 10;
                if (granulatContainer.Height >= 395)
                {
                    granulatyTimer.Stop();

                    granulatExpand = true;
                }
            }
            else
            {
                granulatContainer.Height -= 10;
                if (granulatContainer.Height <= 100)
                {
                    granulatyTimer.Stop();

                    granulatExpand = false;
                }
            }
        }

        private void btnGranulat_Click(object sender, EventArgs e)
        {

            granulatyTimer.Start();
        }

        private void btnAddGranulat_Click(object sender, EventArgs e)
        {

            granulatyTimer.Start();
        }

        private void btnEditGranulat_Click(object sender, EventArgs e)
        {

            granulatyTimer.Start();
        }

        private void btnDeleteGranulat_Click(object sender, EventArgs e)
        {

            granulatyTimer.Start();
        }

        #endregion

        #region lak

        private bool lakExpand = false;
        private void lakTimer_Tick(object sender, EventArgs e)
        {
            if (lakExpand == false)
            {
                lakContainer.Height += 10;
                if (lakContainer.Height >= 395)
                {
                    lakTimer.Stop();

                    lakExpand = true;
                }
            }
            else
            {
                lakContainer.Height -= 10;
                if (lakContainer.Height <= 100)
                {
                    lakTimer.Stop();

                    lakExpand = false;
                }
            }
        }

        private void btnAddLak_Click(object sender, EventArgs e)
        {

            lakTimer.Start();
        }

        private void btnEditLak_Click(object sender, EventArgs e)
        {

            lakTimer.Start();
        }

        private void btnDeleteLak_Click(object sender, EventArgs e)
        {

            lakTimer.Start();
        }

        #endregion

        #region cistice

        private bool cisticeExpand = false;
        private void cisticeTimer_Tick(object sender, EventArgs e)
        {
            if (cisticeExpand == false)
            {
                cisticeContainer.Height += 10;
                if (cisticeContainer.Height >= 395)
                {
                    cisticeTimer.Stop();

                    cisticeExpand = true;
                }
            }
            else
            {
                cisticeContainer.Height -= 10;
                if (cisticeContainer.Height <= 100)
                {
                    cisticeTimer.Stop();

                    cisticeExpand = false;
                }
            }
        }
        private void btnCisitic_Click(object sender, EventArgs e)
        {

            cisticeTimer.Start();
        }

        private void btnAddCistic_Click(object sender, EventArgs e)
        {

            cisticeTimer.Start();
        }

        private void btnEditCistic_Click(object sender, EventArgs e)
        {

            cisticeTimer.Start();
        }

        private void btnDeleteCisitic_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
