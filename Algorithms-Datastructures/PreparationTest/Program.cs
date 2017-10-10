using System;
using System.Collections.Generic;

namespace PreparationTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Excersice 1a");
            Excersice1.printLetters(3);
            
            Console.WriteLine("\n\nExcersice 1b");
            Excersice1.printLetters2(3, 5);
            Console.WriteLine();
            Excersice1.printLetters2(2, 0);
            
            Console.WriteLine("\n\nExcersice 2");
            Excercise2<int> bst = new Excercise2<int>();
            bst.Insert(6);
            bst.Insert(2);
            bst.Insert(8);
            bst.Insert(1);
            bst.Insert(4);
            bst.Insert(3);
            bst.PrintInOrder();
            Console.WriteLine(bst.GiveSecondSmallestElement());
            
            Console.WriteLine("\nExcersice 3");
            
            Console.WriteLine("\nExcersice 4");
//            Excersice4 graph = new Excersice4();
//            graph.AddVertex("A");
//            graph.AddVertex("B");
//            graph.AddVertex("C");
//            graph.AddVertex("D");
//            graph.AddVertex("E");
//            graph.AddVertex("F");
//            graph.AddVertex("G");
//            graph.AddVertex("H");
//            graph.AddVertex("K");
//            graph.AddEdge("A", "B");
//            graph.AddEdge("A", "G");
//            graph.AddEdge("C", "B");
//            graph.AddEdge("D", "F");
//            graph.AddEdge("E", "C");
//            graph.AddEdge("F", "F");
//            graph.AddEdge("G", "F");
//            graph.AddEdge("G", "H");
//            graph.AddEdge("H", "E");
//            graph.AddEdge("H", "K");
//            graph.AddEdge("K", "G");
//            Console.WriteLine(graph);

        }
    }
}