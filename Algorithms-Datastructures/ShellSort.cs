using System;
using System.Collections.Generic;

namespace Algorithms_Datastructures
{
    public class ShellSort
    {
        public ShellSort()
        {
            Random rng = new Random();
            List<int> array = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                array.Add(rng.Next(1, 100));
            }
            Console.WriteLine("Random input array:\n[{0}]", string.Join(", ", array));
            Sort(array);
            Console.WriteLine("Random input array:\n[{0}]", string.Join(", ", array));
        }

        public static void Sort<T>(List<T> array) where T : IComparable<T>
        {
            // Keep shellsorting for each gap, use magic number 2.2 for new gap calculation (best practise)
            for (int gap = (int) Math.Round(array.Count / 2.2); gap > 0; gap = gap == 2 ? 1 : (int) (gap / 2.2))
            {
                // Start at gap so we can compare backwards
                for (int i = gap; i < array.Count; i++)
                {
                    T temp = array[i];
                    int j = i;
                    // Do 'InsertionSort' on all elements in this gap sequence
                    for (; j >= gap && temp.CompareTo(array[j - gap]) < 0; j -= gap)
                        array[j] = array[j - gap];
                    array[j] = temp;
                }   
            }
        }
    }
}