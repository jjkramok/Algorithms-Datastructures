﻿using System;

namespace PreparationTest
{
    public class Excercise2<T> where T : IComparable<T>
    {
        public BinaryNode<T> Root;

        public Excercise2() {
            Root = null;
        }

        public BinaryNode<T> GiveSecondSmallestElement()
        {
            if (Root == null)
                return null;
            BinaryNode<T> prev = null; // Backtracking reference
            BinaryNode<T> curr = Root;

            // Find smallest node in BST
            while (curr.GetLeft() != null)
            {
                prev = curr;
                curr = curr.GetLeft();
            }
            // Return parent if there are no siblings
            if (curr.GetRight() == null)
            {
                return prev;
            }

            // Find smallest element that is bigger than the orginal smallest element
            curr = curr.GetRight();
            while (curr.GetLeft() != null)
            {
                curr = curr.GetLeft();
            }    
            return curr;
        }

        public void Insert(T key)
        {
            if (Root == null)
                Root = new BinaryNode<T>(key);
            else 
                Insert(Root, key);
        }
        
        public void Insert(BinaryNode<T> currNode, T key) 
        {
            if (key.CompareTo(currNode.GetElement()) < 0) {
                //Lower than
                if (currNode.GetLeft() != null) {
                    Insert(currNode.GetLeft(), key);
                } else {
                    currNode.SetLeft(new BinaryNode<T>(key));
                }
            } else {
                //Greater (or equal)
                if (currNode.GetRight() != null) {
                    Insert(currNode.GetRight(), key);
                } else {
                    currNode.SetRight(new BinaryNode<T>(key));
                }
            }
        }
        
        public void PrintInOrder() {
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

            public BinaryNode(T item) {
                _item = item;
                _left = null;
                _right = null;
            }

            public T GetElement() {
                return _item;
            }

            public void SetElement(T item) {
                _item = item;
            }

            public BinaryNode<T> GetLeft() {
                return _left;
            }

            public void SetLeft(BinaryNode<T> left) {
                _left = left;
            }

            public BinaryNode<T> GetRight() {
                return _right;
            }

            public void SetRight(BinaryNode<T> right) {
                _right = right;
            }
            
            public override string ToString()
            {
                return _item.ToString();
            }
        }
    }
}