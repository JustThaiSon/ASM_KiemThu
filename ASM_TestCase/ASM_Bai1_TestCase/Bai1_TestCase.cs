using ASM_Test.Bai1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_TestCase.ASM_Bai1_TestCase
{
    [TestFixture]
    public class Bai1_TestCase
    {
        Bai1 _bai1 = new Bai1();

        [Test]
        [TestCase(2.4,2)]
        [TestCase(2,2.4)]
        [TestCase(2.4,2.9)]
        public void Exception(double a,double b)
        {
            Assert.Throws<ArithmeticException>(() =>
            {
                _bai1.TinhTong(a,b);
            });
        }

        [Test]
        [TestCase(1,2,3)]
        [TestCase(1,2,3)]
        [TestCase(1,4,5)]
        [TestCase(10,4,14)]
        [TestCase(-1,2,1)]
        [TestCase(-1,-1,-2)]
        [TestCase(-1,-2,-3)]
        public void Exception(double a, double b,double result)
        {
            Assert.That(_bai1.TinhTong(a,b),Is.EqualTo(result));
        }

    }
}
