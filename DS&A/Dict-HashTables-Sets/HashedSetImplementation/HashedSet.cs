namespace HashedSetImplementation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using HashTableImplementation;

    public class HashedSet<T> : IEnumerable<T>
    {
        private HashTable<T, T> data;

        public HashedSet()
        {
            this.data = new HashTable<T, T>();
        }

        public void Add(T elementToAdd)
        {
            this.data.Add(elementToAdd, elementToAdd);
        }

        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }

        public T Find(T elementToFind)
        {
            return this.data.Find(elementToFind);
        }

        public void Remove(T elementToRemove)
        {
            this.data.Remove(elementToRemove);
        }

        public void Clear()
        {
            this.data.Clear();
        }

        public HashedSet<T> Union(HashedSet<T> other)
        {
            HashedSet<T> result = new HashedSet<T>();
            foreach (var item in this.data)
            {
                result.Add(item.Value);
            }

            foreach (var item in other.data)
            {
                result.Add(item.Value);
            }

            return result;
        }

        public HashedSet<T> Intersect(HashedSet<T> other)
        {
            HashedSet<T> result = new HashedSet<T>();
            foreach (var item in this.data)
            {
                foreach (var otherItem in other.data)
                {
                    if (Object.Equals(item, otherItem))
                    {
                        result.Add(item.Value);
                    }
                }
            }

            return result;
        }



        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.data)
            {
                yield return item.Value;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
