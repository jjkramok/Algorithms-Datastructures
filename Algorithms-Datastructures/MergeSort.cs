using System;
using System.Collections.Generic;

namespace Algorithms_Datastructures
{
    public class MergeSort
    {
        public MergeSort()
        {
            Random rng = new Random();
            List<int> array = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                array.Add(rng.Next(1, 100));
            }
            Console.WriteLine("Random input array:\n{0}", string.Join(", ", array));
            Console.WriteLine("Mergesorted array:\n{0}", string.Join(", ", Sort(array)));
            
//            List<int> l = new List<int>(); l.Add(0); l.Add(3); l.Add(5); l.Add(7); l.Add(8);
//            List<int> r = new List<int>(); r.Add(1); r.Add(4); r.Add(6); r.Add(8);
//            Console.WriteLine("Merge test array:\n[{0}]", string.Join(", ", Merge(l, r)));
        }
        
        public static List<T> Sort<T>(List<T> array) where T : IComparable<T>
        {
            // List with length of 1 is already sorted
            if (array.Count <= 1)
                return array;
            
            // Divide array in two sublists
            List<T> left = new List<T>();
            List<T> right = new List<T>();
            for (int i = 0; i < array.Count; i++)
            {
                if (i < array.Count / 2)
                    left.Add(array[i]);
                else
                    right.Add(array[i]);
            }
            
            // Return sorted merge of both sublists
            return Merge(Sort(left), Sort(right));
        }
        
        private static List<T> Merge<T>(List<T> left, List<T> right) where T : IComparable<T>
        {
            int i = 0;
            int j = 0;
            List<T> res = new List<T>();
            //Console.Write("[{0}]", string.Join(", ", left));
            //Console.WriteLine(" / [{0}]", string.Join(", ", right));
            // Take smallest element from both sublists and add it to the result, forming a sorted merge result
            while (i < left.Count && j < right.Count) // left not empty && right not empty
            {
                if (left[i].CompareTo(right[j]) <= 0)
                    res.Add(left[i++]);
                else
                    res.Add(right[j++]);
            }
            
            //Copy leftovers from left into res
            while (i < left.Count)
                res.Add(left[i++]);
            //Copy leftovers from left into res
            while (j < right.Count)
                res.Add(right[j++]);
            //Console.WriteLine("RES:[{0}]", string.Join(", ", res));
            return res;
        }
    }
}