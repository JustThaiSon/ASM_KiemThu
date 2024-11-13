using Lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_TestCase
{
    [TestFixture]
    public class Bai4_TestCase
    {
        Bai4 _bai4 = new Bai4();
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 },-1)]
        public void Exception(int[]arr , int index)
        {
            Assert.Throws<IndexOutOfRangeException>(() => { _bai4.GetElementAtIndex(arr, index); });
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4,5)]
        [TestCase(new int[] { 1, 2, 3, 4, 5,8,6,7,8 },8,8 )]
        [TestCase(new int[] { 1, 2 }, 1,2)]
        [TestCase(new int[] { 5, 1, 2 }, 0,5)]
        [TestCase(new int[] { 10, 5, 2 }, 2,2)]
        [TestCase(new int[] { 100, 5, 5 }, 0,100)]
        [TestCase(new int[] { -100, -50, 2 }, 2,2)]
        [TestCase(new int[] { -5, -1, 2 }, 1,-1)]
        [TestCase(new int[] { 6, 3, 2, 1 }, 3,1)]
        [TestCase(new int[] { 20, 10, 2 }, 1,10)]
        public void TruySuatPhanTu(int[] arr, int index,int result)
        {
            Assert.That(_bai4.GetElementAtIndex(arr,index), Is.EqualTo(result));
        }
    }
}
