using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleTag.UI
{
    public partial class CustomCollectionNameDialogForm : Form
    {
        private string collectionName;

        public CustomCollectionNameDialogForm()
        {
            InitializeComponent();
        }

        public string GetCollectionName()
        {
            return collectionName;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            BackToSettings();
        }

        private void BackToSettings()
        {
            Owner.Show();
            this.Close();
        }

        private void NewCollectionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NewCollectionTextBox.Text))
            {
                SaveCollectionNameButton.Enabled = false;
                collectionName = null;
            }
            else
            {
                SaveCollectionNameButton.Enabled = true;
            }
        }

        private void SaveCollectionNameButton_Click(object sender, EventArgs e)
        {
            collectionName = NewCollectionTextBox.Text;
            BackToSettings();
        }

        private void CustomCollectionNameDialogForm_Load(object sender, EventArgs e)
        {
            SaveCollectionNameButton.Enabled = false;
            SetupKeyDownEvents(this);
        }

        private void SetupKeyDownEvents(CustomCollectionNameDialogForm customCollectionNameDialogForm)
        {
            foreach (Control control in customCollectionNameDialogForm.Controls)
            {
                control.KeyDown += CustomCollectionNameDialogForm_KeyDown;
            }
        }

        private void CustomCollectionNameDialogForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveCollectionNameButton.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                BackToSettings();
            }
        }
    }
}
