using Lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_TestCase
{
    public class Bai5_TestCase
    {
        Bai5 _bai5 = new Bai5();
        [TestCase("")]
        public void Exception(string Name) { 
        Assert.Throws<NullReferenceException>(() => _bai5.GetName(Name));
        }

        [TestCase("Thái Sơn", "Thái Sơn")]
        [TestCase("ThanhTuyen", "ThanhTuyen")]
        [TestCase("Nam Man Mát", "Nam Man Mát")]
        [TestCase("Hà Tồi", "Hà Tồi")]
        [TestCase("Phát SanhSM", "Thái Sơn")]
        [TestCase("Nghĩa Gaming", "Nghĩa Gaming")]
        [TestCase("Đẹp Trai vô cùng tận", "Đẹp Trai vô cùng tận")]
        [TestCase("Poly", "Poly")]
        [TestCase("Ong Vàng", "Ong Vàng")]
        [TestCase("Trượt", "Trượt")]
        public void TruySuatTen(string Name, string result)
        {
            Assert.That(_bai5.GetName(Name), Is.EqualTo(result));
        }
    }
}
