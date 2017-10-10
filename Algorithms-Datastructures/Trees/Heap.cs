using System;

namespace Algorithms_Datastructures.Trees
{
    public class Heap<T> where T : IComparable<T>
    {
        private T[] _heap = new T[10];
        public int Size = 0;
        
        public void Insert(T item)
        {
            if (_heap.Length == Size)
            {
                
            }
        }

    }
}