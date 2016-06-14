using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Security.Policy;

/* source : http://stackoverflow.com/questions/153451/how-to-check-if-system-net-webclient-downloaddata-is-downloading-a-binary-file#156750
https://thuru.net/

*/
namespace WebSocket_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string urlname = "pos1.olostaging.com";


            Uri uriResult;
            bool result = Uri.TryCreate(urlname, UriKind.Absolute, out uriResult)
                          && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            Console.WriteLine(result);
            Console.WriteLine("Press key to continue");
            Console.ReadKey();
        }
    }
}
