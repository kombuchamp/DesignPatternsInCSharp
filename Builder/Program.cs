using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create builder
            Builder builder = new ConcreteBulder();
            // Create director
            Director director = new Director(builder);
            // Make director construct object
            director.Construct();
            // Get object from builder
            var complexObject = builder.Result;
            foreach (var item in complexObject.Content)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
