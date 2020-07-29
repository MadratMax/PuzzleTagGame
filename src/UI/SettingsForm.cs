using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using PuzzleTag.Collection;
using PuzzleTag.Configuration;
using PuzzleTag.DataManager;
using PuzzleTag.FileManager;
using PuzzleTag.Game;
using PuzzleTag.SoundMaster;
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
        private List<Control> player1PrizeImagesList;
        private List<Control> player2PrizeImagesList;
        private List<Control> player3PrizeImagesList;
        private PlayersScoreStorage scoreStorage;
        private Player player1;
        private Player player2;
        private Player player3;

        public SettingsForm(Ruler ruler, Players players, CustomButtonsManager buttonManager, ImageLibraryManager libManager, PuzzleTag baseForm)
        {
            this.ruler = ruler;
            this.players = players;
            this.scoreStorage = new PlayersScoreStorage();
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
            SetupKeyDownEvents(this);
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
                SoundPlayer.PlayStartGameSound();
                Shuffle();
                AddPlayersToGame();
                InitPlayerScores();
                InitAvatars();
                var moveQueue = new MoveQueue(players);
                var totalScore = new TotalScore(players);
                ruler.StartGame(moveQueue, totalScore, scoreStorage);
                BlockSettings();
                BackToMain();

                baseForm.Player1Avatar.FlatAppearance.BorderColor = Color.DarkOrange;
                baseForm.Player1Avatar.FlatAppearance.BorderSize = 4;
            }
        }

        private void InitPlayerScores()
        {
            InitPl1ScoreList();
            InitPl2ScoreList();
            InitPl3ScoreList();
        }

        private void InitPl3ScoreList()
        {
            player3PrizeImagesList = new List<Control>
            {
                baseForm.Pl3p1,
                baseForm.Pl3p2,
                baseForm.Pl3p3,
                baseForm.Pl3p4,
                baseForm.Pl3p5,
                baseForm.Pl3p6,
                baseForm.Pl3p7,
                baseForm.Pl3p8,
                baseForm.Pl3p9,
                baseForm.Pl3p10,
                baseForm.Pl3p11,
                baseForm.Pl3p12,
                baseForm.Pl3p13,
                baseForm.Pl3p14,
                baseForm.Pl3p15,
                baseForm.Pl3p16,
            };

            var player = players.GetPlayerByIndex(3);

            if (player != null)
            {
                player.AvaButton = baseForm.Player3Avatar;
            }
            
            scoreStorage.Add(player3PrizeImagesList, player);
        }

        private void InitPl2ScoreList()
        {
            player2PrizeImagesList = new List<Control>
            {
                baseForm.Pl2p1,
                baseForm.Pl2p2,
                baseForm.Pl2p3,
                baseForm.Pl2p4,
                baseForm.Pl2p5,
                baseForm.Pl2p6,
                baseForm.Pl2p7,
                baseForm.Pl2p8,
                baseForm.Pl2p9,
                baseForm.Pl2p10,
                baseForm.Pl2p11,
                baseForm.Pl2p12,
                baseForm.Pl2p13,
                baseForm.Pl2p14,
                baseForm.Pl2p15,
                baseForm.Pl2p16,
            };

            var player = players.GetPlayerByIndex(2);

            if (player != null)
            {
                player.AvaButton = baseForm.Player2Avatar;
            }

            scoreStorage.Add(player2PrizeImagesList, player);
        }

        private void InitPl1ScoreList()
        {
            player1PrizeImagesList = new List<Control>
            {
                baseForm.Pl1p1,
                baseForm.Pl1p2,
                baseForm.Pl1p3,
                baseForm.Pl1p4,
                baseForm.Pl1p5,
                baseForm.Pl1p6,
                baseForm.Pl1p7,
                baseForm.Pl1p8,
                baseForm.Pl1p9,
                baseForm.Pl1p10,
                baseForm.Pl1p11,
                baseForm.Pl1p12,
                baseForm.Pl1p13,
                baseForm.Pl1p14,
                baseForm.Pl1p15,
                baseForm.Pl1p16,
            };

            var player = players.GetPlayerByIndex(1);

            if (player != null)
            {
                player.AvaButton = baseForm.Player1Avatar;
            }
            
            scoreStorage.Add(player1PrizeImagesList, player);
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
            player1 = players.GetPlayerByName(Player1ComboBox.Text);
            player2 = players.GetPlayerByName(Player2ComboBox.Text);
            player3 = players.GetPlayerByName(Player3ComboBox.Text);
            players.AddPlayerToGame(player1, 1);
            players.AddPlayerToGame(player2, 2);
            players.AddPlayerToGame(player3, 3);
        }

        private void RemovePlayersFromGame()
        {
            scoreStorage.DisposeScore(player1);
            scoreStorage.DisposeScore(player2);
            scoreStorage.DisposeScore(player3);
            scoreStorage.DisposeData();
            player1PrizeImagesList = null;
            player2PrizeImagesList = null;
            player3PrizeImagesList = null;
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
            SoundPlayer.PlayOpenCloseCardsSound();
            buttonManager.ShowButtonImages();
        }

        private void HideCardsButton_Click(object sender, EventArgs e)
        {
            SoundPlayer.PlayOpenCloseCardsSound();
            buttonManager.HideButtonImages();
        }

        private void ShuffleCards_Click(object sender, EventArgs e)
        {
            SoundPlayer.PlayShuffleSound();
            ruler?.StopGame();
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
            SoundPlayer.PlayShuffleSound();
            GameState.Category = CategoryComboBox.Text;
            ChangeGameCategory();
        }

        private void ChangeGameCategory()
        {
            Thread.CurrentThread.IsBackground = false;
            buttonManager.AssignImages(GameState.Category);
            buttonManager.HideButtonImages();

            //this.Invoke((Action)(() => baseForm.InfoLabel.Text = ""));
        }

        private void RemovePlayer1Button_Click(object sender, EventArgs e)
        {
            SoundPlayer.PlayRemovePlayerSound();
            Player1ComboBox.SelectedIndex = -1;
            Player2ComboBox.SelectedIndex = -1;
            Player3ComboBox.SelectedIndex = -1;
        }

        private void RemovePlayer2Button_Click(object sender, EventArgs e)
        {
            SoundPlayer.PlayRemovePlayerSound();
            Player2ComboBox.SelectedIndex = -1;
            Player3ComboBox.SelectedIndex = -1;
        }

        private void RemovePlayer3Button_Click(object sender, EventArgs e)
        {
            SoundPlayer.PlayRemovePlayerSound();
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

        private void SetupKeyDownEvents(SettingsForm settingsForm)
        {
            foreach (Control control in settingsForm.Controls)
            {
                control.KeyDown += HandleKeyDown;
            }
        }

        private void HandleKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                BackToMainButton.PerformClick();
            }
        }

        private void Player1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Player1ComboBox.SelectedIndex != -1)
            {
                Player2ComboBox.Enabled = true;
            }
            else
            {
                Player2ComboBox.Enabled = false;
            }
        }

        private void Player2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Player2ComboBox.SelectedIndex != -1)
            {
                Player3ComboBox.Enabled = true;
            }
            else
            {
                Player3ComboBox.Enabled = false;
            }
        }

        private void Player3ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Player1ComboBox.SelectedIndex == -1 || Player2ComboBox.SelectedIndex == -1)
            {
                Player3ComboBox.Enabled = false;
            }
        }

        private void ShowCardsButton_MouseEnter(object sender, EventArgs e)
        {
            SoundPlayer.PlaySelectItemSound();
        }

        private void Player3ComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            SoundPlayer.PlaySelectItemSound();
        }
    }
}