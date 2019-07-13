using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class ConcreteCreator : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProduct();
        }
    }
}
