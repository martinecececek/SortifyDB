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
            labelUCDetailContains = new Label();
            labelUCDetailMainName = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridProjectOutput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMaterialOutput).BeginInit();
            panelColorUCD.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridProjectOutput
            // 
            dataGridProjectOutput.Anchor = AnchorStyles.Top;
            dataGridProjectOutput.BackgroundColor = Color.CornflowerBlue;
            dataGridProjectOutput.BorderStyle = BorderStyle.None;
            dataGridProjectOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProjectOutput.Location = new Point(20, 33);
            dataGridProjectOutput.Margin = new Padding(20);
            dataGridProjectOutput.Name = "dataGridProjectOutput";
            dataGridProjectOutput.RowHeadersWidth = 51;
            dataGridProjectOutput.Size = new Size(1440, 88);
            dataGridProjectOutput.TabIndex = 0;
            // 
            // dataGridMaterialOutput
            // 
            dataGridMaterialOutput.Anchor = AnchorStyles.Top;
            dataGridMaterialOutput.BackgroundColor = Color.CornflowerBlue;
            dataGridMaterialOutput.BorderStyle = BorderStyle.None;
            dataGridMaterialOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMaterialOutput.Location = new Point(20, 149);
            dataGridMaterialOutput.Margin = new Padding(20);
            dataGridMaterialOutput.Name = "dataGridMaterialOutput";
            dataGridMaterialOutput.RowHeadersWidth = 51;
            dataGridMaterialOutput.Size = new Size(1432, 506);
            dataGridMaterialOutput.TabIndex = 1;
            // 
            // panelColorUCD
            // 
            panelColorUCD.BackColor = Color.CornflowerBlue;
            panelColorUCD.Controls.Add(dataGridProjectOutput);
            panelColorUCD.Controls.Add(dataGridMaterialOutput);
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
            labelUCDetailContains.Location = new Point(20, 121);
            labelUCDetailContains.Margin = new Padding(2, 0, 2, 0);
            labelUCDetailContains.Name = "labelUCDetailContains";
            labelUCDetailContains.Size = new Size(169, 30);
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
            labelUCDetailMainName.Size = new Size(169, 30);
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
            ((System.ComponentModel.ISupportInitialize)dataGridProjectOutput).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMaterialOutput).EndInit();
            panelColorUCD.ResumeLayout(false);
            panelColorUCD.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridMainOutput;
        private DataGridView dataGridDetailOutputOutput;
        private Panel panelColorUCD;
        private Label labelUCDetailContains;
        private Label labelUCDetailMainName;
    }
}
