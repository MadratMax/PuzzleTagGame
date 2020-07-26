using System.Windows.Forms;
using PuzzleTag.Controls;

namespace PuzzleTag.ControlProvider
{
    class ControlProvider
    {
        private ControlMap controlMap;

        public ControlProvider(ControlMap controlMap)
        {
            this.controlMap = controlMap;
        }

        public ControlProvider GetElement()
        {
            return this;
        }

        public Control ByName(string controlName)
        {
            return controlMap.GetControlByName(controlName);
        }
    }
}
