using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var state = new ReferenceType(1, "Some string");
            var prototype = new ConcretePrototype(state);
            var clone = prototype.Clone();

            var dotNetPrototype = new DotNetPrototype(state);
            var dotNetClone = dotNetPrototype.Clone();
        }
    }
}
