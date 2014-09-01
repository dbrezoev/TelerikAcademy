namespace HashTableImplementation
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class HashTable<K, T> : IEnumerable<KeyValuePair<K,T>>
    {
        private int count;
        private LinkedList<KeyValuePair<K, T>>[] data;
        private const int DefaultCapacity = 16;
        private const double DefaultPercentForResizing = 0.75;
        private const string NoSuchRecordMessage = "There is no such record with provided key.";
        private const string NegativeCountWarning = "Hashtable count cannot be negative number.";
        private const string ElementAlreadyExistMessage = "The element you're trying to add already exists.";

        public HashTable()
        {
            this.data = new LinkedList<KeyValuePair<K, T>>[DefaultCapacity];
        }

        public int Length
        {
            get
            {
                return this.data.Length;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(NegativeCountWarning);
                }

                this.count = value;
            }
        }

        public void Add(K key, T value)
        {
            var elementToAdd = new KeyValuePair<K,T>(key, value);
            if(this.CheckIfAlreadyExist(elementToAdd))
            {
                //throw new ArgumentException(ElementAlreadyExistMessage);
                return;
            }

            int position = GetPosition(key);

            if (this.data[position] == null)
            {
                this.data[position] = new LinkedList<KeyValuePair<K, T>>();
                this.data[position].AddFirst(elementToAdd);
            }
            else
            {
                this.data[position].AddLast(elementToAdd);
            }

            this.Count++;

            if (CheckLoad(this.Count, DefaultPercentForResizing, this.data.Length))
            {
                this.ResizeArray();
            }
        }        

        public T Find(K key)
        {
            //wrong algorythm

            //var position = GetPosition(key);
            //if (this.data[position] != null)
            //{
            //    var currentLinkedList = this.data[position];
            //    foreach (var item in currentLinkedList)
            //    {
            //        if (Object.Equals(item.Key, key))
            //        {
            //            return item.Value;
            //        }
            //    }
            //}

            //throw new ArgumentException("There is no such record with provided Key.");

            for (int i = 0; i < this.data.Length; i++)
            {
                var currentLinkedList = this.data[i];
                if (currentLinkedList != null)
                {
                    foreach (var item in currentLinkedList)
                    {
                        if (Object.Equals(item.Key, key))
                        {
                            return item.Value;
                        }
                    }
                }
            }

            throw new ArgumentException(NoSuchRecordMessage);
        }

        public void Remove(K key)
        {
            for (int i = 0; i < this.data.Length; i++)
            {
                var currentLinkedList = this.data[i];
                if (currentLinkedList != null)
                {
                    foreach (var item in currentLinkedList)
                    {
                        if (Object.Equals(item.Key, key))
                        {
                            currentLinkedList.Remove(item);
                            this.Count--;
                            return;
                        }
                    }
                }
            }

            throw new ArgumentException(NoSuchRecordMessage);
        }

        public void Clear()
        {
            this.data = new LinkedList<KeyValuePair<K, T>>[DefaultCapacity];
            this.Count = 0;
        }

        public T this[K key]
        {
            get
            {
                var returnValue = this.Find(key);

                return returnValue;
            }
            //TODO Implement not to throw exception when key exists
            set
            {
                this.Add(key, value);
            }
        }

        private int GetPosition(K key)
        {
            var code = key.GetHashCode();
            int position = code % this.data.Length;
            if (position < 0)
            {
                position = -position;
            }

            return position;
        }

        private bool CheckIfAlreadyExist(KeyValuePair<K, T> elementToAdd)
        {
            foreach (var linkedList in this.data)
            {
                if (linkedList != null)
                {
                    foreach (var item in linkedList)
                    {
                        if (Object.Equals(item.Key, elementToAdd.Key))
                        {
                            return true;
                        }
                    }
                }             
            }

            return false;
        }

        private bool CheckLoad(int count, double percent, int length)
        {
            if (count > percent * length)
            {
                return true;
            }

            return false;
        }

        private void ResizeArray()
        {
            var newArray = new LinkedList<KeyValuePair<K,T>>[this.data.Length * 2];

            Array.Copy(this.data, newArray, this.data.Length);

            this.data = newArray;
        }

        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            foreach (var linkedList in this.data)
            {
                if (linkedList != null)
                {
                    foreach (var item in linkedList)
                    {
                        yield return item;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
