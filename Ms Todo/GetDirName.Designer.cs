namespace SortifyDB.Ms_Todo
{
    partial class GetDirName
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
            txtDirName = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(14, 66);
            label1.Name = "label1";
            label1.Size = new Size(474, 37);
            label1.TabIndex = 0;
            label1.Text = "Zadejte v jaké složce se úkoly nachází";
            // 
            // txtDirName
            // 
            txtDirName.Font = new Font("Segoe UI", 22F);
            txtDirName.Location = new Point(55, 106);
            txtDirName.Multiline = true;
            txtDirName.Name = "txtDirName";
            txtDirName.PlaceholderText = "Název složky";
            txtDirName.Size = new Size(393, 52);
            txtDirName.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 15F);
            btnSave.Location = new Point(150, 189);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(200, 99);
            btnSave.TabIndex = 2;
            btnSave.Text = "Uložit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // GetDirName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 300);
            Controls.Add(btnSave);
            Controls.Add(txtDirName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GetDirName";
            Text = "GetDirName";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDirName;
        private Button btnSave;
    }
}