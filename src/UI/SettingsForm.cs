using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using PuzzleTag.Collection;
using PuzzleTag.Configuration;
using PuzzleTag.DataManager;
using PuzzleTag.FileManager;
using PuzzleTag.FileManager.Library;
using PuzzleTag.Game;
using PuzzleTag.ImageCollection.CustomLibrary;
using PuzzleTag.Notification;
using PuzzleTag.SoundMaster;
using PuzzleTag.UI;

namespace PuzzleTag
{
    partial class SettingsForm : Form
    {
        private NewCollectionDialogForm newCollectionDialogForm;
        private PaintForm paintForm;
        private Ruler ruler;
        private CustomImageCollectionConfigurator customImageCollectionConfigurator;
        private FileManager.FileManager fileManager;
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

        public SettingsForm(
            Ruler ruler, 
            Players players, 
            CustomButtonsManager buttonManager, 
            ImageLibraryManager libManager,
            FileManager.FileManager fileManager,
            PuzzleTag baseForm,
            CustomImageCollectionConfigurator customImageCollectionConfigurator)
        {
            this.customImageCollectionConfigurator = customImageCollectionConfigurator;
            this.ruler = ruler;
            this.players = players;
            this.fileManager = fileManager;
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

            if (CategoryComboBox.DataSource == null)
            {
                this.Invoke((Action)(() => CategoryComboBox.DataSource = libManager.GetCategories()));
            }
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
                AddPlayersToGame();
                var moveQueue = new MoveQueue(players);
                var totalScore = new TotalScore(players);
                this.scoreStorage = new PlayersScoreStorage();
                Shuffle();
                InitPlayerScores();
                InitAvatars();
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
            scoreStorage?.DisposeScore(player1);
            scoreStorage?.DisposeScore(player2);
            scoreStorage?.DisposeScore(player3);
            scoreStorage?.DisposeData();
            player1PrizeImagesList = null;
            player2PrizeImagesList = null;
            player3PrizeImagesList = null;
            players.RemovePlayersFromGame();
            Player1ComboBox.SelectedIndex = -1;
            Player2ComboBox.SelectedIndex = -1;
            Player3ComboBox.SelectedIndex = -1;
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
            RemoveCollectionButton.Enabled = false;
            NewGameButton.Enabled = false;
        }

        private void UnblockSettings()
        {
            Player1ComboBox.Enabled = true;
            Player2ComboBox.Enabled = false;
            Player3ComboBox.Enabled = false;
            RemovePlayer1Button.Enabled = true;
            RemovePlayer2Button.Enabled = true;
            RemovePlayer3Button.Enabled = true;
            RemoveCollectionButton.Enabled = true;
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
            var confirm = GetConfirmStatus("Сбросить игру?");

            if (confirm.Yes)
                ResetGame(true);

            confirm.Dispose();
            this.Enabled = true;
        }

        private ConfirmDialogForm GetConfirmStatus(string confirmMessage)
        {
            var confirm = new ConfirmDialogForm(confirmMessage);
            SoundPlayer.PlaySettingsSound();
            confirm.StartPosition = FormStartPosition.Manual;
            confirm.Location = this.Location;
            confirm.StartPosition = FormStartPosition.CenterParent;
            confirm.BackgroundImageLayout = ImageLayout.Stretch;
            this.Enabled = false;
            confirm.ShowDialog(this);
            return confirm;
        }

