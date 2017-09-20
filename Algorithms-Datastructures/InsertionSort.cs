using System;
using System.Collections.Generic;

namespace Algorithms_Datastructures
{
    public class InsertionSort<T> where  T : IComparable
    {
        public static List<T> Sort(List<T> list)
        {
            if (list.Count <= 1)
                return list;
            List<T> res = new List<T>();
            res.Add(list[0]);
            for (int i = 0; i < list.Count; i++)
            {
                res = Insert(res, list[i]);
            }
            return res;
        }

        private static List<T> Insert(List<T> list, T element)
        {
            int i = list.Count - 1;
            while (list[i].CompareTo(element) > 0)
            {
                //TODO sorting
                i--;
            }
            return null;
        }
    }
}