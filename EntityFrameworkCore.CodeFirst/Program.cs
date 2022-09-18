using EntityFrameworkCore.CodeFirst.Context;
using EntityFrameworkCore.CodeFirst.Entities;
using System;
using System.Linq;

namespace EntityFrameworkCore.CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ECommerceDbContext northwindContext = new ECommerceDbContext())
            {
                var customers = northwindContext.Customers.ToList();
                foreach (Customer customer in customers)
                {
                    Console.WriteLine($"{customer.Name} {customer.Name}");
                }
            }
            Console.ReadLine();
        }
    }
}
