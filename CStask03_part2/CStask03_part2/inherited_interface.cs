using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStask03_part2
{
    internal interface IStudentService : IPersonService
    {
        public double CalculateGPA();
    }
}
