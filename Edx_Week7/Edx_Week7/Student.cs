using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edx_Week7
{
    class Student : IComparable
    {
        private string studentname;
        private string birthday;
        Stack grade = new Stack();

        public Stack Grade
        {
            get
            {
                return grade;
            }
            set { grade = value; }
        }
        public string StudentName
        {
            get
            {
                return studentname;
            }
            set { studentname = value; }

        }

        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public Student(string name, string Bday)
        {
            this.StudentName = name;
            this.Birthday = Bday;
        }

        public Student()
        {
            
        }

        public void AddGrade(string grad)
        {
            Grade.Push(grad);
            Console.WriteLine("Adding a grade to the Student {0}",this.StudentName);
        }

        public int CompareTo(object obj1)
        {
           
            throw new NotImplementedException();
        }
    }
}
