using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task6;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a1 = 1, a2 = 2, a3 = 3;
            int N = 3, M = 3, L = 0;
            List<double> array = new List<double>();
            List<double> add = new List<double>();
            bool limit = false;
            Program.Func(a1, a2, a3, array, M, N, L, add, ref limit);
            Assert.IsTrue(limit);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int a1 = 1, a2 = 2, a3 = 3;
            int N = 3, M = 3, L = 1;
            List<double> array = new List<double>();
            List<double> add = new List<double>();
            bool limit = false;
            Program.Func(a1, a2, a3, array, M, N, L, add, ref limit);
            Assert.IsFalse(limit);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int a1 = 1, a2 = 2, a3 = 3;
            int N = 4, M = 4, L = 1;
            List<double> array = new List<double>();
            List<double> add = new List<double>();
            bool limit = false;
            Program.Func(a1, a2, a3, array, M, N, L, add, ref limit);
            Assert.IsFalse(limit);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int a1 = 0, a2 = 0, a3 = 0;
            int N = 4, M = 3, L = 1;
            List<double> array = new List<double>();
            List<double> add = new List<double>();
            bool limit = false;
            Program.Func(a1, a2, a3, array, M, N, L, add, ref limit);
            Assert.IsFalse(limit);
        }
        [TestMethod]
        public void TestMethod5()
        {
            int a1 = -1, a2 = -1, a3 = 1;
            int N = 4, M = 3, L = 1;
            List<double> array = new List<double>();
            List<double> add = new List<double>();
            bool limit = false;
            Program.Func(a1, a2, a3, array, M, N, L, add, ref limit);
            Assert.IsFalse(limit);
        }
        [TestMethod]
        public void TestMethod6()
        {
            int a1 = 1, a2 = 2, a3 = 3;
            int N = 4, M = 3, L = 45;
            var array = new List<double>();
            List<double> add = new List<double>();
            bool limit = false;
            Program.Func(a1, a2, a3, array, M, N, L, add, ref limit);
            Assert.AreEqual(4.5, array.Last());
        }
        [TestMethod]
        public void TestMethod7()
        {
            int a1 = 1, a2 = 2, a3 = 3;
            int N = 5, M = 3, L = 45;
            var array = new List<double>();
            List<double> add = new List<double>();
            bool limit = false;
            Program.Func(a1, a2, a3, array, M, N, L, add, ref limit);
            Assert.AreEqual(13.5, array.Last());
        }
    }
}
