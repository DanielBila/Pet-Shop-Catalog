using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopCatalog.Entities
{
    interface IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Race { get; set; }
        public DateTime Date { get; set; }
    }
}
