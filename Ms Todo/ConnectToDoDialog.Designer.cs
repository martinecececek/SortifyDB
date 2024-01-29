namespace SortifyDB.Ms_Todo
{
    partial class ConnectToDoDialog
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnNe = new Button();
            bntAno = new Button();
            checkBoxShowAgain = new CheckBox();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnNe, 0, 0);
            tableLayoutPanel1.Controls.Add(bntAno, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 199);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(595, 149);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // btnNe
            // 
            btnNe.Dock = DockStyle.Left;
            btnNe.Font = new Font("Segoe UI", 15F);
            btnNe.Location = new Point(300, 4);
            btnNe.Margin = new Padding(3, 4, 3, 13);
            btnNe.Name = "btnNe";
            btnNe.Size = new Size(229, 132);
            btnNe.TabIndex = 1;
            btnNe.Text = "Ne";
            btnNe.UseVisualStyleBackColor = true;
            btnNe.Click += btnNe_Click_1;
            // 
            // bntAno
            // 
            bntAno.Dock = DockStyle.Right;
            bntAno.Font = new Font("Segoe UI", 15F);
            bntAno.Location = new Point(65, 4);
            bntAno.Margin = new Padding(3, 4, 3, 13);
            bntAno.Name = "bntAno";
            bntAno.Size = new Size(229, 132);
            bntAno.TabIndex = 0;
            bntAno.Text = "Ano";
            bntAno.UseVisualStyleBackColor = true;
            bntAno.Click += bntAno_Click;
            // 
            // checkBoxShowAgain
            // 
            checkBoxShowAgain.AutoSize = true;
            checkBoxShowAgain.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            checkBoxShowAgain.Location = new Point(45, 117);
            checkBoxShowAgain.Margin = new Padding(3, 4, 3, 4);
            checkBoxShowAgain.Name = "checkBoxShowAgain";
            checkBoxShowAgain.Size = new Size(183, 27);
            checkBoxShowAgain.TabIndex = 4;
            checkBoxShowAgain.Text = "Přístě nezobrazovat";
            checkBoxShowAgain.UseVisualStyleBackColor = true;
            checkBoxShowAgain.CheckedChanged += checkBoxShowAgain_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(45, 76);
            label1.Name = "label1";
            label1.Size = new Size(522, 35);
            label1.TabIndex = 3;
            label1.Text = "Přejete si aplikaci propojit s Microsoft Todo?";
            // 
            // ConnectToDoDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(595, 348);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(checkBoxShowAgain);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ConnectToDoDialog";
            Text = "ConnectToDoDialog";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button bntAno;
        private CheckBox checkBoxShowAgain;
        private Label label1;
        private Button btnNe;
    }
}