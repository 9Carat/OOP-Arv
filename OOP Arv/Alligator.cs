using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class Alligator : Animal
    {
        public int teeths = 80;

        public Alligator(string name, int legs, string eyeColor, int age, string size, string personality, int teeths) : base(name, legs, eyeColor, age, size, personality)
        {
            this.teeths = teeths;
        }

        public override void MakeSound()
        {
            Console.WriteLine(name + ", the alligator says: Rrrrrrrr!");
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
    }
}
