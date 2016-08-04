using Euler.Problems;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Test.Euler
{
    [TestClass]
    public class PrefixEvaluatorTests
    {
        [TestMethod]
        public void IsOperand_IsTrue_For_AlphaNumeric()
        {
            var tmp = new PrefixEvaluator("");
            Assert.IsTrue(tmp.IsOperand('a'));
            Assert.IsTrue(tmp.IsOperand('g'));
            Assert.IsTrue(tmp.IsOperand('8'));
            Assert.IsFalse(tmp.IsOperand('.'));
        }
    }
}
