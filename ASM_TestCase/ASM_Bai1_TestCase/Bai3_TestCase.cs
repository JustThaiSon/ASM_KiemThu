using ASM_Test.ASN_Bai1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_TestCase.ASM_Bai1_TestCase
{
    [TestFixture]
    public class Bai3_TestCase
    {
        Bai3 _bai3 = new Bai3();

        [Test]
        [TestCase(2.4, 2)]
        [TestCase(2, 2.4)]
        [TestCase(2.4, 2.9)]
        public void Exception(double a, double b)
        {
            Assert.Throws<ArithmeticException>(() =>
            {
                _bai3.TinhHieu(a, b);
            });
        }

        [Test]
        [TestCase(3, 2, 1)]
        [TestCase(10, 4, 6)]
        [TestCase(11, 11, 0)]
        [TestCase(10, -4, 14)]
        [TestCase(-1, -2, 3)]
        [TestCase(5, -1, 6)]
        [TestCase(-1, -2, 3)]
        public void TinhHieu(double a, double b, double result)
        {
            Assert.That(_bai3.TinhHieu(a, b), Is.EqualTo(result));
        }
    }
}
