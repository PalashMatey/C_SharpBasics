using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edx_Week7
{
    class Student
    {
        private string studentname;
        private string birthday;

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

    }
}
