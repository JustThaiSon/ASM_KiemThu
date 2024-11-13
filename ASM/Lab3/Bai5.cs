using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Bai5
    {
        public string GetName(string Name)
        {
            if (Name == null && Name == "")
            {
                throw new NullReferenceException("Name is null");
            }
            return Name;
        }
    }
}
