using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Jagged arrays are interesting. They are basically array of arrays
/*
 int[][] jaggedArray = new int [10][];
 jaggedArray[0] = new Type[5];
 jaggedArray[1] = new Type[7];
 and so on

Look up extending stucts. Look at creating properties and accessors.
There are two types of accessors :  the get and set accessors
*/
namespace Edx_Week4
{
    struct student
    {
        public string firstname;
        public string lastname;
        public string birthday;
    }

    struct teacher
    {
        public string teachername;
        public string course;
    }

    struct Program
    {
        public string programname;
        public int duration;

    }

    struct course
    {
        public string coursename;
        public int credits;
    }
    class RelativelyComplexData
    {

        static void Main(string[] args)
        {
            student s1 = new student();
            Console.WriteLine("Enter the birth date");
            s1.birthday = Console.ReadLine();
            Console.WriteLine("enter the firstname");
            s1.firstname = Console.ReadLine();
            Console.WriteLine("Enter the last name");
            s1.lastname = Console.ReadLine();

            Console.WriteLine("The nameof the student is {0} {1}",s1.firstname,s1.lastname);
            Console.WriteLine("The birthday of the student is: {0}",s1.birthday);

            teacher t1 = new teacher();
            Console.WriteLine("Enter the name of the Prof: ");
            t1.teachername = Console.ReadLine();
            Console.WriteLine("Enter the course that the prof teaches: ");
            t1.course = Console.ReadLine();
            Console.WriteLine("The name of the prof is : {0} who teaches {1}",t1.teachername,t1.course);
            
            Program p1 = new Program();
            Console.WriteLine("Enter the program name");
            p1.programname = Console.ReadLine();
            Console.WriteLine("Enter the duration");
            p1.duration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The name of the program is {0} and it lasts for {1} days",p1.programname,p1.duration);
            
            course c1 = new course();
            Console.WriteLine("Enter the name of the course");
            c1.coursename = Console.ReadLine();
            Console.WriteLine("Enter the number of credits this course is worth : ");
            c1.credits = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The name of the course is {0} and its worth {1} credits",c1.coursename,c1.credits);
            
            student[] newstudent = new student[5];
            for (int i = 0; i < newstudent.Length; i++)
            {
                Console.WriteLine("Enter birthday,firstname,lastname");
                newstudent[i].birthday = Console.ReadLine();
                newstudent[i].firstname = Console.ReadLine();
                newstudent[i].lastname = Console.ReadLine();
            }
            for (int i = 0; i < newstudent.Length; i++)
            {
                Console.WriteLine("The birthdate of the student is {0}. The name of the student is {1}{2}",newstudent[i].birthday,newstudent[i].firstname,newstudent[i].lastname);

            }
            Console.ReadKey();
        }
    }
}
