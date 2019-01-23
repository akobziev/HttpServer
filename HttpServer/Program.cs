using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HttpServer
{
    class Program
    {
        static void Main(string[] args)
        {
            const string url = "http://localhost:51111/MyServer/";
            const string path = @"C:\Users\Student\Desktop\serverFolder";

            var server = new TestWebServer(url, path);
            try
            {
                server.Start();
                Console.ReadLine();
            }
            finally
            {
                server.Stop();
            }            
        }
    }
}
