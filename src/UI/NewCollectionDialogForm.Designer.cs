namespace PuzzleTag.UI
{
    partial class NewCollectionDialogForm
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
            this.NewCollectionTextBox = new System.Windows.Forms.TextBox();
            this.NewCollectionLabel = new System.Windows.Forms.Label();
            this.GenerateCollectionButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewCollectionTextBox
            // 
            this.NewCollectionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewCollectionTextBox.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCollectionTextBox.Location = new System.Drawing.Point(75, 43);
            this.NewCollectionTextBox.Name = "NewCollectionTextBox";
            this.NewCollectionTextBox.Size = new System.Drawing.Size(200, 26);
            this.NewCollectionTextBox.TabIndex = 0;
            this.NewCollectionTextBox.TextChanged += new System.EventHandler(this.NewCollectionTextBox_TextChanged);
            // 
            // NewCollectionLabel
            // 
            this.NewCollectionLabel.AutoSize = true;
            this.NewCollectionLabel.Location = new System.Drawing.Point(75, 20);
            this.NewCollectionLabel.Name = "NewCollectionLabel";
            this.NewCollectionLabel.Size = new System.Drawing.Size(200, 17);
            this.NewCollectionLabel.TabIndex = 1;
            this.NewCollectionLabel.Text = "Введите название категории";
            // 
            // GenerateCollectionButton
            // 
            this.GenerateCollectionButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GenerateCollectionButton.FlatAppearance.BorderSize = 0;
            this.GenerateCollectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateCollectionButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateCollectionButton.Location = new System.Drawing.Point(90, 100);
            this.GenerateCollectionButton.Name = "GenerateCollectionButton";
            this.GenerateCollectionButton.Size = new System.Drawing.Size(166, 64);
            this.GenerateCollectionButton.TabIndex = 4;
            this.GenerateCollectionButton.Text = "Сгенерировать \r\nколлекцию";
            this.GenerateCollectionButton.UseVisualStyleBackColor = false;
            this.GenerateCollectionButton.Click += new System.EventHandler(this.GenerateCollectionButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(319, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 32);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "x";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // NewCollectionDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.ControlBox = false;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.GenerateCollectionButton);
            this.Controls.Add(this.NewCollectionLabel);
            this.Controls.Add(this.NewCollectionTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewCollectionDialogForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "NewCollectionDialogForm";
            this.Load += new System.EventHandler(this.NewCollectionDialogForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewCollectionDialogForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewCollectionTextBox;
        private System.Windows.Forms.Label NewCollectionLabel;
        private System.Windows.Forms.Button GenerateCollectionButton;
        private System.Windows.Forms.Button CloseButton;
    }
}