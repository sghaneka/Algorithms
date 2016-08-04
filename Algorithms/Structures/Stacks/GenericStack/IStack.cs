using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Structures.Stacks.GenericStack
{
    public interface IStack<T>
    {
        Boolean IsEmpty();

        T Peek();

        T Pop();

        void Push(T item);

        int Size();
    }
}
