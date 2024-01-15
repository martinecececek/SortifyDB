namespace SortifyDB
{
    partial class ProjectsUserControl
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
            panelColor1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridProjectOutput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMaterialOutput).BeginInit();
            SuspendLayout();
            // 
            // dataGridProjectOutput
            // 
            dataGridProjectOutput.Anchor = AnchorStyles.Top;
            dataGridProjectOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProjectOutput.Location = new Point(25, 25);
            dataGridProjectOutput.Margin = new Padding(25);
            dataGridProjectOutput.Name = "dataGridProjectOutput";
            dataGridProjectOutput.RowHeadersWidth = 51;
            dataGridProjectOutput.Size = new Size(1410, 133);
            dataGridProjectOutput.TabIndex = 0;
            // 
            // dataGridMaterialOutput
            // 
            dataGridMaterialOutput.Anchor = AnchorStyles.Top;
            dataGridMaterialOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMaterialOutput.Location = new Point(25, 188);
            dataGridMaterialOutput.Margin = new Padding(25);
            dataGridMaterialOutput.Name = "dataGridMaterialOutput";
            dataGridMaterialOutput.RowHeadersWidth = 51;
            dataGridMaterialOutput.Size = new Size(1410, 447);
            dataGridMaterialOutput.TabIndex = 1;
            // 
            // panelColor1
            // 
            panelColor1.BackColor = Color.CadetBlue;
            panelColor1.Location = new Point(0, 0);
            panelColor1.Margin = new Padding(0);
            panelColor1.Name = "panelColor1";
            panelColor1.Size = new Size(1460, 660);
            panelColor1.TabIndex = 2;
            // 
            // ProjectsUserControl
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Controls.Add(dataGridMaterialOutput);
            Controls.Add(dataGridProjectOutput);
            Controls.Add(panelColor1);
            Name = "ProjectsUserControl";
            Size = new Size(1460, 660);
            ((System.ComponentModel.ISupportInitialize)dataGridProjectOutput).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMaterialOutput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridProjectOutput;
        private DataGridView dataGridMaterialOutput;
        private Panel panelColor1;
    }
}
