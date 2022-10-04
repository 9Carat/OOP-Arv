using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class Animal
    {
        public string name;
        public int legs;
        public string eyeColor;
        public int age;
        public string size;
        public string personality;

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

        public virtual void CallAnimal(string personality)
        {
            if (personality == "Obedient")
            {
                Console.WriteLine("The animal comes running to you");
            }
            else
            {
                Console.WriteLine("The animal ignores you");
            }
        }

        public virtual void PetAnimal(string personality)
        {
            if (personality == "Shy")
            {
                Console.WriteLine("The animal runs away");
            }
            else
            {
                Console.WriteLine("The animal looks happy");
            }
        }
    }
}
