namespace SortifyDB.PDF_parser
{
    partial class GetPreviousTL
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
            textBox1 = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(96, 32);
            label1.Name = "label1";
            label1.Size = new Size(258, 28);
            label1.TabIndex = 0;
            label1.Text = "Zadejte původní TL projektu";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(75, 63);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(297, 40);
            textBox1.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(115, 109);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(200, 100);
            btnSave.TabIndex = 2;
            btnSave.Text = "Potvrdit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // GetPreviousTL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 217);
            Controls.Add(btnSave);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "GetPreviousTL";
            Text = "GetPreviousTL";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btnSave;
    }
}