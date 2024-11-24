using ASM_Test.ASM_Bai2;
using ASM_Test.ASM_Bai2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ASM_TestCase.ASM_Bai2_TestCase
{
    [TestFixture]
    public class SinhVienPolyTestCase
    {
        SinhVienPoly _sinhVienPoly = new SinhVienPoly();
        [TestCase("Nguyễn Văn A", 1)] 
        [TestCase("Trần Thị B", 1)]
        [TestCase("Không Tồn Tại", 0)] 
        public void searchName(string name, int expectedCount)
        {
            Assert.That(_sinhVienPoly.SearchByName(name).Count, Is.EqualTo(expectedCount));
        }
        [Test]
        [TestCase("LOP01", 1)] 
        [TestCase("LOP06", 1)] 
        [TestCase("LOP99", 0)]
        public void SearchByMaLop(string maLop, int expectedCount)
        {
            Assert.That(_sinhVienPoly.SearchByName(maLop).Count, Is.EqualTo(expectedCount));
        }

        [Test]
        [TestCase("SV001", 1)]
        [TestCase("SV006", 1)]
        [TestCase("SV949", 0)]
        [TestCase("SV9949", 0)]
        [TestCase("SV99229", 0)]
        public void SearchByMaSV(string MaSv, int expectedCount)
        {
            Assert.That(_sinhVienPoly.SearchByName(MaSv).Count, Is.EqualTo(expectedCount));
        }

        [Test]
        [TestCase("1", "Nguyễn Văn A", "LOP01", "Lớp!!!", "SV001")] 
        [TestCase("2", "Trần Thị B", "LOP02", "Lớp@ABC", "SV002")] 
        [TestCase("3", "Lê Minh C", "LOP03", "Lớp#$%^", "SV003")] 
        public void Exception_KytuDacBiet(string id, string hoTen, string maLop, string tenLop, string maSv)
        {
            var sinhvien = new SinhVien()
            {
                Id = id,
                HoTen = hoTen,
                MaLop = maLop,
                maSv = maSv,
                TenLop = tenLop,
            };
            Assert.Throws<InvalidOperationException>(() =>
            {
                _sinhVienPoly.Them(sinhvien);
            });
        }
        [Test]
        [TestCase("1", "Nguyễn Văn A", "LOP01", "Lop1", "SV001")]
        [TestCase("2", "Trần Thị B", "LOP02", "Lop2", "SV002")]
        [TestCase("3", "Lê Minh C", "LOP03", "Lop3", "SV003")]
        public void Exception_IdExist(string id, string hoTen, string maLop, string tenLop, string maSv)
        {
            var sinhvien = new SinhVien()
            {
                Id = id,
                HoTen = hoTen,
                MaLop = maLop,
                maSv = maSv,
                TenLop = tenLop,
            };
            Assert.Throws<ArithmeticException>(() =>
            {
                _sinhVienPoly.Them(sinhvien);
            });
        }
        [Test]
        [TestCase("11", "Nguyễn Văn N", "LOP01", "Lop1", "SV001")]
        [TestCase("12", "Trần Thị L", "LOP02", "Lop2", "SV002")]
        [TestCase("313", "Lê Minh G", "LOP03", "Lop3", "SV003")]
        [TestCase("323", "Lê Minh D", "LOP03", "Lop3", "SV003")]
        public void ThemSuccess(string id, string hoTen, string maLop, string tenLop, string maSv)
        {
            var sinhvien = new SinhVien()
            {
                Id = id,
                HoTen = hoTen,
                MaLop = maLop,
                maSv = maSv,
                TenLop = tenLop,
            };
            Assert.IsTrue(_sinhVienPoly.Them(sinhvien));
        }
    }
}
