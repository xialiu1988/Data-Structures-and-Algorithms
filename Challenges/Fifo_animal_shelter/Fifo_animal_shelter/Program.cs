using System;
using Fifo_animal_shelter;
namespace Fifo_animal_shelter
{
   public class Program
    {
        static void Main(string[] args)
        {

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
            Console.WriteLine($"We have {WeHope.Counter} animals left in our shelter:");
            WeHope.PrintAnimalList();
            Console.WriteLine("==================");
            Console.WriteLine("======= Adopting==========");
            Console.WriteLine("==================");
            Console.WriteLine("Here are the information of the adopted animals:");
            Animal adoptOne= WeHope.Dequeue("dog3");
            Console.WriteLine(adoptOne.type);
            Animal adopt2 = WeHope.Dequeue("cat1");
            Console.WriteLine(adopt2.type);
            Animal adopt3 = WeHope.Dequeue("dog1");
            Console.WriteLine(adopt3.type);
            Animal adopt4 = WeHope.Dequeue("bird");
            Animal adopt5 = WeHope.Dequeue("lizard");
            Console.WriteLine("==================");           
            Console.WriteLine($"We have {WeHope.Counter} animals left in our shelter:");
            WeHope.PrintAnimalList();

        }
    }
}
