using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Structures.Queue;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Test.Structures.Queue
{
    [TestClass]
    public class ArrayQueueTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "Empty - Can't Dequeue")]
        public void Dequeue_Throws_Exception_If_Queue_Is_Empty()
        {
            IQueue<int> tmp = new ArrayQueue<int>();
            tmp.Dequeue();
        }

        [TestMethod]
        public void Enqueue_Dequeue_Works_Ok()
        {
            IQueue<int> tmp = new ArrayQueue<int>();
            tmp.Enqueue(10);
            tmp.Enqueue(15);
            tmp.Enqueue(9);
            tmp.Enqueue(11);
            tmp.Enqueue(18);
            Assert.AreEqual(10, tmp.Dequeue());
            Assert.AreEqual(15, tmp.Dequeue());
            Assert.AreEqual(9, tmp.Dequeue());
            Assert.AreEqual(11, tmp.Dequeue());
            tmp.Enqueue(43);
            Assert.AreEqual(tmp.Size(), 2);
            Assert.AreEqual(18, tmp.Dequeue());
            Assert.AreEqual(43, tmp.Dequeue());
            Assert.AreEqual(tmp.Size(), 0);
            tmp.Enqueue(10);
            tmp.Enqueue(15);
            tmp.Enqueue(9);
            tmp.Enqueue(11);
            tmp.Enqueue(18);
            tmp.Dequeue();
            tmp.Dequeue();
            tmp.Enqueue(75);
            tmp.Enqueue(99);
            Assert.AreEqual(9, tmp.Dequeue());
            Assert.AreEqual(11, tmp.Dequeue());
            Assert.AreEqual(18, tmp.Dequeue());
            Assert.AreEqual(75, tmp.Dequeue());
            Assert.AreEqual(99, tmp.Dequeue());
        }
    }
}
