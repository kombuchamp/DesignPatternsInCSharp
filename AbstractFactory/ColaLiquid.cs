using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    // Concrete product class
    public class ColaLiquid : AbstractLiquid
    {
        public override string ToString() => "Cola";
    }
}
