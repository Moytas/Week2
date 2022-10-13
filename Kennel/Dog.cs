using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel
{
    public class Dog : Animal
    {
        public string Age;
        public string Colour;

        public enum Medicine
        {
            aspirin,
            depon,
            viagra,
            norgesic,

        };

        private Medicine CurrentlyOn;

        public Dog()
        {
            CanBark = true;
        }

        public Dog(int room)
        {
            NumberOfRoom = room;
        }

        public void ChangeMedicine(Medicine newMedicine)
        {
            CurrentlyOn = newMedicine;
        }

        public Dog(string name)
        {
            Name = name;
        }

       public Dog(string name, string age, string colour)
        {
            Name = name;
            Age = age;
            Colour = colour;
        }

        public void Birthday()
        {
            Age = (int.Parse(Age) + 1).ToString();

        }
    }
}
