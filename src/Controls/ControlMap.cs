using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PuzzleTag.Controls
{
    class ControlMap
    {
        private List<Control> controlMap;
        private PuzzleTag form;

        public ControlMap(PuzzleTag form)
        {
            this.form = form;
            this.controlMap = new List<Control>();
            InitializeControls();
        }

        public void AddControl(Control control)
        {
            controlMap.Add(control);
        }

        public Control GetControlByName(string name)
        {
            return controlMap.FirstOrDefault(n => n.Name == name);
        }

        private void InitializeControls()
        {
            GetAllControls(this.form);
        }

        private void GetAllControls(Control container)
        {
            foreach (Control c in container.Controls)
            {
                GetAllControls(c);
                if (c is Button) controlMap.Add(c);
                if (c is TextBox) controlMap.Add(c);
                if (c is Label) controlMap.Add(c);
                if (c is CheckBox) controlMap.Add(c);
                if (c is ComboBox) controlMap.Add(c);
                if (c is ToolTip) controlMap.Add(c);
            }
        }
    }
}
