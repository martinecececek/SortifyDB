namespace SortifyDB
{
    partial class MainUserControl
    {
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
            searchBox = new TextBox();
            btnProjekty = new Cbtn.CBtn();
            btnMat = new Cbtn.CBtn();
            btnCleanActive = new Cbtn.CBtn();
            btnVarnish = new Cbtn.CBtn();
            btnGran = new Cbtn.CBtn();
            btnBack = new Cbtn.CBtn();
            btnSearch = new Cbtn.CBtn();
            panel1 = new Panel();
            panel2 = new Panel();
            btnMainFormsAdd = new Cbtn.CBtn();
            btnParser = new Cbtn.CBtn();
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
            // btnProjekty
            // 
            btnProjekty.BackColor = Color.FromArgb(0, 142, 255);
            btnProjekty.BackgroundColor = Color.FromArgb(0, 142, 255);
            btnProjekty.BorderColor = Color.Black;
            btnProjekty.BorderRadius = 40;
            btnProjekty.BorderSize = 2;
            btnProjekty.Cursor = Cursors.Hand;
            btnProjekty.FlatAppearance.BorderSize = 0;
            btnProjekty.FlatStyle = FlatStyle.Flat;
            btnProjekty.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold);
            btnProjekty.ForeColor = Color.White;
            btnProjekty.Location = new Point(9, 21);
            btnProjekty.Name = "btnProjekty";
            btnProjekty.Size = new Size(205, 115);
            btnProjekty.TabIndex = 8;
            btnProjekty.Text = "Projekty";
            btnProjekty.TextColor = Color.White;
            btnProjekty.UseVisualStyleBackColor = false;
            btnProjekty.Click += btnProjekty_Click;
            // 
            // btnMat
            // 
            btnMat.BackColor = Color.FromArgb(0, 142, 255);
            btnMat.BackgroundColor = Color.FromArgb(0, 142, 255);
            btnMat.BorderColor = Color.Black;
            btnMat.BorderRadius = 40;
            btnMat.BorderSize = 2;
            btnMat.Cursor = Cursors.Hand;
            btnMat.FlatAppearance.BorderSize = 0;
            btnMat.FlatStyle = FlatStyle.Flat;
            btnMat.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold);
            btnMat.ForeColor = Color.White;
            btnMat.Location = new Point(242, 21);
            btnMat.Name = "btnMat";
            btnMat.Size = new Size(205, 115);
            btnMat.TabIndex = 9;
            btnMat.Text = "Materiály";
            btnMat.TextColor = Color.White;
            btnMat.UseVisualStyleBackColor = false;
            btnMat.Click += btnMat_Click;
            // 
            // btnCleanActive
            // 
            btnCleanActive.BackColor = Color.FromArgb(0, 142, 255);
            btnCleanActive.BackgroundColor = Color.FromArgb(0, 142, 255);
            btnCleanActive.BorderColor = Color.Black;
            btnCleanActive.BorderRadius = 40;
            btnCleanActive.BorderSize = 2;
            btnCleanActive.Cursor = Cursors.Hand;
            btnCleanActive.FlatAppearance.BorderSize = 0;
            btnCleanActive.FlatStyle = FlatStyle.Flat;
            btnCleanActive.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnCleanActive.ForeColor = Color.White;
            btnCleanActive.Location = new Point(471, 21);
            btnCleanActive.Name = "btnCleanActive";
            btnCleanActive.Size = new Size(205, 115);
            btnCleanActive.TabIndex = 10;
            btnCleanActive.Text = "Čističe\r\nAktivátory";
            btnCleanActive.TextColor = Color.White;
            btnCleanActive.UseVisualStyleBackColor = false;
            btnCleanActive.Click += btnCleanActive_Click;
            // 
            // btnVarnish
            // 
            btnVarnish.BackColor = Color.FromArgb(0, 142, 255);
            btnVarnish.BackgroundColor = Color.FromArgb(0, 142, 255);
            btnVarnish.BorderColor = Color.Black;
            btnVarnish.BorderRadius = 40;
            btnVarnish.BorderSize = 2;
            btnVarnish.Cursor = Cursors.Hand;
            btnVarnish.FlatAppearance.BorderSize = 0;
            btnVarnish.FlatStyle = FlatStyle.Flat;
            btnVarnish.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold);
            btnVarnish.ForeColor = Color.White;
            btnVarnish.Location = new Point(703, 21);
            btnVarnish.Name = "btnVarnish";
            btnVarnish.Size = new Size(205, 115);
            btnVarnish.TabIndex = 11;
            btnVarnish.Text = "Kluzké laky";
            btnVarnish.TextColor = Color.White;
            btnVarnish.UseVisualStyleBackColor = false;
            btnVarnish.Click += btnVarnish_Click;
            // 
            // btnGran
            // 
            btnGran.BackColor = Color.FromArgb(0, 142, 255);
            btnGran.BackgroundColor = Color.FromArgb(0, 142, 255);
            btnGran.BorderColor = Color.Black;
            btnGran.BorderRadius = 40;
            btnGran.BorderSize = 2;
            btnGran.Cursor = Cursors.Hand;
            btnGran.FlatAppearance.BorderSize = 0;
            btnGran.FlatStyle = FlatStyle.Flat;
            btnGran.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold);
            btnGran.ForeColor = Color.White;
            btnGran.Location = new Point(937, 21);
            btnGran.Name = "btnGran";
            btnGran.Size = new Size(205, 115);
            btnGran.TabIndex = 12;
            btnGran.Text = "Granuláty";
            btnGran.TextColor = Color.White;
            btnGran.UseVisualStyleBackColor = false;
            btnGran.Click += btnGran_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(0, 142, 255);
            btnBack.BackgroundColor = Color.FromArgb(0, 142, 255);
            btnBack.BackgroundImage = Properties.Resources.back1;
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.BorderColor = Color.Black;
            btnBack.BorderRadius = 40;
            btnBack.BorderSize = 2;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(11, 155);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(80, 80);
            btnBack.TabIndex = 13;
            btnBack.TextColor = Color.White;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(0, 142, 255);
            btnSearch.BackgroundColor = Color.FromArgb(0, 142, 255);
            btnSearch.BackgroundImage = Properties.Resources.Search1;
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.BorderColor = Color.Black;
            btnSearch.BorderRadius = 40;
            btnSearch.BorderSize = 2;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1065, 155);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 80);
            btnSearch.TabIndex = 14;
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.PowderBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnVarnish);
            panel1.Controls.Add(btnGran);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnCleanActive);
            panel1.Controls.Add(searchBox);
            panel1.Controls.Add(btnMat);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(btnProjekty);
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
            panel2.Controls.Add(btnMainFormsAdd);
            panel2.Controls.Add(btnParser);
            panel2.Location = new Point(1537, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(383, 257);
            panel2.TabIndex = 20;
            // 
            // btnMainFormsAdd
            // 
            btnMainFormsAdd.BackColor = Color.FromArgb(0, 95, 172);
            btnMainFormsAdd.BackgroundColor = Color.FromArgb(0, 95, 172);
            btnMainFormsAdd.BorderColor = Color.Black;
            btnMainFormsAdd.BorderRadius = 40;
            btnMainFormsAdd.BorderSize = 2;
            btnMainFormsAdd.Cursor = Cursors.Hand;
            btnMainFormsAdd.FlatAppearance.BorderSize = 0;
            btnMainFormsAdd.FlatStyle = FlatStyle.Flat;
            btnMainFormsAdd.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold);
            btnMainFormsAdd.ForeColor = Color.White;
            btnMainFormsAdd.Location = new Point(92, 22);
            btnMainFormsAdd.Name = "btnMainFormsAdd";
            btnMainFormsAdd.Size = new Size(205, 98);
            btnMainFormsAdd.TabIndex = 23;
            btnMainFormsAdd.Text = "Přidat";
            btnMainFormsAdd.TextColor = Color.White;
            btnMainFormsAdd.UseVisualStyleBackColor = false;
            btnMainFormsAdd.Click += btnMainFormsAdd_Click;
            // 
            // btnParser
            // 
            btnParser.BackColor = Color.FromArgb(0, 95, 172);
            btnParser.BackgroundColor = Color.FromArgb(0, 95, 172);
            btnParser.BorderColor = Color.Black;
            btnParser.BorderRadius = 40;
            btnParser.BorderSize = 2;
            btnParser.Cursor = Cursors.Hand;
            btnParser.FlatAppearance.BorderSize = 0;
            btnParser.FlatStyle = FlatStyle.Flat;
            btnParser.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold);
            btnParser.ForeColor = Color.White;
            btnParser.Location = new Point(92, 136);
            btnParser.Name = "btnParser";
            btnParser.Size = new Size(205, 98);
            btnParser.TabIndex = 22;
            btnParser.Text = "Vložit PDF";
            btnParser.TextColor = Color.White;
            btnParser.UseVisualStyleBackColor = false;
            btnParser.Click += btnParser_Click;
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
        private Cbtn.CBtn btnProjekty;
        private Cbtn.CBtn btnMat;
        private Cbtn.CBtn btnCleanActive;
        private Cbtn.CBtn btnVarnish;
        private Cbtn.CBtn btnGran;
        private Cbtn.CBtn btnBack;
        private Cbtn.CBtn btnSearch;
        private Panel panel1;
        private Panel panel2;
        private Cbtn.CBtn btnMainFormsAdd;
        private Cbtn.CBtn btnParser;
        private DataGridView dataGridOutput;
        private Panel panel4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
    }
}
