using ASM_Test.ASN_Bai1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_TestCase.ASM_Bai1_TestCase
{
    public class Bai5_TestCase
    {
        Bai5 _bai5 = new Bai5();
        [Test]
        [TestCase(new double[] { 1, 2, 3, 4, 5 }, 9)]
        [TestCase(new double[] { 1, 2, 3, 4, 5 }, -3)]
        public void Exception(double[] arr, int index)
        {
            Assert.Throws<IndexOutOfRangeException>(() => { _bai5.GetIndex(arr, index); });
        }
        [TestCase(new double[] {},0)]
        public void Exception_ArrNull(double[] arr, int index)
        {
            Assert.Throws<ArgumentNullException>(() => { _bai5.GetIndex(arr, index); });
        }
        [Test]
        [TestCase(new double[] { 1, 2, 3, 4, 5 }, 2, 3)]
        [TestCase(new double[] { 1, 2, 3, 4, 5 }, 0, 1)]
        [TestCase(new double[] { 1, 2, 3, 4, 5 }, 4, 5)]
        [TestCase(new double[] { 10 }, 0, 10)]
        [TestCase(new double[] { 10, 1, 2, 4, 5, 9 }, 1, 1)]
        [TestCase(new double[] { -1, -2, -3 }, 1, -2)]
        [TestCase(new double[] { -1, 2, -3, 4, -5, 6 }, 5, 6)]
        [TestCase(new double[] { 1.1, 2.2, 3.3 }, 2, 3.3)]
        public void GetIndex(double[] arr, int index, double result)
        {
            Assert.That(_bai5.GetIndex(arr, index), Is.EqualTo(result));
        }
    }
}
