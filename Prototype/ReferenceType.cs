using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    /// <summary>
    /// Just some reference type
    /// </summary>
    class ReferenceType: ICloneable
    {
        public int Number { get; }
        public string Str { get; }

        public ReferenceType(int number, string str)
        {
            Number = number;
            Str = str;
        }

        object ICloneable.Clone()
        {
            return MemberwiseClone();
        }
    }
}
