using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopCatalog.Entities
{
    internal class Dog : IAnimal
    {
        public string Name { get;  set; }
        public int Age { get; set; }
        public string Race { get; set; }

        public Dog(string name, int age, string race)
        {
            Name = name;
            Age = age;
            Race = race;
        }
        public override string ToString()
        {
            return $"Dog - {Name}, {Age} {Race}";
        }
            
    } 
}
