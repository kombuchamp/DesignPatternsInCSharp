using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    // Abstract product class
    public abstract class AbstractBottle
    {
        public abstract override string ToString();
        public abstract void Pour(AbstractLiquid liquid);
    }
}
