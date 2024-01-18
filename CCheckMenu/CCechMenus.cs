using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortifyDB.CCheckMenu
{
    public class CCechMenus : UserControl
    {
        public event EventHandler OptionCheckedChanged;

        public CCechMenus()
        {
            InitializeComponent();
        }


        private void InitializeComponent()
        {
            panelColorCCM1 = new Panel();
            checkBoxProjects = new CheckBox();
            checkBoxGran = new CheckBox();
            checkBoxVarnish = new CheckBox();
            checkBoxCleanActive = new CheckBox();
            checkBoxMaterials = new CheckBox();
            panelColorCCM2 = new Panel();
            panelColorCCM3 = new Panel();
            panelColorCCM4 = new Panel();
            panelColorCCM5 = new Panel();
            labelCCMText = new Label();
            panelColorCCMText = new Panel();
            panelColorCCM1.SuspendLayout();
            panelColorCCM2.SuspendLayout();
            panelColorCCM3.SuspendLayout();
            panelColorCCM4.SuspendLayout();
            panelColorCCM5.SuspendLayout();
            panelColorCCMText.SuspendLayout();
            SuspendLayout();
            // 
            // panelColorCCM1
            // 
            panelColorCCM1.BackColor = Color.FromArgb(101, 196, 206);
            panelColorCCM1.Controls.Add(checkBoxProjects);
            panelColorCCM1.Location = new Point(164, 0);
            panelColorCCM1.Margin = new Padding(0);
            panelColorCCM1.Name = "panelColorCCM1";
            panelColorCCM1.Size = new Size(160, 50);
            panelColorCCM1.TabIndex = 0;
            // 
            // checkBoxProjects
            // 
            checkBoxProjects.Anchor = AnchorStyles.Top;
            checkBoxProjects.AutoSize = true;
            checkBoxProjects.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            checkBoxProjects.ForeColor = Color.White;
            checkBoxProjects.Location = new Point(23, 10);
            checkBoxProjects.Margin = new Padding(0);
            checkBoxProjects.Name = "checkBoxProjects";
            checkBoxProjects.Size = new Size(109, 32);
            checkBoxProjects.TabIndex = 5;
            checkBoxProjects.Text = "Projekty";
            checkBoxProjects.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxProjects.UseVisualStyleBackColor = true;
            // 
            // checkBoxGran
            // 
            checkBoxGran.Anchor = AnchorStyles.Top;
            checkBoxGran.AutoSize = true;
            checkBoxGran.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            checkBoxGran.ForeColor = Color.White;
            checkBoxGran.Location = new Point(18, 10);
            checkBoxGran.Margin = new Padding(0);
            checkBoxGran.Name = "checkBoxGran";
            checkBoxGran.Size = new Size(121, 32);
            checkBoxGran.TabIndex = 9;
            checkBoxGran.Text = "Granuláty";
            checkBoxGran.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxGran.UseVisualStyleBackColor = true;
            // 
            // checkBoxVarnish
            // 
            checkBoxVarnish.Anchor = AnchorStyles.Top;
            checkBoxVarnish.AutoSize = true;
            checkBoxVarnish.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            checkBoxVarnish.ForeColor = Color.White;
            checkBoxVarnish.Location = new Point(13, 10);
            checkBoxVarnish.Margin = new Padding(0);
            checkBoxVarnish.Name = "checkBoxVarnish";
            checkBoxVarnish.Size = new Size(136, 32);
            checkBoxVarnish.TabIndex = 8;
            checkBoxVarnish.Text = "Kluzké laky";
            checkBoxVarnish.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxVarnish.UseVisualStyleBackColor = true;
            // 
            // checkBoxCleanActive
            // 
            checkBoxCleanActive.Anchor = AnchorStyles.Top;
            checkBoxCleanActive.AutoSize = true;
            checkBoxCleanActive.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 238);
            checkBoxCleanActive.ForeColor = Color.White;
            checkBoxCleanActive.Location = new Point(19, 0);
            checkBoxCleanActive.Margin = new Padding(4);
            checkBoxCleanActive.Name = "checkBoxCleanActive";
            checkBoxCleanActive.Size = new Size(125, 54);
            checkBoxCleanActive.TabIndex = 7;
            checkBoxCleanActive.Text = "Čističe\r\nAktivátory";
            checkBoxCleanActive.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxCleanActive.UseVisualStyleBackColor = true;
            // 
            // checkBoxMaterials
            // 
            checkBoxMaterials.Anchor = AnchorStyles.Top;
            checkBoxMaterials.AutoSize = true;
            checkBoxMaterials.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            checkBoxMaterials.ForeColor = Color.White;
            checkBoxMaterials.Location = new Point(20, 10);
            checkBoxMaterials.Margin = new Padding(0);
            checkBoxMaterials.Name = "checkBoxMaterials";
            checkBoxMaterials.Size = new Size(117, 32);
            checkBoxMaterials.TabIndex = 6;
            checkBoxMaterials.Text = "Materiály";
            checkBoxMaterials.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxMaterials.UseVisualStyleBackColor = true;
            // 
            // panelColorCCM2
            // 
            panelColorCCM2.BackColor = Color.FromArgb(149, 189, 193);
            panelColorCCM2.Controls.Add(checkBoxMaterials);
            panelColorCCM2.Location = new Point(324, 0);
            panelColorCCM2.Margin = new Padding(0);
            panelColorCCM2.Name = "panelColorCCM2";
            panelColorCCM2.Size = new Size(160, 50);
            panelColorCCM2.TabIndex = 1;
            // 
            // panelColorCCM3
            // 
            panelColorCCM3.BackColor = Color.FromArgb(101, 196, 206);
            panelColorCCM3.Controls.Add(checkBoxCleanActive);
            panelColorCCM3.Location = new Point(484, 0);
            panelColorCCM3.Margin = new Padding(0);
            panelColorCCM3.Name = "panelColorCCM3";
            panelColorCCM3.Size = new Size(160, 50);
            panelColorCCM3.TabIndex = 1;
            // 
            // panelColorCCM4
            // 
            panelColorCCM4.BackColor = Color.FromArgb(149, 189, 193);
            panelColorCCM4.Controls.Add(checkBoxVarnish);
            panelColorCCM4.Location = new Point(644, 0);
            panelColorCCM4.Margin = new Padding(0);
            panelColorCCM4.Name = "panelColorCCM4";
            panelColorCCM4.Size = new Size(160, 50);
            panelColorCCM4.TabIndex = 1;
            // 
            // panelColorCCM5
            // 
            panelColorCCM5.BackColor = Color.FromArgb(101, 196, 206);
            panelColorCCM5.Controls.Add(checkBoxGran);
            panelColorCCM5.Location = new Point(804, 0);
            panelColorCCM5.Margin = new Padding(0);
            panelColorCCM5.Name = "panelColorCCM5";
            panelColorCCM5.Size = new Size(160, 50);
            panelColorCCM5.TabIndex = 1;
            // 
            // labelCCMText
            // 
            labelCCMText.AutoSize = true;
            labelCCMText.BackColor = Color.Transparent;
            labelCCMText.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelCCMText.ForeColor = Color.White;
            labelCCMText.Location = new Point(0, 4);
            labelCCMText.Margin = new Padding(0);
            labelCCMText.Name = "labelCCMText";
            labelCCMText.Size = new Size(164, 41);
            labelCCMText.TabIndex = 2;
            labelCCMText.Text = "Hledat dle:";
            labelCCMText.TextAlign = ContentAlignment.MiddleCenter;
            labelCCMText.Click += labelCCMText_Click;
            // 
            // panelColorCCMText
            // 
            panelColorCCMText.BackColor = Color.FromArgb(142, 220, 229);
            panelColorCCMText.Controls.Add(labelCCMText);
            panelColorCCMText.Location = new Point(0, 0);
            panelColorCCMText.Margin = new Padding(0);
            panelColorCCMText.Name = "panelColorCCMText";
            panelColorCCMText.Size = new Size(167, 50);
            panelColorCCMText.TabIndex = 6;
            // 
            // CCechMenus
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(142, 220, 229);
            Controls.Add(panelColorCCM5);
            Controls.Add(panelColorCCM4);
            Controls.Add(panelColorCCM3);
            Controls.Add(panelColorCCM2);
            Controls.Add(panelColorCCM1);
            Controls.Add(panelColorCCMText);
            Name = "CCechMenus";
            Size = new Size(964, 50);
            panelColorCCM1.ResumeLayout(false);
            panelColorCCM1.PerformLayout();
            panelColorCCM2.ResumeLayout(false);
            panelColorCCM2.PerformLayout();
            panelColorCCM3.ResumeLayout(false);
            panelColorCCM3.PerformLayout();
            panelColorCCM4.ResumeLayout(false);
            panelColorCCM4.PerformLayout();
            panelColorCCM5.ResumeLayout(false);
            panelColorCCM5.PerformLayout();
            panelColorCCMText.ResumeLayout(false);
            panelColorCCMText.PerformLayout();
            ResumeLayout(false);
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            OptionCheckedChanged?.Invoke(this, EventArgs.Empty);
        }

        private Panel panelColorCCM1;
        private CheckBox checkBoxProjects;
        private CheckBox checkBoxGran;
        private CheckBox checkBoxVarnish;
        private CheckBox checkBoxCleanActive;
        private CheckBox checkBoxMaterials;
        private Panel panelColorCCM2;
        private Panel panelColorCCM3;
        private Panel panelColorCCM4;
        private Label labelCCMText;
        private Panel panelColorCCMText;
        private Panel panelColorCCM5;

        private void labelCCMText_Click(object sender, EventArgs e)
        {

        }
    }
}
