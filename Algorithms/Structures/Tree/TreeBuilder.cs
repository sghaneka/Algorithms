using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Structures.Tree
{
    public static class TreeBuilder
    {
        public static Node GetSampleTree()
        {
            var rn = new Node
            {
                Data = 3,
                Left = new Node {Data = 2, Left = new Node {Data = 1}},
                Right =
                    new Node
                    {
                        Data = 5,
                        Left = new Node {Data = 4},
                        Right = new Node {Data = 6, Right = new Node {Data = 7}}
                    }
            };
            return rn;
        }
    }
}
