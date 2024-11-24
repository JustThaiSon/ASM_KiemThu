using ASM_Test.ASM_Bai2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ASM_Test.ASM_Bai2
{
    public class SinhVienPoly
    {
        List<SinhVien> _sinhvien = new List<SinhVien>
            {
                new SinhVien("1", "Nguyễn Văn A", "LOP01", "Công nghệ thông tin", "SV001"),
                new SinhVien("2", "Trần Thị B", "LOP02", "Kỹ thuật phần mềm", "SV002"),
                new SinhVien("3", "Lê Minh C", "LOP03", "Hệ thống thông tin", "SV003"),
                new SinhVien("4", "Phạm Thanh D", "LOP04", "Trí tuệ nhân tạo", "SV004"),
                new SinhVien("5", "Hoàng Thị E", "LOP05", "An toàn thông tin", "SV005"),
                new SinhVien("6", "Đỗ Văn F", "LOP06", "Công nghệ đa phương tiện", "SV006")
            };

        public List<SinhVien> SearchByName(string name)
        {
            return _sinhvien.Where(x => x.HoTen == name).ToList();
        }
        public List<SinhVien> SearchByMaLop(string MaLop)
        {
            return _sinhvien.Where(x => x.MaLop == MaLop).ToList();
        }

        public bool Them(SinhVien sinhvien)
        {
            string validation = "^[a-zA-Z0-9 ]+$";
            Regex regex = new Regex(validation);
            if (!regex.IsMatch(sinhvien.TenLop))
            {
                throw new System.InvalidOperationException("Tên lớp không được có ký tự đặc biệt");
            }
            if (_sinhvien.Any(x=>x.Id == sinhvien.Id))
            {
                throw new ArithmeticException("Id Đã tồn tại");
            }
            _sinhvien.Add(sinhvien);
            return true;
        }

        public List<SinhVien> searchByMaSV(string MaSV)
        {
            return _sinhvien.Where(x => x.maSv == MaSV).ToList();
        }
    }
}
