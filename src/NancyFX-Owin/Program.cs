using System;
using System.Threading;
using Microsoft.Owin.Hosting;

namespace NancyFX_Owin
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "http://localhost:8888/";

            // start OWIN host 
            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine("Listening at " + url);
                Thread.Sleep(Timeout.Infinite);
            }
        }
    }
}
