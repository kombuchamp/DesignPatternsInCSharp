using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    // Client class
    class SoftDrinkAssembler
    {
        readonly AbstractBottle _bottle;
        readonly AbstractLiquid _liquid;

        public SoftDrinkAssembler(SoftDrinkFactory factory)
        {
            _bottle = factory.CreateBottle();
            _liquid = factory.CreateLiquid();
        }

        public void AssembleDrink()
        {
            _bottle.Pour(_liquid);
            Console.WriteLine("Drink has been assembled");
        }
    }
}
