
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Casting is an expensive process
 Once cannot easily compare objects of different types using arraylist. This behaviour can be more easily replicated using generics.
 Generics guarantee the collection to be homogenous. This way the sort method will work.
 Adding items to the ArrayList, they are implicitly cast to System.Object type which is computationally intensive.
 No boxing and unboxing is required with the use of generics unlike that with ArrayList.
 Since at some point I would have to foreach loop over every item in the custom generic collection, one would have to implement the IEnumberable<T>Interface

 */
namespace Edx_Week8
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
