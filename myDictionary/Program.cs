using System;

namespace myDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(12, "Çağdaş S");
            myDictionary.Add(57, "Özgür S ");
            myDictionary.ShowKeys();
            myDictionary.ShowValues();
            
        }
    }
    class MyDictionary<K,V>
    {
        public K[] keys;
        public V[] values;

        public K[] tempKeys;
        public V[] tempValues;

        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }
        public void Add(K key, V value)
        {
            tempKeys = keys;
            keys = new K[keys.Length + 1];

            tempValues = values;
            values = new V[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }
            keys[keys.Length-1] = key;
            values[values.Length - 1] = value;
        }
        public void ShowKeys()
        {
            foreach (var item in keys)
            {
                Console.WriteLine(item);
            }
        }
        public void ShowValues()
        {
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
