namespace _03.BiDictionaryImplementation
{
    using System.Linq;
    using Wintellect.PowerCollections;

    public class BiDictionary<K1, K2, T>
    {
        private MultiDictionary<K1, T> firstData;
        private MultiDictionary<K2, T> secondData;

        public BiDictionary()
        {
            this.firstData = new MultiDictionary<K1, T>(true);
            this.secondData = new MultiDictionary<K2, T>(true);
        }

        public void Add(K1 firstKey, K2 secondKey, T element)
        {
            this.firstData.Add(firstKey, element);
            this.secondData.Add(secondKey, element);
        }

        public T[] FindByFirstKey(K1 key)
        {
            return this.firstData[key].ToArray();
        }

        public T[] FindBySecondKey(K2 key)
        {
            return this.secondData[key].ToArray();
        }

        public T[] FindByTwoKeys(K1 firstKey, K2 secondKey)
        {
            return this.firstData[firstKey].Intersect(this.secondData[secondKey]).ToArray();
        }
    }
}
