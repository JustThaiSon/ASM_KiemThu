using ASM_Test.ASN_Bai1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_TestCase.ASM_Bai1_TestCase
{
    [TestFixture]
    public class Bai4_TestCase
    {
        Bai4 _bai4 = new Bai4();
        [TestCase(new double[] { })]
        public void Exception(double[] arr)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                _bai4.TrungBinhCong(arr);
            });
        }

        [Test]
        [TestCase(new double[] { 1, 2, 3, 4, 5 }, 3)]
        [TestCase(new double[] { -1, -2, -3, -4, -5 }, -3)]
        [TestCase(new double[] { -1, 2, -3, 4, -5, 6 }, 0.5)]
        [TestCase(new double[] { 10 }, 10)]
        [TestCase(new double[] { 0, 0, 0, 0, 0 }, 0)]
        [TestCase(new double[] { 1.5, 2.5, 3.5 }, 2.5)]
        [TestCase(new double[] { 1000000, 2000000, 3000000 }, 2000000)]
        [TestCase(new double[] { 10, 20 }, 15)]
        [TestCase(new double[] {2,3,4,5,2,4}, 10)]
        public void TinhTrungBinhCong(double[] arr,double result)
        {
          Assert.That(_bai4.TrungBinhCong(arr), Is.EqualTo(result));
        }

    }
}
