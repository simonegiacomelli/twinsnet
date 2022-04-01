using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinsnetConsole
{
    public class Stringhe
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Stringhe");

            string string1 = "ciao Simone";

            var index = string1.IndexOf("Simone");

            Console.WriteLine("string1.IndexOf(\"Simone\") = " + index);

            var substring1 = string1.Substring(5);

            Console.WriteLine("string1.Substring(5) = `" + substring1 + "`");

            var substring2 = string1.Substring(5, 4);

            Console.WriteLine("string1.Substring(5,4) = `" + substring2 + "`");


            bool starts1 = "Simone".StartsWith("Sim");
            Console.WriteLine("\"Simone\".StartsWith(\"Simo\") = " + starts1);

            bool starts2 = "Simone".StartsWith("Fr");
            Console.WriteLine("\"Simone\".StartsWith(\"Fr\") = " + starts2);

            // idem per EndsWith(...)

            //  Trim() TrimEnd() TrimStart()

            Console.WriteLine("Stringa originale -> `" + "  ciao  " + "`");
            Console.WriteLine("Trim -> `" + "  ciao  ".Trim() + "`");
            Console.WriteLine("TrimStart -> `" + "  ciao  ".TrimStart() + "`");
            Console.WriteLine("TrimEnd -> `" + "  ciao  ".TrimEnd() + "`");

            // string e verbatim strings 
            Console.WriteLine("Escaping `\\`");
            Console.WriteLine(@"Escaping `\\`");


            var ciao = "Ciao ";
            var simo = "Simone";
            Console.WriteLine(ciao + simo + "!");

            var string2 = "Ciao ";
            string2 += "Simone";
            string2 += "!";
            Console.WriteLine(string2);

            // replace di stringhe
            var string3 = "Ciao Simone!";
            var string4 = string3.Replace("Simone", "Franco");
            Console.WriteLine(string4);

            // replace di caratteri
            var string5 = string3.Replace('e', 'a');
            Console.WriteLine(string5);

            var string6 = string3.Remove(4, 7); // rimane `Ciao!`
            Console.WriteLine(string6);

            // confronto tra stringhe

            var uguali = string6 == "Ciao!";
            Console.WriteLine("string6 == \"Ciao!\" = " + uguali); // True

            int cmp1 = "A".CompareTo("B");
            Console.WriteLine(" \"A\".CompareTo(\"B\") = " + cmp1); // -1

            char char1 = string6[1];
            Console.WriteLine("string6[1] = `" + char1 + "`"); // i

            // interpolazione di stringhe
            var nicola = "Nicola";
            Console.WriteLine($"Ciao {nicola}!");

            var imponibile = 1234;
            Console.WriteLine($"Iva = { imponibile * 0.22} ");



        }

    }
}
