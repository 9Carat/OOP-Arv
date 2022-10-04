using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class Animal
    {
        public string name = "Fido";
        public int legs = 4;
        public string eyeColor = "Blue";
        public int age = 5;
        public string size = "Average";
        public string personality = "Obedient"; // Obedient, shy, friendly, angry

        public Animal(string name, int legs, string eyeColor, int age, string size, string personality)
        {
            this.name = name;
            this.legs = legs;
            this.eyeColor = eyeColor;
            this.age = age;
            this.size = size;
            this.personality = personality;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("The animal says: ");
        }

        public virtual void CallAnimal()
        {
            Console.WriteLine("You call for " + name);

            if (personality == "Obedient" || personality == "Friendly")
            {
                Console.WriteLine(name + " comes running to you");
            }
            else
            {
                Console.WriteLine(name + " ignores you");
            }
        }

        public virtual void PetAnimal()
        {
            if (personality == "Shy")
            {
                Console.WriteLine(name + " runs away");
            }
            else
            {
                Console.WriteLine(name + " looks happy");
            }
        }
    }
}
