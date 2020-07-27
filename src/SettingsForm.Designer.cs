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
            this.SuspendLayout();
            // 
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(301, 102);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(177, 53);
            this.NewGameButton.TabIndex = 0;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(301, 220);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(177, 53);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ShowCardsButton
            // 
            this.ShowCardsButton.Location = new System.Drawing.Point(518, 102);
            this.ShowCardsButton.Name = "ShowCardsButton";
            this.ShowCardsButton.Size = new System.Drawing.Size(177, 53);
            this.ShowCardsButton.TabIndex = 3;
            this.ShowCardsButton.Text = "Show cards";
            this.ShowCardsButton.UseVisualStyleBackColor = true;
            this.ShowCardsButton.Click += new System.EventHandler(this.ShowCardsButton_Click);
            // 
            // HideCardsButton
            // 
            this.HideCardsButton.Location = new System.Drawing.Point(518, 161);
            this.HideCardsButton.Name = "HideCardsButton";
            this.HideCardsButton.Size = new System.Drawing.Size(177, 53);
            this.HideCardsButton.TabIndex = 4;
            this.HideCardsButton.Text = "Hide cards";
            this.HideCardsButton.UseVisualStyleBackColor = true;
            this.HideCardsButton.Click += new System.EventHandler(this.HideCardsButton_Click);
            // 
            // ShuffleCards
            // 
            this.ShuffleCards.Location = new System.Drawing.Point(518, 220);
            this.ShuffleCards.Name = "ShuffleCards";
            this.ShuffleCards.Size = new System.Drawing.Size(177, 53);
            this.ShuffleCards.TabIndex = 5;
            this.ShuffleCards.Text = "Shuffle cards";
            this.ShuffleCards.UseVisualStyleBackColor = true;
            this.ShuffleCards.Click += new System.EventHandler(this.ShuffleCards_Click);
            // 
            // BackToMainButton
            // 
            this.BackToMainButton.Location = new System.Drawing.Point(582, 406);
            this.BackToMainButton.Name = "BackToMainButton";
            this.BackToMainButton.Size = new System.Drawing.Size(113, 23);
            this.BackToMainButton.TabIndex = 6;
            this.BackToMainButton.Text = "back to main";
            this.BackToMainButton.UseVisualStyleBackColor = true;
            this.BackToMainButton.Click += new System.EventHandler(this.BackToMainButton_Click);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(301, 54);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(177, 24);
            this.CategoryComboBox.TabIndex = 41;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // FirstPlayerLabel
            // 
            this.FirstPlayerLabel.AutoSize = true;
            this.FirstPlayerLabel.Location = new System.Drawing.Point(21, 135);
            this.FirstPlayerLabel.Name = "FirstPlayerLabel";
            this.FirstPlayerLabel.Size = new System.Drawing.Size(59, 17);
            this.FirstPlayerLabel.TabIndex = 42;
            this.FirstPlayerLabel.Text = "1 player";
            // 
            // SecondPlayerLable
            // 
            this.SecondPlayerLable.AutoSize = true;
            this.SecondPlayerLable.Location = new System.Drawing.Point(21, 180);
            this.SecondPlayerLable.Name = "SecondPlayerLable";
            this.SecondPlayerLable.Size = new System.Drawing.Size(59, 17);
            this.SecondPlayerLable.TabIndex = 43;
            this.SecondPlayerLable.Text = "2 player";
            // 
            // ThirdPlayerLabel
            // 
            this.ThirdPlayerLabel.AutoSize = true;
            this.ThirdPlayerLabel.Location = new System.Drawing.Point(21, 224);
            this.ThirdPlayerLabel.Name = "ThirdPlayerLabel";
            this.ThirdPlayerLabel.Size = new System.Drawing.Size(59, 17);
            this.ThirdPlayerLabel.TabIndex = 44;
            this.ThirdPlayerLabel.Text = "3 player";
            // 
            // Player1ComboBox
            // 
            this.Player1ComboBox.FormattingEnabled = true;
            this.Player1ComboBox.Location = new System.Drawing.Point(89, 131);
            this.Player1ComboBox.Name = "Player1ComboBox";
            this.Player1ComboBox.Size = new System.Drawing.Size(121, 24);
            this.Player1ComboBox.TabIndex = 45;
            // 
            // Player2ComboBox
            // 
            this.Player2ComboBox.FormattingEnabled = true;
            this.Player2ComboBox.Location = new System.Drawing.Point(89, 176);
            this.Player2ComboBox.Name = "Player2ComboBox";
            this.Player2ComboBox.Size = new System.Drawing.Size(121, 24);
            this.Player2ComboBox.TabIndex = 46;
            // 
            // Player3ComboBox
            // 
            this.Player3ComboBox.FormattingEnabled = true;
            this.Player3ComboBox.Location = new System.Drawing.Point(89, 220);
            this.Player3ComboBox.Name = "Player3ComboBox";
            this.Player3ComboBox.Size = new System.Drawing.Size(121, 24);
            this.Player3ComboBox.TabIndex = 47;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
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
    }
}