# NancyFx Self-host with Owin

## New Project

Launch Visual Studio and create a new .NET 4.5 console project.

## Install Nuget Package

        Install-Package Nancy
        Install-Package Nancy.owin
        Install-Package Microsoft.owin.Selfhost

## Owin Startup class

Add a new Startup.cs. An example Startup class is included below:

     public class Startup
     {
            public void Configuration(IAppBuilder app)
            {
            #if DEBUG
                // Configure diagnostics
                app.UseErrorPage();
            #endif

               // Configure Nancy
               app.UseNancy();
            }
     }

## Routing

To define route in Nancy, create a nancy module as following:

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = parameters =>
            {
                return "Hello world!";
            };
        }
    }

## Start the OWIN Host

Replace all of the boilerplate code in the Program.cs file with the following:

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
