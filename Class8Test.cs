using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace TestProject1
{
    //120 mぐらいか？
    [TestClass]
    public class Class8Test
    {


        [TestMethod]
        public void testFindStep()
        {
            Chapter8RecursiveAndDynamicProgramming
                r = new Chapter8RecursiveAndDynamicProgramming();



            //When n = 4, answer = 7 
            //{take 1 step + answer (3 remaining)} + {take 2 steps + answer (2 remaining)} + 
            //{take 3 steps + answer (1 remaining)} 
            //= 4 + 2 + 1 
            Chapter8RecursiveAndDynamicProgramming.ResultObjects a1
                = new Chapter8RecursiveAndDynamicProgramming.ResultObjects();
            a1.remaining = 4;

            Assert.AreEqual(7, r.findStep(a1).stepsCase);
                

            //ans(1) = 1
            //ans(2) = 2
            //ans(3) = 4
            // 漸化式
            // recurrence formula
            //ans(4) = ans(4-1) + ans(4-2) + ans(4-3)

            //...

            //ans(n) = ans(n-1) + ans(n-2) + ans(n-3)



        }
    }
}

