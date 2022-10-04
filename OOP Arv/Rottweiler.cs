using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class Rottweiler : Dog
    {
        public int aggressiveness;
        public int hunger;

        public Rottweiler(string name, int legs, string eyeColor, int age, string size, string personality, bool isGuardDog, int aggressiveness, int hunger) : base(name, legs, eyeColor, age, size, personality, isGuardDog)
        {
            this.aggressiveness = aggressiveness;
            this.hunger = hunger;
        }

        public override void GuardHouse()
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
    }
}
