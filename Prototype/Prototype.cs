using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    /// <summary>
    /// Classic Prototype pattern (without IClonable)
    /// </summary>
    abstract class Prototype
    {
        public ReferenceType State { get; set; }
        public Prototype(ReferenceType state)
        {
            State = state;
        }
        public abstract Prototype Clone();
    }
}
