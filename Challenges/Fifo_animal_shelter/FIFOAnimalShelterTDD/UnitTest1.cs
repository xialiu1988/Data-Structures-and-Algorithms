using System;
using Xunit;
using Fifo_animal_shelter;
namespace FIFOAnimalShelterTDD
{
    public class UnitTest1
    {
        [Fact]
        public void CanEnqueueADog()
        {

            Animal a1 = new Animal("dog1");
            AnimalShelter WeHope = new AnimalShelter(a1);
            WeHope.Enqueue("dog2");
            Assert.Equal("dog2", WeHope.Rear.type);
        }



        [Fact]
        public void CanEnqueueAcat()
        {

            Animal a1 = new Animal("dog1");
            AnimalShelter WeHope = new AnimalShelter(a1);
            WeHope.Enqueue("cat1");
            Assert.Equal("cat1", WeHope.Rear.type);
        }



        [Fact]
        public void CanEnqueueAnAnimal()
        {
            Animal a1 = new Animal("dog1");
            AnimalShelter WeHope = new AnimalShelter(a1);
            WeHope.Enqueue("cat1");
            WeHope.Enqueue("cat2");
            Assert.Equal("cat2", WeHope.Rear.type);
        }



        [Fact]
        public void CanDequeueADog()
        {
            Animal a1 = new Animal("dog1");
            AnimalShelter WeHope = new AnimalShelter(a1);
            WeHope.Enqueue("cat1");
            WeHope.Dequeue("dog1");
            Assert.Equal("cat1", WeHope.Front.type);
        }



        [Fact]
        public void CanDequeueAcat()
        {
            Animal a1 = new Animal("dog1");
            AnimalShelter WeHope = new AnimalShelter(a1);
            WeHope.Enqueue("cat1");
            WeHope.Enqueue("cat2");
            WeHope.Dequeue("cat1");
            Assert.Equal(2, WeHope.Counter);
        }



        [Fact]
        public void CanNOtDequeueAbird()
        {
            Animal a1 = new Animal("dog1");
            AnimalShelter WeHope = new AnimalShelter(a1);
            WeHope.Enqueue("cat1");
            WeHope.Enqueue("cat2");
             WeHope.Dequeue("bird");
            Assert.True(WeHope.Dequeue("bird")==null);
        }

    }
}
