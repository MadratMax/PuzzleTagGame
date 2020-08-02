namespace PuzzleTag.UI
{
    partial class PaintForm
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
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.PicNumberTextBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.BrushSizeComboBox = new System.Windows.Forms.ComboBox();
            this.ColorButton = new System.Windows.Forms.Button();
            this.ToolComboBox = new System.Windows.Forms.ComboBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ColorIndicator = new System.Windows.Forms.Button();
            this.BrushSizeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.White;
            this.PictureBox.Location = new System.Drawing.Point(14, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(511, 443);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.PictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintPanel_MouseMove);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(416, 462);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(105, 53);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Сохранить и выйти";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.FlatAppearance.BorderSize = 0;
            this.LeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftButton.Location = new System.Drawing.Point(212, 461);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(33, 23);
            this.LeftButton.TabIndex = 8;
            this.LeftButton.Text = "<";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // RightButton
            // 
            this.RightButton.FlatAppearance.BorderSize = 0;
            this.RightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RightButton.Location = new System.Drawing.Point(298, 461);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(33, 23);
            this.RightButton.TabIndex = 9;
            this.RightButton.Text = ">";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // PicNumberTextBox
            // 
            this.PicNumberTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PicNumberTextBox.Enabled = false;
            this.PicNumberTextBox.Location = new System.Drawing.Point(250, 463);
            this.PicNumberTextBox.Name = "PicNumberTextBox";
            this.PicNumberTextBox.Size = new System.Drawing.Size(41, 22);
            this.PicNumberTextBox.TabIndex = 10;
            this.PicNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(550, 1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 32);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.Text = "x";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // BrushSizeComboBox
            // 
            this.BrushSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BrushSizeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrushSizeComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.BrushSizeComboBox.Location = new System.Drawing.Point(14, 491);
            this.BrushSizeComboBox.Name = "BrushSizeComboBox";
            this.BrushSizeComboBox.Size = new System.Drawing.Size(121, 24);
            this.BrushSizeComboBox.TabIndex = 12;
            this.BrushSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.BrushSizeComboBox_SelectedIndexChanged);
            // 
            // ColorButton
            // 
            this.ColorButton.FlatAppearance.BorderSize = 0;
            this.ColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorButton.Location = new System.Drawing.Point(139, 529);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(110, 34);
            this.ColorButton.TabIndex = 13;
            this.ColorButton.Text = "Цвет";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // ToolComboBox
            // 
            this.ToolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToolComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToolComboBox.Items.AddRange(new object[] {
            "Brush",
            "Pen",
            "Lastic"});
            this.ToolComboBox.Location = new System.Drawing.Point(14, 536);
            this.ToolComboBox.Name = "ToolComboBox";
            this.ToolComboBox.Size = new System.Drawing.Size(121, 24);
            this.ToolComboBox.TabIndex = 14;
            this.ToolComboBox.SelectedIndexChanged += new System.EventHandler(this.ToolComboBox_SelectedIndexChanged);
            // 
            // ClearButton
            // 
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Location = new System.Drawing.Point(416, 530);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(99, 34);
            this.ClearButton.TabIndex = 15;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ColorIndicator
            // 
            this.ColorIndicator.BackColor = System.Drawing.Color.Black;
            this.ColorIndicator.FlatAppearance.BorderSize = 0;
            this.ColorIndicator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorIndicator.Location = new System.Drawing.Point(212, 535);
            this.ColorIndicator.Name = "ColorIndicator";
            this.ColorIndicator.Size = new System.Drawing.Size(37, 24);
            this.ColorIndicator.TabIndex = 16;
            this.ColorIndicator.UseVisualStyleBackColor = false;
            this.ColorIndicator.Click += new System.EventHandler(this.ColorIndicator_Click);
            // 
            // BrushSizeLabel
            // 
            this.BrushSizeLabel.AutoSize = true;
            this.BrushSizeLabel.Location = new System.Drawing.Point(13, 471);
            this.BrushSizeLabel.Name = "BrushSizeLabel";
            this.BrushSizeLabel.Size = new System.Drawing.Size(109, 17);
            this.BrushSizeLabel.TabIndex = 17;
            this.BrushSizeLabel.Text = "Толщина кисти";
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(573, 571);
            this.ControlBox = false;
            this.Controls.Add(this.BrushSizeLabel);
            this.Controls.Add(this.ColorIndicator);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ToolComboBox);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.BrushSizeComboBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.PicNumberTextBox);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PaintForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.PaintForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.TextBox PicNumberTextBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ComboBox BrushSizeComboBox;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.ComboBox ToolComboBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ColorIndicator;
        private System.Windows.Forms.Label BrushSizeLabel;
    }
}