using System;

namespace Algorithms_Datastructures.Trees
{
    public interface IBinaryTree<T> where T : IComparable<T>
    {
        IBinaryNode<T> GetRoot();
        int Size();
        int Height();

        void PrintPreOrder();
        void PrintInOrder();
        void PrintPostOrder();

        void MakeEmpty();
        bool IsEmpty();
        void Merge(T rootItem, IBinaryTree<T> t0, IBinaryTree<T> t1);
    }
}