        private void ResetGame(bool forced = false)
        {
            if (forced || (ruler != null && ruler.IsGameStarted))
            {
                SoundPlayer.PlayShuffleSound();
                ruler?.StopGame();
                RemovePlayersFromGame();
                Shuffle();
                UnblockSettings();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            var confirm = GetConfirmStatus("Выйти?");

            if (confirm.Yes)
                Application.Exit();

            confirm.Dispose();
            this.Enabled = true;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SoundPlayer.PlayShuffleSound();
            ChangeGameCategory();
        }

        private void InitSaveCollectionButton()
        {
            var libPath = libManager.LibraryPath;
            var collectionPath = Path.Combine(libPath, CategoryComboBox.Text);

            SaveCollectionButton.Enabled = false;

            if (!fileManager.IsDirectoryExist(collectionPath))
            {
                SaveCollectionButton.Enabled = true;
            }
        }

        private void ChangeGameCategory()
        {
            GameState.Category = CategoryComboBox.Text;
            buttonManager.AssignImages(GameState.Category);
            buttonManager.HideButtonImages();
            InitSaveCollectionButton();
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
                NewGameButton.Enabled = true;
                StartGameLabel.Enabled = true;
            }
            else
            {
                Player2ComboBox.Enabled = false;
                NewGameButton.Enabled = false;
                StartGameLabel.Enabled = false;
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

        private void AddCollectionButton_Click(object sender, EventArgs e)
        {
            bool needReset = false;
            ConfirmDialogForm confirm = null;

            if (ruler.IsGameStarted)
            {
                confirm = GetConfirmStatus("Сбросить игру?");
                needReset = confirm.Yes;
            }
            else
            {
                needReset = true;
            }

            if (needReset)
            {
                ResetGame();

                if (newCollectionDialogForm == null)
                {
                    newCollectionDialogForm = new NewCollectionDialogForm();
                }

                SoundPlayer.PlaySettingsSound();
                newCollectionDialogForm.StartPosition = FormStartPosition.Manual;
                newCollectionDialogForm.Location = this.Location;
                newCollectionDialogForm.StartPosition = FormStartPosition.CenterParent;
                newCollectionDialogForm.BackgroundImageLayout = ImageLayout.Stretch;
                this.Enabled = false;
                newCollectionDialogForm.NewCollectionTextBox.Focus();
                newCollectionDialogForm.ShowDialog(this);
                var newCollectionName = newCollectionDialogForm.CollectionName;
                this.Enabled = true;

                if (!string.IsNullOrEmpty(newCollectionName) && newCollectionName?.Length > 2)
                {
                    this.Invoke((Action)(() => this.Enabled = false));

                    new Thread(() => {
                        Thread.CurrentThread.IsBackground = true;
                        this.Invoke((Action)(() => baseForm.ShowStatusMessage($"ПОИСК ИЗОБРАЖЕНИЙ ПО КАТЕГОРИИ '{newCollectionName.ToUpper()}' ...")));
                        this.Invoke((Action)(() => customImageCollectionConfigurator.GenerateImageCollectionByCategory(baseForm, newCollectionName, 180, 190)));
                        this.Invoke((Action)(() => buttonManager.AssignImages(newCollectionName)));
                        this.Invoke((Action)(() => buttonManager.HideButtonImages()));
                        this.Invoke((Action)(() => CategoryComboBox.DataSource = libManager.GetCategories().ToList()));
                        this.Invoke((Action)(() => CategoryComboBox.SelectedIndex = CategoryComboBox.FindStringExact(newCollectionName)));
                        this.Invoke((Action)(() => newCollectionDialogForm.ResetCollectionName()));
                        this.Invoke((Action)(() => this.Enabled = true));
                        this.Invoke((Action)(() => baseForm.HideStatusMessage()));
                        SoundPlayer.PlayShuffleSound();
                    }).Start();
                }
            }

            confirm?.Dispose();
            this.Enabled = true;
        }

        private void SaveCollectionButton_Click(object sender, EventArgs e)
        {
            var collectionName = CategoryComboBox.Text;
            var libPath = libManager.LibraryPath;
            var imageCollection = libManager.GetImageCollectionByCategory(collectionName);
            fileManager.SaveNewCollection(imageCollection, collectionName, libPath);
            SaveCollectionButton.Enabled = false;
        }

        private void CustomPaintButton_Click(object sender, EventArgs e)
        {
            SoundPlayer.PlaySettingsSound();

            bool needReset = false;
            ConfirmDialogForm confirm = null;

            if (ruler.IsGameStarted)
            {
                confirm = GetConfirmStatus("Сбросить игру?");
                needReset = confirm.Yes;
            }
            else
            {
                needReset = true;
            }

            if (needReset)
            {
                ResetGame();

                var collectionNameDialog = new CustomCollectionNameDialogForm();
                collectionNameDialog.StartPosition = FormStartPosition.Manual;
                collectionNameDialog.Location = this.Location;
                collectionNameDialog.StartPosition = FormStartPosition.CenterParent;
                collectionNameDialog.BackgroundImageLayout = ImageLayout.Stretch;
                this.Enabled = false;
                collectionNameDialog.ShowDialog(this);
                this.Enabled = true;

                var newCollectionName = collectionNameDialog.GetCollectionName();

                if (libManager.GetCategories().Contains(newCollectionName))
                {
                    baseForm.ShowStatusMessage($"Коллекция {newCollectionName} уже существует", error:true, true);
                    return;
                }

                if (!string.IsNullOrEmpty(newCollectionName))
                {
                    var collectionPath = Path.Combine(libManager.LibraryPath, newCollectionName);
                    if (fileManager.IsDirectoryExist(collectionPath))
                    {
                        var popUpMessage = new TimedPopUp();
                        popUpMessage.Set($"Коллекция {newCollectionName} уже существует");
                        popUpMessage.ShowError(3000);
                        this.Invoke((Action)(() => this.Enabled = true));
                        return;
                    }

                    collectionNameDialog.Dispose();
                    collectionNameDialog = null;
                    paintForm = new PaintForm(this, baseForm, newCollectionName);

                    new Thread(() =>
                    {
                        this.Invoke((Action)(() => paintForm.StartPosition = FormStartPosition.Manual));
                        this.Invoke((Action)(() => paintForm.Location = this.Location));
                        this.Invoke((Action)(() => paintForm.StartPosition = FormStartPosition.CenterParent));
                        this.Invoke((Action)(() => paintForm.BackgroundImageLayout = ImageLayout.Stretch));
                        this.Invoke((Action)(() => this.Enabled = false));
                        this.Invoke((Action)(() => paintForm.ShowDialog(this)));
                        List<CustomImage> newCollection = paintForm.GetCollection();
                        SaveCustomImageCollection(newCollectionName, newCollection);
                        this.Invoke((Action)(() => CategoryComboBox.DataSource = libManager.GetCategories().ToList()));
                        this.Invoke((Action)(() => CategoryComboBox.SelectedIndex = CategoryComboBox.FindStringExact(newCollectionName)));
                        paintForm.Dispose();
                        paintForm = null;
                        this.Invoke((Action)(() => this.Enabled = true));
                    }).Start();
                }
            }

            confirm?.Dispose();
            this.Enabled = true;
        }

        private void SaveCustomImageCollection(string collectionName, List<CustomImage> imageCollection)
        {
            if (imageCollection != null && imageCollection.Count == 32)
            {
                string libPath = libManager.LibraryPath;
                fileManager.SaveNewCollection(imageCollection, collectionName, libPath);
                libManager.AddCategory(collectionName);
                libManager.InitializeNewCollection(imageCollection);
            }
        }

        private void RemoveCollectionButton_Click(object sender, EventArgs e)
        {
            SoundPlayer.PlayRemovePlayerSound();
            var confirm = GetConfirmStatus("Удалить коллекцию?");

            if (confirm.Yes)
            {
                var collectionName = CategoryComboBox.Text;
                libManager.RemoveCategory(collectionName);
                var categories = libManager.GetCategories();
                this.Invoke((Action)(() => CategoryComboBox.DataSource = categories.ToList()));
                this.Invoke((Action)(() => CategoryComboBox.Refresh()));
                fileManager.DeleteCollection(collectionName, libManager.LibraryPath);
            }

            confirm.Dispose();
            this.Enabled = true;
        }
    }
}