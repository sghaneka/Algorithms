using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Structures.Stacks.GenericStack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Test.Structures.Stacks.GenericStack
{
    [TestClass]
    public class LinkedListGenericStackTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "Stack is empty")]
        public void Linked_Int_Peek_Throws_InvalidException_If_Its_Empty()
        {
            var ais = new LinkedListStack<int>();
            ais.Peek();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "Stack is empty")]
        public void Linked_Int_Pop_Throws_InvalidException_If_Its_Empty()
        {
            var ais = new LinkedListStack<int>();
            ais.Pop();
        }

        [TestMethod]
        public void Linked_Int_Push_And_Pop_Work()
        {
            var ais = new LinkedListStack<int>();
            ais.Push(0);
            Assert.AreEqual(ais.Peek(), 0, "0 should be at the current position after push");
            ais.Push(7);
            ais.Push(4);
            ais.Push(8);
            Assert.AreEqual(ais.Pop(), 8, "8 should be popped out");
            Assert.AreEqual(ais.Peek(), 4, "4 should be at the current position");
            ais.Push(11);
            Assert.AreEqual(ais.Peek(), 11, "11 should be at the current position");
            Assert.AreEqual(ais.Pop(), 11, "11 should be popped out");
        }
    }
}
