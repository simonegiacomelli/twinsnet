﻿namespace TwinsnetConsole
{

    public class ProgramClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string str1 = "123";
            int int1 = 100;

            int1 = int.Parse(str1);

            str1 = int1.ToString();

            string str2 = int1.ToString("#.0");

            Console.WriteLine(str2);
            char c = 'x';

            Console.WriteLine(str1 + " " + int1);

            DateTime dt1 = DateTime.Now;

            Console.WriteLine(dt1);


            int int2 = 456;

            ////
            var int3 = 789;

            // il seguente non compila perche' il tipo di int3 e' integer
            // int3 = "ciao";

            var int4 = str2.Split(",");

            int? int5 = null;


        }

    }
}