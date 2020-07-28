namespace PuzzleTag
{
    partial class SettingsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.NewGameButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ShowCardsButton = new System.Windows.Forms.Button();
            this.HideCardsButton = new System.Windows.Forms.Button();
            this.ShuffleCards = new System.Windows.Forms.Button();
            this.BackToMainButton = new System.Windows.Forms.Button();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.FirstPlayerLabel = new System.Windows.Forms.Label();
            this.SecondPlayerLable = new System.Windows.Forms.Label();
            this.ThirdPlayerLabel = new System.Windows.Forms.Label();
            this.Player1ComboBox = new System.Windows.Forms.ComboBox();
            this.Player2ComboBox = new System.Windows.Forms.ComboBox();
            this.Player3ComboBox = new System.Windows.Forms.ComboBox();
            this.RemovePlayer1Button = new System.Windows.Forms.Button();
            this.RemovePlayer3Button = new System.Windows.Forms.Button();
            this.RemovePlayer2Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // NewGameButton
            // 
            this.NewGameButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NewGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NewGameButton.FlatAppearance.BorderSize = 0;
            this.NewGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewGameButton.Image = ((System.Drawing.Image)(resources.GetObject("NewGameButton.Image")));
            this.NewGameButton.Location = new System.Drawing.Point(98, 274);
            this.NewGameButton.Margin = new System.Windows.Forms.Padding(0);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(99, 78);
            this.NewGameButton.TabIndex = 0;
            this.toolTip1.SetToolTip(this.NewGameButton, "Start game");
            this.NewGameButton.UseVisualStyleBackColor = false;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(611, 226);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(177, 35);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ShowCardsButton
            // 
            this.ShowCardsButton.FlatAppearance.BorderSize = 0;
            this.ShowCardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowCardsButton.Location = new System.Drawing.Point(611, 108);
            this.ShowCardsButton.Name = "ShowCardsButton";
            this.ShowCardsButton.Size = new System.Drawing.Size(177, 35);
            this.ShowCardsButton.TabIndex = 3;
            this.ShowCardsButton.Text = "Show cards";
            this.ShowCardsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowCardsButton.UseVisualStyleBackColor = true;
            this.ShowCardsButton.Click += new System.EventHandler(this.ShowCardsButton_Click);
            // 
            // HideCardsButton
            // 
            this.HideCardsButton.FlatAppearance.BorderSize = 0;
            this.HideCardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideCardsButton.Location = new System.Drawing.Point(611, 148);
            this.HideCardsButton.Name = "HideCardsButton";
            this.HideCardsButton.Size = new System.Drawing.Size(177, 35);
            this.HideCardsButton.TabIndex = 4;
            this.HideCardsButton.Text = "Hide cards";
            this.HideCardsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HideCardsButton.UseVisualStyleBackColor = true;
            this.HideCardsButton.Click += new System.EventHandler(this.HideCardsButton_Click);
            // 
            // ShuffleCards
            // 
            this.ShuffleCards.FlatAppearance.BorderSize = 0;
            this.ShuffleCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShuffleCards.Location = new System.Drawing.Point(611, 188);
            this.ShuffleCards.Name = "ShuffleCards";
            this.ShuffleCards.Size = new System.Drawing.Size(177, 35);
            this.ShuffleCards.TabIndex = 5;
            this.ShuffleCards.Text = "Shuffle cards";
            this.ShuffleCards.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShuffleCards.UseVisualStyleBackColor = true;
            this.ShuffleCards.Click += new System.EventHandler(this.ShuffleCards_Click);
            // 
            // BackToMainButton
            // 
            this.BackToMainButton.FlatAppearance.BorderSize = 0;
            this.BackToMainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToMainButton.Image = ((System.Drawing.Image)(resources.GetObject("BackToMainButton.Image")));
            this.BackToMainButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackToMainButton.Location = new System.Drawing.Point(611, 403);
            this.BackToMainButton.Name = "BackToMainButton";
            this.BackToMainButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BackToMainButton.Size = new System.Drawing.Size(136, 35);
            this.BackToMainButton.TabIndex = 6;
            this.BackToMainButton.Text = "back to main";
            this.BackToMainButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackToMainButton.UseVisualStyleBackColor = true;
            this.BackToMainButton.Click += new System.EventHandler(this.BackToMainButton_Click);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(98, 61);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(177, 24);
            this.CategoryComboBox.TabIndex = 41;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // FirstPlayerLabel
            // 
            this.FirstPlayerLabel.AutoSize = true;
            this.FirstPlayerLabel.Location = new System.Drawing.Point(24, 117);
            this.FirstPlayerLabel.Name = "FirstPlayerLabel";
            this.FirstPlayerLabel.Size = new System.Drawing.Size(59, 17);
            this.FirstPlayerLabel.TabIndex = 42;
            this.FirstPlayerLabel.Text = "1 player";
            // 
            // SecondPlayerLable
            // 
            this.SecondPlayerLable.AutoSize = true;
            this.SecondPlayerLable.Location = new System.Drawing.Point(24, 162);
            this.SecondPlayerLable.Name = "SecondPlayerLable";
            this.SecondPlayerLable.Size = new System.Drawing.Size(59, 17);
            this.SecondPlayerLable.TabIndex = 43;
            this.SecondPlayerLable.Text = "2 player";
            // 
            // ThirdPlayerLabel
            // 
            this.ThirdPlayerLabel.AutoSize = true;
            this.ThirdPlayerLabel.Location = new System.Drawing.Point(24, 206);
            this.ThirdPlayerLabel.Name = "ThirdPlayerLabel";
            this.ThirdPlayerLabel.Size = new System.Drawing.Size(59, 17);
            this.ThirdPlayerLabel.TabIndex = 44;
            this.ThirdPlayerLabel.Text = "3 player";
            // 
            // Player1ComboBox
            // 
            this.Player1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Player1ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player1ComboBox.FormattingEnabled = true;
            this.Player1ComboBox.Location = new System.Drawing.Point(98, 114);
            this.Player1ComboBox.Name = "Player1ComboBox";
            this.Player1ComboBox.Size = new System.Drawing.Size(121, 24);
            this.Player1ComboBox.TabIndex = 45;
            // 
            // Player2ComboBox
            // 
            this.Player2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Player2ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player2ComboBox.FormattingEnabled = true;
            this.Player2ComboBox.Location = new System.Drawing.Point(98, 159);
            this.Player2ComboBox.Name = "Player2ComboBox";
            this.Player2ComboBox.Size = new System.Drawing.Size(121, 24);
            this.Player2ComboBox.TabIndex = 46;
            // 
            // Player3ComboBox
            // 
            this.Player3ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Player3ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player3ComboBox.FormattingEnabled = true;
            this.Player3ComboBox.Location = new System.Drawing.Point(98, 203);
            this.Player3ComboBox.Name = "Player3ComboBox";
            this.Player3ComboBox.Size = new System.Drawing.Size(121, 24);
            this.Player3ComboBox.TabIndex = 47;
            // 
            // RemovePlayer1Button
            // 
            this.RemovePlayer1Button.FlatAppearance.BorderSize = 0;
            this.RemovePlayer1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemovePlayer1Button.Location = new System.Drawing.Point(217, 113);
            this.RemovePlayer1Button.Name = "RemovePlayer1Button";
            this.RemovePlayer1Button.Size = new System.Drawing.Size(32, 24);
            this.RemovePlayer1Button.TabIndex = 48;
            this.RemovePlayer1Button.Text = "x";
            this.RemovePlayer1Button.UseVisualStyleBackColor = true;
            this.RemovePlayer1Button.Click += new System.EventHandler(this.RemovePlayer1Button_Click);
            // 
            // RemovePlayer3Button
            // 
            this.RemovePlayer3Button.FlatAppearance.BorderSize = 0;
            this.RemovePlayer3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemovePlayer3Button.Location = new System.Drawing.Point(216, 202);
            this.RemovePlayer3Button.Name = "RemovePlayer3Button";
            this.RemovePlayer3Button.Size = new System.Drawing.Size(32, 24);
            this.RemovePlayer3Button.TabIndex = 49;
            this.RemovePlayer3Button.Text = "x";
            this.RemovePlayer3Button.UseVisualStyleBackColor = true;
            this.RemovePlayer3Button.Click += new System.EventHandler(this.RemovePlayer3Button_Click);
            // 
            // RemovePlayer2Button
            // 
            this.RemovePlayer2Button.FlatAppearance.BorderSize = 0;
            this.RemovePlayer2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemovePlayer2Button.Location = new System.Drawing.Point(217, 158);
            this.RemovePlayer2Button.Name = "RemovePlayer2Button";
            this.RemovePlayer2Button.Size = new System.Drawing.Size(32, 24);
            this.RemovePlayer2Button.TabIndex = 50;
            this.RemovePlayer2Button.Text = "x";
            this.RemovePlayer2Button.UseVisualStyleBackColor = true;
            this.RemovePlayer2Button.Click += new System.EventHandler(this.RemovePlayer2Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "Category";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Start game";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemovePlayer2Button);
            this.Controls.Add(this.RemovePlayer3Button);
            this.Controls.Add(this.RemovePlayer1Button);
            this.Controls.Add(this.Player3ComboBox);
            this.Controls.Add(this.Player2ComboBox);
            this.Controls.Add(this.Player1ComboBox);
            this.Controls.Add(this.ThirdPlayerLabel);
            this.Controls.Add(this.SecondPlayerLable);
            this.Controls.Add(this.FirstPlayerLabel);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.BackToMainButton);
            this.Controls.Add(this.ShuffleCards);
            this.Controls.Add(this.HideCardsButton);
            this.Controls.Add(this.ShowCardsButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.NewGameButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SettingsForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ShowCardsButton;
        private System.Windows.Forms.Button HideCardsButton;
        private System.Windows.Forms.Button ShuffleCards;
        private System.Windows.Forms.Button BackToMainButton;
        public System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label FirstPlayerLabel;
        private System.Windows.Forms.Label SecondPlayerLable;
        private System.Windows.Forms.Label ThirdPlayerLabel;
        private System.Windows.Forms.ComboBox Player1ComboBox;
        private System.Windows.Forms.ComboBox Player2ComboBox;
        private System.Windows.Forms.ComboBox Player3ComboBox;
        private System.Windows.Forms.Button RemovePlayer1Button;
        private System.Windows.Forms.Button RemovePlayer3Button;
        private System.Windows.Forms.Button RemovePlayer2Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}