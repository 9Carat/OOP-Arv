namespace OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alligator alligator1 = new Alligator("Federico", 4, "yellow", 20, "Big", "Angry", 80);
            Cat cat1 = new Cat("Luna", 4, "Blue", 8, "Small", "Shy", "Shorthair");
            Rottweiler rottweiler1 = new Rottweiler("Max", 4, "Brown", 7, "Bulky", "Obedient", true, 8, 2);
            GoldenRetriever goldenRetriever1 = new GoldenRetriever("Bentley", 4, "Blue", 11, "Average", "Friendly", false, 2, true);

            alligator1.MakeSound();
            alligator1.Action();
            alligator1.CheckTeeths();
            cat1.MakeSound();
            cat1.CallAnimal();
            cat1.Hunt();
            rottweiler1.MakeSound();
            rottweiler1.CallAnimal();
            rottweiler1.GuardHouse();
            rottweiler1.ThrowBaconAtDog();
            goldenRetriever1.MakeSound();
            goldenRetriever1.PetAnimal();
            goldenRetriever1.DogPark();
            goldenRetriever1.Fetch();

            Console.ReadLine();
        }
    }
}