using System;
using System.Collections.Generic;

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
            for (var i = 2; i < p + 1; i++)
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


    }
}