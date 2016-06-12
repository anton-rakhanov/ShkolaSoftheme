using System;

namespace MyCollections.Collections.DictionaryElement
{
    public class KeyValueCombination<TKey, TValue>
    {
        public TKey Key { get; private set; }


        public TValue Value { get; private set; }


        public KeyValueCombination(TKey key, TValue value)
        {
            this.Key = key;
            this.Value = Value;
        }
    }
}
