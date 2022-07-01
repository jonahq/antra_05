using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStask03_part2
{
    public abstract class Person : IPersonService
    {
        protected string name;
        protected ArrayList address;
        public abstract string NAME { get; set; }
        public void add_address(string addr) { address.Add(addr); }
        public abstract ArrayList get_address();
        public int calculateAge(int year) { return 2022 - year; }
        public virtual decimal salary(decimal income)
        { return decimal.Divide(Math.Abs(income), 12.0m); }

    }
}
