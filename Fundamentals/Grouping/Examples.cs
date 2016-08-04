using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Grouping
{
    public static class Examples
    {

        public static void PartitionListOfWordsByTheirFirstLetter()
        {
            string[] words = {"hello", "abc", "apple", "heist", "janu", "jungle", "baby", "cat", "doll"};
            var firstLetterGroups = from x in words
                group x by x[0]
                into wg
                select new
                {
                    wg.Key,
                    words = wg
                };

            foreach (var f in firstLetterGroups)
            {
                Console.WriteLine("First Letter: {0}", f.Key);
                foreach(var ww in f.words)
                    Console.WriteLine("Words: " + ww);
            }


        }

        public static void PartitionListOfNumbersByTheirRemainder()
        {
            int[] numbers = {3, 10, 13, 18, 21, 25, 30, 38, 39};
            var result = from x in numbers
                group x by new
                {
                    remainder = x%5
                }
                into g
                select new
                {
                    remainder = g.Key.remainder,
                    num = g.Key
                };

            var numberGroups = from x in numbers
                         group x by x % 5 into g
                             select new
                             {
                                Remainder = g.Key,
                                Numbers = g
                             };

            foreach (var x in numberGroups)
            {
                Console.WriteLine("Numbers with a remainder of {0}, when divided by 5:", x.Remainder);
                foreach (var n in x.Numbers)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }

}
