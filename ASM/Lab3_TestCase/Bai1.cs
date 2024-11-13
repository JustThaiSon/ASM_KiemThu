using Lab3;

namespace Lab3_TestCase
{
    [TestFixture]
    public class Bai1_TestCase
    {
        Bai1 _bai1 = new Bai1();
        [Test]
        [TestCase(10, 7.23)]
        public void Tich_Exception(double a, double b)
        {
            Assert.Throws<ArithmeticException>(() => { _bai1.Tich(a, b); });
        }

        [Test]
        [TestCase(1,2,2)]
        [TestCase(1,3,3)]
        [TestCase(2,5,10)]
        [TestCase(10,10,100)]
        [TestCase(-10,-10,-100)]
        [TestCase(-10,50,-100)]
        [TestCase(-10,0,0)]
        [TestCase(1,-1,-1)]
        [TestCase(-2,-3,-5)]
        public void Tich(double a, double b,double result )
        {
            Assert.That(_bai1.Tich(a, b), Is.EqualTo(result));
        }
    }
}