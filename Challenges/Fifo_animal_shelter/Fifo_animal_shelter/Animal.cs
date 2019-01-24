using System;
using System.Collections.Generic;
using System.Text;

namespace Fifo_animal_shelter
{
   public class Animal
    {
        public string type { get; set; }
        public Animal next { get; set; }
        public Animal(string typeAnimal)
        {
            type = typeAnimal;

        }


    }
}
