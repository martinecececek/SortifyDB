namespace TechnoWizz.ManualAddingForm.Select
{
    partial class MaterialSelect
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
            txtBoxSearch = new TextBox();
            btnSearch = new Button();
            dataGridMaterials = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridMaterials).BeginInit();
            SuspendLayout();
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.Location = new Point(583, 17);
            txtBoxSearch.Margin = new Padding(4, 3, 4, 3);
            txtBoxSearch.Multiline = true;
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.Size = new Size(383, 43);
            txtBoxSearch.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 15F);
            btnSearch.Location = new Point(974, 14);
            btnSearch.Margin = new Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(127, 46);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Vyhledat";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridMaterials
            // 
            dataGridMaterials.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMaterials.Location = new Point(583, 66);
            dataGridMaterials.Margin = new Padding(583, 3, 4, 3);
            dataGridMaterials.Name = "dataGridMaterials";
            dataGridMaterials.Size = new Size(518, 892);
            dataGridMaterials.TabIndex = 9;
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
            // MaterialSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtBoxSearch);
            Controls.Add(btnSearch);
            Controls.Add(dataGridMaterials);
            Controls.Add(btnBack);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MaterialSelect";
            Size = new Size(1620, 1015);
            Load += MaterialSelect_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridMaterials).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridMaterials;
        private System.Windows.Forms.Button btnBack;
    }
}
