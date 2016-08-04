using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    public class SpecialPythagoreanTriplet
    {
        // a^2 + b^2 = c^2

        public int FindTriplet()
        {
            int firstNum = 1;
            int secondNum = 1;
            while (true)
            {
                int sumSq = firstNum*firstNum + secondNum*secondNum;
                int x = (int)Math.Floor(Math.Sqrt(sumSq));
                if (x*x != sumSq)
                {
                    secondNum++;
                    if (firstNum + secondNum + x > 1000)
                    {
                        firstNum++;
                        secondNum = 1;
                    }
                }
                else
                {
                    if (firstNum + secondNum + x == 1000)
                    {
                        break;
                    }
                    secondNum++;
                }
            }

            Console.WriteLine("triplet found: {0},{1},{2}", firstNum, secondNum,
                (int)(Math.Sqrt(firstNum * firstNum + secondNum * secondNum)));

            Console.WriteLine("Product: " + firstNum * secondNum * (int)(Math.Sqrt(firstNum * firstNum + secondNum * secondNum)));

            return 0;
        }
    }
}
