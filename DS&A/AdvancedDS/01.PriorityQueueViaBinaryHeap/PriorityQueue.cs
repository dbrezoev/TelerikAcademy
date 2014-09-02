namespace _01.PriorityQueueViaBinaryHeap
{
    using System;
    using System.Collections.Generic;

    //source:
    //http://visualstudiomagazine.com/Articles/2012/11/01/Priority-Queues-with-C.aspx?Page=2
    public class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> data;
        private int count;

        public PriorityQueue()
        {
            this.data = new List<T>();
        }

        public int Count
        {
            get
            {
                return this.count;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Count cannot be negative.");
                }

                this.count = value;
            }
        }

        public void Enqueue(T item)
        {
            data.Add(item);
            int childIndex = data.Count - 1;
            while (childIndex > 0)
            {
                int parentIndex = (childIndex - 1) / 2;
                if (data[childIndex].CompareTo(data[parentIndex]) >= 0)
                    break;
                T tmp = data[childIndex]; data[childIndex] = data[parentIndex]; data[parentIndex] = tmp;
                childIndex = parentIndex;
            }

            this.Count++;
        }

        public T Dequeue()
        {
            // Assumes pq isn't empty
            int li = data.Count - 1;
            T frontItem = data[0];
            data[0] = data[li];
            data.RemoveAt(li);

            --li;
            int parentIndex = 0;
            while (true)
            {
                int childIndex = parentIndex * 2 + 1;
                if (childIndex > li) break;
                int rc = childIndex + 1;
                if (rc <= li && data[rc].CompareTo(data[childIndex]) < 0)
                    childIndex = rc;
                if (data[parentIndex].CompareTo(data[childIndex]) <= 0) break;
                T tmp = data[parentIndex]; data[parentIndex] = data[childIndex]; data[childIndex] = tmp;
                parentIndex = childIndex;
            }

            this.Count--;
            return frontItem;
        }
    }
}
