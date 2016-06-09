using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edx_Week5
{
    class Student
    {
        private string studentname;
        private string birthday;

        public string StudentName
        {
            get { return studentname; }
            set { studentname = value; }
        }

        public string Bday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public Student(string name, string bday)
        {
            this.StudentName = name;
            this.Bday = bday;
        }

        public Student()
        {
        }
    }
}
