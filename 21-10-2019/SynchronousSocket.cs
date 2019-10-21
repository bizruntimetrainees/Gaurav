using System;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace _21_10_2019
{
    class SynchronousSocket
    {
        public static void CallSocket()
        {
            try
            {
                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPHostEntry iphost = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ipadd = iphost.AddressList[0];
                IPEndPoint ipend = new IPEndPoint(ipadd, 11000);

                try
                {
                    s.Connect(ipend);
                }
                catch (ArgumentNullException ae)
                {
                    Console.WriteLine(ae.ToString());
                }
                catch (SocketException se)
                {
                    Console.WriteLine(se.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

                byte[] msg = System.Text.Encoding.ASCII.GetBytes("Hello This is gaurav Mishra");

                int bytesSent = s.Send(msg);

                byte[] bytes = new byte[1024];
                int byteRec = s.Receive(bytes);

                Console.WriteLine("Ehoed text :" + System.Text.Encoding.ASCII.GetString(bytes, 0, byteRec));

                s.Shutdown(SocketShutdown.Both);
                s.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        static void Main(string[] args)
        {
            SynchronousSocket.CallSocket();

            Console.WriteLine("program success...");
        }
    }
}
