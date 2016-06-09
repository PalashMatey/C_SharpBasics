using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edx_Week6
{
    class Student : Person
    {
        private string _studentid;

        public string StudentId
        {
            get
            {
                return _studentid;
            }
            set { _studentid = value; }
        }

        public void GiveTest(string name)
        {
            Console.WriteLine("Going to definetly fail {0}", name);
        }
    }
}
