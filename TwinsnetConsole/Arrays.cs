using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinsnetConsole
{
    internal class Arrays
    {
        static public void Main(string[] args)
        {

            Console.WriteLine($"I'm class {nameof(Arrays)}");

            int[] array1 = new int[3];

            array1[0] = 10;
            array1[1] = 12;
            array1[2] = 13;

            Console.WriteLine(array1);

            Console.WriteLine("Loop for");
            for (int idx = 0; idx < array1.Length; idx++)
            {
                Console.WriteLine("  " + array1[idx]);
            }

            // mi aspetto un index out of bounds
            //Console.WriteLine(array1[7]);

            Console.WriteLine("Loop foreach");
            foreach (var elemento in array1)
            {
                Console.WriteLine("  " + elemento);
            }

            Console.WriteLine("Loop foreach trasformato in loop for");
            for (int idx = 0; idx < array1.Length; idx++)
            {
                var elemento = array1[idx];
                Console.WriteLine("  " + elemento);
            }

            //Console.WriteLine("Loop foreach indexed");
            //foreach (var (elemento, idx) in array1.ToList().WithIndex())
            //{
            //    Console.WriteLine("  " + elemento);
            //}



        }
    }
}
