using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Puzzles;

namespace PuzzleTests
{
    [TestClass]
    public class TestsWeek1
    {
        #region Week1

        [TestMethod]
        public void Puzzle1Test()
        {
            Assert.AreEqual("abc", Week1.Puzzle1("cba"));
            Assert.AreEqual("", Week1.Puzzle1(null));

        }

        [TestMethod]
        public void Puzzle2Test()
        {
            Assert.AreEqual(0, Week1.Puzzle2(""));
            Assert.AreEqual(0, Week1.Puzzle2(null));
            Assert.AreEqual(97, Week1.Puzzle2("a"));
            Assert.AreEqual(194, Week1.Puzzle2("aa"));
            Assert.AreEqual(98, Week1.Puzzle2("b"));
            Assert.AreEqual(294, Week1.Puzzle2("abc"));
        }

        [TestMethod]
        public void Puzzle3Test()
        {
            Assert.AreEqual("", Week1.Puzzle3(""));
            Assert.AreEqual("", Week1.Puzzle3(null));
            Assert.AreEqual("d", Week1.Puzzle3("a"));
            Assert.AreEqual("dd", Week1.Puzzle3("aa"));
            Assert.AreEqual("e", Week1.Puzzle3("b"));
            Assert.AreEqual("def", Week1.Puzzle3("abc"));
            Assert.AreEqual("abc", Week1.Puzzle3("xyz"));
        }

        [TestMethod]
        public void Puzzle4Test()
        {
            Assert.AreEqual("", Week1.Puzzle4(""));
            Assert.AreEqual("", Week1.Puzzle4(null));
            Assert.AreEqual("a", Week1.Puzzle4("a"));
            Assert.AreEqual("a", Week1.Puzzle4("aa"));
            Assert.AreEqual("b", Week1.Puzzle4("b"));
            Assert.AreEqual("abc", Week1.Puzzle4("abc"));
            Assert.AreEqual("a", Week1.Puzzle4("aaaa"));
            Assert.AreEqual("ab", Week1.Puzzle4("abab"));
        }

        [TestMethod]
        public void Puzzle5Test()
        {
            Assert.AreEqual("", Week1.Puzzle5(null));
            Assert.AreEqual("97", Week1.Puzzle5("a"));
            Assert.AreEqual("98", Week1.Puzzle5("b"));
            Assert.AreEqual("120", Week1.Puzzle5("x"));
            Assert.AreEqual("9797", Week1.Puzzle5("aa"));
            Assert.AreEqual("120121122", Week1.Puzzle5("xyz"));
        }

        [TestMethod]
        public void Puzzle6Test()
        {
            Assert.AreEqual(0, Week1.Puzzle6(0));
            Assert.AreEqual(1, Week1.Puzzle6(1));
            Assert.AreEqual(4, Week1.Puzzle6(2));
            Assert.AreEqual(9, Week1.Puzzle6(3));
            Assert.AreEqual(625, Week1.Puzzle6(25));
        }

        [TestMethod]
        public void Puzzle7Test()
        {
            // mõtelge params peale
            Assert.AreEqual(0, Week1.Puzzle7(0));
            Assert.AreEqual(2, Week1.Puzzle7(1, 1));
            Assert.AreEqual(15, Week1.Puzzle7(1, 2, 3, 4, 5));
        }

        [TestMethod]
        public void Puzzle8Test()
        {
            Assert.AreEqual(0, Week1.Puzzle8(0, 0));
            Assert.AreEqual(243, Week1.Puzzle8(121, 122));
        }

        [TestMethod]
        public void Puzzle9Test()
        {
            // mõtelge params peale
            Assert.AreEqual(0, Week1.Puzzle9(0));
            Assert.AreEqual(1, Week1.Puzzle9(1, 1));
            Assert.AreEqual(208, Week1.Puzzle9(1, 208, 3, 4, 5));
        }

