using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Problems
{
    public class LargestProductInAGrid
    {
        private int[][] _grid;
        public LargestProductInAGrid(int[][] grid)
        {
            _grid = grid;
        }

        public int FindProduct()
        {
            int maxProduct = 0;
            for (int y = 0; y < _grid.Length; y++)
            {
                for (int x = 0; x < _grid.Length; x++)
                {
                    int maxAtPosition = ReturnMaxAtPosition(y, x, 4);
                    if (maxAtPosition > maxProduct)
                        maxProduct = maxAtPosition;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Max is: " + maxProduct);
            return maxProduct;
        }

        private int ReturnMaxAtPosition(int y, int x, int range)
        {
            int maxProduct = 0;            
            var line = ExtractLine(Direction.Right, y, x);
            int currProd = FindMaxInLine(line, range);
            if (currProd > maxProduct)
                maxProduct = currProd;

            line = ExtractLine(Direction.Left, y, x);
            currProd = FindMaxInLine(line, range);
            if (currProd > maxProduct)
                maxProduct = currProd;

            line = ExtractLine(Direction.Down, y, x);
            currProd = FindMaxInLine(line, range);
            if (currProd > maxProduct)
                maxProduct = currProd;

            line = ExtractLine(Direction.Up, y, x);
            currProd = FindMaxInLine(line, range);
            if (currProd > maxProduct)
                maxProduct = currProd;

            line = ExtractLine(Direction.DownRight, y, x);
            currProd = FindMaxInLine(line, range);
            if (currProd > maxProduct)
                maxProduct = currProd;

            line = ExtractLine(Direction.DownLeft, y, x);
            currProd = FindMaxInLine(line, range);
            if (currProd > maxProduct)
                maxProduct = currProd;

            line = ExtractLine(Direction.UpLeft, y, x);
            currProd = FindMaxInLine(line, range);
            if (currProd > maxProduct)
                maxProduct = currProd;

            line = ExtractLine(Direction.UpRight, y, x);
            currProd = FindMaxInLine(line, range);
            if (currProd > maxProduct)
                maxProduct = currProd;

            return maxProduct;
        }


        private int FindMaxInLine(List<int> line, int range)
        {
            int[] lineArray = line.ToArray();
            int maxProd = 0;
            for (int curPos = 0; curPos < lineArray.Length; curPos++)
            {
                int curProd = 1;
                for (int idx = 0; idx < range; idx++)
                {
                    if ((curPos + idx) >= lineArray.Length)
                    {
                        return maxProd;
                    }
                    curProd *= line[curPos + idx];
                    if (curProd > maxProd)
                        maxProd = curProd;
                }
            }
            return maxProd;
        }

        private List<int> ExtractLine(Direction direction, int y, int x)
        {
            int dy = 0;
            int dx = 0;

            switch (direction)
            {
                case Direction.Right:
                    dx = 1;
                    break;
                case Direction.Left:
                    dx = -1;
                    break;
                case Direction.Down:
                    dy = 1;
                    break;
                case Direction.Up:
                    dy = -1;
                    break;
                case Direction.DownLeft:
                    dy = 1;
                    dx = -1;
                    break;
                case Direction.DownRight:
                    dy = 1;
                    dx = 1;
                    break;
                case Direction.UpLeft:
                    dy = -1;
                    dx = -1;
                    break;
                case Direction.UpRight:
                    dy = -1;
                    dx = 1;
                    break;
            }

          //  Console.WriteLine("Path: ");
            List<int> line = new List<int>();

            while ((x >= 0 && x < _grid.Length) &&
                   (y >= 0 && y < _grid.Length))
            {
                int num = _grid[y][x];
                line.Add(num);
                x += dx;
                y += dy;
            }

            return line;

        }


    }

    public enum Direction
    {
        Down,
        Right,
        Left,
        Up,
        DownRight,
        DownLeft,
        UpRight,
        UpLeft
    }
}
