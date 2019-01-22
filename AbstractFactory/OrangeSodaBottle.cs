using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class OrangeSodaBottle : AbstractBottle
    {
        public override void Pour(AbstractLiquid liquid) =>
            Console.WriteLine($"Pouring {liquid} into {this}");

        public override string ToString() => "Orange Soda bottle";
    }
}
