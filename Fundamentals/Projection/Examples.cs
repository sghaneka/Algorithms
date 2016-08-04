using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fundamentals.Data;

namespace Fundamentals.Projection
{
    public class Examples
    {
        public static void SelectExample()
        {
            var customers = DataProvider.GetCustomers();
            var expr = customers.Select((c, index) => new {index, c.Name, c.Country});

            var expr2 = from c in customers
                select new
                {
                    c.Name,
                    c.Country
                };

            foreach(var item in expr)
                Console.WriteLine(item);

        }

        // Select combining collections,
        // Say we wanted to select all the orders of customers from Italy...
        // But this returns something as IEnumerable<Order[]> ...
        // What we really want is to have a flat order collection composed of the two order's
        // IEnumerable<Order>
        // We need SelectMany for that...
        public static void SelectManyIllustrations()
        {
            var orders = DataProvider.GetCustomers()
                .Where(c => c.Country == Countries.Italy)
                .Select((c => c.Orders));

            foreach (var item in orders)
                Console.WriteLine(item);

            var orders1 = DataProvider.GetCustomers()
                .Where(c => c.Country == Countries.Italy)
                .SelectMany((c => c.Orders));

            foreach (var item in orders1)
                Console.WriteLine(item);
        }
    }
}
