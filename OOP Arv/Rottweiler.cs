using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class Rottweiler : Dog
    {
        public int aggressiveness = 7; // 1-10
        public int hunger = 3; // 1-10

        public Rottweiler(string name, int legs, string eyeColor, int age, string size, string personality, bool isGuardDog, int aggressiveness, int hunger) : base(name, legs, eyeColor, age, size, personality, isGuardDog)
        {
            this.aggressiveness = aggressiveness;
            this.hunger = hunger;
        }

        public override void MakeSound()
        {
            Console.WriteLine(name + " the rottweiler says: Woof! ");
        }

        public override void GuardHouse()
        {
            int chanceOfSuccess;

            if (isGuardDog == true && aggressiveness > 5)
            {
                Random rnd = new Random();
                chanceOfSuccess = rnd.Next(1, 61); // chance of success 83 %
            }
            else if (isGuardDog == true && aggressiveness <= 5)
            {
                Random rnd = new Random();
                chanceOfSuccess = rnd.Next(1, 41); // chance of success 75 %
            }
            else if (isGuardDog == false && aggressiveness > 5)
            {
                Random rnd = new Random();
                chanceOfSuccess = rnd.Next(1, 21); // chance of success 50 %
            }
            else
            {
                Random rnd = new Random();
                chanceOfSuccess = rnd.Next(1, 12); // chance of success 9 %
            }

            if(chanceOfSuccess > 10)
            {
                Console.WriteLine("You tell " + name + " to guard your house against intruders");
                Console.WriteLine("During the following night, a couple of burglars tries to break into your house...");
                Console.WriteLine("The burglary attempt was unsuccesful as your dog, " + name + ", managed to scare the burglars away!");
            }
            else
            {
                Console.WriteLine("You told your dog, " + name + ", to guard your house but you dont know if the dog understood you.");
                Console.WriteLine("During the following night, a couple of burglars tried to break into your house...");
                Console.WriteLine(name + " thought that the burglars looked friendly and started wagging its tail.");
                Console.WriteLine("The burglars sat down and gently petted " + name + " and then stole your tv, laptop, phone, money and a photo of your 93 year old grandma while " + name + " happily watched the burglars from afar.");
            }

            Console.WriteLine(chanceOfSuccess);
        }

        public override void PetAnimal()
        {
            if (personality == "Shy")
            {
                Console.WriteLine(name + " runs away");
            }
            else
            {
                Console.WriteLine(name + " looks happy");
            }
        }

        public void ThrowBaconAtDog()
        {
            Console.WriteLine("You throw a piece of bacon towards " + name + ".");
            Console.WriteLine(name + " graciously eats the bacon!");
        }
    }
}
