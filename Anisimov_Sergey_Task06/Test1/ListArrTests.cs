using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library1;

namespace Test1
{
    [TestClass]
    public class ListArrTests
    {
        [TestMethod]
        public void ListArrAppend()
        {
            ListArr<int> first = new ListArr<int>();
            first.Append(12);
            first.Append(24);
            first.Append(36);
            Assert.AreEqual(24,first.Get(1),"тест с числами1");
            Assert.AreNotEqual(12, first.Get(2), "тест с числами2");

            ListArr<string> second = new ListArr<string>();
            second.Append("qwe");
            second.Append("asd");
            second.Append("zxc");
            Assert.AreEqual("asd", second.Get(1), "тест со строками1");
            Assert.AreNotEqual("zxc", second.Get(0), "тест со строками2");

            ListArr<int> third = new ListArr<int>();
            third.Append(12);
            third.Append(24);
            third.Append(36);
            third.Append(48);
            third.Append(60);
            third.Append(72);
            third.Append(84);
            third.Append(96);
            third.Append(108);
            Assert.AreEqual(108, third.Get(8), "тест с числами 3");
        }

        [TestMethod]
        public void ListArrInsertTests()
        {
            ListArr<int> first = new ListArr<int>();
            first.Append(12);
            first.Append(24);
            first.Append(36);
            first.Insert(44, 2);
            Assert.AreEqual(44, first.Get(2), "тест с числами1");
            Assert.AreEqual(36, first.Get(3), "тест с числами2");

            ListArr<string> second = new ListArr<string>();
            second.Append("qwe");
            second.Append("asd");
            second.Append("zxc");
            second.Insert("ewq", 2);
            Assert.AreEqual("ewq", second.Get(2), "тест со строками1");
            Assert.AreEqual("zxc", second.Get(3), "тест со строками2");
        }

        [TestMethod]
        public void ListArrGetTests()
        {
            ListArr<int> first = new ListArr<int>();
            Assert.AreEqual(default(int), first.Get(0), "тест с числами1");
            ListArr<string> second = new ListArr<string>();
            Assert.AreEqual(default(string), second.Get(0), "тест со строками1");
        }

        [TestMethod]
        public void ListArrDeleteTests()
        {
            ListArr<int> first = new ListArr<int>();
            first.Append(12);
            first.Append(24);
            first.Append(36);
            first.Append(48);
            first.Append(60);
            first.Append(72);
            first.Append(84);
            first.Append(96); //7
            first.Append(108);
            first.Delete(7);
            Assert.AreEqual(108, first.Get(7), "тест с числами1");
            Assert.AreEqual(default(int), first.Get(8), "тест с числами2");


            ListArr<string> second = new ListArr<string>();
            second.Append("qwe");
            second.Append("asd");
            second.Append("zxc");
            second.Insert("ewq", 2);
            second.Delete(0);
            Assert.AreEqual("asd", second.Get(0), "тест со строками1");
            Assert.AreEqual(default(string), second.Get(3), "тест со строками2");
        }

        [TestMethod]
        public void ListArrFindTests()
        {
            ListArr<int> first = new ListArr<int>();
            first.Append(12);
            first.Append(24);
            first.Append(36);
            first.Append(48);
            first.Append(60);
            first.Append(72);
            first.Append(84);
            first.Append(96); 
            first.Append(108);
            Assert.AreEqual(8, first.Find(108));
        }
    }
}
