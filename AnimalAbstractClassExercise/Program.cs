namespace AnimalAbstractClassExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[] //new Animal[] może być pominięte w inicjalizatorze kolekcji obiektów klasy animal
            {
                new Wolf(false),
                new Hippo(),
                new Wolf(true),
                new Wolf(false),
                new Hippo()
            };

            foreach (Animal animal in animals)
            {
                animal.MakeNoise();
                if (animal is ISwimmer swimmer) swimmer.Swim();
                if (animal is IPackHunter hunter) hunter.HuntInPack();

                Console.WriteLine();
            }
        }
    }
}
