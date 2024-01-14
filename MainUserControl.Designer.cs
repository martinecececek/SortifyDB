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
            dataGridOutput = new DataGridView();
            panel4 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOutput).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // searchBox
            // 
            searchBox.Anchor = AnchorStyles.Top;
            searchBox.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            searchBox.Location = new Point(97, 168);
            searchBox.Multiline = true;
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "TL číslo, SAP číslo";
            searchBox.Size = new Size(961, 54);
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
            BtnProjekty.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold);
            BtnProjekty.ForeColor = Color.White;
            BtnProjekty.Location = new Point(9, 21);
            BtnProjekty.Name = "BtnProjekty";
            BtnProjekty.Size = new Size(205, 115);
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
            BtnMat.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold);
            BtnMat.ForeColor = Color.White;
            BtnMat.Location = new Point(242, 21);
            BtnMat.Name = "BtnMat";
            BtnMat.Size = new Size(205, 115);
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
            BtnCleanActive.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            BtnCleanActive.ForeColor = Color.White;
            BtnCleanActive.Location = new Point(471, 21);
            BtnCleanActive.Name = "BtnCleanActive";
            BtnCleanActive.Size = new Size(205, 115);
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
            BtnVarnish.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold);
            BtnVarnish.ForeColor = Color.White;
            BtnVarnish.Location = new Point(703, 21);
            BtnVarnish.Name = "BtnVarnish";
            BtnVarnish.Size = new Size(205, 115);
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
            BtnGran.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold);
            BtnGran.ForeColor = Color.White;
            BtnGran.Location = new Point(945, 21);
            BtnGran.Name = "BtnGran";
            BtnGran.Size = new Size(205, 115);
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
            BtnBack.BackgroundImage = (Image)resources.GetObject("BtnBack.BackgroundImage");
            BtnBack.BackgroundImageLayout = ImageLayout.Zoom;
            BtnBack.BorderColor = Color.Black;
            BtnBack.BorderRadius = 40;
            BtnBack.BorderSize = 2;
            BtnBack.Cursor = Cursors.Hand;
            BtnBack.FlatAppearance.BorderSize = 0;
            BtnBack.FlatStyle = FlatStyle.Flat;
            BtnBack.ForeColor = Color.White;
            BtnBack.Location = new Point(11, 155);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(80, 80);
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
            BtnSearch.Location = new Point(1065, 155);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(80, 80);
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
            panel1.Controls.Add(BtnVarnish);
            panel1.Controls.Add(BtnGran);
            panel1.Controls.Add(BtnBack);
            panel1.Controls.Add(BtnCleanActive);
            panel1.Controls.Add(searchBox);
            panel1.Controls.Add(BtnMat);
            panel1.Controls.Add(BtnSearch);
            panel1.Controls.Add(BtnProjekty);
            panel1.Location = new Point(383, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1154, 257);
            panel1.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(BtnMainFormsAdd);
            panel2.Controls.Add(BtnParser);
            panel2.Location = new Point(1537, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(383, 257);
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
            BtnMainFormsAdd.Location = new Point(92, 22);
            BtnMainFormsAdd.Name = "BtnMainFormsAdd";
            BtnMainFormsAdd.Size = new Size(205, 98);
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
            BtnParser.Location = new Point(92, 136);
            BtnParser.Name = "BtnParser";
            BtnParser.Size = new Size(205, 98);
            BtnParser.TabIndex = 22;
            BtnParser.Text = "Vložit PDF";
            BtnParser.TextColor = Color.White;
            BtnParser.UseVisualStyleBackColor = false;
            BtnParser.Click += BtnParser_Click;
            // 
            // dataGridOutput
            // 
            dataGridOutput.Anchor = AnchorStyles.Top;
            dataGridOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOutput.Location = new Point(2, 6);
            dataGridOutput.Margin = new Padding(3, 3, 8, 8);
            dataGridOutput.Name = "dataGridOutput";
            dataGridOutput.Size = new Size(1526, 744);
            dataGridOutput.TabIndex = 21;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.BackColor = Color.CornflowerBlue;
            panel4.Controls.Add(dataGridOutput);
            panel4.Location = new Point(384, 257);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1536, 758);
            panel4.TabIndex = 25;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top;
            flowLayoutPanel1.BackColor = Color.SlateGray;
            flowLayoutPanel1.Location = new Point(4, 8);
            flowLayoutPanel1.Margin = new Padding(8);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(371, 999);
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
            panel3.Size = new Size(383, 1015);
            panel3.TabIndex = 24;
            // 
            // MainUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Name = "MainUserControl";
            Size = new Size(1920, 1015);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridOutput).EndInit();
            panel4.ResumeLayout(false);
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
        private DataGridView dataGridOutput;
        private Panel panel4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
    }
}
