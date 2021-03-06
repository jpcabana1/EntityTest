﻿using System;
using System.Linq;
using System.Reflection.Metadata;
using Entity_Test.Models;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace Entity_Test
{


    /*
        Microsoft.EntityFrameworkCore.Design
        Microsoft.EntityFrameworkCore.SqlServer
        Microsoft.EntityFrameworkCore.Tools

        Entity 
        -pegar dados de um banco que já existe
        OBS: esse comando abaixo deve ser em uma linha só.

        Scaffold-DbContext "Data Source=WINAP1CBJKY7GFD\SQLEXPRESS; Initial Catalog=Northwind; Integrated Security=True;ConnectRetryCount=0" 
        Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Context NorthwindContext
     */


    class Program
    {
        static void Main(string[] args)
        {
            using NorthwindContext context = new NorthwindContext();


            //Products product = new Products()
            //{   

            //    ProductName = "Coca-Cola Alterada",
            //    SupplierId = 1,
            //    CategoryId = 1,
            //    QuantityPerUnit = "10",
            //    UnitPrice = 5,
            //    UnitsInStock = 200,
            //    UnitsOnOrder = 3,
            //    ReorderLevel = 0,
            //    Discontinued = false
            //};

            //context.Add(product);
            //context.Update(product);
            //context.Remove(product);

            //context.SaveChanges();

            var products = context.Products
                .Where(p => p.ProductId == 78 && p.SupplierId == 1)
                .OrderBy(p => p.ProductId);

            foreach (Products p  in products)
            {
                Console.WriteLine($"Id: {p.ProductId}");
            }

            Console.WriteLine("All stuff saved into the database");
            Console.ReadLine();
        }
    }
}
