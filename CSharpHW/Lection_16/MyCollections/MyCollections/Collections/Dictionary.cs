using System;
using System.Collections.Generic;
using MyCollections.Collections.DictionaryElement;

namespace MyCollections.Collections
{
    public class Dictionary<TKey, TValue>
    {
        private List<KeyValueCombination<TKey, TValue>> _listOfCombinations;


        public int Count { get; private set; }


        public Dictionary()
        {
            _listOfCombinations = new List<KeyValueCombination<TKey, TValue>>();
        }


        public void Add(TKey key, TValue value)
        {
            
            if(_listOfCombinations.Contains(new KeyValueCombination<TKey,TValue>(key, value)))
            {
                Console.WriteLine("Sorry, but that key is already in dictionary, we can't add another.");
            }
            else
            {
                _listOfCombinations.Add(new KeyValueCombination<TKey, TValue>(key, value));
            }

        }


        public bool Remove(TKey key)
        {
            
            if(_listOfCombinations.Count == 0)
            {
                Console.WriteLine("Sorry, but dictionary is empty");
                return false;
            }
            else
            {
                foreach (var combination in _listOfCombinations)
                {
                    if (combination.Key.Equals(key))
                    {
                        _listOfCombinations.Remove(combination);
                        return true;
                    }
                }
                return false;
            }
        }


        public bool Contains(TKey key)
        {
            foreach (var combination in _listOfCombinations)
            {
                if (combination.Key.Equals(key))
                {
                    Console.WriteLine("Key: {0} , Value: {1}", combination.Key.ToString(), combination.Value.ToString());
                    return true;
                }
            }
            return false;
        }
    }
}
