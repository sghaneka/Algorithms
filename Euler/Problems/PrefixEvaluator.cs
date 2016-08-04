using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Euler.Problems
{
    public class PrefixEvaluator
    {
        // given expression as  - / + a b c * d + e f
        // convert this to infix
        // (a + b) / c - d* (e + f)

        string _prefix;

        public PrefixEvaluator(string prefix)
        {
            _prefix = prefix.Replace(" ", "");
        }

        public string GetInfix()
        {
            Stack<string> tmp = new Stack<string>();
            for(int idx = _prefix.Length-1; idx >= 0; idx--)
            {
                if (IsOperand(_prefix[idx]))
                {
                    tmp.Push(_prefix[idx].ToString());
                }
                else
                {
                    string op1 = tmp.Pop();
                    string op2 = tmp.Pop();
                    string exp = "";
                    if ( (_prefix[idx] == '+' || _prefix[idx] == '-') && idx > 0)
                    {
                        exp = string.Format("({0}{1}{2})", op1, _prefix[idx].ToString(), op2);
                    }
                    else
                    {
                        exp = string.Format("{0}{1}{2}", op1, _prefix[idx].ToString(), op2);
                    }
                    
                    tmp.Push(exp);
                }
            }
            return tmp.Pop();
        }

        private bool IsOperator(char c)
        {
            return (c == '+' || c == '-' || c == '*' || c == '/');
        }

        public bool IsOperand(char c)
        {
            // investigate regular expression for this
            // ^[a-zA-Z][a-zA-Z0-9]*$
            return Regex.Match(c.ToString(), @"^[a-zA-Z0-9]$").Success;
        }


    }


}
