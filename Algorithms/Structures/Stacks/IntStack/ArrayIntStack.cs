using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Structures.Stacks.IntStack
{
    public class ArrayIntStack : IIntStack
    {
        private int[] _items;
        private int _stackPosition = -1;
        private int _initSize = 5;

        public ArrayIntStack()
        {
            _items = new int[_initSize];
        }

        public bool IsEmpty()
        {
            return (_stackPosition == -1);
        }

        public int Peek()
        {
            if (_stackPosition == -1)
                throw new InvalidOperationException("Stack is empty");
            return _items[_stackPosition];
        }

        public int Pop()
        {
            if (_stackPosition == -1)
                throw new InvalidOperationException("Stack is empty");
            return _items[_stackPosition--];
        }

        public void Push(int item)
        {
            if (++_stackPosition == _items.Length)
            {
                _items = ReSizeItemArray(_items.Length + 1);
            }
            _items[_stackPosition] = item;
        }

        private int[] ReSizeItemArray(int newSize)
        {
            var newItems = new int[newSize + 5];
            for (int i = 0; i < newItems.Length; i++)
            {
                newItems[i] = _items[i];
            }
            return newItems;
        }

        public int Size()
        {
            return _stackPosition+1;
        }
    }
}
