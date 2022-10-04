using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class Cat : Animal
    {
        public string fur;

        public Cat(string name, int legs, string eyeColor, int age, string size, string personality, string fur) : base(name, legs, eyeColor, age, size, personality)
        {
            this.fur = fur;
        }

        public void Hunt()
        {
            Console.WriteLine("The cat comes back with a: "); // Slumpad händelse (switch?)
        }

        public override void MakeSound()
        {
            Console.WriteLine("The cat says: Mjau!");
        }
    }
}
