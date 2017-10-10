using System;
using System.Dynamic;

namespace Algorithms_Datastructures.Trees
{
    public class Heap<T> where T : IComparable<T>
    {
        private T[] _heap = new T[10];
        private int _i = 1; // used as index, points to first empty spot that is not on index 0
        
        public void Insert(T item)
        {
            // Insert in last spot and then percolate up
            _heap[_i] = item;
            
            //Percolate up the new item
            int i = _i;
            while (_heap[i].CompareTo(_heap[i / 2]) < 0 || i == 0)
            {
                //Smaller than parent, swap them
                T parent = _heap[i / 2];
                _heap[i / 2] = _heap[i];
                _heap[i] = parent;
                i /= 2; // Point to percolated item
            }
            if (++_i >= _heap.Length)
            {
                T[] biggerHeap = new T[_heap.Length * 2];
                _heap.CopyTo(biggerHeap);
                //TODO increase heap array size
            }
        }

        public int Size()
        {
            return _i - 1;
        }

    }
}