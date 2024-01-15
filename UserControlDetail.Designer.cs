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
            dataGridProjectOutput = new DataGridView();
            dataGridMaterialOutput = new DataGridView();
            panelColorUCD = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridProjectOutput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMaterialOutput).BeginInit();
            SuspendLayout();
            // 
            // dataGridProjectOutput
            // 
            dataGridProjectOutput.Anchor = AnchorStyles.Top;
            dataGridProjectOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProjectOutput.Location = new Point(20, 20);
            dataGridProjectOutput.Margin = new Padding(20, 20, 20, 20);
            dataGridProjectOutput.Name = "dataGridProjectOutput";
            dataGridProjectOutput.RowHeadersWidth = 51;
            dataGridProjectOutput.Size = new Size(1128, 106);
            dataGridProjectOutput.TabIndex = 0;
            // 
            // dataGridMaterialOutput
            // 
            dataGridMaterialOutput.Anchor = AnchorStyles.Top;
            dataGridMaterialOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMaterialOutput.Location = new Point(20, 150);
            dataGridMaterialOutput.Margin = new Padding(20, 20, 20, 20);
            dataGridMaterialOutput.Name = "dataGridMaterialOutput";
            dataGridMaterialOutput.RowHeadersWidth = 51;
            dataGridMaterialOutput.Size = new Size(1128, 358);
            dataGridMaterialOutput.TabIndex = 1;
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
            Controls.Add(dataGridMaterialOutput);
            Controls.Add(dataGridProjectOutput);
            Controls.Add(panelColorUCD);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UserControlDetail";
            Size = new Size(1168, 528);
            ((System.ComponentModel.ISupportInitialize)dataGridProjectOutput).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMaterialOutput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridProjectOutput;
        private DataGridView dataGridMaterialOutput;
        private Panel panelColorUCD;
    }
}