        [TestMethod]
        public void Puzzle10Test()
        {
            Assert.AreEqual(0, Week1.Puzzle10(0));
            Assert.AreEqual(-1, Week1.Puzzle10(1));
            Assert.AreEqual(10, Week1.Puzzle10(-10));
        }

        #endregion
    }
    [TestClass]
    public class TestWeek2
    {
    #region Week2
        [TestMethod]
        public void Puzzle1Test()
        {
            Assert.AreEqual('c', Week2.Puzzle1(5, 'a', 'b', 'c'));
            //Assert.AreEqual('a', Week2.Puzzle1(-2, 'a', 'b', 'c'));
            Assert.AreEqual('b', Week2.Puzzle1(1, 'a', 'b', 'c'));
            Assert.AreEqual('x', Week2.Puzzle1(2, 'x', 'y', 'x', 'a', 'b'));
        }
        [TestMethod]
        public void Puzzle2Test()
        {
            Assert.AreEqual('\0', Week2.Puzzle2(5, null));
            Assert.AreEqual('\0', Week2.Puzzle2(5, new char[] { }));
            Assert.AreEqual('c', Week2.Puzzle2(5, new[] { 'a', 'b', 'c' }));
            Assert.AreEqual('b', Week2.Puzzle2(1, new[] { 'a', 'b', 'c' }));
            Assert.AreEqual('x', Week2.Puzzle2(2, new[] { 'x', 'y', 'x', 'a', 'b' }));
        }
        [TestMethod]
        public void Puzzle3Test()
        {
            int x;
            x = 4;
            Week2.Puzzle3(ref x);
            Assert.AreEqual(16, x);
            x = 5;
            Week2.Puzzle3(ref x);
            Assert.AreEqual(25, x);
        }
        [TestMethod]
        public void Puzzle4Test()
        {
            int x;
            x = 4;
            Week2.Puzzle4(x);
            Assert.AreEqual(4, x);
            x = 5;
            Week2.Puzzle4(x);
            Assert.AreEqual(5, x);
        }
        [TestMethod]
        public void Puzzle5Test()
        {
            int x;
            Week2.Puzzle5(4, out x);
            Assert.AreEqual(16, x);
            Week2.Puzzle5(5, out x);
            Assert.AreEqual(25, x);
        }
        [TestMethod]
        public void Puzzle6Test()
        {
            Assert.AreEqual(16, Week2.Puzzle6(4));
            Assert.AreEqual(25, Week2.Puzzle6(5));
        }
        ////Kasutada tuleb rekursiooni

        //[TestMethod]
        //public void Puzzle7Test()
        //{
        //    Assert.AreEqual(1, Week2.Puzzle7(0));
        //    Assert.AreEqual(1, Week2.Puzzle7(1));
        //    Assert.AreEqual(2, Week2.Puzzle7(2));
        //    Assert.AreEqual(6, Week2.Puzzle7(3));
        //    Assert.AreEqual(24, Week2.Puzzle7(4));
        //    Assert.AreEqual(120, Week2.Puzzle7(5));
        //    Assert.AreEqual(720, Week2.Puzzle7(6));
        //}
        ////Kasutada tuleb rekursiooni

        //[TestMethod]
        //public void Puzzle8Test()
        //{
        //    Assert.AreEqual("", Week2.Puzzle8(null));
        //    Assert.AreEqual("", Week2.Puzzle8(string.Empty));
        //    Assert.AreEqual("a", Week2.Puzzle8("a"));
        //    Assert.AreEqual("cba", Week2.Puzzle8("abc"));
        //}
        //[TestMethod]
        //public void Puzzle9Test()
        //{
        //    Assert.AreEqual(false, Week2.Puzzle9(null));
        //    Assert.AreEqual(false, Week2.Puzzle9(string.Empty));
        //    Assert.AreEqual(true, Week2.Puzzle9("a"));
        //    Assert.AreEqual(true, Week2.Puzzle9("anna"));
        //    Assert.AreEqual(false, Week2.Puzzle9("beta"));
        //    Assert.AreEqual(true, Week2.Puzzle9("123454321"));
        //}
        #endregion
    }
}
