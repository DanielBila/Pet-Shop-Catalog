using PetShopCatalog.Entities;
using PetShopCatalog.Service;
using System.Globalization;

namespace PetShopCatalog
{
    internal class Program
    {
		 static void Main(string[] args)
        {

            try
            {
                List<IAnimal> animals = new List<IAnimal>();
                Connection c = new Connection();
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(c);
                    int choosl = int.Parse(Console.ReadLine());
                    switch (choosl)
                    {
                        case 1:
                            Console.Clear();
                            c.ListPrint(animals);
                            Console.ReadLine();
                            break;

                        case 2:
                            Console.Clear();
                            c.AddAnimal(animals);
                            break;

                        case 3:
                            Console.Clear();
                            c.RemoveAnimalByIndex(animals);
                            break;
                        case 9:
                            return;
                            break;
                    }
                }

            }
            catch (IOException m)
            {
                Console.WriteLine(m.Message);
            }
            catch (ApplicationException m)
            {
                Console.WriteLine(m.Message);
            }
            catch (FormatException m)
            {
                Console.WriteLine(m.Message);
            }
            catch (ArgumentNullException m)
            {
                Console.WriteLine(m.Message);
            }
            catch (ArgumentException m)
            {
                Console.WriteLine(m.Message);
            }
            catch (UnauthorizedAccessException m)
            {
                Console.WriteLine(m.Message);
            }

        }
    }
}



       
