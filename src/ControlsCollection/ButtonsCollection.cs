using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using PuzzleTag.Controls;
using PuzzleTag.FileManager;
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
            int id = 1;

            foreach (var button in controlMap.GetButtons())
            {
                if (button.Name.ToLower().Contains(nameAttribute.ToLower()))
                {
                    AddButton(id++, button);
                }
            }
        }

        public void Shuffle()
        {
            var range = NumberGenerator.GetRandomRange(1, collection.Count);

            foreach (var button in collection)
            {
                button.Value.Id = NumberGenerator.GetRandomFromRange();
            }
        }

        private void AddButton(int id, Button button)
        {
            var newCustomButton = new CustomButton(button);
            newCustomButton.Id = id;
            collection.Add(id, newCustomButton);
        }
    }
}
