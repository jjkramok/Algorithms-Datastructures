using System;

namespace Algorithms_Datastructures.Trees
{
    public class TreesTest
    {
        public TreesTest()
        {
            Console.WriteLine("Tree Tests");
            Heap<int> heap = new Heap<int>();
            heap.Insert(1);
            heap.Insert(3);
            heap.Insert(2);
            heap.Insert(5);
            heap.Insert(4);
            heap.Insert(9);
            heap.Insert(8);
            heap.Insert(7);
            heap.Insert(6);
            heap.Insert(5);
            heap.Insert(4);
            heap.Insert(9);
            heap.Insert(8);
            heap.Insert(7);
            heap.Insert(6);
            heap.Insert(8);
            heap.Insert(7);
            heap.Insert(6);
            Console.WriteLine(heap);
        }
    }
}