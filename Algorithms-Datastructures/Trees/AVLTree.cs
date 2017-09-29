using System;

namespace Algorithms_Datastructures.Trees
{
    public class AVLTree<T> where T : IComparable<T>
    {
        public AVLNode<T> Root { get; set; }

        public int Height()
        {
            return Root != null ? Height(Root) : 0;
        }

        private int Height(AVLNode<T> node)
        {
            return -1;
        }
        
        public bool Insert(AVLNode<T> node)
        {
            if (Root == null)
            {
                Root = node;
                return true;
            }
            return Insert(node, 0); //Looping
            //return Insert(node, Root); //Recursive
        }
        
        // Recursive strategy
        public bool Insert(AVLNode<T> ins, AVLNode<T> curr)
        {
            if (ins.Key > curr.Key)
            {
                //right
                if (curr.Right == null)
                {
                    curr.Right = ins;
                }
                Insert(ins, curr.Right);
                
            } else if (ins.Key < curr.Key)
            {
                //left
                if (curr.Left == null)
                {
                    curr.Left = ins;
                }
                Insert(ins, curr.Left);
            }
            else
            {
                return false; // both keys are equal, this is not allowed. Break.
            }
            return false; // both keys are equal, this is not allowed. Break.
        }
        
        // Looping strategy
        public bool Insert(AVLNode<T> ins, int unused)
        {
            // TODO 
            // Finds spot for new node :ins: and places it there
            // Does not yet check for the height diff restraint
            // Does not yet perform rotations to fix height diff restraint
            AVLNode<T> curr = Root;
            while (curr != null) //TODO other condition?
            {
                if (ins.Key > curr.Key)
                {
                    //right
                    if (curr.Right == null)
                    {
                        curr.Right = ins;
                    }
                    curr = curr.Right;
                    
                } else if (ins.Key < curr.Key)
                {
                    //left
                    if (curr.Left == null)
                    {
                        curr.Left = ins;
                    }
                    curr = curr.Left;
                }
                else
                {
                    return false; // both keys are equal, this is not allowed. Break.
                }
            }
            return false; // both keys are equal, this is not allowed. Break.
        }

        public class AVLNode<T> where T : IComparable<T>
        {
            public int Key;
            public T Data;
            public AVLNode<T> Left;
            public AVLNode<T> Right;
        }
    }
}