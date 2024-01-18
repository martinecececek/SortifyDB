namespace SortifyDB
{
    partial class MainUserControl
    {
        //Kódík
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUserControl));
            searchBox = new TextBox();
            BtnProjekty = new Cbtn.CBtn();
            BtnMat = new Cbtn.CBtn();
            BtnCleanActive = new Cbtn.CBtn();
            BtnVarnish = new Cbtn.CBtn();
            BtnGran = new Cbtn.CBtn();
            BtnBack = new Cbtn.CBtn();
            BtnSearch = new Cbtn.CBtn();
            panel1 = new Panel();
            panel2 = new Panel();
            BtnMainFormsAdd = new Cbtn.CBtn();
            BtnParser = new Cbtn.CBtn();
            panelMainShower = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            cCechMenusM = new CCheckMenu.CCechMenus();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // searchBox
            // 
            searchBox.Anchor = AnchorStyles.Top;
            searchBox.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            searchBox.Location = new Point(110, 231);
            searchBox.Margin = new Padding(5, 0, 5, 5);
            searchBox.Multiline = true;
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "TL číslo, SAP číslo";
            searchBox.Size = new Size(964, 63);
            searchBox.TabIndex = 2;
            // 
            // BtnProjekty
            // 
            BtnProjekty.BackColor = Color.FromArgb(0, 142, 255);
            BtnProjekty.BackgroundColor = Color.FromArgb(0, 142, 255);
            BtnProjekty.BorderColor = Color.Black;
            BtnProjekty.BorderRadius = 40;
            BtnProjekty.BorderSize = 2;
            BtnProjekty.Cursor = Cursors.Hand;
            BtnProjekty.FlatAppearance.BorderSize = 0;
            BtnProjekty.FlatStyle = FlatStyle.Flat;
            BtnProjekty.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold);
            BtnProjekty.ForeColor = Color.White;
            BtnProjekty.Location = new Point(30, 28);
            BtnProjekty.Margin = new Padding(22, 5, 5, 0);
            BtnProjekty.Name = "BtnProjekty";
            BtnProjekty.Size = new Size(220, 153);
            BtnProjekty.TabIndex = 8;
            BtnProjekty.Text = "Projekty";
            BtnProjekty.TextColor = Color.White;
            BtnProjekty.UseVisualStyleBackColor = false;
            BtnProjekty.Click += BtnProjekty_Click;
            // 
            // BtnMat
            // 
            BtnMat.BackColor = Color.FromArgb(0, 142, 255);
            BtnMat.BackgroundColor = Color.FromArgb(0, 142, 255);
            BtnMat.BorderColor = Color.Black;
            BtnMat.BorderRadius = 40;
            BtnMat.BorderSize = 2;
            BtnMat.Cursor = Cursors.Hand;
            BtnMat.FlatAppearance.BorderSize = 0;
            BtnMat.FlatStyle = FlatStyle.Flat;
            BtnMat.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold);
            BtnMat.ForeColor = Color.White;
            BtnMat.Location = new Point(256, 28);
            BtnMat.Margin = new Padding(5, 5, 5, 0);
            BtnMat.Name = "BtnMat";
            BtnMat.Size = new Size(220, 153);
            BtnMat.TabIndex = 9;
            BtnMat.Text = "Materiály";
            BtnMat.TextColor = Color.White;
            BtnMat.UseVisualStyleBackColor = false;
            BtnMat.Click += BtnMat_Click;
            // 
            // BtnCleanActive
            // 
            BtnCleanActive.BackColor = Color.FromArgb(0, 142, 255);
            BtnCleanActive.BackgroundColor = Color.FromArgb(0, 142, 255);
            BtnCleanActive.BorderColor = Color.Black;
            BtnCleanActive.BorderRadius = 40;
            BtnCleanActive.BorderSize = 2;
            BtnCleanActive.Cursor = Cursors.Hand;
            BtnCleanActive.FlatAppearance.BorderSize = 0;
            BtnCleanActive.FlatStyle = FlatStyle.Flat;
            BtnCleanActive.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            BtnCleanActive.ForeColor = Color.White;
            BtnCleanActive.Location = new Point(482, 28);
            BtnCleanActive.Margin = new Padding(5, 5, 5, 0);
            BtnCleanActive.Name = "BtnCleanActive";
            BtnCleanActive.Size = new Size(220, 153);
            BtnCleanActive.TabIndex = 10;
            BtnCleanActive.Text = "Čističe\r\nAktivátory";
            BtnCleanActive.TextColor = Color.White;
            BtnCleanActive.UseVisualStyleBackColor = false;
            BtnCleanActive.Click += BtnCleanActive_Click;
            // 
            // BtnVarnish
            // 
            BtnVarnish.BackColor = Color.FromArgb(0, 142, 255);
            BtnVarnish.BackgroundColor = Color.FromArgb(0, 142, 255);
            BtnVarnish.BorderColor = Color.Black;
            BtnVarnish.BorderRadius = 40;
            BtnVarnish.BorderSize = 2;
            BtnVarnish.Cursor = Cursors.Hand;
            BtnVarnish.FlatAppearance.BorderSize = 0;
            BtnVarnish.FlatStyle = FlatStyle.Flat;
            BtnVarnish.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold);
            BtnVarnish.ForeColor = Color.White;
            BtnVarnish.Location = new Point(708, 28);
            BtnVarnish.Margin = new Padding(5, 5, 5, 0);
            BtnVarnish.Name = "BtnVarnish";
            BtnVarnish.Size = new Size(220, 153);
            BtnVarnish.TabIndex = 11;
            BtnVarnish.Text = "Kluzké laky";
            BtnVarnish.TextColor = Color.White;
            BtnVarnish.UseVisualStyleBackColor = false;
            BtnVarnish.Click += BtnVarnish_Click;
            // 
            // BtnGran
            // 
            BtnGran.BackColor = Color.FromArgb(0, 142, 255);
            BtnGran.BackgroundColor = Color.FromArgb(0, 142, 255);
            BtnGran.BorderColor = Color.Black;
            BtnGran.BorderRadius = 40;
            BtnGran.BorderSize = 2;
            BtnGran.Cursor = Cursors.Hand;
            BtnGran.FlatAppearance.BorderSize = 0;
            BtnGran.FlatStyle = FlatStyle.Flat;
            BtnGran.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold);
            BtnGran.ForeColor = Color.White;
            BtnGran.Location = new Point(934, 28);
            BtnGran.Margin = new Padding(5, 5, 22, 0);
            BtnGran.Name = "BtnGran";
            BtnGran.Size = new Size(220, 153);
            BtnGran.TabIndex = 12;
            BtnGran.Text = "Granuláty";
            BtnGran.TextColor = Color.White;
            BtnGran.UseVisualStyleBackColor = false;
            BtnGran.Click += BtnGran_Click;
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.FromArgb(0, 142, 255);
            BtnBack.BackgroundColor = Color.FromArgb(0, 142, 255);
            BtnBack.BackgroundImage = Properties.Resources.back;
            BtnBack.BackgroundImageLayout = ImageLayout.Zoom;
            BtnBack.BorderColor = Color.Black;
            BtnBack.BorderRadius = 40;
            BtnBack.BorderSize = 2;
            BtnBack.Cursor = Cursors.Hand;
            BtnBack.FlatAppearance.BorderSize = 0;
            BtnBack.FlatStyle = FlatStyle.Flat;
            BtnBack.ForeColor = Color.White;
            BtnBack.Location = new Point(35, 224);
            BtnBack.Margin = new Padding(22, 0, 0, 0);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(70, 70);
            BtnBack.TabIndex = 13;
            BtnBack.TextColor = Color.White;
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnSearch
            // 
            BtnSearch.BackColor = Color.FromArgb(0, 142, 255);
            BtnSearch.BackgroundColor = Color.FromArgb(0, 142, 255);
            BtnSearch.BackgroundImage = (Image)resources.GetObject("BtnSearch.BackgroundImage");
            BtnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSearch.BorderColor = Color.Black;
            BtnSearch.BorderRadius = 40;
            BtnSearch.BorderSize = 2;
            BtnSearch.Cursor = Cursors.Hand;
            BtnSearch.FlatAppearance.BorderSize = 0;
            BtnSearch.FlatStyle = FlatStyle.Flat;
            BtnSearch.ForeColor = Color.White;
            BtnSearch.Location = new Point(1079, 224);
            BtnSearch.Margin = new Padding(0, 0, 22, 0);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(70, 70);
            BtnSearch.TabIndex = 14;
            BtnSearch.TextColor = Color.White;
            BtnSearch.UseVisualStyleBackColor = false;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.PowderBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cCechMenusM);
            panel1.Controls.Add(BtnVarnish);
            panel1.Controls.Add(BtnGran);
            panel1.Controls.Add(BtnBack);
            panel1.Controls.Add(BtnCleanActive);
            panel1.Controls.Add(searchBox);
            panel1.Controls.Add(BtnMat);
            panel1.Controls.Add(BtnSearch);
            panel1.Controls.Add(BtnProjekty);
            panel1.Location = new Point(438, 11);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 320);
            panel1.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(BtnMainFormsAdd);
            panel2.Controls.Add(BtnParser);
            panel2.Location = new Point(1620, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 330);
            panel2.TabIndex = 20;
            // 
            // BtnMainFormsAdd
            // 
            BtnMainFormsAdd.BackColor = Color.FromArgb(0, 95, 172);
            BtnMainFormsAdd.BackgroundColor = Color.FromArgb(0, 95, 172);
            BtnMainFormsAdd.BorderColor = Color.Black;
            BtnMainFormsAdd.BorderRadius = 40;
            BtnMainFormsAdd.BorderSize = 2;
            BtnMainFormsAdd.Cursor = Cursors.Hand;
            BtnMainFormsAdd.FlatAppearance.BorderSize = 0;
            BtnMainFormsAdd.FlatStyle = FlatStyle.Flat;
            BtnMainFormsAdd.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold);
            BtnMainFormsAdd.ForeColor = Color.White;
            BtnMainFormsAdd.Location = new Point(41, 37);
            BtnMainFormsAdd.Name = "BtnMainFormsAdd";
            BtnMainFormsAdd.Size = new Size(234, 131);
            BtnMainFormsAdd.TabIndex = 23;
            BtnMainFormsAdd.Text = "Přidat";
            BtnMainFormsAdd.TextColor = Color.White;
            BtnMainFormsAdd.UseVisualStyleBackColor = false;
            BtnMainFormsAdd.Click += BtnMainFormsAdd_Click;
            // 
            // BtnParser
            // 
            BtnParser.BackColor = Color.FromArgb(0, 95, 172);
            BtnParser.BackgroundColor = Color.FromArgb(0, 95, 172);
            BtnParser.BorderColor = Color.Black;
            BtnParser.BorderRadius = 40;
            BtnParser.BorderSize = 2;
            BtnParser.Cursor = Cursors.Hand;
            BtnParser.FlatAppearance.BorderSize = 0;
            BtnParser.FlatStyle = FlatStyle.Flat;
            BtnParser.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold);
            BtnParser.ForeColor = Color.White;
            BtnParser.Location = new Point(41, 184);
            BtnParser.Name = "BtnParser";
            BtnParser.Size = new Size(234, 131);
            BtnParser.TabIndex = 22;
            BtnParser.Text = "Vložit PDF";
            BtnParser.TextColor = Color.White;
            BtnParser.UseVisualStyleBackColor = false;
            BtnParser.Click += BtnParser_Click;
            // 
            // panelMainShower
            // 
            panelMainShower.Anchor = AnchorStyles.Top;
            panelMainShower.BackColor = Color.CornflowerBlue;
            panelMainShower.Location = new Point(438, 330);
            panelMainShower.Margin = new Padding(0);
            panelMainShower.Name = "panelMainShower";
            panelMainShower.Size = new Size(1482, 685);
            panelMainShower.TabIndex = 25;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top;
            flowLayoutPanel1.BackColor = Color.SlateGray;
            flowLayoutPanel1.Location = new Point(5, 11);
            flowLayoutPanel1.Margin = new Padding(8);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(424, 993);
            flowLayoutPanel1.TabIndex = 22;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.BackColor = Color.SteelBlue;
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(438, 1015);
            panel3.TabIndex = 24;
            // 
            // cCechMenusM
            // 
            cCechMenusM.BackColor = Color.FromArgb(142, 220, 229);
            cCechMenusM.Location = new Point(110, 181);
            cCechMenusM.Margin = new Padding(0);
            cCechMenusM.Name = "cCechMenusM";
            cCechMenusM.Size = new Size(964, 50);
            cCechMenusM.TabIndex = 15;
            // 
            // MainUserControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Lavender;
            Controls.Add(panelMainShower);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "MainUserControl";
            Size = new Size(1920, 1015);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox searchBox;
        private Cbtn.CBtn BtnProjekty;
        private Cbtn.CBtn BtnMat;
        private Cbtn.CBtn BtnCleanActive;
        private Cbtn.CBtn BtnVarnish;
        private Cbtn.CBtn BtnGran;
        private Cbtn.CBtn BtnBack;
        private Cbtn.CBtn BtnSearch;
        private Panel panel1;
        private Panel panel2;
        private Cbtn.CBtn BtnMainFormsAdd;
        private Cbtn.CBtn BtnParser;
        private Panel panelMainShower;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private CCheckMenu.CCechMenus cCechMenusM;
    }
}