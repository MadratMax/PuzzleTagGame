using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using PuzzleTag.Collection;
using PuzzleTag.Configuration;
using PuzzleTag.Controls;
using PuzzleTag.FileManager;
using PuzzleTag.Game;
using PuzzleTag.ImageCollection.CustomLibrary;
using PuzzleTag.Notification;
using PuzzleTag.SoundMaster;
using PuzzleTag.UI;

namespace PuzzleTag
{
    public partial class PuzzleTag : Form
    {
        private int[] appSize;
        private ControlMap controlMap;
        private ControlProvider.ControlProvider controlProvider;
        private ButtonsCollection customButtonsCollection;
        private CustomButtonsManager buttonManager;
        private ImageLibraryManager libManager;
        private Ruler ruler;
        private Players players;
        private SettingsForm gameSettings;
        private TimedPopUp messageBar;
        private FileManager.FileManager fileManager;
        private CustomImageCollectionConfigurator customImageCollectionConfigurator;

        public PuzzleTag()
        {
            InitializeComponent();
            InitSounds();
        }

        private void PuzzleTag_Load(object sender, EventArgs e)
        {
            ShowStatusMessage("ЗАГРУЗКА...");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            SetupClickEvents(this);
            SetupKeyDownEvents(this);
            InitializeControls(this);
            SetupConfiguration();
            InitializeGameData();
            InitPlayers();
            InitGameRules();

            var sourceApiUrl = Settings.Api;
            customImageCollectionConfigurator = new CustomImageCollectionConfigurator(sourceApiUrl, libManager);

            this.appSize = new int[] {this.Size.Width, this.Size.Height};
            UI.Update.MainFormUI = this;
        }

        private void InitSounds()
        {
            fileManager = new FileManager.FileManager();
            var buttonSoundFile = fileManager.GetFiles(Settings.ButtonSound).FirstOrDefault();
            var settingSoundFile = fileManager.GetFiles(Settings.SettingsSound).FirstOrDefault();
            var winSoundFile = fileManager.GetFiles(Settings.WinSound).FirstOrDefault();
            var selectItemSoundFile = fileManager.GetFiles(Settings.SelectSound).FirstOrDefault();
            var startGameSoundFile = fileManager.GetFiles(Settings.StartGameSound).FirstOrDefault();
            var closeCardSoundFile = fileManager.GetFiles(Settings.CloseCardSound).FirstOrDefault();
            var scoreSoundFile = fileManager.GetFiles(Settings.ScoreSound).FirstOrDefault();
            var shuffleSoundFile = fileManager.GetFiles(Settings.ShuffleSound).FirstOrDefault();
            var openCloseCardsSoundFile = fileManager.GetFiles(Settings.OpenCloseCardsSound).FirstOrDefault();
            var removePlayerSoundFile = fileManager.GetFiles(Settings.RemovePlayerSound).FirstOrDefault();
            var cannotOpenCardSoundFile = fileManager.GetFiles(Settings.CannotOpenCardSound).FirstOrDefault();
            var saveSoundFile = fileManager.GetFiles(Settings.SaveSound).FirstOrDefault();
            var newImageSoundFile = fileManager.GetFiles(Settings.NewImageSound).FirstOrDefault();
            var failedImageSoundFile = fileManager.GetFiles(Settings.FailedImageSound).FirstOrDefault();

            SoundPlayer.ButtonSound = buttonSoundFile;
            SoundPlayer.SettingsSound = settingSoundFile;
            SoundPlayer.WinSound = winSoundFile;
            SoundPlayer.SelectSound = selectItemSoundFile;
            SoundPlayer.StartGameSound = startGameSoundFile;
            SoundPlayer.CloseCardSound = closeCardSoundFile;
            SoundPlayer.ScoreSound = scoreSoundFile;
            SoundPlayer.ShuffleSound = shuffleSoundFile;
            SoundPlayer.OpenCloseCardsSound = openCloseCardsSoundFile;
            SoundPlayer.RemovePlayerSound = removePlayerSoundFile;
            SoundPlayer.CannotOpenCardSound = cannotOpenCardSoundFile;
            SoundPlayer.SaveSound = saveSoundFile;
            SoundPlayer.NewImageSound = newImageSoundFile;
            SoundPlayer.FailedImageSound = failedImageSoundFile;
        }

        public void ShowStatusMessage(string message, bool error = false, bool autoHide = false)
        {
            if(error)
                SoundPlayer.PlayFailedImageSound();

            messageBar = null;
            messageBar = new TimedPopUp();
            messageBar.Set(message, FormStartPosition.CenterScreen);
            messageBar.Show(autoHide:autoHide);
        }

