using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Structures.Stacks.IntStack
{
    public class LinkedIntListStack : IIntStack
    {
        NodeInt _stackHead;
        private int _itemCount;
        public bool IsEmpty()
        {
            return (_stackHead == null);
        }

        public int Peek()
        {
            if (_stackHead == null)
                throw new InvalidOperationException("Stack is empty");
            var result = _stackHead.Data;
            return result;
        }

        public int Pop()
        {
            if (_stackHead == null)
                throw new InvalidOperationException("Stack is empty");

            var result = _stackHead.Data;
            _stackHead = _stackHead.Next;
            _itemCount--;
            return result;
        }

        public void Push(int item)
        {
            NodeInt n = new NodeInt();
            n.Data = item;
            n.Next = _stackHead;
            _stackHead = n;
            _itemCount++;
        }

        public int Size()
        {
            return _itemCount;
        }
    }
}
