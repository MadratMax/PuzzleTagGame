namespace PuzzleTag.UI
{
    partial class WinnerForm
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
            this.CloseWinImageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseWinImageButton
            // 
            this.CloseWinImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseWinImageButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseWinImageButton.Location = new System.Drawing.Point(1013, 12);
            this.CloseWinImageButton.Name = "CloseWinImageButton";
            this.CloseWinImageButton.Size = new System.Drawing.Size(30, 23);
            this.CloseWinImageButton.TabIndex = 0;
            this.CloseWinImageButton.Text = "x";
            this.CloseWinImageButton.UseVisualStyleBackColor = false;
            this.CloseWinImageButton.Click += new System.EventHandler(this.CloseWinImageButton_Click);
            this.CloseWinImageButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CloseWinImageButton_KeyDown);
            // 
            // WinnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1055, 659);
            this.ControlBox = false;
            this.Controls.Add(this.CloseWinImageButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinnerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "WinnerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WinnerForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WinnerForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseWinImageButton;
    }
}