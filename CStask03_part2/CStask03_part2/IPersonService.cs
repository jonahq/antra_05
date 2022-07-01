using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStask03_part2
{
    internal interface IPersonService
    {
        public int calculateAge(int year);
        public decimal salary(decimal income);
    }
}
