﻿using System;
using System.Data.SqlClient;
using System.Dynamic;

namespace Algorithms_Datastructures.Trees
{
    public class Heap<T> where T : IComparable<T>
    {
        private T[] _heap = new T[10];
        private int _i = 1; // used as index, points to first empty spot that is not on index 0
        
        public void Insert(T item)
        {
            // Insert in last spot and then percolate up
            _heap[_i] = item;
            
            //Percolate up the new item
            int i = _i;
            while (_heap[i].CompareTo(_heap[i / 2]) < 0 || i == 0)
            {
                //Smaller than parent, swap them
                T parent = _heap[i / 2];
                _heap[i / 2] = _heap[i];
                _heap[i] = parent;
                i /= 2; // Point to percolated item
            }
            if (++_i >= _heap.Length)
            { 
                IncreaseHeapSize();
            }
        }

        public int Size()
        {
            return _i - 1;
        }

        public void IncreaseHeapSize()
        {
            T[] res = new T[_heap.Length * 2];
            for (int i = 1; i < _heap.Length; i++)
            {
                res[i] = _heap[i];
            }
            _heap = res;
        }

        public override string ToString()
        {
            // Math.ceil(Math.log(_i, 2)) == amount of rows in the heap
            // 2^(#rows-1) is index of first element of last row AND also the length of that row (no. of elements)
            // Current row = Math.Ceiling(Math.log(i, 2))
            // Tabs needed at bottom row = length of bottom row - 1
            // Tabs per indent per row = Floor(length of bottom row / (log(i, 2) + 1))
            
            string res = "";
            int NoOfRows = (int) Math.Ceiling(Math.Log(Convert.ToDouble(_i), 2.0));
            int lengthOfLastRow = (int) Math.Pow(2, NoOfRows - 1);
            int firstPerRowOffset = lengthOfLastRow;
            for (int i = 1; i < _i; i++)
            {
                Console.WriteLine("i: {0} and lolr: {1} loop cond.: {2}", i, lengthOfLastRow, lengthOfLastRow / (i + 1));
                if (Math.Log(Convert.ToDouble(i), 2.0) == Math.Round(Math.Log(Convert.ToDouble(i), 2.0)))
                {
                    res += '\n';
                    Console.WriteLine("i: {0} and lolr: {1} first indent loop cond.: {2}", i, lengthOfLastRow, firstPerRowOffset / 2);
                    for (int j = 0; j < firstPerRowOffset / 2; j++)
                    {
                        res += "  ";
                    }
                    firstPerRowOffset /= 2;
                }
               
                res += _heap[i];
                Console.WriteLine(Math.Floor(lengthOfLastRow / (Math.Log(i, 2) + 1)));
                for (int j = 0; j < firstPerRowOffset+2; j++)
                {
                    //old loop cond: Math.Floor(lengthOfLastRow / (Math.Log(i, 2) + 1))
                    Console.WriteLine("i: {0} and indent is: {1}", i, firstPerRowOffset);
                    // firstPerRowOffset*2 / NoOfRows
                    res += "  ";
                }
            }
            
            /*
            string res = "";
            int NoOfRows = (int) Math.Ceiling(Math.Log(Convert.ToDouble(_i), 2.0));
            int lengthOfLastRow = (int) Math.Pow(2, NoOfRows - 1);
            for (int i = 1; i < _i; i++)
            {
                Console.WriteLine("i: {0} and lolr: {1} loop cond.: {2}", i, lengthOfLastRow, lengthOfLastRow / (i + 1));
                if (Math.Log(Convert.ToDouble(i), 2.0) == Math.Round(Math.Log(Convert.ToDouble(i), 2.0)))
                {
                    Console.WriteLine("newline at: {0}", Math.Log(Convert.ToDouble(i), 2.0));
                    res += '\n';
                    for (int j = 0; j < lengthOfLastRow / (i + 1) + 1; j++)
                    {
                        res += "\t";
                    }
                }
               
                res += _heap[i];
                for (int j = 0; j < lengthOfLastRow / (i + 1) ; j++)
                {
                    res += "\t";
                }
            }
            */
            
            return res;
        }
    }
}