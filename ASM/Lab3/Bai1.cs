using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Bai1
    {
        public double Tich(double x, double y)
        {
            if (x % 1 != 0 || y % 1 != 0)
            {
                throw new ArithmeticException("x và y phải là số nguyên");
            }
            return x * y;
        }

    }
}
