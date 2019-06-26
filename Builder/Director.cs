using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /// <summary>
    /// Director class builds complex object using builder.
    /// Determines an order in which complex object is built
    /// </summary>
    public class Director
    {
        Builder _builder;
        public Director(Builder builder)
        {
            _builder = builder;
        }
        public void Construct ()
        {
            _builder.BuldPartA();
            _builder.BuldPartA();
            _builder.BuldPartC();
            _builder.BuldPartB();
            _builder.BuldPartA();
        }
    }
}
