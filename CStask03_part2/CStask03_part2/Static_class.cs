using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStask03_part2
{
    static class Course
    {
        private static HashSet<string> courses = new HashSet<string>();
        public static void add(string c) { courses.Add(c); }
    }

    static class Department
    {
        internal static string head;
        internal static double budget;
        static HashSet<string> courses = new HashSet<string>();
    }
}
