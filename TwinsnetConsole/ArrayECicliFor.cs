using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinsnetConsole
{
    internal class ArrayECicliFor
    {
        static public void Main(string[] args)
        {

            Console.WriteLine($"I'm class {nameof(ArrayECicliFor)}");

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


            // dichiarazione literal
            int[] array2 = new int[] { 1, 2, 3, 4 };

            var sommaParziale = array2[0] + array2[1];

            var array3 = new int[] { 1, 2, 3, 4 };

            string[] array4 = new string[] { "verde", "bianco", "rosso" };


            int v = Array.IndexOf(array4, "bianco");
            Console.WriteLine("Array.IndexOf(array4, \"bianco\") = " + v);

            var joined = String.Join(",", array4);
            Console.WriteLine($"String.Join(\", \", array4)\" = `{joined}`");

            object[] anagraficaSimone = new object[] { "simone", 45, 43.5 };
            string.Join(",", anagraficaSimone);

            // la seguente istruzione non funziona perche' l'operatore + non
            // e' definito per: object + object
            // var somma2 = anagraficaSimone[1] + anagraficaSimone[2];


            Console.WriteLine("Ecco l'effetto di string.Split(...)");

            const string elenco = "ciao,hello,hola";
            var splittato = elenco.Split(",");
            foreach (var elemento in splittato)
            {
                Console.WriteLine($"`{elemento}`");
            }

            Console.WriteLine("Ecco l'effetto di string.Split(...) con una stringa diversa.");

            string[] elementi2 = "ciao, hello, hola".Split(",");
            foreach (var elemento in elementi2)
            {
                string trimmato = elemento.Trim();
                Console.WriteLine($"`{elemento}`  trimmato: `{trimmato}`");
            }


            int[,] arrayMultiDimensionale = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            Console.WriteLine("Array multidimensionale:");
            Console.WriteLine("arrayMultiDimensionale.Length = " + arrayMultiDimensionale.Length);

            var numeroRighe = arrayMultiDimensionale.GetLength(0);
            var numeroColonne = arrayMultiDimensionale.GetLength(1);

            for (int riga = 0; riga < numeroRighe; riga++)
            {
                for (int colonna = 0; colonna < numeroColonne; colonna++)
                    Console.WriteLine($"  arrayMultiDimensionale[{riga},{colonna}] = " + arrayMultiDimensionale[riga, colonna]);
            }





        }
    }
}
