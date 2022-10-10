using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class Dog : Animal
    {
        protected bool isGuardDog;

        // Constructor for all attributes
        public Dog(string name, int legs, string eyeColor, int age, string size, string personality, bool isGuardDog) : base(name, legs, eyeColor, age, size, personality) 
        {
            this.isGuardDog = isGuardDog;
        }

        // Constructor for relevant attributes only
        public Dog(string name, string personality, bool isGuardDog) 
        {
            this.name = name;
            this.Personality = personality;
            this.isGuardDog = isGuardDog;
        }

        // Constructor with default attributes
        public Dog() 
        {
            this.name = "Fido";
            this.Personality = "Obedient";
            this.isGuardDog = false;
        }

        public virtual void GuardHouse()
        {
            int num;

            if (isGuardDog)
            {
                Random rnd = new Random();
                num = rnd.Next(1, 26); // Chance of success = 80 %
            } else
            {
                Random rnd = new Random();
                num = rnd.Next(1, 11); // Chance of success = 50 %
            }

            if (num >= 5)
            {
                Console.WriteLine("You tell " + name + " to guard your house.");
                Console.WriteLine(name + " will guard your house against intruders.");
            }
            else
            {
                Console.WriteLine("You tell " + name + " to guard your house");
                Console.WriteLine(name + " does not understand you but smiles anyway.");
            }
        }

        public void Fetch()
        {
            Console.WriteLine("You throw the ball as far as you can.");
            Console.WriteLine(name + " comes back with the ball!");
        }

        public override void MakeSound()
        {
            Console.WriteLine(name + " says: Woff!");
        }
    }
}
