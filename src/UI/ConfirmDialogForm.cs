using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleTag
{
    public partial class ConfirmDialogForm : Form
    {
        private bool yes;
        private bool no;
        private string confirmationMessage;

        public ConfirmDialogForm(string confirmationMessage)
        {
            InitializeComponent();
            this.confirmationMessage = confirmationMessage;
        }

        public bool Yes => yes;

        public bool No => no;

        private void SetupKeyDownEvents(ConfirmDialogForm confirmForm)
        {
            foreach (Control control in confirmForm.Controls)
            {
                control.KeyDown += ConfirmDialogForm_KeyDown;
            }
        }

        private void ConfirmDialogForm_Load(object sender, EventArgs e)
        {
            this.yes = false;
            ConfirmTextLabel.Text = confirmationMessage;
            SetupKeyDownEvents(this);
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            this.yes = false;
            this.no = true;
            BackToSettings();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            this.yes = true;
            this.no = false;
            BackToSettings();
        }

        private void BackToSettings()
        {
            Owner.Show();
            this.Close();
        }

        private void ConfirmDialogForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                BackToSettings();
            }
        }

        private void BackGroundButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                BackToSettings();
            }
        }
    }
}
