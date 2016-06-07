using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Edx_Week3
{
    class CompleteInformation
    {
       

        static void Main(string[] args)
        {

            string firstname = "";
            string lastname = "";
            string birthday = "";
            string teacherfirstname;
            string teacherlastname;
            string teachercourse;
            Console.WriteLine("1. Enter Student Information");
            Console.WriteLine("2. Enter Teacher Information");
            Console.WriteLine("3. Print Student Details");
            Console.Write("Enter your choice: ");

            int userInput = Convert.ToInt32(Console.ReadLine());
            //Console.Write(userInput);
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Enter Student Information");
                    GetStudentInformation(out firstname,out lastname,out birthday);
                    PrintStudentDetails(firstname,lastname,birthday);
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Enter Teacher Information");
                    GetTeacherInformation(out teacherfirstname, out teacherlastname, out teachercourse);
                    PrintTeacherInformation(teacherfirstname, teacherlastname, teachercourse);
                    Console.Read();
                    break;
                case 3:
                    Console.WriteLine("Printing Student Details");
                    PrintStudentDetails(firstname, lastname, birthday);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    Console.ReadKey();
                   
                    break;
            }

        }

        static void GetStudentInformation(out string name1,out string name2,out string name3)
            {
                Console.WriteLine("Enter the Students first name");
                name1 = Console.ReadLine();
                Console.WriteLine("Enter the student lastname");
                name2 = Console.ReadLine();
                Console.WriteLine("Enter students birthday");
                name3 = Console.ReadLine();
                // implement DateTime.TryParse

            }
            static void PrintStudentDetails(string name12,string name2,string somedate)
            {
                Console.WriteLine("The student name is {0} {1}", name12, name2);
                Console.WriteLine("The student was born on {0}",somedate);
            }

        static void GetTeacherInformation(out string name1, out string name2, out string name3)
        {
            Console.WriteLine("Enter the Teacher's firstname");
            name1 = Console.ReadLine();
            Console.WriteLine("Enter the teachers lastname");
            name2 = Console.ReadLine();
            Console.WriteLine("Enter the course that the teacher teaches");
            name3 = Console.ReadLine();
        }

        static void PrintTeacherInformation(string name1, string name2, string name3)
        {
            Console.WriteLine("The name of the teacher is {0} {1}",name1,name2);
            Console.WriteLine("The teacher teaches the course : {0}",name3);
        }
        //defining methods
       

        
    }
}
