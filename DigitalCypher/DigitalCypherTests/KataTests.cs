using Microsoft.VisualStudio.TestTools.UnitTesting;
using DigitalCypher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCypher.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void scoutAdd1939()
        {
            var except = new int[] {20, 12, 18, 30, 21};
            var actural = Kata.Encode("scout", 1939);
            CollectionAssert.AreEqual(except, actural);
        }
        [TestMethod()]
        public void masterpieceAdd1939()
        {
            var except = new int[] { 14, 10, 22, 29, 6, 27, 19, 18, 6, 12, 8 };
            var actural = Kata.Encode("masterpiece", 1939);
            CollectionAssert.AreEqual(except, actural);
        }
    }
}