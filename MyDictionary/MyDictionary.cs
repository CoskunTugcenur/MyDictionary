using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
  

    class MyDictionary<Tkey, Tvalue>
    {
        MyDictValue<Tkey, Tvalue>[] values;

        public MyDictionary()
        {
            values = new MyDictValue<Tkey, Tvalue>[0];
        }
        
        public void Add(Tkey key,Tvalue value)
        {
            MyDictValue<Tkey, Tvalue>[] tempValues = values;
            values = new MyDictValue<Tkey, Tvalue>[tempValues.Length+1];
            
            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }

            //yeni veriyi MyDictValue tipine cevir
            MyDictValue<Tkey, Tvalue> newValue = new MyDictValue<Tkey, Tvalue>();
            newValue.Key = key;
            newValue.Value = value;

            values[values.Length - 1] = newValue;

        }


        public MyDictValue<Tkey, Tvalue>[] Items
        {
            get { return values; }
        }
    }
}
