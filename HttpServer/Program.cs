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
            const string url = "http://localhost:80/MyServer/";
            const string path = @"C:\Users\anton.kobziev\Desktop\TestServer";

            var server = new TestWebServer(url, path);
            server.Start();

            //WebClient client = new WebClient();
            //Console.WriteLine(client.DownloadString(url + "Test.html"));
        }
    }
}
