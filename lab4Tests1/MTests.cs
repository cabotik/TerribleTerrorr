using Microsoft.VisualStudio.TestTools.UnitTesting;
using TerribleTerror;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerribleTerror.Tests
{
    [TestClass()]
    public class MTests
    {
        [TestMethod()]
        public void CountAndResulttTestLose()
        {
            int predict1 = 5;
            int predict2 = 4;
            int number1 = 6;
            int number2 = 3;
            int number3 = 1;

            string expected = "Вы проиграли!";

            MainAction m = new MainAction();
            var actual = m.CountAndResult(number1, number2, number3, predict1, predict2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CountAndResulttTestLoseSecond()
        {
            int predict1 = 12;
            int predict2 = 4;
            int number1 = 1;
            int number2 = 1;
            int number3 = 5;

            string expected = "Вы проиграли!";

            MainAction m = new MainAction();
            var actual = m.CountAndResult( number1, number2, number3, predict1, predict2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CountAndResulttTestWin()
        {
            int number1 = 3;
            int number2 = 4;
            int number3 = 6;
            int predict1 = 13;
            int predict2 = 7;
          

            string expected = "Вы выйграли!";

            MainAction m = new MainAction();
            var actual = m.CountAndResult(number1, number2, number3, predict1, predict2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CountAndResulttTestWinSecond()
        {
            int number1 = 6;
            int number2 = 2;
            int number3 = 1;
            int predict1 = 9;
            int predict2 = 5;
            

            string expected = "Вы выйграли!";

            MainAction m = new MainAction();
            var actual = m.CountAndResult(number1, number2, number3, predict1, predict2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CountAndResulttTestLoseThird()
        {
            int predict1 = 678;
            int predict2 = 5;
            int number1 = 6;
            int number2 = 2;
            int number3 = 1;

            string expected = "Вы проиграли!";

            MainAction m = new MainAction();
            var actual = m.CountAndResult(number1, number2, number3, predict1, predict2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CountAndResulttTestLoseFourth()
        {
            int predict1 = 7;
            int predict2 = 3456;
            int number1 = 6;
            int number2 = 2;
            int number3 = 1;

            string expected = "Вы проиграли!";

            MainAction m = new MainAction();
            var actual = m.CountAndResult(number1, number2, number3, predict1, predict2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void CountAndResulttTestLoseFifth()
        {
            int predict1 = 564;
            int predict2 = 44;
            int number1 = 6;
            int number2 = 2;
            int number3 = 1;

            string expected = "Вы проиграли!";

            MainAction m = new MainAction();
            var actual = m.CountAndResult(number1, number2, number3, predict1, predict2);
            Assert.AreEqual(expected, actual);
        }
    }
}