using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edx_Week6
{
    class Teacher : Person
    {
        private string _expertise;
        
        public string Expertise
        {
            get
            {
                return _expertise;

            }
            set { _expertise = value; }
        }

        public void TakeTest(string name)

        {
            Console.WriteLine("This test is going to be on the course {0}", name );

        }
    }
}
