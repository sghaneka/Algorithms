using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Constructors
{

    public class BaseClass
    {
        public BaseClass(int a) { }

    }

    public class SubClass : BaseClass
    {
        public SubClass() : base(322)
        {
            
        }
    }
}
