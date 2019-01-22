using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    // Concrete product class
    public class ColaBottle : AbstractBottle
    {
        public override void Pour(AbstractLiquid liquid) =>
            Console.WriteLine($"Pouring {liquid} into {this}...");

        public override string ToString() => "Cola bottle";
    }
}
