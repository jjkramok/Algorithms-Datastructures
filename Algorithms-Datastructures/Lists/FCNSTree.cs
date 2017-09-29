using System;

namespace Algorithms_Datastructures.Lists
{
    public class FCNSTree<T> where T : IComparable<T>
    {
        private FCNSNode<T> root;
        
        public FCNSTree() {}

        public FCNSTree(FCNSNode<T> r) {
            root = r;
        }

        public void PrintPreOrder()
        {
            PrintPreOrder(root);
        }
        
        private void PrintPreOrder(FCNSNode<T> node) {
            if (node.Data != null) {
                Console.Write(node.Data);
                Console.Write("\t");
            } else {
                Console.Write("(...)\t");
            }
            if (node.FirstChild != null)
                PrintPreOrder(node.FirstChild);
            if (node.NextSibling != null) {
                Console.WriteLine("\n");
                PrintPreOrder(node.NextSibling);
            }
        }

        public int Size()
        {
            return -1; //TODO implement
        }

        public class FCNSNode<T> where T : IComparable<T>
        {
            public T Data { get; set; }
            public FCNSNode<T> FirstChild { get; set; }
            public FCNSNode<T> NextSibling { get; set; }
        }
    }
}