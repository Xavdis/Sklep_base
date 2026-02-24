namespace Sklep_base
{
    partial class Loading
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
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.ForeColor = Color.MediumSeaGreen;
            progressBar.Location = new Point(12, 12);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(436, 37);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 1;
            progressBar.UseWaitCursor = true;
            // 
            // Loading
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(460, 61);
            Controls.Add(progressBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Loading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loading";
            UseWaitCursor = true;
            ResumeLayout(false);
        }

        #endregion
        public ProgressBar progressBar;
        private ProgressBar progressBar1;
    }
}