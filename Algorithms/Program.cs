using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Searching;
using Algorithms.Structures.Tree;
using Fundamentals.Grouping;
using Algorithms.Sorting;
using Fundamentals.RegEx;
using Algorithms.Structures.Queue;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var rootNode = TreeBuilder.GetSampleTree();
            int depth = TreeUtils.Height(rootNode);
            Console.WriteLine(depth);
            Console.ReadLine();
        }




    }
}
