using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;

namespace Algorithms_Datastructures
{
    internal class MyAlgorithms<T> where T : IComparable<T>
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", SieveOfEratosthenes(53)));
        }

        /* Calculates all primes from 2 up until and including p. */
        public static SortedSet<int> SieveOfEratosthenes(int p)
        {
            Console.WriteLine(p);
            if (p < 2)
                return null;
            
            SortedSet<int> n = new SortedSet<int>();
            for (var i = 2; i < p+1; i++)
            {
                n.Add(i);
            }
            
            /*foreach (int primeCandidate in n)
            {
                Console.Write(primeCandidate + ", ");
            }
            Console.Write('\n');*/
        
            SortedSet<int> temp = new SortedSet<int>(n);
            foreach (int primeCandidate in temp)
            {
                //Start with first multiple of i as to not remove i itself (as i is a prime)
                int i = primeCandidate * 2;
                // Loop over all multiples of i and remove them from the list of possible primes (if it is a multiple of i, then it is divisable by i, and therefore not a prime
                while (i < p)
                {
                    n.Remove(i);
                    i += primeCandidate;
                }
            }
            return n;
        }

        public long Fac(int n)
        {
            long f = 1;
            for (int i = 1; i < n; i++)
            {
                f *= i;
            }
            return f;
        }

        public long FacRec(long n)
        {
            //todo base case
            return n * FacRec(n - 1);
        }
        
        public static List<T> QuickSort(List<T> l) {
            if (l.Count <= 1)
            {
                return l;
            }

            var pivotIndex = FindPivotIndex(l);
            T pivot = l[pivotIndex];
            
            //Move pivot to last position
            Swap(pivotIndex, l.Count-1, l);

            // TODO ensure list.Count > 1
            // TODO do insertion sort on smaller lists
            // TODO list with 3 elements or more (see above) should be sorted with insertion sort and returned (avoid doing mot on a three element list)
            // Loop from both direction (ignore pivot!) and swap variables into their respective parts of the list
            int i = 0;
            int j = l.Count - 2;
            while (i > j)
            {
                if (l[i].CompareTo(pivot) > 0 && l[j].CompareTo(pivot) < 0)
                {
                    Swap(i, j, l);
                }
                else
                {
                    i++;
                }

                if (l[j].CompareTo(pivot) < 0 && l[i].CompareTo(pivot) > 0)
                {
                    Swap(i, j, l);
                }
                else
                {
                    j++;
                }
            }
            
            
            // TODO first replace pivot with something in the greater sublist
            // Swap pivot back into the 'greater than pivot' part of the list
            Swap(i, l.Count-1, l);
            
            // Continue QuickSorting on both sublists and then stitch the results together
            List<T> lower = QuickSort(l.GetRange(0, i+1));
            List<T> greater = QuickSort(l.GetRange(i+1, l.Count - i)); //TODO does this work? check bounds
            lower.AddRange(greater);
            return lower;
        }

        private static int FindPivotIndex(List<T> list)
        {
            //TODO implement Median Of Three to find pivot
            //T[] mot = {list[0], list[list.Count / 2], list[list.Count - 1]}; 
            Random rnd = new Random();
            return rnd.Next(0, list.Count);
        }

        private static void Swap(int i, int j, List<T> l)
        {
            T temp = l[i];
            l[i] = l[j];
            l[j] = temp;
        }
    }
}