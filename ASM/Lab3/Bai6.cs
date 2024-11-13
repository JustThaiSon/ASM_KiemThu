using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Bai6
    {
        public int min(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("arr is null");
            }
            int numberMin = arr.OrderByDescending(x => x).First();
            return numberMin;
        }
    }
}
