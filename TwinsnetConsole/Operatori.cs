using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinsnetConsole
{
    public class Operatori
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Operatori");

            int int1 = 0;

            int1++;
            ++int1;

            int1 += 3;
            int1 -= 4;

            double double1 = 10.4;


            Console.WriteLine("10.4 / 2 = " + (double1 / 2));
            Console.WriteLine("5 % 2 = " + (5 % 2));
            Console.WriteLine("9 % 5 = " + (9 % 5));



            byte byte1 = 0x7;
            var byte2 = byte1 | 0x8;
            var byte3 = ^byte2;

            var byte4 = int1 >> 2;

            // questa espressione di assegnazione con shift a destra
            int1 = int1 >> 3;
            // equivale a questa istruzione
            int1 >>= 3;

            if (int1 > 10 || int1 < 5) Console.WriteLine("tra 9 e 4");
        }
    }
}
