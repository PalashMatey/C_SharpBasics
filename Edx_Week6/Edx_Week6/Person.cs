using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edx_Week6
{
    class Person
    {
        private string _personname;
        private string _birthday;
        private string _employed;

        public string PersonName
        {
            get { return _personname; }
            set { _personname = value; }
        }

        public string Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }

        public string Employed
        {
            get { return _employed; }
            set { _employed = value; }
        }
    }
}
