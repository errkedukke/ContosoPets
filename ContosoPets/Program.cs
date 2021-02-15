using ContosoPets.Data;
using ContosoPets.Models;
using System;
using System.Linq;

namespace ContosoPets
{
    class Program
    {
        static void Main(string[] args)
        {
            ContextAddInfo();
            //ContextReadInfo();
        }

        static void ContextAddInfo() 
        {
            using var context = new ContosoPetsContext();

            var squeakyBone = new Product()
            {
                Name = "Squeaky Bone Dog",
                Price = 4.99M
            };

            var tennisBall = new Product()
            {
                Name = "Tennis ball 3-Pack",
                Price = 9.99M
            };

            context.Add(squeakyBone);
            context.Add(tennisBall);

            context.SaveChanges();
        }
        static void ContextReadInfo()
        {
            using var context = new ContosoPetsContext();

            var products = context.Products
                .Where(p => p.Price >= 5.00m)
                .OrderBy(p => p.Name);

            foreach(var product in products) 
            {
                Console.WriteLine("Id: " + product.Id);
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price: " + product.Price);
                Console.WriteLine(new string('-', 20));
            }
        }
    }
}
