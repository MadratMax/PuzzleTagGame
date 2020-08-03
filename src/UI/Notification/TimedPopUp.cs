using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuzzleTag.SoundMaster;

namespace PuzzleTag.Notification
{
    class TimedPopUp : Form
    {
        public void Set(
            string msg,
            FormStartPosition position = FormStartPosition.CenterScreen,
            int width = 600,
            int height = 0
            )
        {
            this.Size = new Size(width, height);
            this.Text = msg;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ShowIcon = false;
            this.ControlBox = false;
            this.StartPosition = position;
        }

        async new public void Show(int waitTime = 2000, bool autoHide = true)
        {
            base.Show();

            if (autoHide)
            {
                await Task.Delay(waitTime);
                this.Hide();
            }
        }

        async new public void ShowError(int waitTime = 3000, bool autoHide = true)
        {
            SoundPlayer.PlayFailedImageSound();
            base.Show();

            if (autoHide)
            {
                await Task.Delay(waitTime);
                this.Hide();
            }
        }

        public void ShowCriticalError(string message)
        {
            GetConfirmStatus(message);

            Application.Exit();
        }

        public void HideForm()
        {
            this.Hide();
        }

        private ConfirmDialogForm GetConfirmStatus(string confirmMessage)
        {
            var confirm = new ConfirmDialogForm(confirmMessage);
            confirm.YesButton.Text = "Ok";
            confirm.NoButton.Enabled = false;
            confirm.NoButton.Visible = false;
            confirm.ConfirmTextLabel.Location = new Point(14, 10);
            confirm.StartPosition = FormStartPosition.Manual;
            confirm.Location = this.Location;
            confirm.StartPosition = FormStartPosition.CenterParent;
            confirm.BackgroundImageLayout = ImageLayout.Stretch;
            this.Enabled = false;
            confirm.ShowDialog(this);
            return confirm;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TimedPopUp
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "TimedPopUp";
            this.Load += new System.EventHandler(this.TimedPopUp_Load);
            this.ResumeLayout(false);

        }

        private void TimedPopUp_Load(object sender, System.EventArgs e)
        {

        }
    }
}
