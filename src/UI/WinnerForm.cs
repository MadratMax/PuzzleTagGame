using System;
using System.Windows.Forms;

namespace PuzzleTag.UI
{
    public partial class WinnerForm : Form
    {
        public WinnerForm()
        {
            InitializeComponent();
        }

        private void CloseWinImageButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WinnerForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void WinnerForm_Load(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void CloseWinImageButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
