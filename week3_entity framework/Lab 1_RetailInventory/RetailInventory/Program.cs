using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main()
    {
        using (var context = new AppDbContext())
        {
            context.Database.Migrate();

            if (!context.Categories.Any())
            {
                var electronics = new Category { Name = "Electronics" };
                var grocery = new Category { Name = "Grocery" };

                context.Categories.AddRange(electronics, grocery);
                context.Products.AddRange(
                    new Product { Name = "Laptop", Stock = 5, Category = electronics },
                    new Product { Name = "Chips", Stock = 50, Category = grocery }
                );
                context.SaveChanges();
            }

            var products = context.Products.Include(p => p.Category).ToList();
            foreach (var p in products)
            {
                Console.WriteLine($"{p.Name} ({p.Category.Name}) - Stock: {p.Stock}");
            }
        }
    }
}
