using System;
using Fifo_animal_shelter;
namespace Fifo_animal_shelter
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AnimalShelterWork();           

        }
        public static void AnimalShelterWork()
        {
            Animal a1 = new Animal("dog1");
            AnimalShelter WeHope = new AnimalShelter(a1);
           WeHope.Enqueue("dog2");
            WeHope.Enqueue("cat1");
           WeHope.Enqueue("dog3");
            WeHope.Enqueue("cat2");
            WeHope.Enqueue("dog4");
            WeHope.Enqueue("dog5");
            WeHope.Enqueue("cat3");
            Console.WriteLine($"We have {WeHope.Counter} animals left in our shelter");
            Console.WriteLine("==================");
            Console.WriteLine("We have following animals available:");
            WeHope.PrintAnimalList();
            Console.WriteLine("==================");
            Animal adoptOne= WeHope.Dequeue("dog3");
            Animal adopt2 = WeHope.Dequeue("cat1");
            Animal adopt3 = WeHope.Dequeue("dog1");
            Console.WriteLine("==================");
            Console.WriteLine("=======After  Adoption==========");
            Console.WriteLine($"We have {WeHope.Counter} animals left in our shelter");
            Console.WriteLine("==================");
            Console.WriteLine("Here are the information of the adopted animals:");
            Console.WriteLine(adoptOne.type);
            Console.WriteLine(adopt2.type);
            Console.WriteLine(adopt3.type);     
            Console.WriteLine("==================");
            Console.WriteLine("==================");
            Console.WriteLine("We have following animals available:");
            WeHope.PrintAnimalList();

        }
    }
}
