using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinsnetConsole
{
    internal class Cli
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"\nI'm {typeof(Cli)}");
            Console.WriteLine($"Numero arogmenti: {args.Length}");
            foreach (var arg in args)
            {
                Console.WriteLine(arg);
            }

            Console.WriteLine();

            var cliArgs = new CliArguments(args);
            cliArgs.Parse();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"opzione File={cliArgs.File}");
            Console.WriteLine($"opzione Content={cliArgs.Content}");

            // cliArgs.Content = " bla bla "; e' privato, non posso accedervi
            
            if (cliArgs.File.Length > 0)
                File.AppendAllText(cliArgs.File, cliArgs.Content);

            Console.WriteLine($"cliArgs.NumeroArguments={cliArgs.NumeroArguments}");


        }

    }

    public class CliArguments
    {
        private string[] args;

        public string File { get; private set; } = "";

        public string Content { get; private set; } = "";


        public int NumeroArguments
        {
            get
            {
                return args.Length;
            }
        }

        public CliArguments(string[] args)
        {
            this.args = args;
        }

        public void Parse()
        {
            for (int idx = 0; idx < args.Length; idx++)
            {
                var arg = args[idx];
                var argSuccessivo = "";
                if (idx < (args.Length - 1))
                    argSuccessivo = args[idx + 1];

                if (arg.StartsWith("-"))
                    ProcessArgument(arg, argSuccessivo);
            }
        }

        private void ProcessArgument(string arg, string argSuccessivo)
        {
            var opt = arg.Substring(1).ToLowerInvariant();
            Console.WriteLine($"{opt}={argSuccessivo}");
            switch (opt)
            {
                case "file":
                    File = argSuccessivo;
                    break;
                case "content":
                    Content = argSuccessivo;
                    break;

            }

        }
    }
}
