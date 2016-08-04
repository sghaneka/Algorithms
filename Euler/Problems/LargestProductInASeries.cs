using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    public class LargestProductInASeries
    {
        public long FindLargestProduct(string digits, int adjacentDigits)
        {
            long largestProduct = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                long currProd = 1;
                for (int cp = i; cp < i + adjacentDigits && cp < digits.Length; cp++)
                {
                    currProd = currProd*int.Parse(digits[cp].ToString());
                }
                if (currProd > largestProduct)
                    largestProduct = currProd;
            }
            Console.WriteLine("Largest Product: " + largestProduct);
            return largestProduct;
        }
    }
}
