using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Project3
{
    class Product
    //Author: Vinay Kudali
    //Purpose: Create a class Product and add variables id, name, price, brand. print product(name and brand) whose price is more than 500

    {
        public int Id;
        public string name;
        public int price;
        public string brand;
    }
    class Program
    { 
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product() { Id = 101, name ="Air Conditioner", price = 63000, brand = "Daikin"},
                new Product() { Id = 201, name ="Television",price = 47909, brand = "LG"},
                new Product() { Id = 301, name ="DvD player", price = 3987, brand = "Onida"},
                new Product() { Id = 401, name ="Refrigrator",price = 28890, brand = "Samsung"},
                new Product() { Id = 501, name ="Laptop", price = 43998, brand = "Dell"}
            };



            //Using For Loop
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].price>47000)
                    Console.WriteLine($"name={products[i].name}, brand={products[i].brand}");
            }

            //Using foreach loop
            foreach (var d in products)
            {
                if (d.price>47000)
                    Console.WriteLine($"name={d.name}, brand={d.brand}");
            }
            //using Lambda Expression
            products.Where(x => x.price>47000).ToList().ForEach(x => Console.WriteLine($"name={x.name}, brand={x.brand}"));


            //Even numbers using LINQ Query
            var result = from v in products
                         where v.price>47000
                         select v;
            result.ToList().ForEach(x => Console.WriteLine($"name={x.name}, brand={x.brand}"));

            Console.ReadLine();

        }
    }
}
