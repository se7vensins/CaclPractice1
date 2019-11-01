using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CaclPractice1
{
    [TestFixture]
    public class CaclPractice1_Tester
    {
        [TestCase(1,2)]
        [TestCase(3,4)]
        [TestCase(100,1)]
        public void addTest(int num1, int num2)
        {

            CalcImplement c = new CalcImplement();
            var expected = num1 + num2;
            Assert.That(c.add(num1, num2), Is.EqualTo(expected));
        }
        [TestCase(1, 2)]
        [TestCase(3, 4)]
        [TestCase(100, 1)]
        public void subTest(int num1, int num2)
        {

            CalcImplement c = new CalcImplement();
            var expected = num1 - num2;
            Assert.That(c.sub(num1, num2), Is.EqualTo(expected));
        }

        [TestCase(1, 2)]
        [TestCase(3, 4)]
        [TestCase(100, 1)]
        public void divTest(int num1, int num2)
        {

            CalcImplement c = new CalcImplement();
            var expected = num1 / num2;
            Assert.That(c.div(num1, num2), Is.EqualTo(expected));
        }

        [TestCase(1, 2)]
        [TestCase(3, 4)]
        [TestCase(100, 1)]
        public void multTest(int num1, int num2)
        {

            CalcImplement c = new CalcImplement();
            var expected = num1 * num2;
            Assert.That(c.mult(num1, num2), Is.EqualTo(expected));
        }
    }
}
