using ASM_Test.ASN_Bai1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_TestCase.ASM_Bai1_TestCase
{
    [TestFixture]
    public class Bai2_TestCase
    {
        Bai2 _bai2 = new Bai2();

        [Test]
        [TestCase(2.4, 2)]
        [TestCase(2,2.4)]
        [TestCase(2.4, 2.9)]
        public void Exception(double a,double b)
        {
            Assert.Throws<ArithmeticException>(() => { _bai2.TinhTich(a, b); });
        }

        [Test]
        [TestCase(1,2,2)]
        [TestCase(1,3,4)]
        [TestCase(1,0,0)]
        [TestCase(3,-1,-3)]
        [TestCase(-3,-2,6)]
        [TestCase(10,10,100)]
        [TestCase(5,5,25)]
        public void TinhTich(double a,double b,double result)
        {
            Assert.That(_bai2.TinhTich(a,b),Is.EqualTo(result));
        }
    }
}
