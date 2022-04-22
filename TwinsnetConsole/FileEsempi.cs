using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinsnetConsole
{
    internal class FileEsempi
    {
        public static void Main(string[] args)
        {
            var topoliniaFilename = "Topolinia.txt";

            File.WriteAllText(topoliniaFilename, "Pluto\nPippo\nTopolino");

            var topoliniaContent = File.ReadAllText(topoliniaFilename);

            Console.WriteLine($"Le righe del file {topoliniaFilename}");

            foreach (var linea in topoliniaContent.Split("\n"))
            {
                Console.WriteLine($"  `{linea}`");
            }

            var appendFileStream = File.AppendText("AppendFile.txt");
            appendFileStream.Write($"NextDouble={ Random.Shared.NextDouble() }\n");
            appendFileStream.Close(); // dobbiamo chiudere lo stream





        }
    }
}
