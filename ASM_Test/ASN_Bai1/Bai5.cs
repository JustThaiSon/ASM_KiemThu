using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_Test.ASN_Bai1
{
    public class Bai5
    {
        public double GetIndex(double[] arr,int index)
        {
            if (arr.Length == 0)
            {
                throw new ArgumentNullException("Mảng Rỗng");
            }

            if ( index > arr.Length || index < 0)
            {
                throw new IndexOutOfRangeException("index loiii");
            }
            return arr[index];
        }
    }
}
