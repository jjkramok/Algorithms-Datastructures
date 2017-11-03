using System;

namespace Algorithms_Datastructures.Trees
{
    public class TreesTest
    {
        public TreesTest()
        {
            Console.WriteLine("Tree Tests");
            //BSTTest();
            //HeapTest();;
            //FCNSTreeTest();
            BinaryTreeTest();
        }

        public void BinaryTreeTest()
        {
            Random rng = new Random();
            Console.WriteLine("::Binary Tree::");
            BinaryTree<int> bt = new BinaryTree<int>();
            for (int i = 0; i < 10; i++)
            {
                bt.Insert(rng.Next(0, 100));
            }
            Console.WriteLine(bt);
            Console.WriteLine("Statistics of the BT. Size: {0} and Height: {1}", bt.Size(), bt.Height());
            //bt.PrintInOrder();
        }
        
        public static void FCNSTreeTest()
        {
            Random rng = new Random();
            Console.WriteLine("::First Child Next Sibling Tree::");
            FCNSTree<int> fcns = new FCNSTree<int>(new FCNSTree<int>.FCNSNode<int>(0));
            FCNSTree<int>.FCNSNode<int> n0 = new FCNSTree<int>.FCNSNode<int>(1);
            FCNSTree<int>.FCNSNode<int> n1 = new FCNSTree<int>.FCNSNode<int>(2);
            FCNSTree<int>.FCNSNode<int> n2 = new FCNSTree<int>.FCNSNode<int>(3);
            FCNSTree<int>.FCNSNode<int> n3 = new FCNSTree<int>.FCNSNode<int>(4);
            FCNSTree<int>.FCNSNode<int> n4 = new FCNSTree<int>.FCNSNode<int>(5);
            FCNSTree<int>.FCNSNode<int> n5 = new FCNSTree<int>.FCNSNode<int>(6);
            FCNSTree<int>.FCNSNode<int> n6 = new FCNSTree<int>.FCNSNode<int>(7);
            FCNSTree<int>.FCNSNode<int> n7 = new FCNSTree<int>.FCNSNode<int>(8);
            FCNSTree<int>.FCNSNode<int> n8 = new FCNSTree<int>.FCNSNode<int>(9);
            FCNSTree<int>.FCNSNode<int> n9 = new FCNSTree<int>.FCNSNode<int>(10);
            FCNSTree<int>.FCNSNode<int> n10 = new FCNSTree<int>.FCNSNode<int>(11);
            FCNSTree<int>.FCNSNode<int> n11 = new FCNSTree<int>.FCNSNode<int>(12);
            
            fcns.Root.FirstChild = n0;
            n0.NextSibling = n1;
            n1.NextSibling = n2;
            n2.NextSibling = n3;
            n3.NextSibling = n4;
            n4.NextSibling = n5;
            n5.NextSibling = n6;
            n3.FirstChild = n7;
            n4.FirstChild = n8;
            n8.NextSibling = n9;
            n9.NextSibling = n10;
            n10.FirstChild = n11;
            //13 items, root already set + 12 more
            Console.WriteLine("Size from root: {0}", fcns.Size());
            Console.WriteLine("Print");
            fcns.PrintPreOrder();
            
        }
        
        public static void BSTTest()
        {
            Console.WriteLine("::Binary Search Tree::");
            Random rng = new Random();
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            for (int i = 0; i < 20; i++)
            {
                bst.Insert(rng.Next(0, 100));
            }
            Console.WriteLine(bst);
            bst.PrintInOrder();
        }

        public static void HeapTest()
        {
            Console.WriteLine("::Heap::");
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
        }
    }
}