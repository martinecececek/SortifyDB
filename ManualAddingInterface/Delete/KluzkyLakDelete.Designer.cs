namespace TechnoWizz.ManualAddingForm.Delete
{
    partial class KluzkyLakDelete
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
            dataGridLak = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridLak).BeginInit();
            SuspendLayout();
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(617, 28);
            textBoxSearch.Margin = new Padding(4, 3, 4, 3);
            textBoxSearch.Multiline = true;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(383, 43);
            textBoxSearch.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 15F);
            btnSearch.Location = new Point(1008, 25);
            btnSearch.Margin = new Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(127, 46);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Vyhledat";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridLak
            // 
            dataGridLak.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLak.Location = new Point(617, 78);
            dataGridLak.Margin = new Padding(583, 3, 4, 3);
            dataGridLak.Name = "dataGridLak";
            dataGridLak.Size = new Size(518, 908);
            dataGridLak.TabIndex = 9;
            // 
            // button1
            // 
            button1.Image = SortifyDB.Properties.Resources.Left;
            button1.Location = new Point(18, 17);
            button1.Margin = new Padding(18, 17, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 54);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // KluzkyLakDelete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxSearch);
            Controls.Add(btnSearch);
            Controls.Add(dataGridLak);
            Controls.Add(button1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "KluzkyLakDelete";
            Size = new Size(1620, 1015);
            Load += KluzkyLakDelete_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridLak).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridLak;
        private System.Windows.Forms.Button button1;
    }
}
