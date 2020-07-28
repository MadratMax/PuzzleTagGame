using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using PuzzleTag.Collection;
using PuzzleTag.Configuration;
using PuzzleTag.FileManager;
using PuzzleTag.Game;
using PuzzleTag.UI;

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

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            Player1ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Player2ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Player3ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Invoke((Action)(() => CategoryComboBox.DataSource = GameState.Categories));
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
                InitAvatars();
                var moveQueue = new MoveQueue(players);
                var totalScore = new TotalScore(players);
                ruler.StartGame(moveQueue, totalScore);
                BlockSettings();
                BackToMain();

                UI.Update.UpdateInfoLabel($"{ruler.CurrentPlayer.Name.ToUpper()} is moving. Score: {ruler.CurrentPlayer.DiscoveredCards}");
            }
        }

        private void InitAvatars()
        {
            var player1 = players.GetPlayerByIndex(1);
            var player2 = players.GetPlayerByIndex(2);
            var player3 = players.GetPlayerByIndex(3);

            baseForm.Player1Avatar.BackgroundImage = player1?.Avatar;
            baseForm.Player2Avatar.BackgroundImage = player2?.Avatar;
            baseForm.Player3Avatar.BackgroundImage = player3?.Avatar;
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
            RemovePlayer1Button.Enabled = false;
            RemovePlayer2Button.Enabled = false;
            RemovePlayer3Button.Enabled = false;
            NewGameButton.Enabled = false;
        }

        private void UnblockSettings()
        {
            Player1ComboBox.Enabled = true;
            Player2ComboBox.Enabled = true;
            Player3ComboBox.Enabled = true;
            RemovePlayer1Button.Enabled = true;
            RemovePlayer2Button.Enabled = true;
            RemovePlayer3Button.Enabled = true;
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
            ruler?.StopGame();
            RemovePlayersFromGame();
            Shuffle();
            UnblockSettings();
            UI.Update.ClearInfoLabel();
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

        private void RemovePlayer1Button_Click(object sender, EventArgs e)
        {
            Player1ComboBox.SelectedIndex = -1;
        }

        private void RemovePlayer2Button_Click(object sender, EventArgs e)
        {
            Player2ComboBox.SelectedIndex = -1;
        }

        private void RemovePlayer3Button_Click(object sender, EventArgs e)
        {
            Player3ComboBox.SelectedIndex = -1;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void SettingsForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Player1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}