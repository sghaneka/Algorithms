using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Utils
{
    public class NumberHelper
    {
        public static string Reverse(string target)
        {
            char[] charArray = target.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);   
        }

        public static int FindTotalDivisors(long num)
        {
            var primeFactors = FindPrimeFactors(num);
            int result = primeFactors.Keys.Aggregate(1, (current, key) => current*(primeFactors[key] + 1));
            return result;
        }

        /// <summary>
        /// PrimeFactor of 28: 2, 7
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static Dictionary<int,int> FindPrimeFactors(long num)
        {
            int count = 0;
            Dictionary<int,int> primeFactors = new Dictionary<int, int>();
            while(true)
            {
                if ((num % 2 != 0) || num == 1) break;
                count++;
                if (primeFactors.ContainsKey(2))
                {
                    primeFactors[2]++;
                }
                else
                {
                    primeFactors[2] = 1;
                }
                num = num / 2;
            }

            int divisor = 3;
            while (true)
            {
                if (divisor > num) break;
                while (true)
                {
                    if (num % divisor != 0 || num == 1) break;
                    count++;
                    if (primeFactors.ContainsKey(divisor))
                    {
                        primeFactors[divisor]++;
                    }
                    else
                    {
                        primeFactors[divisor] = 1;
                    }
                    num = num / divisor;
                }
                divisor += 2;
            }
            return primeFactors;
        }

        public static string GetSum(string number1, string number2)
        {
            StringBuilder result = new StringBuilder();
            var maxNumberLength = Math.Max(number1.Length, number2.Length);
            string number1Reverse = Reverse(number1);
            string number2Reverse = Reverse(number2);
            int carryOver = 0;
            for (int i = 0; i < maxNumberLength; i++)
            {
                int digit1 = 0, digit2 = 0;
                if (i <= number1.Length - 1)
                {
                    digit1 = int.Parse(number1Reverse[i].ToString());
                }
                if (i <= number2.Length - 1)
                {
                    digit2 = int.Parse(number2Reverse[i].ToString());
                }
                int sumCurrentDigit = carryOver + digit1 + digit2;
                if (sumCurrentDigit <= 9)
                {
                    result.Append(sumCurrentDigit);
                    carryOver = 0;
                }
                else
                {
                    result.Append(sumCurrentDigit - 10);
                    carryOver = 1;
                }
            }
            if (carryOver == 1) result.Append("1");
            return Reverse(result.ToString());            
        }
    }
}
