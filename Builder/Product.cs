using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /// <summary>
    /// "Complex" object which is built using builder
    /// </summary>
    public class Product
    {
        List<string> _content = new List<string>();

        public IList<string> Content => _content;
        public void Add(string s)
        {
            _content.Add(s);
        }
    }
}
