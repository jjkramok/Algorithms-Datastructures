using System;

namespace Algorithms_Datastructures.Trees
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public BinaryNode<T> Root;

        public BinarySearchTree() {
            Root = null;
        }

        public void Insert(BinaryNode<T> node) 
        {
            if (Root == null)
                Root = node;
            BinaryNode<T> currNode = Root;
            while(true) {
                if (Root.GetElement().CompareTo(node.GetElement()) < 0) {
                    //Lower than
                    if (currNode.GetLeft() != null) {
                        currNode = currNode.GetLeft();
                    } else {
                        currNode.SetLeft(node);
                        break;
                    }
                } else {
                    //Greater or equal
                    if (currNode.GetRight() != null) {
                        currNode = currNode.GetRight();
                    } else {
                        currNode.SetRight(node);
                        break;
                    }
                }
            }
        }
        
        public void PrintInOrder() {
            if (Root != null)
                PrintInOrder(Root);
        }

        private void PrintInOrder(BinaryNode<T> node) {
            if (node != null) {
                PrintInOrder(node.GetLeft());
                Console.WriteLine(node.GetElement().ToString());
                PrintInOrder(node.GetRight());
            }
        }

        public class BinaryNode<T> {
            private T _item;
            private BinaryNode<T> _left;
            private BinaryNode<T> _right;

            private BinaryNode(T item) {
                this._item = item;
            }

            public T GetElement() {
                return _item;
            }

            public void SetElement(T item) {
                this._item = item;
            }

            public BinaryNode<T> GetLeft() {
                return _left;
            }

            public void SetLeft(BinaryNode<T> left) {
                this._left = left;
            }

            public BinaryNode<T> GetRight() {
                return _right;
            }

            public void SetRight(BinaryNode<T> right) {
                this._right = right;
            }
        }
    }
}