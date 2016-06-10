using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Collections is C#'s way of defining lists and dictionaries / Queue's and Stack's.
 * This would be useful for algorithm and data structure implementation.
 * Why use a sorted list(allows you to access items by key) when you already have a hashtable.
 * something to do with performance but will investigate this further.
 * Add objects of any kind to an ArrayList collection.
 * Retrieving items from a collection must be done explicitly. 
 * Its best to use a foreach loop to iterate over the collection.
 * Study the lambda method, seems important and present all over olo repositories
 * Keeping the IComparer class in mind is important when trying to sort over arraylists
 * of user defined datatypes such as classes. In this case we could examine the student class,
 * Considering two students and sorting them on the basis of their age.
*/
namespace Edx_Week7
{
    class Program
    {
        static void Main(string[] args)
        {
            Course c = new Course();
            Student stud = new Student();

            c.Coursename = "Electrical Engineering";
            int numOfStudents;
            Console.WriteLine("Enter the number of students to be added to a course");
            numOfStudents = Convert.ToInt32(Console.ReadLine());

            Student student = new Student();
            int count = 0;
            for (int i = 0; i < numOfStudents; i++)
            {
                student = new Student();
                {
                    Console.WriteLine("Enter the name and birthday of the student: {0}", i + 1);
                    student.StudentName = Console.ReadLine();
                    student.Birthday = Console.ReadLine();
                    c.AddStudent(student);

                }
            }
            c.DisplayStuff();
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
