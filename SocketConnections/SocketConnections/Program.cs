using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Net.NetworkInformation;

/* Sources https://msdn.microsoft.com/en-us/library/bew39x2a(v=vs.110).aspx
 *   http://stackoverflow.com/questions/153451/how-to-check-if-system-net-webclient-downloaddata-is-downloading-a-binary-file#156750
 *   https://thuru.net/
*/

public class SynchronousSocketClient
{

    public static void StartClient()
    {
        // Data buffer for incoming data.
        //byte[] bytes = new byte[1024];
        Dictionary<string, int> dict = new Dictionary<string, int>();
        dict.Add("pos1.olostaging.com", 443);
        dict.Add("pos2.olostaging.com", 9292);
        dict.Add("pos3.olostaging.com", 443);
        dict.Add("pos1.olo.com", 9292);
        dict.Add("api.olo.com", 443);
        // Connect to a remote device.
        try
        {
            foreach (KeyValuePair<string, int> d in dict)
            {
                //Check for web connection
                var resultOfWebConnection = CheckForConnection(d.Key);
                if (resultOfWebConnection == true)
                {
                    Console.WriteLine("WebConnection Test Passed for {0} ", d.Key);
                }
                else
                {
                    Console.WriteLine("WebConnection Test Failed for {0} ", d.Key);
                    continue;
                }

                // Establish the remote endpoint for the socket.

                string urlname = d.Key;
                int portname = d.Value;

                IPAddress ipAddress = Dns.GetHostAddresses(urlname)[0];
                Console.WriteLine("Connecting to url: {0} @ IP address {1} with port number {2} ", urlname, ipAddress,
                    portname);
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, portname);
                // Create a TCP/IP  socket.
                Socket sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // Connect the socket to the remote endpoint. Catch any errors.
                try
                {
                    sender.Connect(remoteEP);

                    Console.WriteLine("Socket connected to {0}",
                        sender.RemoteEndPoint.ToString());

                    // Encode the data string into a byte array.
                    byte[] msg = Encoding.ASCII.GetBytes("This is a test<EOF>");

                    // Send the data through the socket.
                    int bytesSent = sender.Send(msg);

                    //Not waiting for a response from the server

                    // Release the socket.
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();

                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine("SocketException : {0}", se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }



            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }


    public static bool CheckForConnection(string url)
    {
        try
        {
            using (var client = new WebClient())
            {
                using (var stream = client.OpenRead("http://" + url))
                {
                    return true;
                }
            }
        }
        catch (WebException ex)
        {
            Console.WriteLine(ex.ToString());
            return false;
        }
    }



    public static int Main(String[] args)
    {
        StartClient();
        Console.ReadKey();
        return 0;
    }
}