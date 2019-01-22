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

        }
    }
}
