using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class Animal
    {
        protected string name;
        protected int legs;
        protected string eyeColor;
        protected int age;
        protected string size;
        protected string personality; // Obedient, shy, friendly, angry

        public string Personality 
        { 
            get { return personality; } 
            set
            {
                if (value != "Obedient" || value != "Shy" || value != "Friendly" || value  != "Angry")
                {
                    personality = "Unknown";
                }
                else
                {
                    personality = value;
                }
            } 
        }

        // Constructor for all attributes
        public Animal(string name, int legs, string eyeColor, int age, string size, string personality)
        {
            this.name = name;
            this.legs = legs;
            this.eyeColor = eyeColor;
            this.age = age;
            this.size = size;
            this.personality = personality;
        }

        // Constructor with default attributes
        public Animal()
        {
            this.name = "Fido";
            this.legs = 4;
            this.eyeColor = "Blue";
            this.age = 5;
            this.size = "Average";
            this.personality = "Obedient";
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
                Console.WriteLine(name + " comes running to you.");
            }
            else
            {
                Console.WriteLine(name + " ignores you.");
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
