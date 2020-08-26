using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            #region HashTable
            HashTableEx hashtable = new HashTableEx();
            hashtable.Add(1, 2);
            #endregion         
        }
    }

    public class HashTableEx
    {
        public List<object> keys = new List<object>();
        public List<object> values = new List<object>();
        public object Get(object key)
        {
            int index = keys.IndexOf(key);
            return values[index];
        }

        public void Add(object key, object value)
        {
            keys.Add(key);
            values.Add(value);
        }

        public void Remove(object key)
        {
            int index = keys.IndexOf(key);
            keys.RemoveAt(index);
            values.RemoveAt(index);
        }

        public void Clear()
        {
            keys = new List<object>();
            values = new List<object>();
        }
    }
}
