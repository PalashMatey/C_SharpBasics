using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edx_Week5
{
    class UProgram
    {
        private string nameprogram;
        private Degree degr = new Degree();
        public string NameProgram
        {
            get
            {
                return nameprogram;
            }
            set { nameprogram = value; }
        }

        public Degree Degr
        {
            get { return degr; }
        }
        public void AddDegree(Degree d)
        {
            this.degr = d;
        }
    }
}
