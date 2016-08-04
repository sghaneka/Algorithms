using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Fundamentals.RegEx
{
    public class RegExExamples
    {
        public string Example1(string tmp)
        {
            string result = Regex.Replace(tmp, @"\\t|\\n|\\r", "");
            return result;
        }
    }
}
