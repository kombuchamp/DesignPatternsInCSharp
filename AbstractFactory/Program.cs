using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ColaFactory(); // Create concrete factory
            var client = new SoftDrinkAssembler(factory); // Create client object
            client.AssembleDrink(); // Let client arrange stuff between related objects

            Console.WriteLine(new string('-', 40));

            var anotherFactory = new OrangeSodaFactory(); // Create another factory
            client = new SoftDrinkAssembler(anotherFactory); // Create another instance of factory
            client.AssembleDrink();
        }
    }
}
