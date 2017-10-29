using System;
using Algorithms_Datastructures.Trees;

namespace Algorithms_Datastructures.Lists
{
    /// <summary>
    /// A priority queue based on my minHeap. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PriorityQueue<T> where T : IComparable<T>
    {
        private Heap<T> _q = new Heap<T>();

        public void Enqueue(T e)
        {
            _q.Insert(e);
        }

        public T Peek()
        {
            return _q.FindMin();
        }

        public T Dequeue()
        {
            return _q.Pop();
        }

        public int Length()
        {
            return _q.Size();
        }
    }
}