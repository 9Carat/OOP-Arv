using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Arv
{
    internal class GoldenRetriever : Dog
    {
        protected int aggressiveness;
        protected bool adopted;

        // Constructor for all attributes
        public GoldenRetriever(string name, int legs, string eyeColor, int age, string size, string personality, bool isGuardDog, int aggressiveness, bool adopted) : base(name, legs, eyeColor, age, size, personality, isGuardDog)
        {
            this.aggressiveness = aggressiveness;
            this.adopted = adopted;
        }
        // Constructor for relevant attributes only
        public GoldenRetriever(string name, string personality, bool isGuardDog, int aggressiveness)
        {
            this.name = name;
            this.Personality = personality;
            this.isGuardDog = isGuardDog;
            this.aggressiveness = aggressiveness;
        }
        // Constructor with default attributes
        public GoldenRetriever()
        {
            this.aggressiveness = 3;
            this.adopted = true;
        }

        public override void MakeSound()
        {
            Console.WriteLine(name + " the golden retriever says: Woof woof! ");
        }

        public override void GuardHouse()
        {
            int chanceOfSuccess;

            if (isGuardDog == true && aggressiveness > 5) // Chance of different scenarios depending on aggressiveness and whether or not the dog is a guarddog
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

            if (chanceOfSuccess > 10)
            {
                Console.WriteLine("You tell " + name + " to guard your house against intruders.");
                Console.WriteLine("During the following night, a couple of burglars tried to break into your house...");
                Console.WriteLine("The burglary attemp was unsuccessful as your dog, " + name + ", managed to scare the burglars away!");
            }
            else
            {
                Console.WriteLine("You told your dog, " + name + ", to guard your house but your if the dog understood you.");
                Console.WriteLine("During the following night, a couple of burglars tried to break into your house...");
                Console.WriteLine(name + " thought that the burglars looked friendly and started wagging its tail.");
                Console.WriteLine("The burglars sat down and gently petted " + name + " and then stole your tv, laptop, phone, money and a photo of your 93 year old grandma while " + name + " happily watched the burglars from afar.");
            }
        }

        public void DogPark()
        {
            Console.WriteLine("You take " + name + " to the local dog park.");
            Console.WriteLine(name + " blissfully chases after the other dogs at the park.");
        }
    }
}
