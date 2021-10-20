using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace TestProject1
{
    [TestClass]
    public class Chapter7DeckTest
    {

        [TestMethod]
        public void testGetValue()
        {

            ConsoleApp1.Suit s = ConsoleApp1.Suit.Club;

            // using ConsoleApp1を入れるとOK
            Assert.AreEqual(ConsoleApp1.Suit.Club, s.getValue());
            
            

        }

        [TestMethod]
        public void testGetFromValue()
        {
            Suit s = Suit.Club.getFromValue(4);
            
            // Assert.AreEqual(Suit.Club, s.getValue());
            Assert.AreEqual(Suit.Spade, s.getValue());
        }

        [TestMethod]
        public void testGetFromValueEnumNative()
        {

            int suitInteger = 3;
            Suit spade = (Suit)suitInteger;

            Assert.AreEqual(Suit.Spade, spade);


        }


    }
}
