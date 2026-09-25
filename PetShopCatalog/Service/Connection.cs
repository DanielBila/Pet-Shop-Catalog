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
            if (list.Count <= 0)
            {
                Console.WriteLine("Void list");
                return;
            }
                
            Console.WriteLine("Type   Name  Age Sex Race");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
        public void AddAnimal(List<IAnimal> values)
        {
            Console.WriteLine("Enter the type of animal (dog/cat): ");
            string animalType = Console.ReadLine();
            Console.WriteLine("Enter the name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Enter the age of {name}: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter the sex of {name}: ");
            string sex = Console.ReadLine();
            Console.WriteLine($"Enter the race of {name}: ");
            string race = Console.ReadLine();

            IAnimal newAnimal = animalType.ToLower() switch
            {
                "dog" => new Dog(name, age, sex, race,DateTime.Now),
                "cat" => new Cat(name, age, sex, race,DateTime.Now),
                _ => throw new ArgumentException("Tipo invalido")
            };

            values.Add(newAnimal);
        }
        public void RemoveAnimalByIndex(List<IAnimal> values)
        {
            if (values.Count == 0)
            {
                Console.WriteLine("Void list");
                Console.Read();
                return;
            }

            Console.WriteLine("Current animals:");
            for (int i = 0; i < values.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {values[i].Name} ({values[i].Race}, {values[i].Age} anos)");
            }

            Console.WriteLine("Enter the number of the animal to remove: ");
            int index = int.Parse(Console.ReadLine()) - 1;

            if (index < 0 || index >= values.Count)
            {
                Console.WriteLine("Invalid index.");
                Console.Read();
                return;
            }

            Console.WriteLine($"{values[index].Name} removed successfully!");
            values.RemoveAt(index);
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