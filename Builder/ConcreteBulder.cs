using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /// <summary>
    /// Concrete builder class.
    /// Implements parts construction of complex object.
    /// </summary>
    public class ConcreteBulder : Builder
    {
        public override void BuldPartA()
        {
            _product.Add("Part A");
        }

        public override void BuldPartB()
        {
            _product.Add("Part B");
        }

        public override void BuldPartC()
        {
            _product.Add("Part C");
        }
    }
}
