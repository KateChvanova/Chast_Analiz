using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chastota_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void chast_150and20_13i33returned()
        {
            int allBukvs = 150;
            int bukva = 20;
            CHASTANAL.Program program = new CHASTANAL.Program();
            var actual = CHASTANAL.Program.Chastota(allBukvs, bukva);
            var excepted = 13.33;
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void chast_99and3_3i03returned()
        {
            int allBukvs = 99;
            int bukva = 3;
            CHASTANAL.Program program = new CHASTANAL.Program();
            var actual = CHASTANAL.Program.Chastota(allBukvs, bukva);
            var excepted = 3.03;
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void negative_chast_666and222_55i66returned()
        {
            int allBukvs = 666;
            int bukva = 222;
            CHASTANAL.Program program = new CHASTANAL.Program();
            var actual = CHASTANAL.Program.Chastota(allBukvs, bukva);
            var excepted = 55.66;
            Assert.AreEqual(excepted, actual);
        }
    }
}
