namespace SortifyDB
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainUserControl1 = new MainUserControl();
            SuspendLayout();
            // 
            // mainUserControl1
            // 
            mainUserControl1.BackColor = Color.Lavender;
            mainUserControl1.Dock = DockStyle.Bottom;
            mainUserControl1.Location = new Point(0, 65);
            mainUserControl1.Name = "mainUserControl1";
            mainUserControl1.Size = new Size(1920, 1015);
            mainUserControl1.TabIndex = 0;

            mainUserControl2 = new MainUserControl();
            SuspendLayout();
            // 
            // mainUserControl2
            // 
            mainUserControl2.BackColor = Color.Lavender;
            mainUserControl2.Location = new Point(-2, 65);
            mainUserControl2.Margin = new Padding(3, 4, 3, 4);
            mainUserControl2.Name = "mainUserControl2";
            mainUserControl2.Size = new Size(1920, 1015);
            mainUserControl2.TabIndex = 0;
            SuspendLayout();
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1080);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            Controls.Add(mainUserControl1);
            Controls.Add(mainUserControl2);
            ResumeLayout(false);
        }

        #endregion

        private MainUserControl mainUserControl1;
        private MainUserControl mainUserControl2;
    }
}
