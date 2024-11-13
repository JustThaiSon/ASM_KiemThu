using Lab3;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_TestCase
{
    [TestFixture]
    public class Bai6_TestCase
    {
        Bai6 _bai6 = new Bai6();
        [Test]
        [TestCase(new int[]{})]
        public void Exception(int[] arr)
        {
            Assert.Throws<ArgumentException>(() => { _bai6.min(arr); });
        }
        [Test]
        [TestCase(new int[] { 20, 10, 2 }, 2)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 1)]
        [TestCase(new int[] { -1, 2, 3, 4, 5 }, -1)]
        [TestCase(new int[] { 5, 4, 3, 2, 1 }, 1)]
        [TestCase(new int[] { 100, 50, 200, 10 }, 10)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, -5)]
        [TestCase(new int[] { 7 }, 7)]  
        [TestCase(new int[] { -7 }, -7)] 
        [TestCase(new int[] { 0, 0, 0, 0, 0 }, 0)]  
        [TestCase(new int[] { 2, 2, 2, 2, 2 }, 2)]
        public void TruySuatPhanTu(int[] arr, int result)
        {
            Assert.That(_bai6.min(arr), Is.EqualTo(result));
        }
    }
}
