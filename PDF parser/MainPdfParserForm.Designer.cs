namespace SortifyDB.PDF_parser
{
    partial class MainPdfParserForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(22, 26);
            label1.Name = "label1";
            label1.Size = new Size(410, 56);
            label1.TabIndex = 0;
            label1.Text = "Přejete si vytvořit nový technocký list nebo \r\nupravit stávající?\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanel1.Controls.Add(btnEdit, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 120);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(459, 97);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Right;
            btnAdd.Font = new Font("Segoe UI", 15F);
            btnAdd.Location = new Point(26, 3);
            btnAdd.Margin = new Padding(3, 3, 3, 10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 84);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Přidat";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Dock = DockStyle.Left;
            btnEdit.Font = new Font("Segoe UI", 15F);
            btnEdit.Location = new Point(232, 3);
            btnEdit.Margin = new Padding(3, 3, 3, 10);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(200, 84);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Upravit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // MainPdfParserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 217);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Name = "MainPdfParserForm";
            Text = "MainPdfParserForm";
            Load += MainPdfParserForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAdd;
        private Button btnEdit;
    }
}