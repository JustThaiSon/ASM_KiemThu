using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Bai3
    {
        public double ChiaMang(int[] arr)
        {
            double avg = 1;
            foreach (int i in arr)
            {
                if (i == 0)
                {
                    throw new ArithmeticException("Mảng không được chứa số 0"); 
                }
                avg = avg / i;
            }
            return avg;
        }
    }
}
