﻿namespace PuzzleTag
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
            this.AddCollectionButton = new System.Windows.Forms.Button();
            this.SaveCollectionButton = new System.Windows.Forms.Button();
            this.CustomPaintButton = new System.Windows.Forms.Button();
            this.StartGameLabel = new System.Windows.Forms.Label();
            this.RemoveCollectionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewGameButton
            // 
            this.NewGameButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NewGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NewGameButton.FlatAppearance.BorderSize = 0;
            this.NewGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewGameButton.Image = ((System.Drawing.Image)(resources.GetObject("NewGameButton.Image")));
            this.NewGameButton.Location = new System.Drawing.Point(138, 290);
            this.NewGameButton.Margin = new System.Windows.Forms.Padding(0);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(108, 90);
            this.NewGameButton.TabIndex = 0;
            this.toolTip1.SetToolTip(this.NewGameButton, "Начать игру");
            this.NewGameButton.UseVisualStyleBackColor = false;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            this.NewGameButton.MouseEnter += new System.EventHandler(this.ShowCardsButton_MouseEnter);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(612, 299);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(177, 35);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Выход";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ShowCardsButton_MouseEnter);
            // 
            // ShowCardsButton
            // 
            this.ShowCardsButton.FlatAppearance.BorderSize = 0;
            this.ShowCardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowCardsButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCardsButton.Location = new System.Drawing.Point(612, 178);
            this.ShowCardsButton.Name = "ShowCardsButton";
            this.ShowCardsButton.Size = new System.Drawing.Size(177, 35);
            this.ShowCardsButton.TabIndex = 3;
            this.ShowCardsButton.Text = "Показать карты";
            this.ShowCardsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowCardsButton.UseVisualStyleBackColor = true;
            this.ShowCardsButton.Click += new System.EventHandler(this.ShowCardsButton_Click);
            this.ShowCardsButton.MouseEnter += new System.EventHandler(this.ShowCardsButton_MouseEnter);
            // 
            // HideCardsButton
            // 
            this.HideCardsButton.FlatAppearance.BorderSize = 0;
            this.HideCardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideCardsButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideCardsButton.Location = new System.Drawing.Point(612, 219);
            this.HideCardsButton.Name = "HideCardsButton";
            this.HideCardsButton.Size = new System.Drawing.Size(177, 35);
            this.HideCardsButton.TabIndex = 4;
            this.HideCardsButton.Text = "Закрыть карты";
            this.HideCardsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HideCardsButton.UseVisualStyleBackColor = true;
            this.HideCardsButton.Click += new System.EventHandler(this.HideCardsButton_Click);
            this.HideCardsButton.MouseEnter += new System.EventHandler(this.ShowCardsButton_MouseEnter);
            // 
            // ShuffleCards
            // 
            this.ShuffleCards.FlatAppearance.BorderSize = 0;
            this.ShuffleCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShuffleCards.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShuffleCards.Location = new System.Drawing.Point(612, 260);
            this.ShuffleCards.Name = "ShuffleCards";
            this.ShuffleCards.Size = new System.Drawing.Size(177, 35);
            this.ShuffleCards.TabIndex = 5;
            this.ShuffleCards.Text = "Сброс игры";
            this.ShuffleCards.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShuffleCards.UseVisualStyleBackColor = true;
            this.ShuffleCards.Click += new System.EventHandler(this.ShuffleCards_Click);
            this.ShuffleCards.MouseEnter += new System.EventHandler(this.ShowCardsButton_MouseEnter);
            // 
            // BackToMainButton
            // 
            this.BackToMainButton.FlatAppearance.BorderSize = 0;
            this.BackToMainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToMainButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMainButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackToMainButton.Location = new System.Drawing.Point(699, 1);
            this.BackToMainButton.Name = "BackToMainButton";
            this.BackToMainButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BackToMainButton.Size = new System.Drawing.Size(99, 31);
            this.BackToMainButton.TabIndex = 6;
            this.BackToMainButton.Text = "скрыть";
            this.BackToMainButton.UseVisualStyleBackColor = true;
            this.BackToMainButton.Click += new System.EventHandler(this.BackToMainButton_Click);
            this.BackToMainButton.MouseEnter += new System.EventHandler(this.ShowCardsButton_MouseEnter);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryComboBox.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryComboBox.ForeColor = System.Drawing.Color.Red;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(108, 61);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(177, 32);
            this.CategoryComboBox.TabIndex = 41;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            this.CategoryComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Player3ComboBox_MouseClick);
            // 
            // FirstPlayerLabel
            // 
            this.FirstPlayerLabel.AutoSize = true;
            this.FirstPlayerLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstPlayerLabel.Location = new System.Drawing.Point(24, 117);
            this.FirstPlayerLabel.Name = "FirstPlayerLabel";
            this.FirstPlayerLabel.Size = new System.Drawing.Size(61, 20);
            this.FirstPlayerLabel.TabIndex = 42;
            this.FirstPlayerLabel.Text = "1 игрок";
            // 
            // SecondPlayerLable
            // 
            this.SecondPlayerLable.AutoSize = true;
            this.SecondPlayerLable.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondPlayerLable.Location = new System.Drawing.Point(24, 162);
            this.SecondPlayerLable.Name = "SecondPlayerLable";
            this.SecondPlayerLable.Size = new System.Drawing.Size(63, 20);
            this.SecondPlayerLable.TabIndex = 43;
            this.SecondPlayerLable.Text = "2 игрок";
            // 
            // ThirdPlayerLabel
            // 
            this.ThirdPlayerLabel.AutoSize = true;
            this.ThirdPlayerLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirdPlayerLabel.Location = new System.Drawing.Point(24, 206);
            this.ThirdPlayerLabel.Name = "ThirdPlayerLabel";
            this.ThirdPlayerLabel.Size = new System.Drawing.Size(63, 20);
            this.ThirdPlayerLabel.TabIndex = 44;
            this.ThirdPlayerLabel.Text = "3 игрок";
            // 
            // Player1ComboBox
            // 
            this.Player1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Player1ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player1ComboBox.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1ComboBox.ForeColor = System.Drawing.Color.Red;
            this.Player1ComboBox.FormattingEnabled = true;
            this.Player1ComboBox.Location = new System.Drawing.Point(108, 114);
            this.Player1ComboBox.Name = "Player1ComboBox";
            this.Player1ComboBox.Size = new System.Drawing.Size(177, 32);
            this.Player1ComboBox.TabIndex = 45;
            this.Player1ComboBox.SelectedIndexChanged += new System.EventHandler(this.Player1ComboBox_SelectedIndexChanged);
            this.Player1ComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Player3ComboBox_MouseClick);
            // 
            // Player2ComboBox
            // 
            this.Player2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Player2ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player2ComboBox.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2ComboBox.ForeColor = System.Drawing.Color.Red;
            this.Player2ComboBox.FormattingEnabled = true;
            this.Player2ComboBox.Location = new System.Drawing.Point(108, 159);
            this.Player2ComboBox.Name = "Player2ComboBox";
            this.Player2ComboBox.Size = new System.Drawing.Size(177, 32);
            this.Player2ComboBox.TabIndex = 46;
            this.Player2ComboBox.SelectedIndexChanged += new System.EventHandler(this.Player2ComboBox_SelectedIndexChanged);
            this.Player2ComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Player3ComboBox_MouseClick);
            // 
            // Player3ComboBox
            // 
            this.Player3ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Player3ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player3ComboBox.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player3ComboBox.ForeColor = System.Drawing.Color.Red;
            this.Player3ComboBox.FormattingEnabled = true;
            this.Player3ComboBox.Location = new System.Drawing.Point(108, 203);
            this.Player3ComboBox.Name = "Player3ComboBox";
            this.Player3ComboBox.Size = new System.Drawing.Size(177, 32);
            this.Player3ComboBox.TabIndex = 47;
            this.Player3ComboBox.SelectedIndexChanged += new System.EventHandler(this.Player3ComboBox_SelectedIndexChanged);
            this.Player3ComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Player3ComboBox_MouseClick);
            // 
            // RemovePlayer1Button
            // 
            this.RemovePlayer1Button.FlatAppearance.BorderSize = 0;
            this.RemovePlayer1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemovePlayer1Button.Location = new System.Drawing.Point(301, 116);
            this.RemovePlayer1Button.Name = "RemovePlayer1Button";
            this.RemovePlayer1Button.Size = new System.Drawing.Size(32, 24);
            this.RemovePlayer1Button.TabIndex = 48;
            this.RemovePlayer1Button.Text = "x";
            this.RemovePlayer1Button.UseVisualStyleBackColor = true;
            this.RemovePlayer1Button.Click += new System.EventHandler(this.RemovePlayer1Button_Click);
            this.RemovePlayer1Button.MouseEnter += new System.EventHandler(this.ShowCardsButton_MouseEnter);
            // 
            // RemovePlayer3Button
            // 
            this.RemovePlayer3Button.FlatAppearance.BorderSize = 0;
            this.RemovePlayer3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemovePlayer3Button.Location = new System.Drawing.Point(301, 205);
            this.RemovePlayer3Button.Name = "RemovePlayer3Button";
            this.RemovePlayer3Button.Size = new System.Drawing.Size(32, 24);
            this.RemovePlayer3Button.TabIndex = 49;
            this.RemovePlayer3Button.Text = "x";
            this.RemovePlayer3Button.UseVisualStyleBackColor = true;
            this.RemovePlayer3Button.Click += new System.EventHandler(this.RemovePlayer3Button_Click);
            this.RemovePlayer3Button.MouseEnter += new System.EventHandler(this.ShowCardsButton_MouseEnter);
            // 
            // RemovePlayer2Button
            // 
            this.RemovePlayer2Button.FlatAppearance.BorderSize = 0;
            this.RemovePlayer2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemovePlayer2Button.Location = new System.Drawing.Point(301, 161);
            this.RemovePlayer2Button.Name = "RemovePlayer2Button";
            this.RemovePlayer2Button.Size = new System.Drawing.Size(32, 24);
            this.RemovePlayer2Button.TabIndex = 50;
            this.RemovePlayer2Button.Text = "x";
            this.RemovePlayer2Button.UseVisualStyleBackColor = true;
            this.RemovePlayer2Button.Click += new System.EventHandler(this.RemovePlayer2Button_Click);
            this.RemovePlayer2Button.MouseEnter += new System.EventHandler(this.ShowCardsButton_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Категория";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Start game";
            // 
            // AddCollectionButton
            // 
            this.AddCollectionButton.FlatAppearance.BorderSize = 0;
            this.AddCollectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCollectionButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCollectionButton.Location = new System.Drawing.Point(612, 122);
            this.AddCollectionButton.Name = "AddCollectionButton";
            this.AddCollectionButton.Size = new System.Drawing.Size(177, 35);
            this.AddCollectionButton.TabIndex = 52;
            this.AddCollectionButton.Text = "Генерация коллекции";
            this.AddCollectionButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddCollectionButton.UseVisualStyleBackColor = true;
            this.AddCollectionButton.Click += new System.EventHandler(this.AddCollectionButton_Click);
            this.AddCollectionButton.MouseEnter += new System.EventHandler(this.ShowCardsButton_MouseEnter);
            // 
            // SaveCollectionButton
            // 
            this.SaveCollectionButton.FlatAppearance.BorderSize = 0;
            this.SaveCollectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveCollectionButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCollectionButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveCollectionButton.Image")));
            this.SaveCollectionButton.Location = new System.Drawing.Point(291, 60);
            this.SaveCollectionButton.Name = "SaveCollectionButton";
            this.SaveCollectionButton.Size = new System.Drawing.Size(48, 35);
            this.SaveCollectionButton.TabIndex = 53;
            this.SaveCollectionButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveCollectionButton.UseVisualStyleBackColor = true;
            this.SaveCollectionButton.Click += new System.EventHandler(this.SaveCollectionButton_Click);
            this.SaveCollectionButton.MouseEnter += new System.EventHandler(this.ShowCardsButton_MouseEnter);
            // 
            // CustomPaintButton
            // 
            this.CustomPaintButton.FlatAppearance.BorderSize = 0;
            this.CustomPaintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomPaintButton.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomPaintButton.Location = new System.Drawing.Point(612, 81);
            this.CustomPaintButton.Name = "CustomPaintButton";
            this.CustomPaintButton.Size = new System.Drawing.Size(177, 35);
            this.CustomPaintButton.TabIndex = 54;
            this.CustomPaintButton.Text = "Рисовать";
            this.CustomPaintButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomPaintButton.UseVisualStyleBackColor = true;
            this.CustomPaintButton.Click += new System.EventHandler(this.CustomPaintButton_Click);
            this.CustomPaintButton.MouseEnter += new System.EventHandler(this.ShowCardsButton_MouseEnter);
            // 
            // StartGameLabel
            // 
            this.StartGameLabel.AutoSize = true;
            this.StartGameLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGameLabel.Location = new System.Drawing.Point(170, 284);
            this.StartGameLabel.Name = "StartGameLabel";
            this.StartGameLabel.Size = new System.Drawing.Size(48, 20);
            this.StartGameLabel.TabIndex = 55;
            this.StartGameLabel.Text = "Старт";
            // 
            // RemoveCollectionButton
            // 
            this.RemoveCollectionButton.FlatAppearance.BorderSize = 0;
            this.RemoveCollectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveCollectionButton.Location = new System.Drawing.Point(345, 66);
            this.RemoveCollectionButton.Name = "RemoveCollectionButton";
            this.RemoveCollectionButton.Size = new System.Drawing.Size(32, 24);
            this.RemoveCollectionButton.TabIndex = 56;
            this.RemoveCollectionButton.Text = "x";
            this.RemoveCollectionButton.UseVisualStyleBackColor = true;
            this.RemoveCollectionButton.Click += new System.EventHandler(this.RemoveCollectionButton_Click);
            this.RemoveCollectionButton.MouseEnter += new System.EventHandler(this.ShowCardsButton_MouseEnter);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.RemoveCollectionButton);
            this.Controls.Add(this.StartGameLabel);
            this.Controls.Add(this.CustomPaintButton);
            this.Controls.Add(this.SaveCollectionButton);
            this.Controls.Add(this.AddCollectionButton);
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
        private System.Windows.Forms.Button AddCollectionButton;
        private System.Windows.Forms.Button SaveCollectionButton;
        private System.Windows.Forms.Button CustomPaintButton;
        private System.Windows.Forms.Label StartGameLabel;
        private System.Windows.Forms.Button RemoveCollectionButton;
    }
}