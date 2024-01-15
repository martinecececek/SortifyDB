namespace SortifyDB
{
    partial class UserControlOutPut
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
            dataGridUCOutput = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridUCOutput).BeginInit();
            SuspendLayout();
            // 
            // dataGridUCOutput
            // 
            dataGridUCOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUCOutput.Location = new Point(0, 0);
            dataGridUCOutput.Name = "dataGridUCOutput";
            dataGridUCOutput.Size = new Size(1168, 528);
            dataGridUCOutput.TabIndex = 0;
            // 
            // UserControlOutPut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridUCOutput);
            Name = "UserControlOutPut";
            Size = new Size(1168, 528);
            ((System.ComponentModel.ISupportInitialize)dataGridUCOutput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridUCOutput;
    }
}
