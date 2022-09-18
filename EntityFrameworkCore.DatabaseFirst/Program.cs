
using EntityFrameworkCore.DatabaseFirst.Context;
using EntityFrameworkCore.DatabaseFirst.Entities;
using System;
using System.Linq;

namespace EntityFrameworkCore.DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                var products = northwindContext.Products.ToList();
                foreach (Product product in products)
                {
                    Console.WriteLine($"{product.ProductName}");
                }
            }
            Console.ReadLine();
        }
    }
}
