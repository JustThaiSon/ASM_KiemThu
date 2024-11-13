using Lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_TestCase
{
    [TestFixture]
    public class Bai3_TestCase
    {
        Bai3 _bai3 = new Bai3();
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 0 })]
        public void Exception(int[] arr)
        {
            Assert.Throws<ArithmeticException>(() => { _bai3.ChiaMang(arr); });
        }
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0.00833333)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0.00833333)]
        [TestCase(new int[] { 1, 2 }, 0.5)]
        [TestCase(new int[] { 5, 1, 2 }, 0.1)]         
        [TestCase(new int[] { 10, 5, 2 }, 0.01)]        
        [TestCase(new int[] { 100, 5, 5 }, 0.004)]      
        [TestCase(new int[] { -100, -50, 2 }, 0.0001)]  
        [TestCase(new int[] { -5, -1, 2 }, 0.1)]        
        [TestCase(new int[] { 6, 3, 2, 1 }, 0.02777778)]
        [TestCase(new int[] { 20, 10, 2 }, 0.005)]
        public void Chia(int[] arr, double result)
        {
            Assert.That(_bai3.ChiaMang(arr), Is.EqualTo(result));
        }
    }
}
