using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void a_true_return()
        {
            char perem = 'а';
            CHASTANAL.Program program = new CHASTANAL.Program();
            bool actual = CHASTANAL.Program.IsRussianBukva(perem);
            bool excepted = true;
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void я_true_return()
        {
            char perem = 'я';
            CHASTANAL.Program program = new CHASTANAL.Program();
            bool actual = CHASTANAL.Program.IsRussianBukva(perem);
            bool excepted = true;
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void вопрос_false_return()
        {
            char perem = '?';
            CHASTANAL.Program program = new CHASTANAL.Program();
            bool actual = CHASTANAL.Program.IsRussianBukva(perem);
            bool excepted = false;
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void пробел_false_return()
        {
            char perem = ' ';
            CHASTANAL.Program program = new CHASTANAL.Program();
            bool actual = CHASTANAL.Program.IsRussianBukva(perem);
            bool excepted = false;
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void negative___false_return()
        {
            char perem = '_';
            CHASTANAL.Program program = new CHASTANAL.Program();
            bool actual = CHASTANAL.Program.IsRussianBukva(perem);
            bool excepted = true;
            Assert.AreEqual(excepted, actual);
        }
    }
}
