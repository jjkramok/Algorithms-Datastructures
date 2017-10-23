using System;
using System.CodeDom.Compiler;
using System.Data.SqlClient;
using System.Dynamic;

namespace Algorithms_Datastructures.Trees
{
    public class Heap<T> where T : IComparable<T>
    {
        private T[] _heap = new T[10];
        private int _i = 1; // used as index, points to first empty spot that is not on index 0

        public Heap() {}

        public Heap(T[] bulk)
        {
            BuildHeap(bulk);
        }
        
        public T FindMin()
        {
            return _heap[1];
        }
        
        public void Insert(T item)
        {
            // TODO reduce array size when heap shrinks
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

        /// <summary>
        /// Assumes bulk array is completely filled
        /// </summary>
        /// <param name="bulk"></param>
        /// <returns></returns>
        public void BuildHeap(T[] bulk)
        {
            // Test with heaps of size 2 or 3
            _heap = new T[bulk.Length + 2];
            _i = bulk.Length + 1;
            Array.Copy(bulk, 0, _heap, 1, bulk.Length);
            
            // Start at the first index where swapping makes sense. So start at a node with children.
            int noOfRows = (int) Math.Ceiling(Math.Log(Convert.ToDouble(_i), 2.0));
            int lengthOfPenultimateRow = (int) Math.Pow(2, noOfRows - 2);
            int startIndex = lengthOfPenultimateRow + lengthOfPenultimateRow - 1;
            Console.WriteLine("Starting at: {0}", _heap[startIndex]);
            Console.WriteLine(ToString());
            for (int i = startIndex; i > 0; i--)
            {
                PercolateDown(i);
            }
        }

        private void PercolateDown(int node)
        {
            int noOfRows = (int) Math.Ceiling(Math.Log(Convert.ToDouble(_i), 2.0));
            int lengthOfPenultimateRow = (int) Math.Pow(2, noOfRows - 2);
            int startIndex = lengthOfPenultimateRow + lengthOfPenultimateRow - 1;
            
            // assume parent i, then childs are: 2i + 1 and 2i
            
            while (node <= startIndex)
            {
                if (node * 2 >= _i)
                {
                    // child is out of bounds (this parent has no children)
                    return;
                }

                int smallestIndex = node;
                T smallest = _heap[smallestIndex];
                if (!(node * 2 >= _i) && smallest.CompareTo(_heap[2 * node]) > 0)
                {
                    smallestIndex = 2 * node;
                    smallest = _heap[smallestIndex];
                }
                if (!(node * 2 + 1 >= _i) && smallest.CompareTo(_heap[2 * node + 1]) > 0)
                {
                    smallestIndex = 2 * node + 1;
                    smallest = _heap[smallestIndex];
                }
                if (smallestIndex == node)
                {
                    return; // node is smallest of itself and its children
                }
                
                // Percolate the new 
                T temp = _heap[node];
                _heap[node] = smallest;
                _heap[smallestIndex] = temp;
                
                // Keep percolating with the newly percolated item until it is in place
                node = smallestIndex;
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
            
            // Offset factor: OF(1) = (LoBR + (LoBR-1)) / 2
            // OF(r) = OF(r-1) / 2
            
            string res = "";
            string spacing = "  "; // mostly length of elements (string length) + 1 space is enough
            int NoOfRows = (int) Math.Ceiling(Math.Log(Convert.ToDouble(_i), 2.0));
            int lengthOfLastRow = (int) Math.Pow(2, NoOfRows - 1);
            for (int i = 1; i < _i; i++)
            {
                if (Math.Log(Convert.ToDouble(i), 2.0) == Math.Round(Math.Log(Convert.ToDouble(i), 2.0)))
                {
                    res += '\n';
                    int offset = OffsetFactor((int) Math.Ceiling(Math.Log(i, 2))+1, lengthOfLastRow);
                    for (int j = 0; j < offset; j++)
                    {
                        res += spacing;
                    }
                }
               
                res += _heap[i];
                int spacingFactor = SpacingFactor((int) Math.Floor(Math.Log(i, 2)) + 1, lengthOfLastRow);
                //Console.WriteLine("index: {0} rowNumb: {1} with spacing: {2}", i, (int) Math.Ceiling(Math.Log(i, 2)) + 1, spacingFactor);
                for (int j = 0; j < spacingFactor; j++)
                {
                    res += spacing;
                }
            }
            return res;
        }
        
        // current row number and length of bottom row; helper function for ToString
        private int OffsetFactor(int currRow, int lobr)
        {
            if (currRow == 1)
                return (lobr + (lobr - 1)) / 2;
            return OffsetFactor(currRow - 1, lobr) / 2;
        }

        // helper function for ToString
        private int SpacingFactor(int currRow, int lobr)
        {
            if (currRow == 1)
                return lobr + (lobr - 1);
            return SpacingFactor(currRow - 1, lobr) / 2;
        }
    }
}