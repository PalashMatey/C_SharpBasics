using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Edx_Week1
{
    class School
    {
        static void Main()
        {
            string FirstName;
            string LastName;
            string Birthdate;
            string AddressLine1;
            string AddressLine2;
            string City;
            string State;
            int ZipCode;
            string Country;

            FirstName = "Palash";
            LastName = "Matey";
            Birthdate = "6th June 2016";
            AddressLine1 = "Something";
            AddressLine2 = "Make this optional";
            City = "New YOrk";
            State = "New York";
            ZipCode = 10027;
            Country = "USA";
            Console.WriteLine("{0}{1}",FirstName,LastName);
            Console.WriteLine("{0} {1}",FirstName,LastName);
            Console.WriteLine(Birthdate);
            Console.WriteLine("{0} {1}", AddressLine1,AddressLine2);
            Console.WriteLine(City);
            Console.WriteLine(State);
            Console.WriteLine(ZipCode);
            Console.WriteLine(Country);

            Console.WriteLine("Enter the country: ");
            Country = Console.ReadLine();

            Console.WriteLine(Country);
            Console.Write("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
