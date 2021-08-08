using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1;

namespace TestProject1
{
    [TestClass]
    public class Chapter6FindMedicineTest
    {


        [TestMethod]
        public void testFindBin()
        {

            LinkedList<LinkedList<double>> bins = new LinkedList<LinkedList<double>>();
            LinkedList<double> bin1 = new LinkedList<double>();
            bin1.AddLast(1.0);
            bins.AddLast(bin1);

            LinkedList<double> bin2 = new LinkedList<double>();
            bin2.AddLast(1.0);
            bins.AddLast(bin2);

            LinkedList<double> bin3 = new LinkedList<double>();
            bin3.AddLast(1.1);
            bins.AddLast(bin3);



            Assert.AreEqual(3, Chapter6FindMedicine.findBinFromMedicine(bins));

        }
    }
}
