using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopCatalog.Entities
{
    internal class Dog : IAnimal
    {
        public string Name { get;  set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Race { get; set; }
        public DateTime Date { get; set; }

        public Dog(string name, int age, string sex, string race,DateTime date)
        {
            Name = name;
            Age = age;
            Sex = sex;
            Race = race;
            Date = date;
        }
        public override string ToString()
        {
            return $"Dog - {Name}, {Age}, {Sex}, {Race}";
        }
            
    } 
}
