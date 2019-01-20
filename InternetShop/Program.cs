using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace InternetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Warehouse newProducts = new Warehouse();
            newProducts.products.Add(100, "Bread");
            newProducts.products.Add(101, "Water");
            newProducts.products.Add(102, "Juice");
            newProducts.products.Add(103, "Pasta");
            newProducts.products.Add(104, "Flour");
            newProducts.products.Add(105, "Eggs");
            newProducts.products.Add(106, "Tea");
            newProducts.products.Add(107, "Coffee");
            newProducts.products.Add(108, "Cocoa");

            newProducts.workers.Add(6007542, "Alex");
            newProducts.workers.Add(7566984, "Bill");


        }
    }
}
