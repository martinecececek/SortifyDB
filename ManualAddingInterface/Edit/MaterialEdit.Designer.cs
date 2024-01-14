namespace TechnoWizz.ManualAddingForm.Edit
{
    partial class MaterialEdit
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
            components = new System.ComponentModel.Container();
            btnCancel = new Button();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSave = new Button();
            btnInkoust = new Button();
            btnRedidlo = new Button();
            btnLak = new Button();
            panel8 = new Panel();
            btnSelecterTyp = new Button();
            btnAktivator = new Button();
            panel5 = new Panel();
            btnDil = new Button();
            btnPrimer = new Button();
            panel4 = new Panel();
            btnPolymer = new Button();
            panel3 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            typContainer = new FlowLayoutPanel();
            panel6 = new Panel();
            panel7 = new Panel();
            label2 = new Label();
            txtBoxNazev = new TextBox();
            txtBoxSap = new TextBox();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            typTimer = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            typContainer.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Left;
            btnCancel.Font = new Font("Segoe UI", 15F);
            btnCancel.Location = new Point(814, 3);
            btnCancel.Margin = new Padding(4, 3, 4, 12);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(233, 118);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Zrušit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(1050, 406);
            label3.Margin = new Padding(82, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 28);
            label3.TabIndex = 12;
            label3.Text = "Typ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnSave, 0, 0);
            tableLayoutPanel1.Controls.Add(btnCancel, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 882);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1620, 133);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Right;
            btnSave.Font = new Font("Segoe UI", 15F);
            btnSave.Location = new Point(573, 3);
            btnSave.Margin = new Padding(4, 3, 4, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(233, 118);
            btnSave.TabIndex = 0;
            btnSave.Text = "Uložit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnInkoust
            // 
            btnInkoust.BackColor = Color.FromArgb(0, 38, 255);
            btnInkoust.Font = new Font("Segoe UI", 15F);
            btnInkoust.ForeColor = Color.White;
            btnInkoust.Location = new Point(-28, -23);
            btnInkoust.Margin = new Padding(4, 3, 4, 3);
            btnInkoust.Name = "btnInkoust";
            btnInkoust.Size = new Size(344, 105);
            btnInkoust.TabIndex = 0;
            btnInkoust.Text = "Inkoust";
            btnInkoust.UseVisualStyleBackColor = false;
            // 
            // btnRedidlo
            // 
            btnRedidlo.BackColor = Color.FromArgb(0, 38, 255);
            btnRedidlo.Font = new Font("Segoe UI", 15F);
            btnRedidlo.ForeColor = Color.White;
            btnRedidlo.Location = new Point(-28, -23);
            btnRedidlo.Margin = new Padding(4, 3, 4, 3);
            btnRedidlo.Name = "btnRedidlo";
            btnRedidlo.Size = new Size(344, 105);
            btnRedidlo.TabIndex = 0;
            btnRedidlo.Text = "Ředidlo";
            btnRedidlo.UseVisualStyleBackColor = false;
            // 
            // btnLak
            // 
            btnLak.BackColor = Color.FromArgb(0, 38, 255);
            btnLak.Font = new Font("Segoe UI", 15F);
            btnLak.ForeColor = Color.White;
            btnLak.Location = new Point(-28, -23);
            btnLak.Margin = new Padding(4, 3, 4, 3);
            btnLak.Name = "btnLak";
            btnLak.Size = new Size(344, 105);
            btnLak.TabIndex = 0;
            btnLak.Text = "Kluzný lak";
            btnLak.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnSelecterTyp);
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(292, 58);
            panel8.TabIndex = 2;
            // 
            // btnSelecterTyp
            // 
            btnSelecterTyp.Font = new Font("Segoe UI", 15F);
            btnSelecterTyp.Location = new Point(-28, -23);
            btnSelecterTyp.Margin = new Padding(4, 3, 4, 3);
            btnSelecterTyp.Name = "btnSelecterTyp";
            btnSelecterTyp.Size = new Size(344, 105);
            btnSelecterTyp.TabIndex = 0;
            btnSelecterTyp.Text = "Vyberte typ materiálu";
            btnSelecterTyp.UseVisualStyleBackColor = true;
            btnSelecterTyp.Click += BtnSelecterTyp_Click;
            // 
            // btnAktivator
            // 
            btnAktivator.BackColor = Color.FromArgb(0, 38, 255);
            btnAktivator.Font = new Font("Segoe UI", 15F);
            btnAktivator.ForeColor = Color.White;
            btnAktivator.Location = new Point(-28, -23);
            btnAktivator.Margin = new Padding(4, 3, 4, 3);
            btnAktivator.Name = "btnAktivator";
            btnAktivator.Size = new Size(344, 105);
            btnAktivator.TabIndex = 0;
            btnAktivator.Text = "Aktivátor/čistič";
            btnAktivator.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLightLight;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(btnDil);
            panel5.ForeColor = SystemColors.ControlLight;
            panel5.Location = new Point(0, 58);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(291, 57);
            panel5.TabIndex = 1;
            // 
            // btnDil
            // 
            btnDil.BackColor = Color.FromArgb(0, 38, 255);
            btnDil.Font = new Font("Segoe UI", 15F);
            btnDil.ForeColor = Color.White;
            btnDil.Location = new Point(-28, -23);
            btnDil.Margin = new Padding(4, 3, 4, 3);
            btnDil.Name = "btnDil";
            btnDil.Size = new Size(344, 105);
            btnDil.TabIndex = 0;
            btnDil.Text = "Díl";
            btnDil.UseVisualStyleBackColor = false;
            // 
            // btnPrimer
            // 
            btnPrimer.BackColor = Color.FromArgb(0, 38, 255);
            btnPrimer.Font = new Font("Segoe UI", 15F);
            btnPrimer.ForeColor = Color.White;
            btnPrimer.Location = new Point(-28, -23);
            btnPrimer.Margin = new Padding(4, 3, 4, 3);
            btnPrimer.Name = "btnPrimer";
            btnPrimer.Size = new Size(344, 105);
            btnPrimer.TabIndex = 0;
            btnPrimer.Text = "Primer";
            btnPrimer.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btnPolymer);
            panel4.ForeColor = SystemColors.ControlLight;
            panel4.Location = new Point(0, 115);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(291, 57);
            panel4.TabIndex = 1;
            // 
            // btnPolymer
            // 
            btnPolymer.BackColor = Color.FromArgb(0, 38, 255);
            btnPolymer.Font = new Font("Segoe UI", 15F);
            btnPolymer.ForeColor = Color.White;
            btnPolymer.Location = new Point(-28, -23);
            btnPolymer.Margin = new Padding(4, 3, 4, 3);
            btnPolymer.Name = "btnPolymer";
            btnPolymer.Size = new Size(344, 105);
            btnPolymer.TabIndex = 0;
            btnPolymer.Text = "Polymer/lepidlo";
            btnPolymer.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnPrimer);
            panel3.ForeColor = SystemColors.ControlLight;
            panel3.Location = new Point(0, 172);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(291, 57);
            panel3.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnAktivator);
            panel1.ForeColor = SystemColors.ControlLight;
            panel1.Location = new Point(0, 229);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 57);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnLak);
            panel2.ForeColor = SystemColors.ControlLight;
            panel2.Location = new Point(0, 286);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(291, 57);
            panel2.TabIndex = 1;
            // 
            // typContainer
            // 
            typContainer.Controls.Add(panel8);
            typContainer.Controls.Add(panel5);
            typContainer.Controls.Add(panel4);
            typContainer.Controls.Add(panel3);
            typContainer.Controls.Add(panel1);
            typContainer.Controls.Add(panel2);
            typContainer.Controls.Add(panel6);
            typContainer.Controls.Add(panel7);
            typContainer.Location = new Point(1054, 444);
            typContainer.Margin = new Padding(4, 3, 4, 3);
            typContainer.Name = "typContainer";
            typContainer.Size = new Size(292, 58);
            typContainer.TabIndex = 11;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlLightLight;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(btnRedidlo);
            panel6.ForeColor = SystemColors.ControlLight;
            panel6.Location = new Point(0, 343);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(291, 57);
            panel6.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ControlLightLight;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(btnInkoust);
            panel7.ForeColor = SystemColors.ControlLight;
            panel7.Location = new Point(0, 400);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(291, 57);
            panel7.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(519, 1);
            label2.Margin = new Padding(82, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 4;
            label2.Text = "Název";
            // 
            // txtBoxNazev
            // 
            txtBoxNazev.Dock = DockStyle.Left;
            txtBoxNazev.Location = new Point(513, 37);
            txtBoxNazev.Margin = new Padding(76, 3, 4, 3);
            txtBoxNazev.Multiline = true;
            txtBoxNazev.Name = "txtBoxNazev";
            txtBoxNazev.Size = new Size(291, 59);
            txtBoxNazev.TabIndex = 7;
            // 
            // txtBoxSap
            // 
            txtBoxSap.Dock = DockStyle.Right;
            txtBoxSap.Location = new Point(141, 37);
            txtBoxSap.Margin = new Padding(4, 3, 4, 3);
            txtBoxSap.Multiline = true;
            txtBoxSap.Name = "txtBoxSap";
            txtBoxSap.Size = new Size(291, 59);
            txtBoxSap.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(141, 1);
            label1.Margin = new Padding(140, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 28);
            label1.TabIndex = 3;
            label1.Text = "SAP";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 426F));
            tableLayoutPanel2.Controls.Add(txtBoxNazev, 1, 1);
            tableLayoutPanel2.Controls.Add(txtBoxSap, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Location = new Point(174, 406);
            tableLayoutPanel2.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 66.66666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel2.Size = new Size(873, 100);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // typTimer
            // 
            typTimer.Interval = 10;
            typTimer.Tick += TypTimer_Tick;
            // 
            // MaterialEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(typContainer);
            Controls.Add(label3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MaterialEdit";
            Size = new Size(1620, 1015);
            Load += MaterialEdit_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            typContainer.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnInkoust;
        private System.Windows.Forms.Button btnRedidlo;
        private System.Windows.Forms.Button btnLak;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnSelecterTyp;
        private System.Windows.Forms.Button btnAktivator;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDil;
        private System.Windows.Forms.Button btnPrimer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnPolymer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel typContainer;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNazev;
        private System.Windows.Forms.TextBox txtBoxSap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Timer typTimer;
    }
}
