using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library1;

namespace Test1
{
    [TestClass]
    public class StackArrTests
    {
        [TestMethod]
        public void StackArrPushTests()
        {
            StackArr<int> first = new StackArr<int>();
            first.Push(2);
            first.Push(4);
            first.Push(6);
            first.Push(8);
            first.Push(10);
            first.Push(12);
            Assert.AreEqual(12, first.Pop());
            Assert.AreEqual(10, first.Pop());
            Assert.AreEqual(8, first.Pop());
            Assert.AreNotEqual(4, first.Pop());

            StackArr<string> second = new StackArr<string>();
            second.Push("qwe");
            second.Push("asd");
            second.Push("zxc");
            second.Push("ewq");
            second.Push("dsa");
            second.Push("cxz");
            Assert.AreEqual("cxz", second.Pop());
            Assert.AreEqual("dsa", second.Pop());
            Assert.AreEqual("ewq", second.Pop());
            Assert.AreNotEqual("asd", second.Pop());

            first.Push(100);
            second.Push("qwerty");

            Assert.AreEqual(100, first.Pop());
            Assert.AreEqual("qwerty", second.Pop());
        }

        [TestMethod]
        public void StackArrPopTests()
        {
            StackArr<int> first = new StackArr<int>();
            StackArr<string> second = new StackArr<string>();

            Assert.AreEqual(default(int), first.Pop());
            Assert.AreEqual(default(string), second.Pop());
        }

    }
}
