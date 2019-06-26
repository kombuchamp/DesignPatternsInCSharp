using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /// <summary>
    /// Abstract builder class.
    /// Provides interface to construct complex object part by part.
    /// </summary>
    public abstract class Builder
    {
        protected Product _product;
        public Builder()
        {
            _product = new Product();
        }
        public abstract void BuldPartA();
        public abstract void BuldPartB();
        public abstract void BuldPartC();
        public Product Result => _product;
    }
}
