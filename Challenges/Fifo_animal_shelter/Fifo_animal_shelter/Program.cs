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
            Animal a1 = new Animal("dog");
            AnimalShelter WeHope = new AnimalShelter(a1);
           WeHope.Enqueue("dog");
            WeHope.Enqueue("cat");
           WeHope.Enqueue("dog");
            WeHope.Enqueue("cat");
            WeHope.Enqueue("dog");
            WeHope.Enqueue("dog");
            WeHope.Enqueue("dog");
            Console.WriteLine(WeHope.Counter);

            Console.WriteLine("==================");
            Console.WriteLine("==================");
            Console.WriteLine("==================");
            Animal adoptOne= WeHope.Dequeue("cat");
            Animal adopt2 = WeHope.Dequeue("cat");
            Animal adopt3 = WeHope.Dequeue("bird");
            Console.WriteLine("==================");
            Console.WriteLine("===after==adoption==========");
            Console.WriteLine("==================");
            Console.WriteLine(WeHope.Counter);
            Console.WriteLine(adoptOne.type);
            Console.WriteLine(adopt2.type);
            Console.WriteLine(adopt3);
            Console.WriteLine("==================");
            Console.WriteLine("==================");
            Console.WriteLine("==================");
  



        }
    }
}
