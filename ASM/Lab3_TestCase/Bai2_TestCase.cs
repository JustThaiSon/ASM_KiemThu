using Lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_TestCase
{
    public class Bai2_TestCase
    {
        Bai2 _bai2  = new Bai2();
        [TestCase(5,0)]
        [TestCase(10, 0)]
        public void Chia_TestCase_ThrowsExceptionForDivideByZero(double a, double b)
        {
            Assert.Throws<ArgumentException>(() => _bai2.Chia(a, b));
        }
        [Test]
        [TestCase(5, 1, 5)]
        [TestCase(5, 5, 1)]
        [TestCase(1, 1, 1)]
        [TestCase(10, 5, 2)]
        [TestCase(20, 5, 4)]
        [TestCase(100, 2, 50)]
        [TestCase(-10, 1, -10)]
        [TestCase(-10, -10, 1)]
        [TestCase(-10, 2, 5)]
        public void Chia(double x, double y,double result)
        {
         Assert.That(_bai2.Chia(x,y), Is.EqualTo(result));
        }
    }
}
