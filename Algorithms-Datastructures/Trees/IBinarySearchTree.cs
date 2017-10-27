using System;

namespace Algorithms_Datastructures.Trees
{
    public interface IBinarySearchTree<T> where T : IComparable<T>
    {
        void Insert(T x);
        void Remove(T x);
        void RemoveMin();
        T FindMin();
        void PrintInOrder();
        string ToString();
    }
}