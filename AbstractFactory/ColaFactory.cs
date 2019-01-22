using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    // Concrete factory
    class ColaFactory : SoftDrinkFactory
    {
        public override AbstractBottle CreateBottle() => new ColaBottle();
        public override AbstractLiquid CreateLiquid() => new ColaLiquid();
    }
}
