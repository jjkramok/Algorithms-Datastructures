using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace Algorithms_Datastructures
{
    public class QuickSort
    {
        public static void Main()
        {
            Random rnd = new Random();
            List<int> testcase = new List<int>();
            for (int i = 0; i < 88; i++)
            {
                testcase.Add(rnd.Next(0, 1001));
            }
            Console.WriteLine("Start Test Case");
            Console.WriteLine("[{0}]", string.Join(", ", testcase));
            //InsertionSort.Sort(testcase);
            Quicksort(testcase);
            Console.WriteLine("[{0}]", string.Join(", ", testcase));
        }


        public static void Quicksort<U>(List<U> l) where U : IComparable<U>
        {
            Sort(l, 0, l.Count - 1);
        }

        private static void Sort<U>(List<U> l, int low, int high) where U : IComparable<U>
        {
            const int insertionSortFaster = 10;
            if (l.Count <= insertionSortFaster)
            {
                InsertionSort.Sort(l);
                return;
            }
            int lo = low;
            int hi = high;
            int mi = (lo + hi) / 2; // index of middle element
            
            // Sort for Median of Three
            if (l[hi].CompareTo(l[lo]) < 0)
                Swap(hi, lo, l);
            if (l[mi].CompareTo(l[lo]) < 0)
                Swap(mi, lo, l);
            if (l[hi].CompareTo(l[mi]) < 0)
                Swap(hi, mi, l);
            U pivot = l[mi];
            
            while (lo < hi)
            {
                //Console.WriteLine("p:{0} i:{1} j:{2}", pivot, lo, hi);
                while (l[lo].CompareTo(pivot) < 0)
                {
                    lo++;
                }
                while (l[hi].CompareTo(pivot) > 0)
                {
                    hi--;
                }

                if (lo <= hi)
                {
                    Swap(lo++, hi--, l);
                }
            }

            if (low < hi)
            {
                Sort(l, low, hi);
            }
            if (lo < high)
            {
                Sort(l, lo, high);
            }
        }
        
        private static void Swap<U>(int i, int j, List<U> l)
        {
            U temp = l[i];
            l[i] = l[j];
            l[j] = temp;
        }
    }
}