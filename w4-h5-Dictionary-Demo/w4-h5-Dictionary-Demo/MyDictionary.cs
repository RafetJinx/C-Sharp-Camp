using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w4_h5_Dictionary_Demo
{
    class MyDictionary<T1,T2>
    {
        T1[] keys;
        T2[] values;

        public MyDictionary()
        {
            keys = new T1[0];
            values = new T2[0];
        }

        public void Add(T1 key, T2 value)
        {
            for(int i = 0; i < keys.Length; i++)
            {
                if (key.Equals(keys[i]))
                {
                    Console.WriteLine("Bu anahtar adına sahip bir ogrenci kayitli");
                    return;
                }
            }
            T1[] tempKeys = keys;
            T2[] tempValues = values;

            keys = new T1[keys.Length + 1];
            values = new T2[values.Length + 1];
           
            for(int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
    }
}
