using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_Test.ASN_Bai1
{
    public class Bai2
    {
        public double TinhTich(double a, double b)
        {
            if (a % 1 != 0 || b % 1 != 0)
            {
                throw new ArithmeticException("a và b phải là số nguyên");
            }
            return a * b;
        }
    }
}
