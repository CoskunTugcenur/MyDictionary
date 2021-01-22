using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictValue<Tkey, Tvalue>
    {
        public Tkey Key { get; set; }
        public Tvalue Value { get; set; }
        
    }
}
