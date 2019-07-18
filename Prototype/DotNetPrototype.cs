using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    /// <summary>
    /// .NET prototype implementation.
    /// Uses ICloneable interface
    /// </summary>
    class DotNetPrototype : ICloneable
    {
        public ReferenceType State { get; set; }
        public DotNetPrototype(ReferenceType state)
        {
            State = state;
        }
        public object Clone()
        {
            return (State as ICloneable).Clone();
        }
    }
}
