using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_Test.ASM_Bai2.Models
{
    public class SinhVien
    {
        public SinhVien(string id, string hoTen, string maLop, string tenLop, string maSv)
        {
            Id = id;
            HoTen = hoTen;
            MaLop = maLop;
            TenLop = tenLop;
            this.maSv = maSv;
        }
        public SinhVien()
        {
            
        }
        public string Id { get; set; }
        public string HoTen { get; set; }
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string maSv { get; set; }
    }
}
