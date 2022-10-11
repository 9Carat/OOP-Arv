using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class Alligator : Animal
    {
        protected int teeths;

        // Constructor for all attributes
        public Alligator(string name, int legs, string eyeColor, int age, string size, string personality, int teeths) : base(name, legs, eyeColor, age, size, personality)
        {
            this.teeths = teeths;
        }

        // Constructor for relevant attributes only
        public Alligator(string name, string personality, int teeths)
        {
            this.name = name;
            this.Personality = personality;
            this.teeths = teeths;
        }

        // Constructor with default attributes
        public Alligator()
        {
            this.teeths = 80;
        }

        public override void MakeSound()
        {
            Console.WriteLine(name + " the alligator says: Rrrrrrrr!");
        }

        public void Action()
        {
            Random rnd = new Random();
            int selection = rnd.Next(1, 4);

            switch (selection)
            {
                case 1:
                    Console.WriteLine(name + " is sleeping.");
                    break;
                case 2:
                    Console.WriteLine(name + " is eating.");
                    break;
                case 3:
                    Console.WriteLine(name + " is hunting for food.");
                    break;
            }
        }

        public void CheckTeeths()
        {
            Console.WriteLine("You decide to inspect " + name + "s teeths.");
            Console.WriteLine(name + " has " + teeths + " teeths and they look pretty sharp!");
        }
    }
}
