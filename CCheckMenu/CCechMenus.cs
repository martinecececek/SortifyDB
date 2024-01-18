using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace SortifyDB.CCheckMenu
{
    public class CCechMenus : UserControl
    {
        public event EventHandler OptionCheckedChanged;
        public int vyber = 0;
        List<CheckBox> boxy = new List<CheckBox>();
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
            checkBoxProjects.Location = new Point(34, 12);
            checkBoxProjects.Margin = new Padding(0);
            checkBoxProjects.Name = "checkBoxProjects";
            checkBoxProjects.Size = new Size(89, 25);
            checkBoxProjects.TabIndex = 5;
            checkBoxProjects.Text = "Projekty";
            checkBoxProjects.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxProjects.UseVisualStyleBackColor = true;
            checkBoxProjects.CheckedChanged += checkBoxProjects_CheckedChanged;
            // 
            // checkBoxGran
            // 
            checkBoxGran.Anchor = AnchorStyles.Top;
            checkBoxGran.AutoSize = true;
            checkBoxGran.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            checkBoxGran.ForeColor = Color.White;
            checkBoxGran.Location = new Point(28, 12);
            checkBoxGran.Margin = new Padding(0);
            checkBoxGran.Name = "checkBoxGran";
            checkBoxGran.Size = new Size(98, 25);
            checkBoxGran.TabIndex = 9;
            checkBoxGran.Text = "Granuláty";
            checkBoxGran.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxGran.UseVisualStyleBackColor = true;
            checkBoxGran.CheckedChanged += checkBoxGran_CheckedChanged;
            // 
            // checkBoxVarnish
            // 
            checkBoxVarnish.Anchor = AnchorStyles.Top;
            checkBoxVarnish.AutoSize = true;
            checkBoxVarnish.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            checkBoxVarnish.ForeColor = Color.White;
            checkBoxVarnish.Location = new Point(25, 12);
            checkBoxVarnish.Margin = new Padding(0);
            checkBoxVarnish.Name = "checkBoxVarnish";
            checkBoxVarnish.Size = new Size(108, 25);
            checkBoxVarnish.TabIndex = 8;
            checkBoxVarnish.Text = "Kluzké laky";
            checkBoxVarnish.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxVarnish.UseVisualStyleBackColor = true;
            checkBoxVarnish.CheckedChanged += checkBoxVarnish_CheckedChanged;
            // 
            // checkBoxCleanActive
            // 
            checkBoxCleanActive.Anchor = AnchorStyles.Top;
            checkBoxCleanActive.AutoSize = true;
            checkBoxCleanActive.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 238);
            checkBoxCleanActive.ForeColor = Color.White;
            checkBoxCleanActive.Location = new Point(30, 3);
            checkBoxCleanActive.Margin = new Padding(4);
            checkBoxCleanActive.Name = "checkBoxCleanActive";
            checkBoxCleanActive.Size = new Size(100, 44);
            checkBoxCleanActive.TabIndex = 7;
            checkBoxCleanActive.Text = "Čističe\r\nAktivátory";
            checkBoxCleanActive.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxCleanActive.UseVisualStyleBackColor = true;
            checkBoxCleanActive.CheckedChanged += checkBoxCleanActive_CheckedChanged;
            // 
            // checkBoxMaterials
            // 
            checkBoxMaterials.Anchor = AnchorStyles.Top;
            checkBoxMaterials.AutoSize = true;
            checkBoxMaterials.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            checkBoxMaterials.ForeColor = Color.White;
            checkBoxMaterials.Location = new Point(29, 12);
            checkBoxMaterials.Margin = new Padding(0);
            checkBoxMaterials.Name = "checkBoxMaterials";
            checkBoxMaterials.Size = new Size(97, 25);
            checkBoxMaterials.TabIndex = 6;
            checkBoxMaterials.Text = "Materiály";
            checkBoxMaterials.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxMaterials.UseVisualStyleBackColor = true;
            checkBoxMaterials.CheckedChanged += checkBoxMaterials_CheckedChanged;
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
            labelCCMText.Location = new Point(12, 5);
            labelCCMText.Margin = new Padding(0);
            labelCCMText.Name = "labelCCMText";
            labelCCMText.Size = new Size(133, 32);
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
        private void BoxAddInList()
        {
            boxy.Add(checkBoxProjects);
            boxy.Add(checkBoxGran);
            boxy.Add(checkBoxVarnish);
            boxy.Add(checkBoxCleanActive);
            boxy.Add(checkBoxMaterials);


        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string parametr = string.Empty;
            foreach (CheckBox checkBox in boxy)
            {
                labelCCMText.Text = "pes2";
                if (checkBox.Checked && checkBox.Name != parametr)
                {
                    checkBox.Checked = false;
                }
            }



            var checkBoxIF = sender as CheckBox;

            if (checkBoxIF.Checked)
            {
                if (checkBoxIF == checkBoxProjects)
                {
                    vyber = 1;
                    
                }
                else if (checkBoxIF == checkBoxMaterials)
                {
                    vyber = 2;
                }
                else if (checkBoxIF == checkBoxCleanActive)
                {
                    vyber = 3;
                }
                else if (checkBoxIF == checkBoxVarnish)
                {
                    vyber = 4;
                }
                else if (checkBoxIF == checkBoxGran)
                {
                    vyber = 5;
                }
                else
                {
                    vyber = 0;
                }
            }


        }
        private void labelCCMText_Click(object sender, EventArgs e)
        {
            //Ignore this
        }

        private void checkBoxProjects_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox_CheckedChanged(sender, e);
        }

        private void checkBoxMaterials_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox_CheckedChanged(sender, e);
        }

        private void checkBoxCleanActive_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox_CheckedChanged(sender, e);
        }

        private void checkBoxVarnish_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox_CheckedChanged(sender, e);
        }

        private void checkBoxGran_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox_CheckedChanged(sender, e);
        }
    }
}
