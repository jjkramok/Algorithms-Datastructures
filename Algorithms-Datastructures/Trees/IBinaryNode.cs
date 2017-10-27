using System;

namespace Algorithms_Datastructures.Trees
{
    public interface IBinaryNode<T> where T : IComparable<T>
    {
        T GetValue();
    }
}