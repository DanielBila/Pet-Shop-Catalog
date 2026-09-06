using PetShopCatalog.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopCatalog.Service
{
    internal class Connection
    {
        public void ListPrint<T>(List<T> list)
        {
            Console.WriteLine("Type   Name  Age Race");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        public void AddList<T>(List<T> values)
        {
            Console.WriteLine("Entar the which animal: ");
            string animal = Console.ReadLine();
            Console.WriteLine($"Name {animal}");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter the age in {name}");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the race in {name}");
            string race = Console.ReadLine();

            values.Add(new animal(name, age, race));






        }





        public override string ToString()
        {
            return """
                TotalList - 1
                Add Animal - 2
                Removie Animal - 3
                Exit - 9
                """;
        }


    }
}