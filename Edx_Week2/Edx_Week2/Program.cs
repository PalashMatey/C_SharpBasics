using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edx_Week2
{
    class Patterns
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 8; i++)
            {
                Console.WriteLine();

                for (int j = 1; j <= 8; j++)
                {
                    if (i%2==0)
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write("X");
                    }

                }
            }
            Console.ReadKey();
        }
    }
}
