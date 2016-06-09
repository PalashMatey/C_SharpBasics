using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//use of partial classes to split the class over various source files which can all be combined during compile.
//constructors have the same name as the class but they also have parameters which are used to initialize variables.
//constructors can be used to directly initialize the variables at the time of object creation.
//regardless of the instances of a class, there is always only one static member. Typically you do not need to instantiate a class in order to use a static member.
//Anonymous classes, way of encapsulating read only properties into a single object without the need to explicitly define a type first.
//However you cannot define methods for anonymous classes

namespace Edx_Week5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Student Definitions
            Student[] student = new Student[3];
            for (int i = 0; i < student.Length; i++)
            {
                student[i] = new Student();
                {
                    Console.WriteLine("Enter the name and birthday of the student: {0}", i+1);
                    student[i].StudentName = Console.ReadLine();
                    student[i].Bday = Console.ReadLine();
                }
            }
            student[0].StudentName = "Palash";
            student[0].Bday = "06-06-1992";
            Console.WriteLine("{0}   {1}",student[0].StudentName,student[0].Bday);
            Console.Write("Press any key to continue . . .");
            Console.ReadKey();
            #endregion
        }
    }
}
