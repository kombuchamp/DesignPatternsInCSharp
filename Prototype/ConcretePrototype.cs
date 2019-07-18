using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class ConcretePrototype : Prototype
    {
        public ConcretePrototype(ReferenceType state) : base(state) { }
        /// <summary>
        /// Intentionaly not using ICloneable here
        /// </summary>
        /// <returns></returns>
        public override Prototype Clone()
        {
            var newState = new ReferenceType(State.Number, State.Str);
            return new ConcretePrototype(newState) as Prototype;
        }
    }
}
