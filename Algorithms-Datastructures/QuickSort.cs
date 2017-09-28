using System;
using System.Collections.Generic;

namespace Algorithms_Datastructures
{
    public class QuickSort
    {

        public static void Main()
        {
            Random rnd = new Random();
            List<int> testcase = new List<int>();
            for (int i = 0; i < 8; i++)
            {
                testcase.Add(rnd.Next(0, 1001));
            }
            Console.WriteLine("[{0}]", string.Join(", ", testcase));
            testcase = Sort(testcase);
            Console.WriteLine("[{0}]", string.Join(", ", testcase));
        }
        
        public static List<U> Sort<U>(List<U> l) where U : IComparable<U>
        {
            if (l.Count <= 1)
            {
                return l;
            }

            
            int pivotIndex = FindPivotIndex(l);
            U pivot = l[pivotIndex];
            Console.WriteLine("PivIndex: {0} \t Pivot: {1}", pivotIndex, pivot);

            //Move pivot to last position
            Swap(pivotIndex, l.Count - 1, l);
            Console.WriteLine("Swapped Pivot:\n [{0}]", string.Join(", ", l));

            // TODO ensure list.Count > 1
            // TODO do insertion sort on smaller lists
            // TODO list with 3 elements or more (see above) should be sorted with insertion sort and returned (avoid doing mot on a three element list)
            // Loop from both direction (ignore pivot!) and swap variables into their respective parts of the list
            int i = 0;
            int j = l.Count - 2;
            while (i < j)
            {
                Console.WriteLine("p:{0} i:{1} j:{2}", pivot, i, j);
                //Console.WriteLine("28 CompareTo 36 => {0}", 28.CompareTo(36));
                if (l[i].CompareTo(pivot) > 0)
                {
                    if (l[j].CompareTo(pivot) < 0)
                    {
                        Console.WriteLine("Swapping from I {0} with {1}", l[i], l[j]);
                        Swap(i, j, l);
                    }
                }
                else
                {
                    i++;
                }

                if (l[j].CompareTo(pivot) < 0)
                {
                    if (l[i].CompareTo(pivot) > 0)
                    {
                        Console.WriteLine("Swapping from J {0} with {1}", l[i], l[j]);
                        Swap(i, j, l);
                    }
                }
                else
                {
                    j--;
                }
            }

            // Swap pivot back into the 'greater than pivot' part of the list
            Swap(i, l.Count - 1, l);

            Console.WriteLine("lower: [{0}]", string.Join(", ", l.GetRange(0, i+1)));
            Console.WriteLine("higher: [{0}]", string.Join(", ", l.GetRange(i, l.Count - i - 1)));
            // Continue QuickSorting on both sublists and then stitch the results together
            List<U> lower = Sort(l.GetRange(0, i+1));
            List<U> greater = Sort(l.GetRange(i, l.Count - i - 1));
            lower.AddRange(greater);
            return lower;
        }

        private static int FindPivotIndex<U>(List<U> list) where U : IComparable<U>
        {
            //TODO implement Median Of Three to find pivot
            //int[] indices = {0, list.Count / 2, list.Count - 1};
            //U[] elements = {list[0], list[list.Count / 2], list[list.Count - 1]};
            SortedDictionary<U, int> mot = new SortedDictionary<U, int>();
            try
            {
                mot.Add(list[0], 0);
                mot.Add(list[list.Count / 2], list.Count / 2);
                mot.Add(list[list.Count - 1], list.Count - 1);
            }
            catch (ArgumentException e) { /* D/C handled later */ }

            int i = 0;
            foreach (KeyValuePair<U, int> e in mot)
            {
                if (mot.Count == 3 && i == 1)
                    return e.Value;
                i++;
            }
            return 0;
        }

        private static void Swap<U>(int i, int j, List<U> l)
        {
            U temp = l[i];
            l[i] = l[j];
            l[j] = temp;
        }
    }
}