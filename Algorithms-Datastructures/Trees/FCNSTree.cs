using System;

namespace Algorithms_Datastructures.Trees
{
    public class FCNSTree<T> where T : IComparable<T>
    {
        public FCNSNode<T> Root;
        
        public FCNSTree() {}

        public FCNSTree(FCNSNode<T> r) {
            Root = r;
        }

        public void PrintPreOrder()
        {
            PrintPreOrder(Root, 0);
        }
        
        private void PrintPreOrder(FCNSNode<T> node, int indent) {
            for (int i = 0; i < indent; i++) {Console.Write("\t");}
            if (node.Data != null) {
                Console.Write(node.Data);
                
            } else {
                Console.Write("(...)");
            }
            if (node.FirstChild != null)
                PrintPreOrder(node.FirstChild, indent + 1);
            if (node.NextSibling != null) {
                Console.WriteLine("\n");
                PrintPreOrder(node.NextSibling, indent);
            }
        }

        public int Size()
        {
            if (Root == null)
                return 0;
            return Size(Root);
        }

        public int Size(FCNSNode<T> node)
        {
            int size = 1;
            if (node.FirstChild != null)
                size += Size(node.FirstChild);
            if (node.NextSibling != null)
                size += Size(node.NextSibling);
            return size;
        }

        public class FCNSNode<T> where T : IComparable<T>
        {
            public T Data { get; set; }
            public FCNSNode<T> FirstChild { get; set; }
            public FCNSNode<T> NextSibling { get; set; }

            public FCNSNode(T data)
            {
                Data = data;
            }
        }
    }
}