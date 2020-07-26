using System;
using System.Drawing;
using System.Windows.Forms;
using PuzzleTag.Collection;
using PuzzleTag.Controls;

namespace PuzzleTag
{
    public partial class PuzzleTag : Form
    {
        private int[] appSize;
        private ControlMap controlMap;
        private ControlProvider.ControlProvider controlProvider;
        private ButtonsCollection customButtonsCollection;
        private CustomButtonsManager buttonManager;

        public PuzzleTag()
        {
            InitializeComponent();
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
            this.buttonManager = new CustomButtonsManager(customButtonsCollection);
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            //this.controlProvider.GetElement().ByName("CustomButton5").Enabled = false;
            //customButtonsCollection.GetCustomButtonByName("CustomButton3").Visible = false;
            //customButtonsCollection.GetCustomButtonByIndex(8).Text = Generator.GetRandomNumber();

            this.Invoke((Action)(() => customButtonsCollection.Shuffle()));

            //var gen = new ButtonGenerator();
            //gen.GenerateButtons(3, 130, 130, 61, 300);

            //var newButtons = gen.GetButtons();

            //foreach (var button in newButtons)
            //{
            //    this.Controls.Add(button);
            //}
        }

        private void PuzzleTag_ResizeEnd(object sender, EventArgs e)
        {
            var newSize = new int[] { this.Size.Width, this.Size.Height };

            var diffPersentageX = (newSize[0] * 100 / appSize[0]) - 100;
            var diffPersentageY = (newSize[1] * 100 / appSize[1]) - 100;

            this.appSize = newSize;

            //buttonManager.ResizeButtons(appSize, diffPersentageX + diffPersentageY);
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetImageButton_Click(object sender, EventArgs e)
        {
            var image = System.Drawing.Image.FromFile(@"C:\Users\mgaydideev\Downloads\PuzzleTagImages\animals\alexandru-rotariu-o_QTeyGVWjQ-unsplash.jpg");
            var button = customButtonsCollection.GetCustomButtonText("3");
            button.SetImage(image);
            this.Invoke((Action)(() => button.ShowImage()));
        }
    }
}