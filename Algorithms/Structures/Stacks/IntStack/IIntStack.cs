using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Structures.Stacks.IntStack
{
    public interface IIntStack
    {
        Boolean IsEmpty();

        int Peek();

        int Pop();

        void Push(int item);

        int Size();
    }
}
