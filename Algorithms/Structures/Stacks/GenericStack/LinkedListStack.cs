using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Structures.Stacks.GenericStack
{
    public class LinkedListStack<T> : IStack<T>
    {
        Node<T> _stackHead;
        private int _itemCount;
        public bool IsEmpty()
        {
            return (_stackHead == null);
        }

        public T Peek()
        {
            if (_stackHead == null)
                throw new InvalidOperationException("Stack is empty");
            var result = _stackHead.Data;
            return result;
        }

        public T Pop()
        {
            if (_stackHead == null)
                throw new InvalidOperationException("Stack is empty");

            var result = _stackHead.Data;
            _stackHead = _stackHead.Next;
            _itemCount--;
            return result;
        }

        public void Push(T item)
        {
            Node<T> n = new Node<T>();
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
