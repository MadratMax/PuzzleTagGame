using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PuzzleTag.Controls
{
    class ControlMap
    {
        private List<Control> controlMap;
        private List<Button> buttonControlMap;
        private List<TextBox> textBoxControlMap;
        private List<Label> labelBoxControlMap;
        private PuzzleTag form;

        public ControlMap(PuzzleTag form)
        {
            this.form = form;
            this.controlMap = new List<Control>();
            this.textBoxControlMap = new List<TextBox>();
            this.buttonControlMap = new List<Button>();
            this.labelBoxControlMap = new List<Label>();

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

        public List<Button> GetButtons()
        {
            return buttonControlMap;
        }

        public List<TextBox> GetTextBoxes()
        {
            return textBoxControlMap;
        }

        public List<Label> GetLabels()
        {
            return labelBoxControlMap;
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

                if (c is Button)
                {
                    controlMap.Add(c);
                    buttonControlMap.Add((Button)c);
                }

                if (c is TextBox)
                {
                    controlMap.Add(c);
                    textBoxControlMap.Add((TextBox)c);
                }

                if (c is Label)
                {
                    controlMap.Add(c);
                    labelBoxControlMap.Add((Label)c);
                }

                if (c is CheckBox)
                {
                    controlMap.Add(c);
                }

                if (c is ComboBox)
                {
                    controlMap.Add(c);
                }

                if (c is ToolTip)
                {
                    controlMap.Add(c);
                }
            }
        }
    }
}
