using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HttpServer
{
    public class SimpleHttpServer
    {
        public async void ListenAsync()
        {
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:51111/MyServer/");
            listener.Start();

            HttpListenerContext context = await listener.GetContextAsync();

            var msg = "You asked for " + context.Request.RawUrl;
            context.Response.ContentLength64 = Encoding.UTF8.GetByteCount(msg);
            context.Response.StatusCode = (int) HttpStatusCode.OK;

            using (Stream s = context.Response.OutputStream)
            using (var sw = new StreamWriter(s))
            {
                await sw.WriteAsync(msg);
            }
            listener.Stop();
        }
    }
}
