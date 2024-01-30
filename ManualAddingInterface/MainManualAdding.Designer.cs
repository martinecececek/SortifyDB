namespace SortifyDB.ManualAddingInterface
{
    partial class MainManualAdding
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            materialConatainer = new FlowLayoutPanel();
            panel1 = new Panel();
            btnMaterial = new Button();
            panel2 = new Panel();
            btnAddMaterial = new Button();
            panel3 = new Panel();
            btnEditMaterial = new Button();
            panel4 = new Panel();
            btnDeleteMaterial = new Button();
            projectContainer = new FlowLayoutPanel();
            panel5 = new Panel();
            btnProjekt = new Button();
            panel6 = new Panel();
            btnAddProjekt = new Button();
            panel7 = new Panel();
            btnEditProjekt = new Button();
            panel8 = new Panel();
            btnDeleteProjekt = new Button();
            granulatContainer = new FlowLayoutPanel();
            panel13 = new Panel();
            btnGranulat = new Button();
            panel14 = new Panel();
            btnAddGranulat = new Button();
            panel15 = new Panel();
            btnEditGranulat = new Button();
            panel16 = new Panel();
            btnDeleteGranulat = new Button();
            lakContainer = new FlowLayoutPanel();
            panel9 = new Panel();
            btnLak = new Button();
            panel10 = new Panel();
            btnAddLak = new Button();
            panel11 = new Panel();
            btnEditLak = new Button();
            panel12 = new Panel();
            btnDeleteLak = new Button();
            cisticeContainer = new FlowLayoutPanel();
            panel17 = new Panel();
            btnCisitic = new Button();
            panel18 = new Panel();
            btnAddCistic = new Button();
            panel19 = new Panel();
            btnEditCistic = new Button();
            panel20 = new Panel();
            btnDeleteCisitic = new Button();
            panel21 = new Panel();
            btnBack = new Button();
            materialTimer = new System.Windows.Forms.Timer(components);
            projectTimer = new System.Windows.Forms.Timer(components);
            granulatyTimer = new System.Windows.Forms.Timer(components);
            lakTimer = new System.Windows.Forms.Timer(components);
            cisticeTimer = new System.Windows.Forms.Timer(components);
            mainContainer = new Panel();
            flowLayoutPanel1.SuspendLayout();
            materialConatainer.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            projectContainer.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            granulatContainer.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            lakContainer.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            cisticeContainer.SuspendLayout();
            panel17.SuspendLayout();
            panel18.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            panel21.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(0, 38, 255);
            flowLayoutPanel1.Controls.Add(materialConatainer);
            flowLayoutPanel1.Controls.Add(projectContainer);
            flowLayoutPanel1.Controls.Add(granulatContainer);
            flowLayoutPanel1.Controls.Add(lakContainer);
            flowLayoutPanel1.Controls.Add(cisticeContainer);
            flowLayoutPanel1.Controls.Add(panel21);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(300, 1015);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // materialConatainer
            // 
            materialConatainer.Controls.Add(panel1);
            materialConatainer.Controls.Add(panel2);
            materialConatainer.Controls.Add(panel3);
            materialConatainer.Controls.Add(panel4);
            materialConatainer.Location = new Point(0, 30);
            materialConatainer.Margin = new Padding(0, 30, 0, 0);
            materialConatainer.Name = "materialConatainer";
            materialConatainer.Size = new Size(300, 100);
            materialConatainer.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnMaterial);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 100);
            panel1.TabIndex = 2;
            // 
            // btnMaterial
            // 
            btnMaterial.BackColor = Color.FromArgb(0, 38, 255);
            btnMaterial.Font = new Font("Segoe UI", 20F);
            btnMaterial.ForeColor = Color.White;
            btnMaterial.Location = new Point(-22, -13);
            btnMaterial.Name = "btnMaterial";
            btnMaterial.Size = new Size(350, 130);
            btnMaterial.TabIndex = 5;
            btnMaterial.Text = "Materiál";
            btnMaterial.UseVisualStyleBackColor = false;
            btnMaterial.Click += btnMaterial_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAddMaterial);
            panel2.Location = new Point(0, 100);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(302, 100);
            panel2.TabIndex = 3;
            // 
            // btnAddMaterial
            // 
            btnAddMaterial.BackColor = Color.FromArgb(0, 148, 255);
            btnAddMaterial.Font = new Font("Segoe UI", 15F);
            btnAddMaterial.ForeColor = Color.White;
            btnAddMaterial.Image = Properties.Resources.Add_New;
            btnAddMaterial.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddMaterial.Location = new Point(-22, -18);
            btnAddMaterial.Name = "btnAddMaterial";
            btnAddMaterial.Padding = new Padding(60, 0, 0, 0);
            btnAddMaterial.Size = new Size(350, 130);
            btnAddMaterial.TabIndex = 5;
            btnAddMaterial.Text = "                  Přidat";
            btnAddMaterial.TextAlign = ContentAlignment.MiddleLeft;
            btnAddMaterial.UseVisualStyleBackColor = false;
            btnAddMaterial.Click += btnAddMaterial_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnEditMaterial);
            panel3.Location = new Point(0, 200);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(302, 100);
            panel3.TabIndex = 6;
            // 
            // btnEditMaterial
            // 
            btnEditMaterial.BackColor = Color.FromArgb(0, 148, 255);
            btnEditMaterial.Font = new Font("Segoe UI", 15F);
            btnEditMaterial.ForeColor = Color.White;
            btnEditMaterial.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditMaterial.Location = new Point(-22, -18);
            btnEditMaterial.Name = "btnEditMaterial";
            btnEditMaterial.Padding = new Padding(60, 0, 0, 0);
            btnEditMaterial.Size = new Size(350, 130);
            btnEditMaterial.TabIndex = 5;
            btnEditMaterial.Text = "                  Upravit";
            btnEditMaterial.TextAlign = ContentAlignment.MiddleLeft;
            btnEditMaterial.UseVisualStyleBackColor = false;
            btnEditMaterial.Click += btnEditMaterial_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnDeleteMaterial);
            panel4.Location = new Point(0, 300);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(302, 100);
            panel4.TabIndex = 6;
            // 
            // btnDeleteMaterial
            // 
            btnDeleteMaterial.BackColor = Color.FromArgb(0, 148, 255);
            btnDeleteMaterial.Font = new Font("Segoe UI", 15F);
            btnDeleteMaterial.ForeColor = Color.White;
            btnDeleteMaterial.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteMaterial.Location = new Point(-22, -18);
            btnDeleteMaterial.Name = "btnDeleteMaterial";
            btnDeleteMaterial.Padding = new Padding(60, 0, 0, 0);
            btnDeleteMaterial.Size = new Size(350, 130);
            btnDeleteMaterial.TabIndex = 5;
            btnDeleteMaterial.Text = "                  Smazat";
            btnDeleteMaterial.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteMaterial.UseVisualStyleBackColor = false;
            btnDeleteMaterial.Click += btnDeleteMaterial_Click;
            // 
            // projectContainer
            // 
            projectContainer.Controls.Add(panel5);
            projectContainer.Controls.Add(panel6);
            projectContainer.Controls.Add(panel7);
            projectContainer.Controls.Add(panel8);
            projectContainer.Location = new Point(0, 130);
            projectContainer.Margin = new Padding(0);
            projectContainer.Name = "projectContainer";
            projectContainer.Size = new Size(300, 100);
            projectContainer.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnProjekt);
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(302, 100);
            panel5.TabIndex = 2;
            // 
            // btnProjekt
            // 
            btnProjekt.BackColor = Color.FromArgb(0, 38, 255);
            btnProjekt.Font = new Font("Segoe UI", 20F);
            btnProjekt.ForeColor = Color.White;
            btnProjekt.Location = new Point(-22, -13);
            btnProjekt.Name = "btnProjekt";
            btnProjekt.Size = new Size(350, 130);
            btnProjekt.TabIndex = 5;
            btnProjekt.Text = "Projekt";
            btnProjekt.UseVisualStyleBackColor = false;
            btnProjekt.Click += btnProjekt_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnAddProjekt);
            panel6.Location = new Point(0, 100);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(302, 100);
            panel6.TabIndex = 3;
            // 
            // btnAddProjekt
            // 
            btnAddProjekt.BackColor = Color.FromArgb(0, 148, 255);
            btnAddProjekt.Font = new Font("Segoe UI", 15F);
            btnAddProjekt.ForeColor = Color.White;
            btnAddProjekt.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddProjekt.Location = new Point(-22, -18);
            btnAddProjekt.Name = "btnAddProjekt";
            btnAddProjekt.Padding = new Padding(60, 0, 0, 0);
            btnAddProjekt.Size = new Size(350, 130);
            btnAddProjekt.TabIndex = 5;
            btnAddProjekt.Text = "                  Přidat";
            btnAddProjekt.TextAlign = ContentAlignment.MiddleLeft;
            btnAddProjekt.UseVisualStyleBackColor = false;
            btnAddProjekt.Click += btnAddProjekt_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnEditProjekt);
            panel7.Location = new Point(0, 200);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(302, 100);
            panel7.TabIndex = 6;
            // 
            // btnEditProjekt
            // 
            btnEditProjekt.BackColor = Color.FromArgb(0, 148, 255);
            btnEditProjekt.Font = new Font("Segoe UI", 15F);
            btnEditProjekt.ForeColor = Color.White;
            btnEditProjekt.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditProjekt.Location = new Point(-22, -18);
            btnEditProjekt.Name = "btnEditProjekt";
            btnEditProjekt.Padding = new Padding(60, 0, 0, 0);
            btnEditProjekt.Size = new Size(350, 130);
            btnEditProjekt.TabIndex = 5;
            btnEditProjekt.Text = "                  Upravit";
            btnEditProjekt.TextAlign = ContentAlignment.MiddleLeft;
            btnEditProjekt.UseVisualStyleBackColor = false;
            btnEditProjekt.Click += btnEditProjekt_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnDeleteProjekt);
            panel8.Location = new Point(0, 300);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(302, 100);
            panel8.TabIndex = 6;
            // 
            // btnDeleteProjekt
            // 
            btnDeleteProjekt.BackColor = Color.FromArgb(0, 148, 255);
            btnDeleteProjekt.Font = new Font("Segoe UI", 15F);
            btnDeleteProjekt.ForeColor = Color.White;
            btnDeleteProjekt.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteProjekt.Location = new Point(-22, -18);
            btnDeleteProjekt.Name = "btnDeleteProjekt";
            btnDeleteProjekt.Padding = new Padding(60, 0, 0, 0);
            btnDeleteProjekt.Size = new Size(350, 130);
            btnDeleteProjekt.TabIndex = 5;
            btnDeleteProjekt.Text = "                  Smazat";
            btnDeleteProjekt.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteProjekt.UseVisualStyleBackColor = false;
            btnDeleteProjekt.Click += btnDeleteProjekt_Click;
            // 
            // granulatContainer
            // 
            granulatContainer.Controls.Add(panel13);
            granulatContainer.Controls.Add(panel14);
            granulatContainer.Controls.Add(panel15);
            granulatContainer.Controls.Add(panel16);
            granulatContainer.Location = new Point(0, 230);
            granulatContainer.Margin = new Padding(0);
            granulatContainer.Name = "granulatContainer";
            granulatContainer.Size = new Size(300, 100);
            granulatContainer.TabIndex = 8;
            // 
            // panel13
            // 
            panel13.Controls.Add(btnGranulat);
            panel13.Location = new Point(0, 0);
            panel13.Margin = new Padding(0);
            panel13.Name = "panel13";
            panel13.Size = new Size(302, 100);
            panel13.TabIndex = 2;
            // 
            // btnGranulat
            // 
            btnGranulat.BackColor = Color.FromArgb(0, 38, 255);
            btnGranulat.Font = new Font("Segoe UI", 20F);
            btnGranulat.ForeColor = Color.White;
            btnGranulat.Location = new Point(-22, -13);
            btnGranulat.Name = "btnGranulat";
            btnGranulat.Size = new Size(350, 130);
            btnGranulat.TabIndex = 5;
            btnGranulat.Text = "Granulat";
            btnGranulat.UseVisualStyleBackColor = false;
            btnGranulat.Click += btnGranulat_Click;
            // 
            // panel14
            // 
            panel14.Controls.Add(btnAddGranulat);
            panel14.Location = new Point(0, 100);
            panel14.Margin = new Padding(0);
            panel14.Name = "panel14";
            panel14.Size = new Size(302, 100);
            panel14.TabIndex = 3;
            // 
            // btnAddGranulat
            // 
            btnAddGranulat.BackColor = Color.FromArgb(0, 148, 255);
            btnAddGranulat.Font = new Font("Segoe UI", 15F);
            btnAddGranulat.ForeColor = Color.White;
            btnAddGranulat.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddGranulat.Location = new Point(-22, -18);
            btnAddGranulat.Name = "btnAddGranulat";
            btnAddGranulat.Padding = new Padding(60, 0, 0, 0);
            btnAddGranulat.Size = new Size(350, 130);
            btnAddGranulat.TabIndex = 5;
            btnAddGranulat.Text = "                  Přidat";
            btnAddGranulat.TextAlign = ContentAlignment.MiddleLeft;
            btnAddGranulat.UseVisualStyleBackColor = false;
            btnAddGranulat.Click += btnAddGranulat_Click;
            // 
            // panel15
            // 
            panel15.Controls.Add(btnEditGranulat);
            panel15.Location = new Point(0, 200);
            panel15.Margin = new Padding(0);
            panel15.Name = "panel15";
            panel15.Size = new Size(302, 100);
            panel15.TabIndex = 6;
            // 
            // btnEditGranulat
            // 
            btnEditGranulat.BackColor = Color.FromArgb(0, 148, 255);
            btnEditGranulat.Font = new Font("Segoe UI", 15F);
            btnEditGranulat.ForeColor = Color.White;
            btnEditGranulat.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditGranulat.Location = new Point(-22, -18);
            btnEditGranulat.Name = "btnEditGranulat";
            btnEditGranulat.Padding = new Padding(60, 0, 0, 0);
            btnEditGranulat.Size = new Size(350, 130);
            btnEditGranulat.TabIndex = 5;
            btnEditGranulat.Text = "                  Upravit";
            btnEditGranulat.TextAlign = ContentAlignment.MiddleLeft;
            btnEditGranulat.UseVisualStyleBackColor = false;
            btnEditGranulat.Click += btnEditGranulat_Click;
            // 
            // panel16
            // 
            panel16.Controls.Add(btnDeleteGranulat);
            panel16.Location = new Point(0, 300);
            panel16.Margin = new Padding(0);
            panel16.Name = "panel16";
            panel16.Size = new Size(302, 100);
            panel16.TabIndex = 6;
            // 
            // btnDeleteGranulat
            // 
            btnDeleteGranulat.BackColor = Color.FromArgb(0, 148, 255);
            btnDeleteGranulat.Font = new Font("Segoe UI", 15F);
            btnDeleteGranulat.ForeColor = Color.White;
            btnDeleteGranulat.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteGranulat.Location = new Point(-22, -18);
            btnDeleteGranulat.Name = "btnDeleteGranulat";
            btnDeleteGranulat.Padding = new Padding(60, 0, 0, 0);
            btnDeleteGranulat.Size = new Size(350, 130);
            btnDeleteGranulat.TabIndex = 5;
            btnDeleteGranulat.Text = "                  Smazat";
            btnDeleteGranulat.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteGranulat.UseVisualStyleBackColor = false;
            btnDeleteGranulat.Click += btnDeleteGranulat_Click;
            // 
            // lakContainer
            // 
            lakContainer.Controls.Add(panel9);
            lakContainer.Controls.Add(panel10);
            lakContainer.Controls.Add(panel11);
            lakContainer.Controls.Add(panel12);
            lakContainer.Location = new Point(0, 330);
            lakContainer.Margin = new Padding(0);
            lakContainer.Name = "lakContainer";
            lakContainer.Size = new Size(300, 100);
            lakContainer.TabIndex = 7;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnLak);
            panel9.Location = new Point(0, 0);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Size = new Size(302, 100);
            panel9.TabIndex = 2;
            // 
            // btnLak
            // 
            btnLak.BackColor = Color.FromArgb(0, 38, 255);
            btnLak.Font = new Font("Segoe UI", 20F);
            btnLak.ForeColor = Color.White;
            btnLak.Location = new Point(-22, -13);
            btnLak.Name = "btnLak";
            btnLak.Size = new Size(350, 130);
            btnLak.TabIndex = 5;
            btnLak.Text = "Kluzký lak";
            btnLak.UseVisualStyleBackColor = false;
            btnLak.Click += btnLak_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(btnAddLak);
            panel10.Location = new Point(0, 100);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Size = new Size(302, 100);
            panel10.TabIndex = 3;
            // 
            // btnAddLak
            // 
            btnAddLak.BackColor = Color.FromArgb(0, 148, 255);
            btnAddLak.Font = new Font("Segoe UI", 15F);
            btnAddLak.ForeColor = Color.White;
            btnAddLak.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddLak.Location = new Point(-22, -18);
            btnAddLak.Name = "btnAddLak";
            btnAddLak.Padding = new Padding(60, 0, 0, 0);
            btnAddLak.Size = new Size(350, 130);
            btnAddLak.TabIndex = 5;
            btnAddLak.Text = "                  Přidat";
            btnAddLak.TextAlign = ContentAlignment.MiddleLeft;
            btnAddLak.UseVisualStyleBackColor = false;
            btnAddLak.Click += btnAddLak_Click;
            // 
            // panel11
            // 
            panel11.Controls.Add(btnEditLak);
            panel11.Location = new Point(0, 200);
            panel11.Margin = new Padding(0);
            panel11.Name = "panel11";
            panel11.Size = new Size(302, 100);
            panel11.TabIndex = 6;
            // 
            // btnEditLak
            // 
            btnEditLak.BackColor = Color.FromArgb(0, 148, 255);
            btnEditLak.Font = new Font("Segoe UI", 15F);
            btnEditLak.ForeColor = Color.White;
            btnEditLak.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditLak.Location = new Point(-22, -18);
            btnEditLak.Name = "btnEditLak";
            btnEditLak.Padding = new Padding(60, 0, 0, 0);
            btnEditLak.Size = new Size(350, 130);
            btnEditLak.TabIndex = 5;
            btnEditLak.Text = "                  Upravit";
            btnEditLak.TextAlign = ContentAlignment.MiddleLeft;
            btnEditLak.UseVisualStyleBackColor = false;
            btnEditLak.Click += btnEditLak_Click;
            // 
            // panel12
            // 
            panel12.Controls.Add(btnDeleteLak);
            panel12.Location = new Point(0, 300);
            panel12.Margin = new Padding(0);
            panel12.Name = "panel12";
            panel12.Size = new Size(302, 100);
            panel12.TabIndex = 6;
            // 
            // btnDeleteLak
            // 
            btnDeleteLak.BackColor = Color.FromArgb(0, 148, 255);
            btnDeleteLak.Font = new Font("Segoe UI", 15F);
            btnDeleteLak.ForeColor = Color.White;
            btnDeleteLak.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteLak.Location = new Point(-22, -18);
            btnDeleteLak.Name = "btnDeleteLak";
            btnDeleteLak.Padding = new Padding(60, 0, 0, 0);
            btnDeleteLak.Size = new Size(350, 130);
            btnDeleteLak.TabIndex = 5;
            btnDeleteLak.Text = "                  Smazat";
            btnDeleteLak.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteLak.UseVisualStyleBackColor = false;
            btnDeleteLak.Click += btnDeleteLak_Click;
            // 
            // cisticeContainer
            // 
            cisticeContainer.Controls.Add(panel17);
            cisticeContainer.Controls.Add(panel18);
            cisticeContainer.Controls.Add(panel19);
            cisticeContainer.Controls.Add(panel20);
            cisticeContainer.Location = new Point(0, 430);
            cisticeContainer.Margin = new Padding(0);
            cisticeContainer.Name = "cisticeContainer";
            cisticeContainer.Size = new Size(300, 100);
            cisticeContainer.TabIndex = 9;
            // 
            // panel17
            // 
            panel17.Controls.Add(btnCisitic);
            panel17.Location = new Point(0, 0);
            panel17.Margin = new Padding(0);
            panel17.Name = "panel17";
            panel17.Size = new Size(302, 100);
            panel17.TabIndex = 2;
            // 
            // btnCisitic
            // 
            btnCisitic.BackColor = Color.FromArgb(0, 38, 255);
            btnCisitic.Font = new Font("Segoe UI", 20F);
            btnCisitic.ForeColor = Color.White;
            btnCisitic.Location = new Point(-22, -13);
            btnCisitic.Name = "btnCisitic";
            btnCisitic.Size = new Size(350, 130);
            btnCisitic.TabIndex = 5;
            btnCisitic.Text = "Čistič/Aktivátor";
            btnCisitic.UseVisualStyleBackColor = false;
            btnCisitic.Click += btnCisitic_Click;
            // 
            // panel18
            // 
            panel18.Controls.Add(btnAddCistic);
            panel18.Location = new Point(0, 100);
            panel18.Margin = new Padding(0);
            panel18.Name = "panel18";
            panel18.Size = new Size(302, 100);
            panel18.TabIndex = 3;
            // 
            // btnAddCistic
            // 
            btnAddCistic.BackColor = Color.FromArgb(0, 148, 255);
            btnAddCistic.Font = new Font("Segoe UI", 15F);
            btnAddCistic.ForeColor = Color.White;
            btnAddCistic.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddCistic.Location = new Point(-22, -18);
            btnAddCistic.Name = "btnAddCistic";
            btnAddCistic.Padding = new Padding(60, 0, 0, 0);
            btnAddCistic.Size = new Size(350, 130);
            btnAddCistic.TabIndex = 5;
            btnAddCistic.Text = "                  Přidat";
            btnAddCistic.TextAlign = ContentAlignment.MiddleLeft;
            btnAddCistic.UseVisualStyleBackColor = false;
            btnAddCistic.Click += btnAddCistic_Click;
            // 
            // panel19
            // 
            panel19.Controls.Add(btnEditCistic);
            panel19.Location = new Point(0, 200);
            panel19.Margin = new Padding(0);
            panel19.Name = "panel19";
            panel19.Size = new Size(302, 100);
            panel19.TabIndex = 6;
            // 
            // btnEditCistic
            // 
            btnEditCistic.BackColor = Color.FromArgb(0, 148, 255);
            btnEditCistic.Font = new Font("Segoe UI", 15F);
            btnEditCistic.ForeColor = Color.White;
            btnEditCistic.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditCistic.Location = new Point(-22, -18);
            btnEditCistic.Name = "btnEditCistic";
            btnEditCistic.Padding = new Padding(60, 0, 0, 0);
            btnEditCistic.Size = new Size(350, 130);
            btnEditCistic.TabIndex = 5;
            btnEditCistic.Text = "                  Upravit";
            btnEditCistic.TextAlign = ContentAlignment.MiddleLeft;
            btnEditCistic.UseVisualStyleBackColor = false;
            btnEditCistic.Click += btnEditCistic_Click;
            // 
            // panel20
            // 
            panel20.Controls.Add(btnDeleteCisitic);
            panel20.Location = new Point(0, 300);
            panel20.Margin = new Padding(0);
            panel20.Name = "panel20";
            panel20.Size = new Size(302, 100);
            panel20.TabIndex = 6;
            // 
            // btnDeleteCisitic
            // 
            btnDeleteCisitic.BackColor = Color.FromArgb(0, 148, 255);
            btnDeleteCisitic.Font = new Font("Segoe UI", 15F);
            btnDeleteCisitic.ForeColor = Color.White;
            btnDeleteCisitic.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteCisitic.Location = new Point(-22, -18);
            btnDeleteCisitic.Name = "btnDeleteCisitic";
            btnDeleteCisitic.Padding = new Padding(60, 0, 0, 0);
            btnDeleteCisitic.Size = new Size(350, 130);
            btnDeleteCisitic.TabIndex = 5;
            btnDeleteCisitic.Text = "                  Smazat";
            btnDeleteCisitic.TextAlign = ContentAlignment.MiddleLeft;
            btnDeleteCisitic.UseVisualStyleBackColor = false;
            btnDeleteCisitic.Click += btnDeleteCisitic_Click;
            // 
            // panel21
            // 
            panel21.Controls.Add(btnBack);
            panel21.Location = new Point(0, 530);
            panel21.Margin = new Padding(0);
            panel21.Name = "panel21";
            panel21.Size = new Size(302, 100);
            panel21.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(0, 38, 255);
            btnBack.Font = new Font("Segoe UI", 20F);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(-22, -18);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(350, 130);
            btnBack.TabIndex = 5;
            btnBack.Text = "Zpět";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // materialTimer
            // 
            materialTimer.Interval = 10;
            materialTimer.Tick += materialTimer_Tick;
            // 
            // projectTimer
            // 
            projectTimer.Interval = 10;
            projectTimer.Tick += projectTimer_Tick;
            // 
            // granulatyTimer
            // 
            granulatyTimer.Interval = 10;
            granulatyTimer.Tick += granulatyTimer_Tick;
            // 
            // lakTimer
            // 
            lakTimer.Interval = 10;
            lakTimer.Tick += lakTimer_Tick;
            // 
            // cisticeTimer
            // 
            cisticeTimer.Interval = 10;
            cisticeTimer.Tick += cisticeTimer_Tick;
            // 
            // mainContainer
            // 
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(300, 0);
            mainContainer.Margin = new Padding(0);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(1620, 1015);
            mainContainer.TabIndex = 3;
            // 
            // MainManualAdding
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainContainer);
            Controls.Add(flowLayoutPanel1);
            Name = "MainManualAdding";
            Size = new Size(1920, 1015);
            flowLayoutPanel1.ResumeLayout(false);
            materialConatainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            projectContainer.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            granulatContainer.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel16.ResumeLayout(false);
            lakContainer.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel12.ResumeLayout(false);
            cisticeContainer.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel18.ResumeLayout(false);
            panel19.ResumeLayout(false);
            panel20.ResumeLayout(false);
            panel21.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel materialConatainer;
        private Panel panel1;
        private Button btnMaterial;
        private Panel panel2;
        private Button btnAddMaterial;
        private Panel panel3;
        private Button btnEditMaterial;
        private Panel panel4;
        private Button btnDeleteMaterial;
        private FlowLayoutPanel projectContainer;
        private Panel panel5;
        private Button btnProjekt;
        private Panel panel6;
        private Button btnAddProjekt;
        private Panel panel7;
        private Button btnEditProjekt;
        private Panel panel8;
        private Button btnDeleteProjekt;
        private FlowLayoutPanel lakContainer;
        private Panel panel9;
        private Button btnLak;
        private Panel panel10;
        private Button btnAddLak;
        private Panel panel11;
        private Button btnEditLak;
        private Panel panel12;
        private Button btnDeleteLak;
        private FlowLayoutPanel granulatContainer;
        private Panel panel13;
        private Button btnGranulat;
        private Panel panel14;
        private Button btnAddGranulat;
        private Panel panel15;
        private Button btnEditGranulat;
        private Panel panel16;
        private Button btnDeleteGranulat;
        private FlowLayoutPanel cisticeContainer;
        private Panel panel17;
        private Button btnCisitic;
        private Panel panel18;
        private Button btnAddCistic;
        private Panel panel19;
        private Button btnEditCistic;
        private Panel panel20;
        private Button btnDeleteCisitic;
        private System.Windows.Forms.Timer materialTimer;
        private System.Windows.Forms.Timer projectTimer;
        private System.Windows.Forms.Timer granulatyTimer;
        private System.Windows.Forms.Timer lakTimer;
        private System.Windows.Forms.Timer cisticeTimer;
        private Panel panel21;
        private Button btnBack;
        private Panel mainContainer;
    }
}
