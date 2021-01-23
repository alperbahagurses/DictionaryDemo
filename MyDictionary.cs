using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDemo
{
    class MyDictionary<T1,T2>
    {
        T1[] ids;
        T2[] names;
        public MyDictionary()
        {
            ids = new T1[0];
            names = new T2[0];
        }
        public void Add(T1 id,T2 name)
        {
            T1[] tempIds = ids;
            T2[] tempNames = names;
            ids = new T1[ids.Length+1];
            names = new T2[names.Length+1];
            for (int i = 0; i < tempIds.Length; i++)
            {
                ids[i] = tempIds[i];
                names[i] = tempNames[i];
            }
            ids[ids.Length - 1] = id;
            names[names.Length - 1] = name;
        }

        public T1[] Ids
        {
            get { return ids; }
        }

        public T2[] Names
        {
            get { return names; }
        }
    }
}
