using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Clovece;

namespace CloveceTest
{
    [TestClass]
    public class PlayerTesty
    {
        [TestMethod]
        public void playerX()
        {
            int pozicia = 0;
           
            Assert.AreEqual<int>(0, Player.Instance.x("zelena", pozicia));


            Assert.AreEqual<int>(6, Player.Instance.x("cervena", pozicia));


            Assert.AreEqual<int>(10, Player.Instance.x("modra", pozicia));


            Assert.AreEqual<int>(4, Player.Instance.x("zlta", pozicia));
        }


        [TestMethod]
        public void playerY()
        {
            int pozicia = 0;
            Assert.AreEqual<int>(6, Player.Instance.y("zelena", pozicia));


            Assert.AreEqual<int>(10, Player.Instance.y("cervena", pozicia));


            Assert.AreEqual<int>(4, Player.Instance.y("modra", pozicia));


            Assert.AreEqual<int>(0, Player.Instance.y("zlta", pozicia));
        }


        [TestMethod]
        public void domcekX()
        {
            Assert.AreEqual<int>(0, Player.Instance.dx("zelena", 0));


            Assert.AreEqual<int>(9, Player.Instance.dx("cervena", 4));


            Assert.AreEqual<int>(9, Player.Instance.dx("modra", 8));


            Assert.AreEqual<int>(0, Player.Instance.dx("zlta", 12));
        }


        [TestMethod]
        public void domcekY()
        {
            Assert.AreEqual<int>(9, Player.Instance.dy("zelena", 0));


            Assert.AreEqual<int>(9, Player.Instance.dy("cervena", 4));


            Assert.AreEqual<int>(0, Player.Instance.dy("modra", 8));


            Assert.AreEqual<int>(0, Player.Instance.dy("zlta", 12));
        }



    }
}