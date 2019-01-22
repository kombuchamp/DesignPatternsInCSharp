using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    // It's the Abstract Factory
    public abstract class SoftDrinkFactory
    {
        public abstract AbstractLiquid CreateLiquid();
        public abstract AbstractBottle CreateBottle();
    }
}
