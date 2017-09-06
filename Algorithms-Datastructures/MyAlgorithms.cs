using System;
using System.Collections.Generic;

namespace Algorithms_Datastructures
{
    internal class MyAlgorithms
    {
        public static void Main(string[] args)
        {
        }

        public List<int> sieveOfEratosthenes(int p)
        {
            SortedDictionary<int, bool> N = new SortedDictionary<int, bool>();
            for (var i = 2; i < p; i++)
            {
                N.Add(i, true);
            }
            foreach (KeyValuePair<int, bool> entry in N)
            {
                Console.WriteLine(entry.Key + ", ");
            }
            foreach (KeyValuePair<int, bool> entry in N)
            {
                if (entry.Value)
                {
                    int i = entry.Key;
                    while (i < p)
                    {
                        i += entry.Key;
                    }
                    
                }
                    
            }
            
            
            return null;
        }
    }
}