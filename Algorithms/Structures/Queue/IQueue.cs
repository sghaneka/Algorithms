using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Structures.Queue
{
    public interface IQueue<T>
    {
        T Dequeue();

        void Enqueue(T item);

        Boolean IsEmpty();

        T Peek();

        int Size();
    }
}
