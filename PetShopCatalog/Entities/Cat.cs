using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopCatalog.Entities
{
    internal class Cat : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Sex { get; set; }

        public string Race { get; set; }


        public override string ToString()
        {
            return $"Cat - {Name}, {Sex} {Age} {Race}";
        }
    
    
    
    }
}
