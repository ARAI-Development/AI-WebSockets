using System;

namespace The_ARAI_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Sockets arai = new Sockets();
            arai.startSockets("127.0.0.1","35");
        }
    }
}
