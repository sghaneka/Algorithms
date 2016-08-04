using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Structures.Queue
{
    public class ArrayQueue<T> : IQueue<T>
    {
        private int _front = 0;
        private int _rear = 0;

        private T[] _data;

        public ArrayQueue()
        {
            _data = new T[5];
        }

        private void Resize()
        {
            var tmp = new T[_data.Length + 5];
            int j = _front;
            for (int idx = 0; idx < _data.Length; idx++)
            {
                tmp[idx] = _data[(_front + idx) % _data.Length];
            }
            _front = 0;
            _rear = _data.Length;
            _data = tmp;
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Empty - Can't Dequeue");
            }
            T result = _data[_front];
            _front = (_front + 1) % _data.Length;
            return result;
        }

        public void Enqueue(T item)
        {
            _data[_rear] = item;
            _rear = (_rear + 1) % _data.Length;
            if (_rear == _front)   // at last element
            {
                Resize();
            }
        }

        public bool IsEmpty()
        {
            return Size() == 0;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Empty - Can't Peek");
            }
            T result = _data[_front];
            return result;
        }

        public int Size()
        {
            if (_rear < _front)
            {
                int remaining = _data.Length - _front;
                return remaining + _rear + 1;
            }
            return _rear - _front;
        }
    }
}
