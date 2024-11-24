using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_Test.ASN_Bai1
{
    public class Bai4
    {
        public double TrungBinhCong(double[] arr)
        {
            if (arr.Length == 0)
            {
                throw new ArgumentNullException("Mảng Rỗng");
            }
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;
        }
    }
}
