namespace SortifyDB
{
    partial class UserControlDetail
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
            dataGridMainOutput = new DataGridView();
            dataGridDetailOutput = new DataGridView();
            panelColorUCD = new Panel();
            labelUCDetailContains = new Label();
            labelUCDetailMainName = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridMainOutput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDetailOutput).BeginInit();
            panelColorUCD.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridMainOutput
            // 
            dataGridMainOutput.Anchor = AnchorStyles.Top;
            dataGridMainOutput.BackgroundColor = Color.CornflowerBlue;
            dataGridMainOutput.BorderStyle = BorderStyle.None;
            dataGridMainOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMainOutput.Location = new Point(20, 46);
            dataGridMainOutput.Name = "dataGridMainOutput";
            dataGridMainOutput.RowHeadersWidth = 51;
            dataGridMainOutput.Size = new Size(1440, 71);
            dataGridMainOutput.TabIndex = 0;
            // 
            // dataGridDetailOutput
            // 
            dataGridDetailOutput.Anchor = AnchorStyles.Top;
            dataGridDetailOutput.BackgroundColor = Color.CornflowerBlue;
            dataGridDetailOutput.BorderStyle = BorderStyle.None;
            dataGridDetailOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDetailOutput.Location = new Point(20, 149);
            dataGridDetailOutput.Margin = new Padding(20);
            dataGridDetailOutput.Name = "dataGridDetailOutput";
            dataGridDetailOutput.RowHeadersWidth = 51;
            dataGridDetailOutput.Size = new Size(1432, 506);
            dataGridDetailOutput.TabIndex = 1;
            // 
            // panelColorUCD
            // 
            panelColorUCD.BackColor = Color.CornflowerBlue;
            panelColorUCD.Controls.Add(dataGridMainOutput);
            panelColorUCD.Controls.Add(dataGridDetailOutput);
            panelColorUCD.Controls.Add(labelUCDetailContains);
            panelColorUCD.Controls.Add(labelUCDetailMainName);
            panelColorUCD.Location = new Point(0, 0);
            panelColorUCD.Margin = new Padding(0);
            panelColorUCD.Name = "panelColorUCD";
            panelColorUCD.Size = new Size(1472, 675);
            panelColorUCD.TabIndex = 2;
            // 
            // labelUCDetailContains
            // 
            labelUCDetailContains.Anchor = AnchorStyles.Top;
            labelUCDetailContains.AutoSize = true;
            labelUCDetailContains.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic);
            labelUCDetailContains.ForeColor = Color.White;
            labelUCDetailContains.Location = new Point(20, 109);
            labelUCDetailContains.Margin = new Padding(2, 0, 2, 0);
            labelUCDetailContains.Name = "labelUCDetailContains";
            labelUCDetailContains.Size = new Size(220, 38);
            labelUCDetailContains.TabIndex = 1;
            labelUCDetailContains.Text = "PlaceholderText";
            // 
            // labelUCDetailMainName
            // 
            labelUCDetailMainName.Anchor = AnchorStyles.Top;
            labelUCDetailMainName.AutoSize = true;
            labelUCDetailMainName.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic);
            labelUCDetailMainName.ForeColor = Color.White;
            labelUCDetailMainName.Location = new Point(20, 5);
            labelUCDetailMainName.Margin = new Padding(2, 0, 2, 0);
            labelUCDetailMainName.Name = "labelUCDetailMainName";
            labelUCDetailMainName.Size = new Size(220, 38);
            labelUCDetailMainName.TabIndex = 0;
            labelUCDetailMainName.Text = "PlaceholderText";
            // 
            // UserControlDetail
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panelColorUCD);
            Margin = new Padding(2);
            Name = "UserControlDetail";
            Size = new Size(1472, 675);
            Load += UserControlDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridMainOutput).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDetailOutput).EndInit();
            panelColorUCD.ResumeLayout(false);
            panelColorUCD.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridMainOutput;
        private DataGridView dataGridDetailOutput;
        private Panel panelColorUCD;
        private Label labelUCDetailContains;
        private Label labelUCDetailMainName;
    }
}
