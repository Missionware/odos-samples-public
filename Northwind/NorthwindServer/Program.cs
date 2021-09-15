using Mc3s.Odos.Server;
using System;

namespace NorthwindServer
{
    class Program
    {
        [MTAThread]
        static void Main(string[] args)
        {
            ServerManager.StartInConsole();
        }
    }
}
