﻿namespace SortifyDB
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
            mainUserControl1.Margin = new Padding(2, 5, 2, 5);
            mainUserControl1.Name = "mainUserControl1";
            mainUserControl1.Size = new Size(1920, 1015);
            mainUserControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1920, 1080);
            Controls.Add(mainUserControl1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(3, 7, 3, 7);
            Name = "MainForm";
            Text = "SortifyDB";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private MainUserControl mainUserControl1;
    }
}
