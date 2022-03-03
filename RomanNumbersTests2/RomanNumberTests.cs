using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbers.Tests
{
    [TestClass()]
    public class RomanNumberTests
    {
        [TestMethod()]
        public void ZeroExceptionTest()
        {
            RomanNumber a;
            Assert.ThrowsException<RomanNumberException>(() => a = new(0));
        }
        [TestMethod()]
        public void ZeroExceptionTest2()
        {
            RomanNumber a = new(10);
            RomanNumber b = new(15);
            Assert.ThrowsException<RomanNumberException>(() => a - b);
        }
        [TestMethod()]
        public void RomanNumberTest()
        {
            RomanNumber a = new(45);
            Assert.IsNotNull(a);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            RomanNumber a = new(21);
            string result = "XXI";
            Assert.AreEqual(a.ToString(), result);
        }

        [TestMethod()]
        public void CloneTest()
        {
            RomanNumber a = new(123);
            RomanNumber b = (RomanNumber)a.Clone();
            Assert.AreNotSame(a, b);
        }

        [TestMethod()]
        public void ArraySortTest()
        {
            RomanNumber a = new(123);
            RomanNumber b = new(520);
            RomanNumber c = new(33);
            RomanNumber d = new(15);
            RomanNumber[] result = {d, c, a, b};
            RomanNumber[] massive = { a, b, c, d };

            Array.Sort(massive);
            for(int i = 0; i < 3; i++)
            {
                Assert.AreEqual(massive[i], result[i]);
            }
        }

        [TestMethod()]
        public void CompareToTest()
        {
            RomanNumber a = new(123);
            RomanNumber b = new(123);
            int expected = 0;
            int actual = a.CompareTo(b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AddTest()
        {
            RomanNumber a = new(123);
            RomanNumber b = new(520);
            RomanNumber result = new(643);
            Assert.AreEqual(result.ToString(), (a+b).ToString());
        }

        [TestMethod()]
        public void SubTest()
        {
            RomanNumber a = new(1450);
            RomanNumber b = new(520);
            RomanNumber result = new(930);
            Assert.AreEqual(result.ToString(), (a - b).ToString());
        }
        [TestMethod()]
        public void DivTest()
        {
            RomanNumber a = new(356);
            RomanNumber b = new(102);
            RomanNumber result = new(3);
            Assert.AreEqual(result.ToString(), (a / b).ToString());
        }
        [TestMethod()]
        public void MulTest()
        {
            RomanNumber a = new(9);
            RomanNumber b = new(8);
            RomanNumber result = new(72);
            Assert.AreEqual(result.ToString(), (a * b).ToString());
        }
    }
}