using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStask03_part2
{
    public class Student : Person, IStudentService
    {
        private ArrayList grades;

        public Student() { 
            grades = new ArrayList(); 
        }
        //assuming course and g have same length for this hw
        public Student(string[] courses, char[] g)
        {
            grades = new ArrayList();
            for (int i = 0; i < courses.Length; i++) 
            {
                grades.Add(g[i]);
                Course.add(courses[i]);
            }
            
        }
        public override string NAME { set { name = value; } get { return name; } }


        public override ArrayList get_address()
        {
            return address;
        }
        public double CalculateGPA()
        {
            double grade = 0.0;
            foreach (char letter_grade in grades)
            {
                switch (letter_grade)
                {
                    case 'A':
                        grade += 4;
                        break;
                    case 'B':
                        grade += 3;
                        break;
                    case 'C':
                        grade += 2;
                        break;
                    case 'D':
                        grade += 1;
                        break;
                }
            }
            Console.WriteLine(grade / grades.Count);
            return grade / grades.Count;
        }
    }

    public class Instructor : Person
    {
        private string department;
        private int years;
        Instructor(string n, string d, bool ishead, int y)
        {
            name = n;
            department = d;
            if (ishead)
            {
                Department.head = name;
            }

            this.years = y;
        }
        public override string NAME { set { name = value; } get { return name; } }


        public override ArrayList get_address()
        {
            return address;
        }

        public override decimal salary(decimal income)
        { return decimal.Divide(Math.Abs(income) + (decimal) years * 1000.0m, 12.0m); }
    }
}
