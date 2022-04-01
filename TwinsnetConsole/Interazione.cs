

namespace TwinsnetConsole;

class Interazione
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello from Interazione.Main(...)");
        Console.Write("Come");
        Console.Write(" stai?");
        Console.WriteLine();

        Console.WriteLine("Scrivi un integer");
        string? line = Console.ReadLine();
        Console.WriteLine("Mi hai scritto: " + line);

        int int1;
        var ok = int.TryParse(line, out int1);
        if (ok)
        {
            var int2 = int1 * 2;
            Console.WriteLine(line + " * 2 = " + int2);
        }
        else
        {
            Console.WriteLine("La stringa " + line + " non e' un valore numerico intero");
        }


    }
}

