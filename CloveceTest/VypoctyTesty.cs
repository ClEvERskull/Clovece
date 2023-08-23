using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Clovece;

namespace CloveceTest
{
    [TestClass]
    public class VypoctyTesty
    {
        [TestMethod]
        public void figurkyNieDoma()
        {
            Vypocty vypocty = new Vypocty();

            for (int i = 0; i < 4; i++)
            {
                Player.Instance.Hrac_x[i] = 5;
                Player.Instance.Hrac_y[i] = 5;
            }
            Assert.AreEqual<bool>(false, vypocty.domcek("zelena"));


            for (int i = 4; i < 8; i++)
            {
                Player.Instance.Hrac_x[i] = 5;
                Player.Instance.Hrac_y[i] = 5;
            }
            Assert.AreEqual<bool>(false, vypocty.domcek("cervena"));


            for (int i = 8; i < 12; i++)
            {
                Player.Instance.Hrac_x[i] = 5;
                Player.Instance.Hrac_y[i] = 5;
            }
            Assert.AreEqual<bool>(false, vypocty.domcek("modra"));


            for (int i = 12; i < 16; i++)
            {
                Player.Instance.Hrac_x[i] = 5;
                Player.Instance.Hrac_y[i] = 5;
            }
            Assert.AreEqual<bool>(false, vypocty.domcek("zlta"));
        }


        [TestMethod]
        public void figurkyDoma()
        {
            Vypocty vypocty = new Vypocty();
            for(int i = 0; i < 4; i++)
            {
                Player.Instance.Hrac_x[i] = Player.Instance.dx("zelena", i);
                Player.Instance.Hrac_y[i] = Player.Instance.dy("zelena", i);
            }
            Assert.AreEqual<bool>(true, vypocty.domcek("zelena"));

            for (int i = 4; i < 8; i++)
            {
                Player.Instance.Hrac_x[i] = Player.Instance.dx("cervena", i);
                Player.Instance.Hrac_y[i] = Player.Instance.dy("cervena", i);
            }
            Assert.AreEqual<bool>(true, vypocty.domcek("cervena"));

            for (int i = 8; i < 12; i++)
            {
                Player.Instance.Hrac_x[i] = Player.Instance.dx("modra", i);
                Player.Instance.Hrac_y[i] = Player.Instance.dy("modra", i);
            }
            Assert.AreEqual<bool>(true, vypocty.domcek("modra"));


            for (int i = 12; i < 16; i++)
            {
                Player.Instance.Hrac_x[i] = Player.Instance.dx("zlta", i);
                Player.Instance.Hrac_y[i] = Player.Instance.dy("zlta", i);
            }
            Assert.AreEqual<bool>(true, vypocty.domcek("zlta"));

        }


        [TestMethod]
        public void vsetkeFigurkyDoma()
        {
            Vypocty vypocty = new Vypocty();
            for (int i = 0; i < 4; i++)
            {
                Player.Instance.Hrac_x[i] = Player.Instance.dx("zelena", i);
                Player.Instance.Hrac_y[i] = Player.Instance.dy("zelena", i);
            }
            Assert.AreEqual<bool>(false, vypocty.jeVon("zelena"));

            for (int i = 4; i < 8; i++)
            {
                Player.Instance.Hrac_x[i] = Player.Instance.dx("cervena", i);
                Player.Instance.Hrac_y[i] = Player.Instance.dy("cervena", i);
            }
            Assert.AreEqual<bool>(false, vypocty.jeVon("cervena"));

            for (int i = 8; i < 12; i++)
            {
                Player.Instance.Hrac_x[i] = Player.Instance.dx("modra", i);
                Player.Instance.Hrac_y[i] = Player.Instance.dy("modra", i);
            }
            Assert.AreEqual<bool>(false, vypocty.jeVon("modra"));


            for (int i = 12; i < 16; i++)
            {
                Player.Instance.Hrac_x[i] = Player.Instance.dx("zlta", i);
                Player.Instance.Hrac_y[i] = Player.Instance.dy("zlta", i);
            }
            Assert.AreEqual<bool>(false, vypocty.jeVon("zlta"));

        }


        [TestMethod]
        public void figurkaVon()
        {
            Vypocty vypocty = new Vypocty();

            for (int i = 0; i < 4; i++)
            {
                Player.Instance.Hrac_x[i] = 5;
                Player.Instance.Hrac_y[i] = 5;
            }
            Assert.AreEqual<bool>(true, vypocty.jeVon("zelena"));


            for (int i = 4; i < 8; i++)
            {
                Player.Instance.Hrac_x[i] = 5;
                Player.Instance.Hrac_y[i] = 5;
            }
            Assert.AreEqual<bool>(true, vypocty.jeVon("cervena"));


            for (int i = 8; i < 12; i++)
            {
                Player.Instance.Hrac_x[i] = 5;
                Player.Instance.Hrac_y[i] = 5;
            }
            Assert.AreEqual<bool>(true, vypocty.jeVon("modra"));


            for (int i = 12; i < 16; i++)
            {
                Player.Instance.Hrac_x[i] = 5;
                Player.Instance.Hrac_y[i] = 5;
            }
            Assert.AreEqual<bool>(true, vypocty.jeVon("zlta"));
        }
    }
}
