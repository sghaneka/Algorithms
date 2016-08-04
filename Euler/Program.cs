using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Euler.Problems;
using Euler.Utils;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            // var tmp = new LongestCollatzSequence();
            // var x = tmp.NumberForLongestChainBelow(1000000);
            //
            PrefixEvaluator p = new PrefixEvaluator("-/+abc*d+ef");
            Console.WriteLine(p.GetInfix());
            int a = 1 % 5;
            Console.ReadLine();
        }

        static int[][] GetGrid()
        {
            int[][] result = new int[20][];

            int idx = 0;            
            using (StreamReader sw = new StreamReader(@"c:\temp\grid.txt"))
            {
                string line;
                while ((line = sw.ReadLine()) != null)
                {
                    string[] items = line.Split(' ');
                    result[idx] = new int[items.Length];
                    int ctr = 0;
                    foreach (string item in items)
                    {
                        result[idx][ctr++] = int.Parse(item);
                    }
                    idx++;
                }

            }

            return result;
        }
    }
}
