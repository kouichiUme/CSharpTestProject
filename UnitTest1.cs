using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using log4net.Config;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodNGcase()
        {


            Assert.IsFalse(ConsoleApp1.Chapter1String.checkSortedString("abcde", "edcaa"));


        }
        [TestMethod]
        public void TestMethodNGLength()
        {
            ConsoleApp1.ApproximationAlgorithms aa = new ConsoleApp1.ApproximationAlgorithms();
            BasicConfigurator.Configure();
            aa.approxSubsetSum();
            Debug.WriteLine("debug ");
            Assert.IsFalse(ConsoleApp1.Chapter1String.checkSortedString("abcde", "edca"));


        }


        [TestMethod]
        public void TestMethodOKcase()
        {


            Assert.IsTrue(ConsoleApp1.Chapter1String.checkSortedString("abcde", "edcba"));


        }

        [TestMethod]
        public void testDuplicatedCharOK()
        {
            Assert.IsTrue(ConsoleApp1.Chapter1String.hasOnlyUniqueChars("abcde"));
        }


        [TestMethod]
        public void testDuplicatedCharNG()
        {
            Assert.IsFalse(ConsoleApp1.Chapter1String.hasOnlyUniqueChars("abcdea"));
        }


    }
}
