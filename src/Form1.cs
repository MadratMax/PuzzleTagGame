using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using PuzzleTag.Collection;
using PuzzleTag.Configuration;
using PuzzleTag.Controls;
using PuzzleTag.FileManager;
using PuzzleTag.Game;

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

        public PuzzleTag()
        {
            InitializeComponent();
        }

        private void PuzzleTag_Load(object sender, EventArgs e)
        {
            SetupClickEvents(this);
            InitializeControls(this);
            SetupConfiguration();
            InitGameRules();
            InitializeGameData();
            InitPlayers();
            this.appSize = new int[] {this.Size.Width, this.Size.Height};
        }

        private void InitPlayers()
        {
            players = new Players();
            players.AddPlayer(Settings.Player1Name, Settings.Player1AvaImage);
            players.AddPlayer(Settings.Player2Name, Settings.Player2AvaImage);
            players.AddPlayer(Settings.Player3Name, Settings.Player3AvaImage);
        }

        private void SetupClickEvents(Control container)
        {
            foreach (Control control in container.Controls)
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
            this.ruler = new Ruler(buttonManager, customButtonsCollection, libManager);
        }

        private void InitializeGameData()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = false;
                this.Invoke((Action)(() => InfoLabel.Text = "Initializing..."));
                InitializeLibrary();
                buttonManager.AssignImages(GameState.Category);
                buttonManager.SetClosedCardImages();
                buttonManager.HideButtonImages();
            }).Start();
        }

        private void InitializeLibrary()
        {
            libManager.InitializeLibrary();
            this.Invoke((Action)(() => InfoLabel.Text = ""));
        }

        private void HandleClicks(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            if (control.Name.Contains("CustomButton"))
            {
                ruler.OpenCard(control.Name);
                if (ruler.RoundWin)
                {
                    InfoLabel.Text = "Win!";
                }
                else
                {
                    InfoLabel.Text = "";
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
                gameSettings = new SettingsForm(ruler, players, buttonManager, libManager, this);
            }

            gameSettings.StartPosition = FormStartPosition.Manual;
            gameSettings.Location = this.Location;
            gameSettings.StartPosition = FormStartPosition.CenterParent;
            gameSettings.ShowDialog(this);
        }
    }
}