using Euler.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    public class DivisibleTriangularNumber
    {
        public static int Highest(int divisorLimit)
        {
            int currentTriNum = 1;
            int currentIndex = 1;
            while (true)
            {
                int factors = NumberHelper.FindTotalDivisors(currentTriNum);
                if (factors > divisorLimit)
                    break;
                currentIndex++;
                Console.WriteLine("Checked: " + currentTriNum);
                currentTriNum = currentTriNum + currentIndex;
               
            }
            return currentTriNum;
        }
    }
}
