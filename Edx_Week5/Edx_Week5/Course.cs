using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edx_Week5
{
    class Course
    {
        public int count =0 ;
        private string coursename;
        private Student[] students = new Student[1000];
        private Teacher teach = new Teacher();
        public string Coursename
        {
            get { return coursename; }
            set { coursename = value; }
        }

        public Teacher Teach
        {
            get { return teach; }
        }
        public Student[] Students
        {
            get { return students; }
        }
        public void AddStudent(int i, Student name)
        {
            this.students[i] = name;
            Console.WriteLine("The student has been added successfully ");
        
        }

        public void AddTeacher(Teacher t)
        {
            this.teach = t;
            Console.WriteLine("The teacher has been added successfully to the course");

        }
        
    }
}
