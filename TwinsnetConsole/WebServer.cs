using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
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
            Console.WriteLine("Un client per web server: https://chrome.google.com/webstore/detail/advanced-rest-client/hgmloofddffdnphfgcellkdfbfbjeloo");
            // https://en.wikipedia.org/wiki/List_of_HTTP_status_codes

            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => $"Hello World! {DateTime.Now}");

            var lockObject = new object();


            var webappScriviTxt = "webserver-scrivi.txt";
            app.MapGet("/scriviGet", (HttpContext context) =>
            {
                lock (lockObject)
                {
                    var contenuto = context.Request.Query["contenuto"].ToString();
                    if (contenuto == null || contenuto == "")
                        contenuto = "ciao\n";
                    File.AppendAllText(webappScriviTxt, contenuto);
                    return context.Response.WriteAsync(File.ReadAllText(webappScriviTxt));
                }
            });

            app.MapPost("/scriviPost", async (HttpContext context) =>
            {
                var contenuto = await new StreamReader(context.Request.Body).ReadToEndAsync();
                lock (lockObject)
                {
                    if (contenuto == null || contenuto == "")
                        contenuto = "ciao\n";
                    File.AppendAllText(webappScriviTxt, contenuto);
                    return context.Response.WriteAsync(File.ReadAllText(webappScriviTxt));
                }
            });

            app.MapGet("/html1", () => {
                return Results.Text("<h1>ciaooo</h1>", "text/html");
            });

            app.MapGet("/leggi", () =>
            {
                lock (lockObject)
                {
                    return File.ReadAllText(webappScriviTxt);
                }
            });



            app.Run();
        }
    }
}
