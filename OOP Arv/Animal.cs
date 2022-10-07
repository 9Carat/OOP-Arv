using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class Animal
    {
        protected string name = "Fido";
        protected int legs = 4;
        protected string eyeColor = "Blue";
        protected int age = 5;
        protected string size = "Average";
        protected string personality = "Obedient"; // Obedient, shy, friendly, angry

        public string Personality 
        { 
            get { return personality; } 
            set
            {
                if (personality != "Obedient" || personality != "Shy" || personality != "Friendly" || personality != "Angry")
                {
                    personality = "Unknown";
                }
                else
                {
                    personality = Personality;
                }
            } 
        }

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

        public void CallAnimal()
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

        public void PetAnimal()
        {
            Console.WriteLine("You crouch down and gently pet " + name);

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
