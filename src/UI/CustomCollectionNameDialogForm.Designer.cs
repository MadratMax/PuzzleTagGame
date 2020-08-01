namespace PuzzleTag.UI
{
    partial class CustomCollectionNameDialogForm
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.SaveCollectionNameButton = new System.Windows.Forms.Button();
            this.NewCollectionLabel = new System.Windows.Forms.Label();
            this.NewCollectionTextBox = new System.Windows.Forms.TextBox();
            this.BackGroundButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(314, 8);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 32);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "x";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SaveCollectionNameButton
            // 
            this.SaveCollectionNameButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SaveCollectionNameButton.FlatAppearance.BorderSize = 0;
            this.SaveCollectionNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveCollectionNameButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCollectionNameButton.Location = new System.Drawing.Point(92, 96);
            this.SaveCollectionNameButton.Name = "SaveCollectionNameButton";
            this.SaveCollectionNameButton.Size = new System.Drawing.Size(166, 64);
            this.SaveCollectionNameButton.TabIndex = 9;
            this.SaveCollectionNameButton.Text = "Сохранить";
            this.SaveCollectionNameButton.UseVisualStyleBackColor = false;
            this.SaveCollectionNameButton.Click += new System.EventHandler(this.SaveCollectionNameButton_Click);
            // 
            // NewCollectionLabel
            // 
            this.NewCollectionLabel.AutoSize = true;
            this.NewCollectionLabel.Location = new System.Drawing.Point(78, 19);
            this.NewCollectionLabel.Name = "NewCollectionLabel";
            this.NewCollectionLabel.Size = new System.Drawing.Size(200, 17);
            this.NewCollectionLabel.TabIndex = 8;
            this.NewCollectionLabel.Text = "Введите название категории";
            // 
            // NewCollectionTextBox
            // 
            this.NewCollectionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewCollectionTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCollectionTextBox.Location = new System.Drawing.Point(78, 42);
            this.NewCollectionTextBox.Name = "NewCollectionTextBox";
            this.NewCollectionTextBox.Size = new System.Drawing.Size(200, 26);
            this.NewCollectionTextBox.TabIndex = 7;
            this.NewCollectionTextBox.TextChanged += new System.EventHandler(this.NewCollectionTextBox_TextChanged);
            this.NewCollectionTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomCollectionNameDialogForm_KeyDown);
            // 
            // BackGroundButton
            // 
            this.BackGroundButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackGroundButton.Enabled = false;
            this.BackGroundButton.FlatAppearance.BorderSize = 2;
            this.BackGroundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackGroundButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackGroundButton.Location = new System.Drawing.Point(8, 4);
            this.BackGroundButton.Name = "BackGroundButton";
            this.BackGroundButton.Size = new System.Drawing.Size(340, 190);
            this.BackGroundButton.TabIndex = 11;
            this.BackGroundButton.UseVisualStyleBackColor = false;
            this.BackGroundButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomCollectionNameDialogForm_KeyDown);
            // 
            // CustomCollectionNameDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(356, 198);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveCollectionNameButton);
            this.Controls.Add(this.NewCollectionLabel);
            this.Controls.Add(this.NewCollectionTextBox);
            this.Controls.Add(this.BackGroundButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomCollectionNameDialogForm";
            this.Text = "CustomCollectionNameDialogForm";
            this.Load += new System.EventHandler(this.CustomCollectionNameDialogForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomCollectionNameDialogForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SaveCollectionNameButton;
        private System.Windows.Forms.Label NewCollectionLabel;
        public System.Windows.Forms.TextBox NewCollectionTextBox;
        private System.Windows.Forms.Button BackGroundButton;
    }
}