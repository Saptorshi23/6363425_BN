using System;
using System.Collections.Generic;

namespace EcommerceSearchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product(101, "Laptop", "Electronics"),
                new Product(203, "Shirt", "Clothing"),
                new Product(150, "Smartphone", "Electronics"),
                new Product(120, "Book", "Stationery"),
                new Product(302, "Shoes", "Footwear")
            };

            Console.WriteLine("Original Product List:");
            foreach (var p in products)
                Console.WriteLine(p);

            Console.WriteLine("\n🔍 Linear Search for Product ID 150:");
            var linearResult = LinearSearch(products.ToArray(), 150);
            Console.WriteLine(linearResult != null ? $"Found: {linearResult}" : "Not Found");

            // Sort products by ProductId for binary search
            products.Sort((a, b) => a.ProductId.CompareTo(b.ProductId));

            Console.WriteLine("\nSorted Product List (for Binary Search):");
            foreach (var p in products)
                Console.WriteLine(p);

            Console.WriteLine("\n🔍 Binary Search for Product ID 150:");
            var binaryResult = BinarySearch(products.ToArray(), 150);
            Console.WriteLine(binaryResult != null ? $"Found: {binaryResult}" : "Not Found");
        }

        static Product LinearSearch(Product[] products, int productId)
        {
            foreach (var p in products)
            {
                if (p.ProductId == productId)
                    return p;
            }
            return null;
        }
        static Product BinarySearch(Product[] products, int productId)
        {
            int left = 0;
            int right = products.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (products[mid].ProductId == productId)
                    return products[mid];
                else if (productId < products[mid].ProductId)
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return null;
        }
    }
}
