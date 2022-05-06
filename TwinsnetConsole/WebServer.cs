using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinsnetConsole
{
    internal class WebServer
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"I'm {nameof(WebServer)}");
            
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => $"Hello World! {DateTime.Now}");

            app.MapGet("/scrivi", () =>
            {

                File.AppendAllText("webserver-scrivi.txt", "ciao\n");
                return File.ReadAllText("webserver-scrivi.txt");
            });

            app.Run();
        }
    }
}
