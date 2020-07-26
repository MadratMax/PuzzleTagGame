using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleTag.Notification
{
    class TimedPopUp : Form
    {
        public TextBox textBox;
        public int waitTime;

        public void Set(
            string msg,
            int width = 600,
            int height = 0)
        {
            this.Size = new Size(width, height);
            this.Text = msg;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ShowIcon = false;
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        async new public void Show(int waitTime = 2000)
        {
            base.Show();
            await Task.Delay(waitTime);
            this.Hide();
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
