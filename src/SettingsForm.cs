using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using PuzzleTag.Collection;
using PuzzleTag.Configuration;
using PuzzleTag.FileManager;
using PuzzleTag.Game;

namespace PuzzleTag
{
    partial class SettingsForm : Form
    {
        private Ruler ruler;
        private Players players;
        private CustomButtonsManager buttonManager;
        private ImageLibraryManager libManager;
        private PuzzleTag baseForm;

        public SettingsForm(Ruler ruler, Players players, CustomButtonsManager buttonManager, ImageLibraryManager libManager, PuzzleTag baseForm)
        {
            this.ruler = ruler;
            this.players = players;
            this.buttonManager = buttonManager;
            this.libManager = libManager;
            this.baseForm = baseForm;
            InitializeComponent();
            InitSettings();
            InitPlayers();
        }

        private void InitSettings()
        {
            Player1ComboBox.DataSource = players.GetPlayerNames();
            Player2ComboBox.DataSource = players.GetPlayerNames();
            Player3ComboBox.DataSource = players.GetPlayerNames();

            Player1ComboBox.SelectedIndex = -1;
            Player2ComboBox.SelectedIndex = -1;
            Player3ComboBox.SelectedIndex = -1;
        }

        private void InitPlayers()
        {
            //Player1ComboBox.Text = players.GetPlayerByIndex(1)?.Name ?? "";
            //Player2ComboBox.Text = players.GetPlayerByIndex(2)?.Name ?? "";
            //Player3ComboBox.Text = players.GetPlayerByIndex(3)?.Name ?? "";
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            this.Invoke((Action)(() => CategoryComboBox.DataSource = GameState.Categories));
            InitPlayers();
        }

        private void BackToMainButton_Click(object sender, EventArgs e)
        {
            BackToMain();
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            if (Player1ComboBox.Text != string.Empty)
            {
                Shuffle();
                AddPlayersToGame();
                ruler.StartGame();
                BlockSettings();
                BackToMain();
            }
        }

        private void AddPlayersToGame()
        {
            var pl1 = players.GetPlayerByName(Player1ComboBox.Text);
            var pl2 = players.GetPlayerByName(Player2ComboBox.Text);
            var pl3 = players.GetPlayerByName(Player3ComboBox.Text);
            players.AddPlayerToGame(pl1, 1);
            players.AddPlayerToGame(pl2, 2);
            players.AddPlayerToGame(pl3, 3);
        }

        private void RemovePlayersFromGame()
        {
            players.RemovePlayersFromGame();
        }

        private void BlockSettings()
        {
            Player1ComboBox.Enabled = false;
            Player2ComboBox.Enabled = false;
            Player3ComboBox.Enabled = false;
            CategoryComboBox.Enabled = false;
            NewGameButton.Enabled = false;
        }

        private void UnblockSettings()
        {
            Player1ComboBox.Enabled = true;
            Player2ComboBox.Enabled = true;
            Player3ComboBox.Enabled = true;
            CategoryComboBox.Enabled = true;
            NewGameButton.Enabled = true;
        }

        private void BackToMain()
        {
            Owner.Show();
            this.Close();
        }

        private void Shuffle()
        {
            this.Invoke((Action)(() => buttonManager.ButtonsCollection().Shuffle()));
            buttonManager.HideButtonImages();
            buttonManager.AssignImages(GameState.Category);
        }

        private void ShowCardsButton_Click(object sender, EventArgs e)
        {
            buttonManager.ShowButtonImages();
        }

        private void HideCardsButton_Click(object sender, EventArgs e)
        {
            buttonManager.HideButtonImages();
        }

        private void ShuffleCards_Click(object sender, EventArgs e)
        {
            RemovePlayersFromGame();
            Shuffle();
            UnblockSettings();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GameState.Category = CategoryComboBox.Text;

            this.Invoke((Action)(() => baseForm.InfoLabel.Text = "Initializing..."));
            ChangeGameCategory();
        }

        private void ChangeGameCategory()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = false;
                buttonManager.AssignImages(GameState.Category);
                buttonManager.HideButtonImages();
            }).Start();

            this.Invoke((Action)(() => baseForm.InfoLabel.Text = ""));
        }
    }
}