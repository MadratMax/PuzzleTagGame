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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintForm));
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.PicNumberTextBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.BrushSizeComboBox = new System.Windows.Forms.ComboBox();
            this.ColorButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ColorIndicator = new System.Windows.Forms.Button();
            this.BrushSizeLabel = new System.Windows.Forms.Label();
            this.UndoButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.White;
            this.PictureBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.PictureBox.Location = new System.Drawing.Point(44, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(511, 443);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.PictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintPanel_MouseMove);
            this.PictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp_1);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.Location = new System.Drawing.Point(496, 518);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(59, 64);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.FlatAppearance.BorderSize = 0;
            this.LeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeftButton.Location = new System.Drawing.Point(241, 462);
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
            this.RightButton.Location = new System.Drawing.Point(325, 462);
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
            this.PicNumberTextBox.Location = new System.Drawing.Point(278, 464);
            this.PicNumberTextBox.Name = "PicNumberTextBox";
            this.PicNumberTextBox.Size = new System.Drawing.Size(41, 22);
            this.PicNumberTextBox.TabIndex = 10;
            this.PicNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(570, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(21, 32);
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
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.BrushSizeComboBox.Location = new System.Drawing.Point(7, 31);
            this.BrushSizeComboBox.Name = "BrushSizeComboBox";
            this.BrushSizeComboBox.Size = new System.Drawing.Size(121, 24);
            this.BrushSizeComboBox.TabIndex = 12;
            this.BrushSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.BrushSizeComboBox_SelectedIndexChanged);
            // 
            // ColorButton
            // 
            this.ColorButton.FlatAppearance.BorderSize = 0;
            this.ColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorButton.Location = new System.Drawing.Point(7, 61);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(110, 34);
            this.ColorButton.TabIndex = 13;
            this.ColorButton.Text = "Цвет";
            this.ColorButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Location = new System.Drawing.Point(339, 66);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(99, 29);
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
            this.ColorIndicator.Location = new System.Drawing.Point(109, 558);
            this.ColorIndicator.Name = "ColorIndicator";
            this.ColorIndicator.Size = new System.Drawing.Size(24, 24);
            this.ColorIndicator.TabIndex = 16;
            this.ColorIndicator.UseVisualStyleBackColor = false;
            this.ColorIndicator.Click += new System.EventHandler(this.ColorIndicator_Click);
            // 
            // BrushSizeLabel
            // 
            this.BrushSizeLabel.AutoSize = true;
            this.BrushSizeLabel.Location = new System.Drawing.Point(4, 11);
            this.BrushSizeLabel.Name = "BrushSizeLabel";
            this.BrushSizeLabel.Size = new System.Drawing.Size(109, 17);
            this.BrushSizeLabel.TabIndex = 17;
            this.BrushSizeLabel.Text = "Толщина кисти";
            // 
            // UndoButton
            // 
            this.UndoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UndoButton.FlatAppearance.BorderSize = 0;
            this.UndoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UndoButton.Image = ((System.Drawing.Image)(resources.GetObject("UndoButton.Image")));
            this.UndoButton.Location = new System.Drawing.Point(260, 69);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(29, 26);
            this.UndoButton.TabIndex = 18;
            this.UndoButton.UseVisualStyleBackColor = true;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(210, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 26);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.button1);
            this.GroupBox.Controls.Add(this.ColorButton);
            this.GroupBox.Controls.Add(this.ClearButton);
            this.GroupBox.Controls.Add(this.BrushSizeComboBox);
            this.GroupBox.Controls.Add(this.UndoButton);
            this.GroupBox.Controls.Add(this.BrushSizeLabel);
            this.GroupBox.Location = new System.Drawing.Point(45, 491);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(444, 107);
            this.GroupBox.TabIndex = 20;
            this.GroupBox.TabStop = false;
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(595, 611);
            this.ControlBox = false;
            this.Controls.Add(this.ColorIndicator);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.PicNumberTextBox);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.GroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PaintForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.PaintForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
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
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ColorIndicator;
        private System.Windows.Forms.Label BrushSizeLabel;
        private System.Windows.Forms.Button UndoButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox GroupBox;
    }
}