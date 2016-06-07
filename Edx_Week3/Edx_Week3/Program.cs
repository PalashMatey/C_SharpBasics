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
        private static string firstname;
        private static string lastname;
        private static string birthday;

        static void Main(string[] args)
        {

            string firstname = "";
            string lastname = "";
            string birthday = "";
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
                    GetStudentInformation();
                    PrintStudentDetails(firstname,lastname,birthday);
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Printing Student Details");
                    PrintStudentDetails(firstname, lastname, birthday);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

        }

        static void GetStudentInformation()
            {
                Console.WriteLine("Enter the Students first name");
                firstname = Console.ReadLine();
                Console.WriteLine("Enter the student lastname");
                lastname = Console.ReadLine();
                Console.WriteLine("Enter students birthday");
                birthday = Console.ReadLine();
                // implement DateTime.TryParse

            }
            static void PrintStudentDetails(string name12,string name2,string somedate)
            {
                Console.WriteLine("The student name is {0} {1}", firstname, lastname);
            }

        
        
        //defining methods
       

        
    }
}
