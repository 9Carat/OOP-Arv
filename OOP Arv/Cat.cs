using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class Cat : Animal
    {
        protected string fur = "Short";

        public Cat(string name, int legs, string eyeColor, int age, string size, string personality, string fur) : base(name, legs, eyeColor, age, size, personality)
        {
            this.fur = fur;
        }

        public void Hunt()
        {
            Console.WriteLine(name + " goes away on a hunt");

            Random rnd = new Random();
            int selection = rnd.Next(1, 5);

            switch (selection)
            {
                case 1:
                    Console.WriteLine(name + " comes back with a dead mouse!");
                    break;
                case 2:
                    Console.WriteLine(name + " comes back with a mouse that is still alive!");
                    break;
                case 3:
                    Console.WriteLine(name + " comes back with a leaf!");
                    break;
                case 4:
                    Console.WriteLine(name + " comes back with a stick!");
                    break;
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine(name + " the cat says: Mjau!");
        }
    }
}
