using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library1;

namespace Test1
{
    [TestClass]
    public class QueueRefTests
    {
        [TestMethod]
        public void QueueRefInQueueTests()
        {
            QueueRef<int> first = new QueueRef<int>();
            first.InQueue(2);
            first.InQueue(4);
            first.InQueue(6);
            first.InQueue(8);
            first.InQueue(10);
            first.InQueue(12);
            Assert.AreEqual(2, first.DeQueue());
            Assert.AreEqual(4, first.DeQueue());
            Assert.AreEqual(6, first.DeQueue());
            Assert.AreNotEqual(10, first.DeQueue());

            QueueRef<string> second = new QueueRef<string>();
            second.InQueue("qwe");
            second.InQueue("asd");
            second.InQueue("zxc");
            second.InQueue("ewq");
            second.InQueue("dsa");
            second.InQueue("cxz");
            Assert.AreEqual("qwe", second.DeQueue());
            Assert.AreEqual("asd", second.DeQueue());
            Assert.AreEqual("zxc", second.DeQueue());
            Assert.AreNotEqual("dsa", second.DeQueue());

            first.InQueue(100);
            second.InQueue("qwerty");

            Assert.AreEqual(10, first.DeQueue());
            Assert.AreEqual("dsa", second.DeQueue());
        }

        [TestMethod]
        public void QueueRefDeQueueTests()
        {
            QueueRef<int> first = new QueueRef<int>();
            QueueRef<string> second = new QueueRef<string>();

            Assert.AreEqual(default(int), first.DeQueue());
            Assert.AreEqual(default(string), second.DeQueue());
        }
    }
}
