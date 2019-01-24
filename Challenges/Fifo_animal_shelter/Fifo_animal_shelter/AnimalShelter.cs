using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fifo_animal_shelter
{
    public class AnimalShelter
    {
        public Animal Front { get; set; }
        public Animal Rear { get; set; }
        public int Counter { get; set; }

        public AnimalShelter(Animal animal)
        {
            Front = animal;
            Rear = animal;
            Counter = 1;
        }


        public void Enqueue(string animalType)
        {
            Animal an = new Animal(animalType);

            Rear.next = an;
            Rear = an;
            Counter++;
        }

        List<Animal> list = new List<Animal>();

        public Animal Dequeue(string pref)
        {

            if (list.Any())
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].type == pref)
                    {
                        Counter--;
                        Animal cc = new Animal(pref);
                        list.Remove(list[i]);
                        return cc;
                    }
                }
            }

            else
            {
                if (Front.type == pref)
                {
                    Animal temp = Front;
                    Counter--;
                    Front = Front.next;
                    temp.next = null;
                    return temp;
                }

                while (Front.next != null)
                {
                    Animal temp = Front;
                    list.Add(temp);
                    Front = Front.next;
                    temp.next = null;


                    if (Front.type == pref)
                    {
                        Animal temp2 = Front;
                        Counter--;
                        Front = Front.next;
                        temp2.next = null;
                        return temp2;
                    }
                    
                }
              
            }
           
            Animal notExsit = new Animal(pref);
            Console.WriteLine($"Your request is null,no {notExsit.type} exsits in our shelter");
            return notExsit;        

        }



        public void PrintAnimalList()
        {
            if (list.Any())
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i].type);

                }
            }
            else
            {
                while (Front.next != null)
                {
                    Animal temp = Front;
                    Console.WriteLine(Front.type);
                    Front = Front.next;
                    list.Add(temp);
                    temp.next = null;
                }


                Console.WriteLine(Front.type);
                Animal temp4 = Front;
                Front = Front.next;
                list.Add(temp4);
                temp4.next = null;

                for (int i = 0; i < list.Count; i++)
                {
                    Enqueue(list[i].type);
                    Counter--;
                }

            }
        }

    }
}