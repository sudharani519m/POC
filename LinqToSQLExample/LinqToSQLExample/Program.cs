using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;

namespace LinqToSQLExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerDBEntities db = new CustomerDBEntities();
            //var cuslist = db.customers.tolist();
            //console.writeline(cuslist.count);

            //foreach (var item in cuslist)
            //{
            //    console.writeline(item.contactname);
            //}


            //#region Order By 

            //var products = db.Products.ToList();
            //var orderdedProducts = from n in products orderby n.ProductName descending select n;

            //foreach (var item in orderdedProducts)
            //{
            //    Console.WriteLine(item.ProductName);
            //}


            //#endregion
            //    Console.Read();
            //}

            //#region nested-count

            //List<Customer> customers = db.Customers.ToList();


            //var orderCounts = from c in customers
            //                  select (c.CustomerID, OrderCount: c.Orders.Count());

            //foreach (var customer in orderCounts)
            //{
            //    Console.WriteLine($"ID: {customer.CustomerID}, count: {customer.OrderCount}");
            //}

            //#endregion


            //#region grouped-count
            //List<Product> products = db.Products.ToList();

            //var categoryCounts = from p in products
            //                     group p by p.Category into g
            //                     select (Category: g.Key, ProductCount: g.Count());

            //foreach (var c in categoryCounts)
            //{
            //    Console.WriteLine($"Category: {c.Category.CategoryName}, Product count: {c.ProductCount}");

            //}
            //Console.ReadLine();
            //#endregion

            //#region grouped-sum
            //List<Product> products = db.Products.ToList();

            //var categories = from p in products
            //                 group p by p.Category into g
            //                 select (Category: g.Key, TotalUnitsInStock: g.Sum(p => p.UnitsInStock));

            //foreach (var pair in categories)
            //{
            //    Console.WriteLine($"Category: {pair.Category.CategoryName}, Units in stock: {pair.TotalUnitsInStock}");

            //}
            //Console.ReadLine();
            //#endregion

            //#region min-grouped
            //List<Product> products = db.Products.ToList();

            //var categories = from p in products
            //                 group p by p.Category into g
            //                 select (Category: g.Key, CheapestPrice: g.Min(p => p.UnitPrice));

            //foreach (var c in categories)
            //{
            //    Console.WriteLine($"Category: {c.Category.CategoryName}, Lowest price: {c.CheapestPrice}");

            //}
            //Console.ReadLine();
            //#endregion

            //#region min-each-group
            //List<Product> products = db.Products.ToList();

            //var categories = from p in products
            //                 group p by p.Category into g
            //                 let minPrice = g.Min(p => p.UnitPrice)
            //                 select (Category: g.Key, CheapestProducts: g.Where(p => p.UnitPrice == minPrice));

            //foreach (var c in categories)
            //{
            //    Console.WriteLine($"Category: {c.Category.CategoryName}");
            //    foreach (var p in c.CheapestProducts)
            //    {
            //        Console.WriteLine($"\tProduct: {p.ProductName}");

            //    }
            //}
            //Console.ReadLine();
            //#endregion

            //#region max-grouped
            //List<Product> products = db.Products.ToList();

            //var categories = from p in products
            //                 group p by p.Category into g
            //                 select (Category: g.Key, MostExpensivePrice: g.Max(p => p.UnitPrice));

            //foreach (var c in categories)
            //{
            //    Console.WriteLine($"Category: {c.Category.CategoryName} Most expensive product: {c.MostExpensivePrice}");
            //}
            //Console.ReadLine();
            //#endregion

            //#region average-grouped

            //List < Product > products = db.Products.ToList();
            //var categories = from p in products
            //                 group p by p.Category into g
            //                 select (Category: g.Key, AveragePrice: g.Average(p => p.UnitPrice));

            //foreach (var c in categories)
            //{
            //    Console.WriteLine($"Category: {c.Category.CategoryName}, Average price: {c.AveragePrice}");
            //}
            //Console.ReadLine();
            //#endregion

            //#region first-element
            //List<Product> products = db.Products.ToList();

            //Product product12 = (from p in products
            //                   where p.ProductID == 12
            //                  select p).First();


            //Console.WriteLine (product12.ProductID + product12.ProductName + product12.UnitPrice);
            //Console.ReadLine();
            //#endregion

            //var topOrderedProducts = db.Order_Details.GroupBy(od => od.ProductID)
            //                                         .Select(g => new { ProductID = g.Key, TotalQuantity = g.Sum(od => od.Quantity) })
            //                                         .OrderByDescending(g => g.TotalQuantity)
            //                                         .Take(3)
            //                                         .ToList();
            //foreach (var product in topOrderedProducts)
            //{
            //    Console.WriteLine("ProductID" + product.ProductID+ "ProductID TotalQuantity"+product.TotalQuantity);

            //}

            //  var customersByCountry = db.Customers
            //               .GroupBy(c => c.Country)
            //               .Select(g => new {Country = g.Key , Count = g.Count()})
            //               .ToList();

            //foreach ( var customer in customersByCountry)
            //{
            //    Console.WriteLine(customer.Country);
            //}

            //var ordersperCustomer = db.Orders
            //           .GroupBy(o => o.CustomerID)
            //           .Select(g => new {CustomerID = g.Key,TotalOrders = g.Count()})
            //           .ToList();
            //foreach (var order in ordersperCustomer) 
            //{
            //    Console.WriteLine(order.CustomerID);
            //}

            //Console.ReadLine();

            //var salesperProduct = db.Order_Details
            //           .GroupBy(od => od.ProductID)
            //           .Select(g => new { ProductID = g.Key, TotalSales = g.Sum(od => od.Quantity * od.UnitPrice) })
            //           .ToList();

            //foreach (var sale in salesperProduct)
            //{
            //    Console.WriteLine($"Product ID: {sale.ProductID}, Total Sales: {sale.TotalSales}");
            //}
            //Console.ReadLine();

            //var ordersperyears = db.Orders
            //           .GroupBy(o => o.OrderDate.Value.Year)
            //           .Select(g => new { year = g.Key, ordercount = g.Count() })
            //           .ToList();
            //foreach (var order in ordersperyears)
            //{
            //    Console.WriteLine($"year: {order.year} ,total orders: {order.ordercount}");

            //}
            //Console.ReadLine();

            //var orderswithcustomers = db.orders
            //             .join(db.customers, order => order.customerid, customer => customer.customerid,
            //              (order, customer) => new { order.orderid, customer.contactname, order.orderdate }).tolist();
            //     foreach ( var customer in orderswithcustomers )
            //{
            //    console.writeline($"order:{customer.orderid}, customer:{customer.contactname} ,orderdate:{customer.orderdate}");
            //}
            //console.readline();

            //var ProductsWithCategory = db.Products

            //    .Join(db.Categories,Product => Product.CategoryID,Category => Category.CategoryID,(Product,Category) => new { Product.ProductName, Category.CategoryName}).ToList();
            //foreach (var Product in ProductsWithCategory)
            //{
            //    Console.WriteLine($"Product:{Product.ProductName}, Category:{Product.CategoryName}");
            //}
            //Console.ReadLine();
             
                                     




        }


    }

    }
