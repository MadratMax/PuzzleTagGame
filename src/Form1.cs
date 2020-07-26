using System;
using System.Threading;
using System.Windows.Forms;
using PuzzleTag.Collection;
using PuzzleTag.Configuration;
using PuzzleTag.Controls;
using PuzzleTag.FileManager;

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

        public PuzzleTag()
        {
            InitializeComponent();
        }

        private void InitializeLibrary()
        {
            libManager.InitializeLibrary();
            this.Invoke((Action)(() => InfoLabel.Text = ""));
            this.Invoke((Action)(() => CategoryComboBox.DataSource = GameState.Categories));
        }

        private void InitializeControls(PuzzleTag form)
        {
            controlMap = new ControlMap(form);
            controlProvider = new ControlProvider.ControlProvider(controlMap);
            customButtonsCollection = new ButtonsCollection(controlMap);
            customButtonsCollection.InitializeByButtonNameAttribute("custom");
        }

        private void PuzzleTag_Load(object sender, EventArgs e)
        {
            InitializeControls(this);
            SetupConfiguration();
            this.appSize = new int[] {this.Size.Width, this.Size.Height};
        }

        private void SetupConfiguration()
        {
            this.libManager = new ImageLibraryManager();
            this.buttonManager = new CustomButtonsManager(customButtonsCollection, libManager);
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            this.Invoke((Action)(() => customButtonsCollection.Shuffle()));

            if (buttonManager != null)
            {
                this.Invoke((Action)(() => HideImagesButton.PerformClick()));
                buttonManager.AssignImages(GameState.Category);
            }
        }

        private void PuzzleTag_ResizeEnd(object sender, EventArgs e)
        {
            var newSize = new int[] { this.Size.Width, this.Size.Height };

            var diffPersentageX = (newSize[0] * 100 / appSize[0]) - 100;
            var diffPersentageY = (newSize[1] * 100 / appSize[1]) - 100;

            this.appSize = newSize;
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetImageButton_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = false;
                this.Invoke((Action)(() => InfoLabel.Text = "Initializing..."));
                InitializeLibrary();
                buttonManager.AssignImages(GameState.Category);
                buttonManager.SetClosedCardImages();
            }).Start();
        }

        private void ShowImageButton_Click(object sender, EventArgs e)
        {
            buttonManager.ShowButtonImages();
        }

        private void HideImagesButton_Click(object sender, EventArgs e)
        {
            buttonManager.HideButtonImages();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GameState.Category = CategoryComboBox.Text;
        }

        private void CustomButton7_Click(object sender, EventArgs e)
        {

        }

        private void CustomButton1_Click(object sender, EventArgs e)
        {
            var button = customButtonsCollection.GetCustomButtonByName("CustomButton1");

            if (button.Closed)
            {
                button.ShowImage();
            }
            else
            {
                button.ShowClosedCardImage();
            }
        }
    }
}