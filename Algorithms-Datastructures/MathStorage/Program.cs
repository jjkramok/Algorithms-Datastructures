using System;
using System.Collections.Generic;

namespace MathStorage
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Product> warehouse = new List<Product>();
//            for (int i = 0; i < 10; i++)
//            {
//                warehouse.Add(new Product("", 0.0, false));
//            }
            warehouse.Add(new Product("Pineapple", 2.0, true));
            warehouse.Add(new Product("Orange", 0.5, true));
            warehouse.Add(new Product("Wodka", 3.2, true));
            warehouse.Add(new Product("Water", 0.8, true));
            warehouse.Add(new Product("Introduction to Calculus", Product.ECategory.Book, 32.0, true));
            warehouse.Add(new Product("Rollercoaster Tycoon 2", 5.0, false));
            warehouse.Add(new Product("OpenRCT2", 0.0, true));
            warehouse.Add(new Product("OpenRA", 0.0, true));
            warehouse.Add(new Product("OpenTTD", 0.0, true));
            warehouse.Add(new Product("The Way of Kings", Product.ECategory.Book, 45.0, true));
            warehouse.Add(new Product("Volleyball", 4.5, false));
            warehouse.Add(new Product("Aardappel", 0.32, true));

            // Ap : p e Products : InStock(p)
            Console.WriteLine("\n===Available Products===");
            // With delegate (anonymous) function
            Predicate<Product> avails = delegate(Product p)
                { return p.InStock; };

            // With lambda
            Predicate<Product> avails2 = p => p.InStock;
            
            for (int i = 0; i < warehouse.Count; i++)
            {
                if (avails(warehouse[i]))
                    Console.WriteLine(warehouse[i]);
            }
            
            // Ap : p e Products : StartWithLetterA(p)
            Console.WriteLine("\n===Start with letter 'A'===");
            Predicate<Product> startWithA = p => p.Name[0] == 'a' || p.Name[0] == 'A';
            
            for (int i = 0; i < warehouse.Count; i++)
            {
                if (startWithA(warehouse[i]))
                    Console.WriteLine(warehouse[i]);
            }
            
            // Ap : p e Products : MinimumPriceOfFiveUnits(p)
            Console.WriteLine("\n===Does everything have minimum price of five units?===");
            if (warehouse.FindAll(p => p.Price >= 5).Count < warehouse.Count)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }

            // Ep : p e Products : IsBook(p)
            Console.WriteLine("\n===Are there books in the warehouse?===");
            if (warehouse.Find(p => p.Category >= Product.ECategory.Book) != null)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            
            // Ap : p e Products : StartsWithLetterE(p) || !InStock(p)
            Console.WriteLine("\n===Do all products contain the letter 'e' or are they not in stock?===");
            if (warehouse.FindAll(p => !p.InStock || (p.Name.Contains("e") || p.Name.Contains("E")) ).Count == warehouse.Count ) 
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}