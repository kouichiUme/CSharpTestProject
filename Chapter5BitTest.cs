using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestProject1
{
    [TestClass]
    public class Chapter5BitTest
    {


        [TestMethod]
        public void problem1()
        {


            ConsoleApp1.Chapter5Bit b = new ConsoleApp1.Chapter5Bit();

            UInt32 binary = b.problem1(0b1, 0b0, 0, 1);

            Console.WriteLine(binary);
            



        }
    }
}
