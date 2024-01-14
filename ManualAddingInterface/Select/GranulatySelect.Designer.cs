namespace TechnoWizz.ManualAddingForm.Select
{
    partial class GranulatySelect
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxSearch = new TextBox();
            btnSearch = new Button();
            dataGridGranulat = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridGranulat).BeginInit();
            SuspendLayout();
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(616, 17);
            textBoxSearch.Margin = new Padding(4, 3, 4, 3);
            textBoxSearch.Multiline = true;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(383, 43);
            textBoxSearch.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 15F);
            btnSearch.Location = new Point(1007, 14);
            btnSearch.Margin = new Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(127, 46);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Vyhledat";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridGranulat
            // 
            dataGridGranulat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridGranulat.Location = new Point(616, 67);
            dataGridGranulat.Margin = new Padding(583, 3, 4, 3);
            dataGridGranulat.Name = "dataGridGranulat";
            dataGridGranulat.Size = new Size(518, 909);
            dataGridGranulat.TabIndex = 9;
            // 
            // btnBack
            // 
            btnBack.Image = SortifyDB.Properties.Resources.Left;
            btnBack.Location = new Point(18, 17);
            btnBack.Margin = new Padding(18, 17, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 54);
            btnBack.TabIndex = 8;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // GranulatySelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxSearch);
            Controls.Add(btnSearch);
            Controls.Add(dataGridGranulat);
            Controls.Add(btnBack);
            Margin = new Padding(4, 3, 4, 3);
            Name = "GranulatySelect";
            Size = new Size(1620, 1015);
            Load += GranulatySelect_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridGranulat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridGranulat;
        private System.Windows.Forms.Button btnBack;
    }
}
