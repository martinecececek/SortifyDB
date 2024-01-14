namespace SortifyDB.PDF_parser
{
    partial class ProcessingPDF
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
            progressBar1 = new ProgressBar();
            processLabel = new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.Lime;
            progressBar1.Location = new Point(19, 66);
            progressBar1.Margin = new Padding(10);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(358, 33);
            progressBar1.TabIndex = 0;
            // 
            // processLabel
            // 
            processLabel.AutoSize = true;
            processLabel.Font = new Font("Segoe UI", 15F);
            processLabel.Location = new Point(161, 28);
            processLabel.Name = "processLabel";
            processLabel.Size = new Size(65, 28);
            processLabel.TabIndex = 1;
            processLabel.Text = "label1";
            // 
            // ProcessingPDF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 118);
            Controls.Add(processLabel);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProcessingPDF";
            Text = "ProcessingPDF";
            Load += ProcessingPDF_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label processLabel;
    }
}