using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Structures.Tree
{
    public static class TreeUtils
    {
        public static int Height(Node root)
        {
            int depth = 0;
            List<Node> currLine = new List<Node>();
            currLine.Add(root);
            List<Node> children;
            while ((children = GetChildren(currLine)).Count > 0)
            {
                depth++;
                currLine = children;
            }
            return depth;
        }

        public static List<Node> GetChildren(List<Node> nodes)
        {
            List<Node> results = new List<Node>();
            foreach (var n in nodes)
            {
                if (n.Left != null)
                    results.Add(n.Left);
                if (n.Right != null)
                    results.Add(n.Right);
            }
            return results;
        }
    }
}
