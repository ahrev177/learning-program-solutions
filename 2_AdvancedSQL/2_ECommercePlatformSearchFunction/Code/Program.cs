using SearchFunction;
using System;

class Program
{
    static void Main()
    {
        var products = new Product[]
        {
            new Product { ProductId = 1, ProductName = "Laptop", Category = "Electronics" },
            new Product { ProductId = 2, ProductName = "Shirt", Category = "Apparel" },
            new Product { ProductId = 3, ProductName = "Watch", Category = "Accessories" }
        };

        int linearIndex = SearchService.LinearSearch(products, "Watch");
        Console.WriteLine($"Linear Search: Found at index {linearIndex}");

        Array.Sort(products, (a, b) => a.ProductName.CompareTo(b.ProductName));
        int binaryIndex = SearchService.BinarySearch(products, "Watch");
        Console.WriteLine($"Binary Search: Found at index {binaryIndex}");
    }
}