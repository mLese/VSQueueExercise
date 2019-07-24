using Microsoft.VisualStudio.TestTools.UnitTesting;
using Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Tests
{
    [TestClass()]
    public class MyQueueTests
    {
        MyQueue<int> queue;

        [TestInitialize()]
        public void init()
        {
            queue = new MyQueue<int>();
        }
        [TestMethod()]
        public void dequeueTest()
        {
            queue.enqueue(0);
            queue.enqueue(1);
            Assert.AreEqual(0, queue.dequeue());
        }

        [TestMethod()]
        public void enqueueTest()
        {
            queue.enqueue(0);
            queue.enqueue(1);
            Assert.AreEqual(0, queue.peek());
        }

        [TestMethod()]
        public void peekTest()
        {
            queue.enqueue(1);
            Assert.AreEqual(1, queue.peek());
        }

        [TestMethod()]
        public void sizeTest()
        {
            queue.enqueue(0);
            queue.enqueue(1);
            queue.enqueue(3);
            Assert.AreEqual(3, queue.size());
        }
    }
}