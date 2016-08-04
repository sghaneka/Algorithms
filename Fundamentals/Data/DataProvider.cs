using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Data
{
    public static class DataProvider
    {
        public static Customer[] GetCustomers()
        {
            return new Customer[]
            {
                new Customer
                {
                    Name = "Paolo",
                    City = "Brescia",
                    Country = Countries.Italy,
                    Orders = new Order[]
                    {
                        new Order
                        {
                            IdOrder = 1,
                            Quantity = 3,
                            IdProduct = 1,
                            Shipped = false,
                            Month = "January"
                        },
                        new Order
                        {
                            IdOrder = 2,
                            Quantity = 5,
                            IdProduct = 2,
                            Shipped = true,
                            Month = "May"
                        }
                    }
                },
                new Customer
                {
                    Name = "Marco",
                    City = "Torino",
                    Country = Countries.Italy,
                    Orders = new Order[]
                    {
                        new Order
                        {
                            IdOrder = 3,
                            Quantity = 10,
                            IdProduct = 1,
                            Shipped = false,
                            Month = "July"
                        },
                        new Order
                        {
                            IdOrder = 4,
                            Quantity = 20,
                            IdProduct = 3,
                            Shipped = true,
                            Month = "December"
                        }
                    }
                },
                new Customer
                {
                    Name = "James",
                    City = "Dallas",
                    Country = Countries.USA,
                    Orders = new Order[]
                    {
                        new Order
                        {
                            IdOrder = 5,
                            Quantity = 20,
                            IdProduct = 3,
                            Shipped = true,
                            Month = "December"
                        }
                    }
                },
                new Customer
                {
                    Name = "Frank",
                    City = "Seattle",
                    Country = Countries.USA,
                    Orders = new Order[]
                    {
                        new Order
                        {
                            IdOrder = 6,
                            Quantity = 20,
                            IdProduct = 5,
                            Shipped = false,
                            Month = "July"
                        }
                    }
                }
            };
        }

        public static Product[] GetProducts()
        {
            return new Product[] {
    new Product {IdProduct = 1, Price = 10 },
    new Product {IdProduct = 2, Price = 20 },
    new Product {IdProduct = 3, Price = 30 },
    new Product {IdProduct = 4, Price = 40 },
    new Product {IdProduct = 5, Price = 50 },
    new Product {IdProduct = 6, Price = 60 }};
        }
    }
}
