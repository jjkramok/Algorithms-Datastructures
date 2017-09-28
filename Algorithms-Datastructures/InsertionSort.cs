using System;
using System.Collections.Generic;

namespace Algorithms_Datastructures
{
    public class InsertionSort
    {
        public static void Sort<T>(List<T> l) where T : IComparable<T>
        {
            for (int i = 1; i < l.Count; i++)
            {
                int j = i;
                while (j > 0 && l[j - 1].CompareTo(l[j]) > 0)
                {
                    Swap(j-1, j--, l);
                }
            }
        }
    
        private static void Swap<T>(int i, int j, List<T> l)
        {
            T temp = l[i];
            l[i] = l[j];
            l[j] = temp;
        }
    }
}