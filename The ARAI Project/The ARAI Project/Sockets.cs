using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace The_ARAI_Project
{
    class Sockets
    {
        private string _port;

        public void startSockets(string ip, string port)
        {
            _port = port;
            byte[] buffer = new Byte[1024];
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse(ip), int.Parse(_port));
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                while (true)
                {
                    Socket socket = listener.Accept();
                    string data = "";

                        int bytesRec = socket.Receive(buffer);
                        data += Encoding.ASCII.GetString(buffer, 0, bytesRec);
                        Console.WriteLine(data);
                       byte[] msg = Encoding.ASCII.GetBytes(data);

                    socket.Send(msg);
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
