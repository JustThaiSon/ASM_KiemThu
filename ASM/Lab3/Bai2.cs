using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Bai2
    {
        public double Chia(double x,double y)
        {
            if (y == 0)
            {
                throw new ArgumentException("Khong the chia cho 0");
            }
            return x / y;
        }
    }
}
