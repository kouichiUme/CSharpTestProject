using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1;


namespace TestProject1
{
    [TestClass]
    public class Chapter2LinkTest
    {

        [TestMethod]
        public void TestRemoveNode()
        {

            LinkedList<int> ll = new LinkedList<int>();

            ll.AddLast(0);

            ll.AddLast(5);
            ll.AddLast(1);
            ll.AddLast(5);


            Chapter2Link<int>.deleteDuplicatedNode(ll,5);

            foreach(int a in ll)
            {
                Console.WriteLine(a);
            }

        }


    }
}
