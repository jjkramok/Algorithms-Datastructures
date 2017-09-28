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
            Console.WriteLine("[{0}] : length={1}", string.Join(", ", testcase), testcase.Count);
            //InsertionSort.Sort(testcase);
            Quicksort(testcase);
            Console.WriteLine("[{0}] : length={1}", string.Join(", ", testcase), testcase.Count);
        }


        public static void Quicksort<U>(List<U> l) where U : IComparable<U>
        {
            Sort(l, 0, l.Count - 1);
        }

        private static void Sort<U>(List<U> l, int low, int high) where U : IComparable<U>
        {
            // When insertionsort would be faster use insertionsort rather than recursively calling quicksort.
            const int insertionSortFaster = 10;
            if (l.Count <= insertionSortFaster)
            {
                InsertionSort.Sort(l);
                return;
            }
            int i = low;
            int j = high;
            int mid = (i + j) / 2; // index of middle of the sublist.
            
            // Sort for Median of Three
            if (l[j].CompareTo(l[i]) < 0)
                Swap(j, i, l);
            if (l[mid].CompareTo(l[i]) < 0)
                Swap(mid, i, l);
            if (l[j].CompareTo(l[mid]) < 0)
                Swap(j, mid, l);
            U pivot = l[mid]; // Mid points to the median of three, use that as pivot.
            
            while (i < j)
            {
                // Keep iterating through the list while things are still in the correct place.
                while (l[i].CompareTo(pivot) < 0)
                    i++;
                // Keep iterating through the list while things are still in the correct place.
                while (l[j].CompareTo(pivot) > 0)
                    j--;
                
                // Swap elements that are both in the wrong part of the list.
                if (i <= j)
                    Swap(i++, j--, l);
            }

            // If there are elements left over in the 'smaller than pivot'-part then continue quicksort on that part
            if (low < j)
                Sort(l, low, j);
            // If there are elements left over in the 'greater than pivot'-part then continue quicksort on that part
            if (i < high)
                Sort(l, i, high);
        }
        
        private static void Swap<U>(int i, int j, List<U> l)
        {
            U temp = l[i];
            l[i] = l[j];
            l[j] = temp;
        }
    }
}