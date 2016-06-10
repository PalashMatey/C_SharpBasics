using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Edx_Week7
{
    class Course
    {
        private string coursename;
        static readonly ArrayList students = new ArrayList();

        private Student s = new Student();

        public string Coursename
        {
            get
            {
                return coursename;
            }
            set { coursename = value; }
        }
        public Student S
        {
            get
            {
                return s;
            }

            set
            {
                s = value;
            }
        }

        public void AddStudent(Student s)
        {

            students.Add(s);
            Console.WriteLine("Adding a student to the ArrayList");
          
            
        }

        public void DisplayStuff()
        {
            foreach (Student stude in students)
            {
                Console.WriteLine("Student name {0} and Birthday {1} with Grades {2}", stude.StudentName,stude.Birthday,stude.Grade);
            }
        }
    }
}
