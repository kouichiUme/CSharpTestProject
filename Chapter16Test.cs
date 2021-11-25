using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace TestProject1
{
    [TestClass]
    public class Chapter16Test
    {

        [TestMethod]
        public void SwapWithoutVariable()
        {

            int a = 1;
            int b = 2;
            int[] res =  Chapter16Intermediate.swapWithoutVariables(a,b);


            Assert.AreEqual(a, res[1]);
            Assert.AreEqual(b, res[0]);


        }


        [TestMethod]
        public void testCount()
        {

            String book = "吾輩は猫である。名前はまだない。";
            string word = "。";
            Chapter16Intermediate.countWordInBook(book, word);
            Chapter16Intermediate.countWordInBook(book, word);

        }



    }
}
