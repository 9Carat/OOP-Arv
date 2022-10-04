using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class Dog : Animal
    {
        public bool isGuardDog;

        public Dog(string name, int legs, string eyeColor, int age, string size, string personality, bool isGuardDog) : base(name, legs, eyeColor, age, size, personality)
        {
            this.isGuardDog = isGuardDog;
        }

        public virtual void GuardHouse()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 11);
            bool success;

            if (num <= 5)
            {
                success = false;
            }
            else
            {
                success = true;
            }

            if (success == true)
            {
                Console.WriteLine("The dog will guard your house against intruders"); // Slumpad händelse (switch?)
            }
            else
            {
                Console.WriteLine("The dog does not understand you");
            }
        }

        public void Fetch()
        {
            Console.WriteLine("You throw the ball.");
            Console.WriteLine("The dog brings the ball back!");
        }

        public override void MakeSound()
        {
            Console.WriteLine("The dog says: Woff!");
        }
    }
}
