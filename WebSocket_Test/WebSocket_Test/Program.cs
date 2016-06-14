using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
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
            var isConnected = CheckForConnection();
            Console.WriteLine("Checking to see if the connection is established using WebClient ");
            Console.WriteLine(isConnected);
            Console.WriteLine("Checking if it is connected using Ping");
            var isPingValid = PingMethod();
            Console.WriteLine(isPingValid);
            Console.WriteLine("Press key to continue");
            Console.ReadKey();

       
        }

        public static bool CheckForConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://pos1.olostaging.com"))
                    {
                        return true;
                    }
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public static string PingMethod()
        {
            try
            {
                Ping myPing = new Ping();
                string url = "pos2.olostaging.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(url, timeout, buffer, pingOptions);
                return Convert.ToString(reply.Status == IPStatus.Success);
            }
            catch (Exception ex)
            {
                
                return Convert.ToString(ex);
            }
        }
    }
}
