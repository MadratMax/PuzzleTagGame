using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using PuzzleTag.Controls;
using PuzzleTag.RandomGenerator;

namespace PuzzleTag.Collection
{
    class ButtonsCollection
    {
        private ControlMap controlMap;
        private IDictionary<int, CustomButton> collection;

        public ButtonsCollection(ControlMap controlMap)
        {
            this.controlMap = controlMap;
            this.collection = new Dictionary<int, CustomButton>();
        }

        public CustomButton GetCustomButtonByName(string name)
        {
            return collection.Values.FirstOrDefault(n => n.GetName() == name);
        }

        public CustomButton GetCustomButtonText(string text)
        {
            return collection.Values.FirstOrDefault(n => n.Text == text);
        }

        public CustomButton GetCustomButtonByIndex(int index)
        {
            return collection[index];
        }

        public IDictionary<int, CustomButton> GetAllButtons()
        {
            return collection;
        }

        public void InitializeByButtonNameAttribute(string nameAttribute)
        {
            foreach (var button in controlMap.GetButtons())
            {
                if (button.Name.ToLower().Contains(nameAttribute.ToLower()))
                {
                    AddButton(button);
                }
            }
        }

        public void Shuffle()
        {
            var range = NumberGenerator.GetRandomRange(1, collection.Count);
            int i;

            foreach (var button in collection)
            {
                button.Value.Text = NumberGenerator.GetRandomFromRange().ToString();
            }
        }

        private void AddButton(Button button)
        {
            var newCustomButton = new CustomButton(button);
            int index;
            var isInt = int.TryParse(button.Text, out index);
            
            if(isInt) collection.Add(index, newCustomButton);
        }
    }
}
