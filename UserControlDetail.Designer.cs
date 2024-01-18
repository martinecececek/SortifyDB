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
            dataGridDetailOutputOutput = new DataGridView();
            panelColorUCD = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridMainOutput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDetailOutputOutput).BeginInit();
            SuspendLayout();
            // 
            // dataGridProjectOutput
            // 
            dataGridMainOutput.Anchor = AnchorStyles.Top;
            dataGridMainOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMainOutput.Location = new Point(20, 20);
            dataGridMainOutput.Margin = new Padding(20);
            dataGridMainOutput.Name = "dataGridMainOutput";
            dataGridMainOutput.RowHeadersWidth = 51;
            dataGridMainOutput.Size = new Size(1128, 106);
            dataGridMainOutput.TabIndex = 0;
            // 
            // dataGridMaterialOutput
            // 
            dataGridDetailOutputOutput.Anchor = AnchorStyles.Top;
            dataGridDetailOutputOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDetailOutputOutput.Location = new Point(20, 150);
            dataGridDetailOutputOutput.Margin = new Padding(20);
            dataGridDetailOutputOutput.Name = "dataGridDetailOutputOutput";
            dataGridDetailOutputOutput.RowHeadersWidth = 51;
            dataGridDetailOutputOutput.Size = new Size(1128, 358);
            dataGridDetailOutputOutput.TabIndex = 1;
            // 
            // panelColorUCD
            // 
            panelColorUCD.BackColor = Color.CadetBlue;
            panelColorUCD.Location = new Point(0, 0);
            panelColorUCD.Margin = new Padding(0);
            panelColorUCD.Name = "panelColorUCD";
            panelColorUCD.Size = new Size(1168, 528);
            panelColorUCD.TabIndex = 2;
            // 
            // UserControlDetail
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(dataGridDetailOutputOutput);
            Controls.Add(dataGridMainOutput);
            Controls.Add(panelColorUCD);
            Margin = new Padding(2);
            Name = "UserControlDetail";
            Size = new Size(1168, 528);
            Load += UserControlDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridMainOutput).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDetailOutputOutput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridMainOutput;
        private DataGridView dataGridDetailOutputOutput;
        private Panel panelColorUCD;
    }
}
