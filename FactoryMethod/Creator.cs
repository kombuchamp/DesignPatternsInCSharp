using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    abstract class Creator
    {
        /// <summary>
        /// Factory method.
        /// Class Creator delegates the instantiation of product
        /// to derived classes. This approach is used in all creational patterns.
        /// Factory method pattern can be easily converted to any of them
        /// </summary>
        /// <returns>Product</returns>
        public abstract Product FactoryMethod();
    }
}
