using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class OrangeSodaFactory : SoftDrinkFactory
    {
        public override AbstractBottle CreateBottle() => new OrangeSodaBottle();
        public override AbstractLiquid CreateLiquid() => new OrangeSodaLiquid();
    }
}
