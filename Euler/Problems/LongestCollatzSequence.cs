using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    public class LongestCollatzSequence
    {
        private long NextNumber(long currentNumber)
        {
            if (currentNumber%2 == 0)
            {
                return currentNumber/2;
            }
            return currentNumber*3 + 1;
        }

        public long NumberForLongestChainBelow(long upperLimit)
        {
            long currentNumber = 13;
            long longestCount = 0;
            long longestNumber = currentNumber;
            while (currentNumber < upperLimit)
            {
                long tmp = currentNumber;
                long chainCount = 1;
                while (tmp != 1)
                {
                    tmp = NextNumber(tmp);
                    chainCount++;
                }
                if (chainCount > longestCount) {
                    longestCount = chainCount;
                    longestNumber = currentNumber;
                }
                currentNumber++;
            }
            return longestNumber;
        }
    }
}
