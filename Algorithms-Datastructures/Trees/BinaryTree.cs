﻿using System;
using System.Collections.Generic;
using Algorithms_Datastructures.Lists;

namespace Algorithms_Datastructures.Trees
{
    public class BinaryTree<T> : IBinaryTree<T> where T : IComparable<T>
    {
        public BinaryNode<T> Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }
        
        public IBinaryNode<T> GetRoot()
        {
            return Root;
        }

        public int Size()
        {
            if (Root == null)
                return 0;
            return Size(Root);
        }
        
        public int Size(BinaryNode<T> node)
        {
            int size = 1;
            if (node.GetLeft() != null)
                size += Size(node.GetLeft());
            if (node.GetRight() != null)
                size += Size(node.GetRight());
            return size;
        }

        public int Height()
        {
            if (Root == null)
                return -1;
            return Height(Root) - 1;
        }
        
        public int Height(BinaryNode<T> node)
        {
            int rHeight = 0;
            int lHeight = 0;
            if (node.GetLeft() != null)
                rHeight = Height(node.GetLeft());
            if (node.GetRight() != null)
                lHeight = Height(node.GetRight());
            return rHeight > lHeight ? rHeight + 1 : lHeight + 1;
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

            if (key.CompareTo(currNode.GetValue()) < 0) {
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

        public void PrintPreOrder()
        {
            if (Root != null)
                PrintInOrder(Root);
        }

        private void PrintPreOrder(BinaryNode<T> node)
        {
            if (node != null)
            {
                Console.WriteLine(node.GetValue().ToString());
                PrintInOrder(node.GetLeft());
                PrintInOrder(node.GetRight());
            }
        }

        public void PrintInOrder()
        {
            if (Root != null)
                PrintInOrder(Root);
        }

        private void PrintInOrder(BinaryNode<T> node)
        {
            if (node != null)
            {
                PrintInOrder(node.GetLeft());
                Console.WriteLine(node.GetValue().ToString());
                PrintInOrder(node.GetRight());
            }
        }

        public void PrintPostOrder()
        {
            if (Root != null)
                PrintInOrder(Root);
        }

        private void PrintPostOrder(BinaryNode<T> node)
        {
            if (node != null)
            {
                PrintInOrder(node.GetLeft());
                PrintInOrder(node.GetRight());
                Console.WriteLine(node.GetValue().ToString());
            }
        }

        public void MakeEmpty()
        {
            Root = null;
        }

        public bool IsEmpty()
        {
            return Root == null;
        }

        public void Merge(T rootItem, IBinaryTree<T> t0, IBinaryTree<T> t1)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return ToStringHelper(Root);
        }

        private string ToStringHelper(BinaryNode<T> startNode)
        {
            const string frontSpaceString = " ";
            const string nullNodeCharacter = "_";
            const string nodeSpacingString = " ";
            
            List<List<BinaryNode<T>>> layers = new List<List<BinaryNode<T>>>();
            List<BinaryNode<T>> layer = new List<BinaryNode<T>>();
            // add root to first layer
            layers.Add(layer);
            layer.Add(startNode);
            
            int row = 0;
            while (row < Height())
            {
                layers.Add(new List<BinaryNode<T>>());
                layer = layers[row];

                /* Add all childs of every node in this layer and add a marker if null */
                for (int i = 0; i < layer.Count; i++)
                {
                    if (layer[i] != null)
                    {
                        layers[row + 1].Add(layer[i].GetLeft());
                        layers[row + 1].Add(layer[i].GetRight());
                    }
                    else
                    {
                        layers[row + 1].Add(null);
                        layers[row + 1].Add(null);
                    }
                }
                /* go to next row */
                row++;
            }

            string res = "";
            /* Loop over our newly created layered tree representation */
            for (int layerIndex = 0; layerIndex < layers.Count; layerIndex++)
            {
                /* define frontspacing by adding (currentLayer - total layers) to (lastLayerSize /currentLayerSize) */
                double frontSpacing = row - layers.Count+0.5 + layers[layers.Count-1].Count / (double) layers[layerIndex].Count;

                /* add front spaces to this layer */
                for(int i = 0; i < frontSpacing; i++)
                {
                    res += frontSpaceString;
                }
                
                /* print every node in this layer */
                for (int nodeIndex = 0; nodeIndex < layers[layerIndex].Count; nodeIndex++)
                {
                    double elementSpacing = frontSpacing * 2;
                    

                    if (layers[layerIndex][nodeIndex] == null)
                    {
                        res += nullNodeCharacter;
                    }
                    else
                    {
                        res += layers[layerIndex][nodeIndex];
                    }

                    for (int i = 0; i < elementSpacing; i++)
                    {
                        res += nodeSpacingString;
                    }
                }
                res += "\n";
            }
            
           

            return res;
        }

        public class BinaryNode<T> : IComparable<BinaryNode<T>>, IBinaryNode<T> where T : IComparable<T>
        {
            private T _item;
            private BinaryNode<T> _left;
            private BinaryNode<T> _right;

            public BinaryNode(T item)
            {
                _item = item;
            }

            public T GetValue()
            {
                return _item;
            }

            public void SetValue(T item)
            {
                _item = item;
            }

            public BinaryNode<T> GetLeft()
            {
                return _left;
            }

            public void SetLeft(BinaryNode<T> left)
            {
                _left = left;
            }

            public BinaryNode<T> GetRight()
            {
                return _right;
            }

            public void SetRight(BinaryNode<T> right)
            {
                _right = right;
            }

            public int CompareTo(BinaryNode<T> other)
            {
                return 0;
            }

            public override string ToString()
            {
                return _item.ToString();
            }
        }
    }
}