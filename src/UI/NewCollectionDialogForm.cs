using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PuzzleTag.FileManager;

namespace PuzzleTag.UI
{
    partial class NewCollectionDialogForm : Form
    {
        private ImageLibraryManager libManager;
        private string collectionName;

        public NewCollectionDialogForm()
        {
            InitializeComponent();
        }

        public string CollectionName => collectionName;

        public string ResetCollectionName() => collectionName = null;

        private void NewCollectionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NewCollectionTextBox.Text != string.Empty)
            {
                NewCollectionLabel.Visible = false;
            }
            else
            {
                NewCollectionLabel.Visible = true;
            }
        }

        private void GenerateCollectionButton_Click(object sender, EventArgs e)
        {
            collectionName = NewCollectionTextBox.Text;
            BackToSettings();
        }

        private void BackToSettings()
        {
            Owner.Show();
            this.Close();
        }

        private void NewCollectionDialogForm_Load(object sender, EventArgs e)
        {
            SetupKeyDownEvents(this);
            NewCollectionTextBox.Text = string.Empty;
            NewCollectionTextBox.Focus();
        }

        private void SetupKeyDownEvents(NewCollectionDialogForm newCollectionForm)
        {
            foreach (Control control in newCollectionForm.Controls)
            {
                control.KeyDown += NewCollectionDialogForm_KeyDown;
            }
        }

        private void NewCollectionDialogForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                BackToSettings();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            BackToSettings();
        }

        private void NewCollectionTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(NewCollectionTextBox.Text))
                {
                    collectionName = NewCollectionTextBox.Text;
                }

                BackToSettings();
            }
        }

        private void NewCollectionDialogForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
