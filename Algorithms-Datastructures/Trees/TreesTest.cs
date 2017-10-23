using System;

namespace Algorithms_Datastructures.Trees
{
    public class TreesTest
    {
        public TreesTest()
        {
            Console.WriteLine("Tree Tests");
            Heap<int> heap = new Heap<int>();
            Random rng = new Random();
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            heap.Insert(rng.Next(0, 100));
            Console.WriteLine(heap);

            int[] bulk = new int[20];
            for (int i = 0; i < bulk.Length; i++)
            {
                bulk[i] = rng.Next(0, 100);
            }
            Heap<int> bulkHeap = new Heap<int>(bulk);
            Console.WriteLine(bulkHeap);
            
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            for (int i = 0; i < 20; i++)
            {
                bst.Insert(rng.Next(0, 100));
            }
            Console.WriteLine(bst);
            bst.PrintInOrder();
        }
    }
}