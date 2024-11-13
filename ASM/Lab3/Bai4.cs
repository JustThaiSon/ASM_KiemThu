using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Bai4
    {
        public int GetElementAtIndex(int[] arr , int index )
        {
            if (arr.Length !>= index && index < 0)
            {
                throw new IndexOutOfRangeException("Index Không đúng");
            }
            return arr[index];
        }
    }
}
