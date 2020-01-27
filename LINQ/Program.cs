using LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            //Exercise1(); // :)
            //Exercise2(); // :)
            //Exercise3(); // :)
            //Exercise4(); // :)
            //Exercise5(); // :)
            //Exercise6(); // :)
            //Exercise7(); // :)
            //Exercise8(); // :)
            //Exercise9(); // :)
            //Exercise10(); // :)
            //Exercise11(); // :)
            //Exercise12(); // :)
            //Exercise13(); 
            //Exercise14(); // :)
            //Exercise15(); // :)
            //Exercise16(); // :)
            //Exercise17(); // :)
            //Exercise18(); // :)
            //Exercise19(); // :)
            //Exercise20(); //:)
            //Exercise21(); // :)
            //Exercise22(); // :)
            //Exercise23(); // :)
            //Exercise24(); // :)
            //Exercise25(); 
            //Exercise26(); // :)
            //Exercise27(); 
            //Exercise28(); // :)
            //Exercise29(); 
            //Exercise30(); // :)
            //Exercise31(); 
            //PrintAllProducts();
            //PrintAllCustomers();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            List<Product> products = new List<Product>();
        }

        #region "Sample Code"
        /// <summary>
        /// Sample, load and print all the product objects
        /// </summary>
        static void PrintAllProducts()
        {
            List<Product> products = DataLoader.LoadProducts();
            PrintProductInformation(products);
        }

        /// <summary>
        /// This will print a nicely formatted list of products
        /// </summary>
        /// <param name="products">The collection of products to print</param>
        static void PrintProductInformation(IEnumerable<Product> products)
        {
            string line = "{0,-5} {1,-35} {2,-15} {3,6:c} {4,6}";
            Console.WriteLine(line, "ID", "Product Name", "Category", "Unit", "Stock");
            Console.WriteLine("==============================================================================");

            foreach (var product in products)
            {
                Console.WriteLine(line, product.ProductID, product.ProductName, product.Category,
                    product.UnitPrice, product.UnitsInStock);
            }

        }

        /// <summary>
        /// Sample, load and print all the customer objects and their orders
        /// </summary>
        static void PrintAllCustomers()
        {
            var customers = DataLoader.LoadCustomers();
            PrintCustomerInformation(customers);
        }

        /// <summary>
        /// This will print a nicely formated list of customers
        /// </summary>
        /// <param name="customers">The collection of customer objects to print</param>
        static void PrintCustomerInformation(IEnumerable<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("==============================================================================");
                Console.WriteLine(customer.CompanyName);
                Console.WriteLine(customer.Address);
                Console.WriteLine("{0}, {1} {2} {3}", customer.City, customer.Region, customer.PostalCode, customer.Country);
                Console.WriteLine("p:{0} f:{1}", customer.Phone, customer.Fax);
                Console.WriteLine();
                Console.WriteLine("\tOrders");
                foreach (var order in customer.Orders)
                {
                    Console.WriteLine("\t{0} {1:MM-dd-yyyy} {2,10:c}", order.OrderID, order.OrderDate, order.Total);
                }
                Console.WriteLine("==============================================================================");
                Console.WriteLine();
            }
        }
        #endregion

        /// <summary>
        /// Print all products that are out of stock.
        /// </summary>
        static void Exercise1()
        {
            var outOfStock = DataLoader.LoadProducts().Where(p => p.UnitsInStock == 0);

            PrintProductInformation(outOfStock);
        }

        /// <summary>
        /// Print all products that are in stock and cost more than 3.00 per unit.
        /// </summary>
        static void Exercise2()
        {
            var inStockAndHigherThanThree = from p in DataLoader.LoadProducts().ToList()
                                            where p.UnitPrice > 3
                                            where p.UnitsInStock != 0
                                            select p;
            PrintProductInformation(inStockAndHigherThanThree);
        }

        /// <summary>
        /// Print all customer and their order information for the Washington (WA) region.
        /// </summary>
        static void Exercise3()
        {
            var customersInWashington = DataLoader.LoadCustomers().Where(c => c.Region == "WA");
            PrintCustomerInformation(customersInWashington);
        }

        /// <summary>
        /// Create and print an anonymous type with just the ProductName
        /// </summary>
        static void Exercise4()
        {
            List<Product> products = DataLoader.LoadProducts();
            var result = from product in products
                         select new
                         {
                             product_name = product.ProductName,
                         };
            foreach (var item in result)
            {
                Console.WriteLine($" - {item.product_name} - ");
            }
        }

        /// <summary>
        /// Create and print an anonymous type of all product information but increase the unit price by 25%
        /// </summary>
        static void Exercise5()
        {
            List<Product> products = DataLoader.LoadProducts();

            var result = from product in products
                         select new
                         {
                             product_id = product.ProductID,
                             product_name = product.ProductName,
                             product_category = product.Category,
                             unit_price = product.UnitPrice,
                             units_instock = product.UnitsInStock
                         };
            foreach (var item in result)
            {
                Console.WriteLine($"{item.product_id} - {item.product_name} - {item.product_category} - {item.units_instock} - {item.unit_price.ToString("C")}");
            }
        }

        /// <summary>
        /// Create and print an anonymous type of only ProductName and Category with all the letters in upper case
        /// </summary>
        static void Exercise6()
        {
            var products = from p in DataLoader.LoadProducts()
                           select new { UpperCaseStuff = p.ProductName + " | " + p.Category };


            Console.WriteLine("--------------------");
            foreach (var product in products)
            {
                Console.WriteLine(product.UpperCaseStuff.ToUpper());
                Console.WriteLine("");
                Console.WriteLine("");
            }

        }

        /// <summary>
        /// Create and print an anonymous type of all Product information with an extra bool property ReOrder which should 
        /// be set to true if the Units in Stock is less than 3
        /// 
        /// Hint: use a ternary expression
        /// </summary>
        static void Exercise7()
        {
            List<Product> products = DataLoader.LoadProducts();

            var result = from product in products
                         select new
                         {
                             product_id = product.ProductID,
                             product_name = product.ProductName,
                             product_category = product.Category,
                             unit_price = product.UnitPrice,
                             units_instock = product.UnitsInStock,
                             re_order = (product.UnitsInStock < 3) ? true : false,
                         };
            foreach (var item in result)
            {
                Console.WriteLine($"{item.product_id} - {item.product_name} - {item.product_category} - {item.units_instock} - {item.unit_price.ToString("C")} - {item.re_order}");
            }
        }

        /// <summary>
        /// Create and print an anonymous type of all Product information with an extra decimal called 
        /// StockValue which should be the product of unit price and units in stock
        /// </summary>
        static void Exercise8()
        {
            List<Product> products = DataLoader.LoadProducts();

            var result = from product in products
                         select new
                         {
                             product_id = product.ProductID,
                             product_name = product.ProductName,
                             product_category = product.Category,
                             unit_price = product.UnitPrice,
                             units_instock = product.UnitsInStock,
                             stock_value = product.UnitPrice * product.UnitsInStock,
                         };
            foreach (var item in result)
            {
                Console.WriteLine($"{item.product_id} - {item.product_name} - {item.product_category} - {item.units_instock} - {item.unit_price.ToString("C")} - {item.stock_value.ToString("C")}");
            }
        }

        /// <summary>
        /// Print only the even numbers in NumbersA
        /// </summary>
        static void Exercise9()
        {
            var onlyEvens = from number in DataLoader.NumbersA
                            where number % 2 == 0
                            orderby number
                            select number;
            foreach (var n in onlyEvens)
            {
                Console.WriteLine(n);
            }
        }

        /// <summary>
        /// Print only customers that have an order whose total is less than $500
        /// </summary>
        static void Exercise10()
        {
            //var underFiveHundred = from customer in DataLoader.LoadCustomers()
            //                       where customer.Orders 
            //                       select customer;



            //var underFiveHundred = from customer in DataLoader.LoadCustomers()
            //                       where customer.Orders.Total < 500.00M
            //                       where 
            //                       select customer;
            //PrintCustomerInformation(underFiveHundred);

            var underFiveHundred = from customer in DataLoader.LoadCustomers()
                                   from order in customer.Orders
                                   where order.Total < 500M
                                   select customer;
            PrintCustomerInformation(underFiveHundred);
        }

        /// <summary>
        /// Print only the first 3 odd numbers from NumbersC
        /// </summary>
        static void Exercise11()
        {
            var firstThreeOdds = (from number in DataLoader.NumbersC
                                  where number % 2 == 1
                                  select number).Take(3);
            foreach (var n in firstThreeOdds)
            {
                Console.WriteLine(n);
            }
        }

        /// <summary>
        /// Print the numbers from NumbersB except the first 3
        /// </summary>
        static void Exercise12()
        {
            var skipThree = (from number in DataLoader.NumbersB
                             select number).Skip(3);

            foreach (var n in skipThree)
            {
                Console.WriteLine(n);
            }
        }

        /// <summary>
        /// Print the Company Name and most recent order for each customer in Washington
        /// </summary>
        static void Exercise13()
        {
            var recentOrders = from customer in DataLoader.LoadCustomers().Where(c => c.Region == "WA")
                               from order in customer.Orders
                               group customer by order.OrderDate into g
                               select g.OrderByDescending(t => t.Orders).FirstOrDefault();
            PrintCustomerInformation(recentOrders);
        }

        /// <summary>
        /// Print all the numbers in NumbersC until a number is >= 6
        /// </summary>
        static void Exercise14()
        {
            var divisbleBy3FirstNumber = from number in DataLoader.NumbersC
                                         where number <= 6
                                         orderby number
                                         select number;
            foreach (var number in divisbleBy3FirstNumber)
            {
                Console.WriteLine(number);
            }
        }

        /// <summary>
        /// Print all the numbers in NumbersC that come after the first number divisible by 3
        /// </summary>
        static void Exercise15()
        {

            // This one is mind boggling

            var division = (from number in DataLoader.NumbersC
                            where number % 3 == 1
                            select number);

            var numbers = DataLoader.NumbersC.Skip(DataLoader.NumbersC.Where(e => e % 3 == 0).First() + 1);
            foreach (var num in numbers)
                Console.WriteLine(num);
        }

        /// <summary>
        /// Print the products alphabetically by name
        /// </summary>
        static void Exercise16()
        {
            var productsAlphabetically = from product in DataLoader.LoadProducts()
                                         group product by product.ProductName into newgroup
                                         orderby newgroup.Key
                                         select newgroup;
            string lineFormat = "{0, -15} {1, -15,} {2, 4}";

            foreach (var group in productsAlphabetically)
            {
                Console.WriteLine("");

                Console.WriteLine("-------------------------");

                foreach (var product in group)
                {
                    Console.WriteLine(product.ProductName);
                    Console.WriteLine("");
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Print the products in descending order by units in stock
        /// </summary>
        static void Exercise17()
        {
            var unitsInStockDescending = DataLoader.LoadProducts().OrderByDescending(p => p.UnitsInStock);
            PrintProductInformation(unitsInStockDescending);
        }

        /// <summary>
        /// Print the list of products ordered first by category, then by unit price, from highest to lowest.
        /// </summary>
        static void Exercise18()
        {
            var groups = from products in DataLoader.LoadProducts()
                         let price = products.UnitPrice
                         orderby price descending
                         group products by products.Category into newgroup
                         orderby newgroup.Key
                         select newgroup;

            string line = "{0,-15} {1,-15}";

            foreach (var group in groups)
            {
                Console.WriteLine("Category: {0}", group.Key);
                Console.WriteLine("=====================================");
                Console.WriteLine();
                foreach (var product in group)
                {
                    Console.WriteLine(line, product.ProductName, product.UnitPrice);
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Print NumbersB in reverse order
        /// </summary>
        static void Exercise19()
        {
            var reverseOrder = from number in DataLoader.NumbersB
                               orderby number descending
                               select number;
            foreach (var n in reverseOrder)
            {
                Console.WriteLine(n);
            }
        }

        /// <summary>
        /// Group products by category, then print each category name and its products
        /// ex:
        /// 
        /// Beverages
        /// Tea
        /// Coffee
        /// 
        /// Sandwiches
        /// Turkey
        /// Ham
        /// </summary>
        static void Exercise20()
        {
            var groups = from product in DataLoader.LoadProducts()
                         group product by product.Category into newgroup
                         orderby newgroup.Key
                         select newgroup;
            foreach (var group in groups)
            {
                Console.WriteLine("Category: {0}", group.Key);
                Console.WriteLine("---------------------------");

                foreach (var product in group)
                {
                    Console.WriteLine(product.ProductName, product.Category);
                }
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            }

        }

        /// <summary>
        /// Print all Customers with their orders by Year then Month
        /// ex:
        /// 
        /// Joe's Diner
        /// 2015
        ///     1 -  $500.00
        ///     3 -  $750.00
        /// 2016
        ///     2 - $1000.00
        /// </summary>
        static void Exercise21()
        {
            List<Customer> customers = DataLoader.LoadCustomers();
            var result = (from customer in customers
                          select new
                          {
                              companyName = customer.CompanyName,
                              YearGroups = (from order in customer.Orders
                                            group order by order.OrderDate.Year into sortedOrders
                                            select new
                                            {
                                                Year = sortedOrders.Key,
                                                MonthGroups = from order in sortedOrders
                                                              group order by order.OrderDate.Month into monthlyOrders
                                                              select new { Month = monthlyOrders.Key, Orders = monthlyOrders }
                                            }).ToList()
                          }).ToList();
            foreach (var item in result)
            {
                Console.WriteLine($"{item.companyName}");
                Console.WriteLine("");
                foreach (var year in item.YearGroups)
                {
                    Console.WriteLine($"{year.Year}");
                    Console.WriteLine("");
                    foreach (var month in year.MonthGroups)
                    {
                        Console.WriteLine($"{month.Month} - {month.Orders.Sum(x => x.Total).ToString("C")}");
                    }
                    Console.WriteLine("");
                }
            }
        }

        /// <summary>
        /// Print the unique list of product categories
        /// </summary>
        static void Exercise22()
        {
            var groups = from categories in DataLoader.LoadProducts()
                         group categories by categories.Category into newgroup
                         orderby newgroup.Key
                         select newgroup;

            foreach (var group in groups)
            {
                Console.WriteLine("Category: {0}", group.Key);
                Console.WriteLine("--------------------------");


            }

        }

        /// <summary>
        /// Write code to check to see if Product 789 exists
        /// </summary>
        static void Exercise23()
        {

            // How can I display that ID 789 does not exist? 

            Console.WriteLine("");
            var existsOrNot = from p in DataLoader.LoadProducts()
                              where p.ProductID == 789 // plug any number into this
                              select p;

            PrintProductInformation(existsOrNot);
            Console.WriteLine("");





        }

        /// <summary>
        /// Print a list of categories that have at least one product out of stock
        /// </summary>
        static void Exercise24()
        {
            var groups = from categories in DataLoader.LoadProducts()
                         where categories.UnitsInStock == 0
                         group categories by categories.Category into newgroup
                         orderby newgroup.Key
                         select newgroup;

            foreach (var group in groups)
            {

                Console.WriteLine("Category: {0}", group.Key);
                Console.WriteLine("--------------------------");


            }
        }

        /// <summary>
        /// Print a list of categories that have no products out of stock
        /// </summary>
        static void Exercise25()
        {
            //NEEDS WORK
            var groups = from categories in DataLoader.LoadProducts()
                         where categories.UnitsInStock == 0
                         group categories by categories.Category into newgroup
                         orderby newgroup.Key
                         select newgroup;

            foreach (var group in groups)
            {

                Console.WriteLine("Category: {0}", group.Key);
                Console.WriteLine("--------------------------");


            }
        }

        /// <summary>
        /// Count the number of odd numbers in NumbersA
        /// </summary>
        static void Exercise26()
        {
            int numberOfOdds = 0;
            var countingOdds = from number in DataLoader.NumbersA
                               where number % 2 == 1
                               orderby number
                               select number;
            foreach (var n in countingOdds)
            {
                numberOfOdds++;
                Console.WriteLine(n);
            }

            Console.WriteLine("");
            Console.WriteLine("The number of odds in this array: {0}", numberOfOdds);
            Console.WriteLine("");
        }

        /// <summary>
        /// Create and print an anonymous type containing CustomerId and the count of their orders
        /// </summary>
        static void Exercise27()
        {

            // NEEDS WORK 

            List<Customer> customers = DataLoader.LoadCustomers();

            var result = from customer in customers
                         select new
                         {
                             customer_id = customer.CustomerID,
                             order_count = customer.Orders
                         };

            foreach (var item in result)
            {

                Console.WriteLine($" - {item.customer_id} - {item.order_count}");

            }

            //List<Customer> customers = DataLoader.LoadCustomers();

            //int orderCount = 0;
            //var result = from customer in customers
            //             select new
            //             {
            //                 customer_id = customer.CustomerID,
            //                 order_count = customer.Orders
            //             };
            //foreach (var item in result)
            //{

            //    Console.WriteLine($" - {item.customer_id} - {orderCount++} ");
            //}

        }

        /// <summary>
        /// Print a distinct list of product categories and the count of the products they contain
        /// </summary>
        static void Exercise28()
        {


            var groups = from categories in DataLoader.LoadProducts()
                         group categories by categories.Category into newgroup
                         orderby newgroup.Key
                         select newgroup;

            foreach (var group in groups)
            {
                Console.WriteLine("Category: {0}", group.Key);
                Console.WriteLine("--------------------------");

                int productCount = 0;


                foreach (var product in group)
                {
                    Console.WriteLine(product.ProductName);
                    Console.WriteLine("");
                    productCount++;

                }
                Console.WriteLine("*******************");
                Console.WriteLine("PRODUCT COUNT: {0}", productCount);
                Console.WriteLine("*******************");
                Console.WriteLine();





            }
        }

        /// <summary>
        /// Print a distinct list of product categories and the total units in stock
        /// </summary>
        static void Exercise29()
        {

            // NEEDS WORK
            var groups = from categories in DataLoader.LoadProducts()
                         group categories by categories.Category into newgroup
                         orderby newgroup.Key
                         select newgroup;

            foreach (var group in groups)
            {
                Console.WriteLine("Category: {0}", group.Key);
                Console.WriteLine("--------------------------");

                foreach (var units in groups)
                {
                    int totalUnitsInStock = 0;
                    totalUnitsInStock++;
                    Console.WriteLine("Total units in stock: {0}", totalUnitsInStock);
                }


            }
        }

        /// <summary>
        /// Print a distinct list of product categories and the lowest priced product in that category
        /// </summary>
        static void Exercise30()
        {
            var query = DataLoader.LoadProducts().GroupBy(r => r.Category)
                .Select(group => new
                {
                    Category = group.Key,
                    Min = group.Min(t => t.UnitPrice)
                });

            foreach (var result in query)
            {
                Console.WriteLine($" {result.Category} - {result.Min}");
            }
        }

        /// <summary>
        /// Print the top 3 categories by the average unit price of their products
        /// </summary>
        static void Exercise31()
        {
            //var products = DataLoader.LoadProducts();

            //decimal average = products.Average(s => s.UnitPrice);

            //Console.WriteLine("THe average unit price is: {0}", average);

            var averageUnitPrice = DataLoader.LoadProducts().OrderByDescending(p => p.UnitPrice).Take(3);

            PrintProductInformation(averageUnitPrice);
        }
    }
}
