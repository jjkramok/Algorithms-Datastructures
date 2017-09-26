using System;

namespace MathStorage
{
    public class Product
    {
        public string Name { get; set; }
        public ECategory Category { get; set; }
        public double Price { get; set; }
        public bool InStock { get; set; }

        // Used by Predicates
        public static bool CheckInStock(Product p)
        {
            return p.InStock;
        }

        public Product(string name, ECategory category, double price, bool inStock)
        {
            Name = name;
            Category = category;
            Price = price;
            InStock = inStock;
        }
        
        public Product(string name, double price, bool inStock)
        {
            Name = name;
            Category = ECategory.None;
            Price = price;
            InStock = inStock;
        }


        public enum ECategory
        {
            None, Book
        }

        public override string ToString()
        {
            return Name + " - " + Category;
        }
    }
}