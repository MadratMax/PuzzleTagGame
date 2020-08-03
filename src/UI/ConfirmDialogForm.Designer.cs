namespace PuzzleTag
{
    partial class ConfirmDialogForm
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
            this.ConfirmTextLabel = new System.Windows.Forms.Label();
            this.BackGroundButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.YesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConfirmTextLabel
            // 
            this.ConfirmTextLabel.AutoSize = true;
            this.ConfirmTextLabel.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmTextLabel.Location = new System.Drawing.Point(117, 24);
            this.ConfirmTextLabel.Name = "ConfirmTextLabel";
            this.ConfirmTextLabel.Size = new System.Drawing.Size(77, 24);
            this.ConfirmTextLabel.TabIndex = 0;
            this.ConfirmTextLabel.Text = "message";
            // 
            // BackGroundButton
            // 
            this.BackGroundButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackGroundButton.Enabled = false;
            this.BackGroundButton.FlatAppearance.BorderSize = 2;
            this.BackGroundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackGroundButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackGroundButton.Location = new System.Drawing.Point(12, 10);
            this.BackGroundButton.Name = "BackGroundButton";
            this.BackGroundButton.Size = new System.Drawing.Size(501, 190);
            this.BackGroundButton.TabIndex = 7;
            this.BackGroundButton.UseVisualStyleBackColor = false;
            this.BackGroundButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BackGroundButton_KeyDown);
            // 
            // NoButton
            // 
            this.NoButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NoButton.FlatAppearance.BorderSize = 0;
            this.NoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoButton.Location = new System.Drawing.Point(316, 82);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(166, 64);
            this.NoButton.TabIndex = 8;
            this.NoButton.Text = "Нет";
            this.NoButton.UseVisualStyleBackColor = false;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // YesButton
            // 
            this.YesButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.YesButton.FlatAppearance.BorderSize = 0;
            this.YesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YesButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesButton.Location = new System.Drawing.Point(47, 82);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(166, 64);
            this.YesButton.TabIndex = 9;
            this.YesButton.Text = "Да";
            this.YesButton.UseVisualStyleBackColor = false;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // ConfirmDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(525, 211);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.ConfirmTextLabel);
            this.Controls.Add(this.BackGroundButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmDialogForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ConfirmDialogForm";
            this.Load += new System.EventHandler(this.ConfirmDialogForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConfirmDialogForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label ConfirmTextLabel;
        private System.Windows.Forms.Button BackGroundButton;
        public System.Windows.Forms.Button NoButton;
        public System.Windows.Forms.Button YesButton;
    }
}