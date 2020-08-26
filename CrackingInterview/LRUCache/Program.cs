using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRUCache
{
    class Program
    {
        static void Main(string[] args)
        {
            LRUCache lRUCache = new LRUCache(2);
            lRUCache.Put(1, 1);
            lRUCache.Put(2, 2);
            lRUCache.Get(1);       // returns 1
            lRUCache.Put(3, 3);    // evicts key 2
            lRUCache.Get(2);       // returns -1 (not found)
            lRUCache.Put(4, 4);    // evicts key 1
            lRUCache.Get(1);       // returns -1 (not found)
            lRUCache.Get(3);       // returns 3
            lRUCache.Get(4);       // returns 4
        }
    }

    public class LRUCache
    {
        private Dictionary<int, LinkedListNode<int>> hashes;
        private LinkedList<int> list;
        private readonly int capacity;

        public LRUCache(int capacity)
        {
            hashes = new Dictionary<int, LinkedListNode<int>>(capacity);
            list = new LinkedList<int>();
            this.capacity = capacity;
        }

        public int Get(int key)
        {
            if (!hashes.ContainsKey(key))
                return -1;
            var node = hashes[key];
            if (node.List == null)
            {
                hashes.Remove(key);
                return -1;
            }
            list.Remove(node);
            list.AddFirst(node);
            return node.Value;
        }

        public void Put(int key, int value)
        {
            if (hashes.ContainsKey(key))
            {
                var node = hashes[key];
                if (node.List != null)
                {
                    node.Value = value;
                    list.Remove(node);
                    list.AddFirst(node);
                    return;
                }
                else
                    hashes.Remove(key);
            }
            if (list.Count == capacity)
                list.RemoveLast();
            var newNode = list.AddFirst(value);
            hashes.Add(key, newNode);
        }
    }
}
