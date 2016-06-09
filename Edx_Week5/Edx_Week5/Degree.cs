using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Edx_Week5
{
    class Degree
    {
        private string Degreename;
        private Course coursetaken  = new Course();
        public string DegreeName

        {
            get { return Degreename; }
            set { Degreename = value; }
            
        }

        public Course CourseTaken
        {
            get { return coursetaken; }
        }

        public void AddCourse(Course c)
        {
            this.coursetaken = c;
        }

    }
}
