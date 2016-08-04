using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    public class SumOfPrimes
    {
        public long FindSumOfPrimesBelow(int amount)
        {
            long total = 0;
            for (int i = 1; i < amount; i++)
            {
                if (IsPrime(i))
                {
                    total += i;
                  //  Console.WriteLine(i + " is prime");
                }
                else
                {
                    //Console.WriteLine(i + " is not prime");
                }
            }
            Console.WriteLine(total);
            return total;
        }

        public bool IsPrime(int candidate)
        {
            // Test whether the parameter is a prime number.
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            // Note:
            // ... This version was changed to test the square.
            // ... Original version tested against the square root.
            // ... Also we exclude 1 at the end.
            for (long i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }

        public void GeneratePrimes(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = 1;
            for (int outer = 2; outer <= arr.GetUpperBound(0);
                outer++)
                for (int inner = outer + 1; inner <= arr.GetUpperBound(0);
                    inner++)
                    ////if (arr[inner] == 1)
                        if ((inner % outer) == 0)
                            arr[inner] = 0;

            for (int i=2; i <= arr.GetUpperBound(0); i++)
            {
                if (arr[i] != 0)
                    Console.WriteLine(i);
            }
        }
    }
}
