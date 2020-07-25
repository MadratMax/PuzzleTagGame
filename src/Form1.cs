using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuzzleTag.Controls;

namespace PuzzleTag
{
    public partial class PuzzleTag : Form
    {
        private ControlMap controlMap;

        public PuzzleTag()
        {
            InitializeComponent();
        }

        private void InitializeControls(PuzzleTag form)
        {
            controlMap = new ControlMap(form);
            controlMap.AddControl(reloadButton);
            controlMap.AddControl(button1);
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            var Button1Control = controlMap.GetControlByName("button3");
        }

        private void PuzzleTag_Load(object sender, EventArgs e)
        {
            InitializeControls(this);
        }
    }
}
