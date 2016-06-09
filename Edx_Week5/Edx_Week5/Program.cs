using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Comments i felt were necessary just to reiterate a point
//use of partial classes to split the class over various source files which can all be combined during compile.
//constructors have the same name as the class but they also have parameters which are used to initialize variables.
//constructors can be used to directly initialize the variables at the time of object creation.
//regardless of the instances of a class, there is always only one static member. Typically you do not need to instantiate a class in order to use a static member.
//Anonymous classes, way of encapsulating read only properties into a single object without the need to explicitly define a type first.
//However you cannot define methods for anonymous classes
//keep a track of the number of instances created in the main class only. This might be stupid but keep in mind that each and every instance gets its own set of variables.

namespace Edx_Week5
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();
          
            #region Student Definitions

            int numOfStudents;
            Console.WriteLine("Enter the number of students to be added to a course");
            numOfStudents = Convert.ToInt32(Console.ReadLine());
            Student[] student = new Student[numOfStudents];
            int count = 0;
            for (int i = 0; i < student.Length; i++)
            {
                student[i] = new Student();
                {
                    Console.WriteLine("Enter the name and birthday of the student: {0}", i+1);
                    student[i].StudentName = Console.ReadLine();
                    student[i].Bday = Console.ReadLine();
                    course.AddStudent(i,student[i]);
                    count++;


                }
            }
           
            
            #endregion
            #region Teacher Definitions

            #endregion
            #region Course definition
            
            course.Coursename = "Programming in C#";
            Console.WriteLine("The name of the course is: {0} with {1} students",course.Coursename,count);

            
            #endregion

            Console.Write("Press any key to continue . . .");
            Console.ReadKey();
        }
        
    }
}
