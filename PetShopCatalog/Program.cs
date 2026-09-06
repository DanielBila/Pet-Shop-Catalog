using PetShopCatalog.Entities;
using PetShopCatalog.Service;
using System.Globalization;

namespace PetShopCatalog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>();
            Connection c = new Connection();
            while (true){
                Console.WriteLine(c);
                int choosl = int.Parse(Console.ReadLine());
                switch (choosl)
                {
                    case 1:
                        Console.Clear();
                        c.ListPrint(animals);
                        Console.ReadLine();
                        break;

                     
                    




                }





            }



           




           



          

        }
    }
}