        public void UpdateStatusMessage(string updateMessage)
        {
            messageBar?.HideForm();
            messageBar?.Set(updateMessage, FormStartPosition.CenterScreen);
            messageBar?.Show(autoHide: false);
        }

        public void HideStatusMessage()
        {
            messageBar?.HideForm();
        }

        private void SetupKeyDownEvents(PuzzleTag puzzleTag)
        {
            foreach (Control control in puzzleTag.Controls)
            {
                control.KeyDown += HandleKeyDown;
            }
        }

        private void InitPlayers()
        {
            players = new Players();
            players.AddPlayer(Settings.Player1Name, Settings.Player1AvaImage);
            players.AddPlayer(Settings.Player2Name, Settings.Player2AvaImage);
            players.AddPlayer(Settings.Player3Name, Settings.Player3AvaImage);
        }

        private void SetupClickEvents(Control puzzleTag)
        {
            foreach (Control control in puzzleTag.Controls)
            {
                control.Click += HandleClicks;
            }
        }

        private void InitializeControls(PuzzleTag form)
        {
            controlMap = new ControlMap(form);
            controlProvider = new ControlProvider.ControlProvider(controlMap);
            customButtonsCollection = new ButtonsCollection(controlMap);
            customButtonsCollection.InitializeByButtonNameAttribute("custom");
        }

        private void SetupConfiguration()
        {
            this.libManager = new ImageLibraryManager();
            this.buttonManager = new CustomButtonsManager(customButtonsCollection, libManager);
        }
        private void InitGameRules()
        {
            this.ruler = new Ruler(buttonManager, customButtonsCollection, libManager, players);
        }

        private void InitializeGameData()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = false;
                this.Invoke((Action)(InitializeLibrary));
                this.Invoke((Action)(() => buttonManager.AssignImages(GameState.Category)));
                this.Invoke((Action)(() => buttonManager.SetClosedCardImages()));
                this.Invoke((Action)(() => buttonManager.HideButtonImages()));
                this.Invoke((Action)(HideStatusMessage));
            }).Start();
        }

        private void InitializeLibrary()
        {
            libManager.InitializeLibrary();
            this.BackgroundImage = libManager.GetMainImage().Image;
        }

        private void HandleClicks(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            if (control.Name.Contains("CustomButton"))
            {
                if (ruler.IsGameStarted)
                {
                    ruler.OpenCard(control.Name);
                }
                else
                {
                    var card = buttonManager.ButtonsCollection().GetCustomButtonByName(control.Name);
                    var imageCollection = libManager.GetImageCollection();
                    var customImage = imageCollection.FirstOrDefault(n => n.Image == card.Image);

                    if (customImage != null && customImage.AllowUpdate)
                    {
                        var newImage = customImageCollectionConfigurator.UpdateImage(customImage);
                        buttonManager.RefreshButtonImage(card, newImage);
                        SoundPlayer.PlayButtonSound();
                    }
                    else
                    {
                        SoundPlayer.PlayCannotOpenCardSound();
                        messageBar.Set("Нажмите ESC чтобы войти в меню");
                        messageBar.Show(3000, true);
                    }
                }
            }
        }

        private void HandleKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                SettingsButton.PerformClick();
            }

            if (e.KeyCode == Keys.Left)
            {
                foreach (Control control in this.Controls)
                {
                    control.Location = new Point(control.Location.X-1, control.Location.Y-1);
                }
            }
        }

        private void PuzzleTag_ResizeEnd(object sender, EventArgs e)
        {
            var newSize = new int[] { this.Size.Width, this.Size.Height };

            var diffPersentageX = (newSize[0] * 100 / appSize[0]) - 100;
            var diffPersentageY = (newSize[1] * 100 / appSize[1]) - 100;

            this.appSize = newSize;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            if (gameSettings == null)
            {
                gameSettings = new SettingsForm(
                    ruler, 
                    players, 
                    buttonManager, 
                    libManager, 
                    fileManager,
                    this,
                    customImageCollectionConfigurator);
            }

            SoundPlayer.PlaySettingsSound();
            gameSettings.StartPosition = FormStartPosition.Manual;
            gameSettings.Location = this.Location;
            gameSettings.StartPosition = FormStartPosition.CenterParent;
            gameSettings.BackgroundImageLayout = ImageLayout.Stretch;
            gameSettings.ShowDialog(this);
        }

        private void PuzzleTag_FormClosed(object sender, FormClosedEventArgs e)
        {
            gameSettings.Dispose();
            libManager.Dispose();
            buttonManager.Dispose();
            this.Dispose();
            //var collectionName = "car";
            //fileManager.DeleteCollection(collectionName, libManager.LibraryPath);
        }
    }
}