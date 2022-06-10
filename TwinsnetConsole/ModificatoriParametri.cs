using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinsnetConsole
{
    public class ModificatoriParametri
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"I'm {nameof(ModificatoriParametri)}");
            var istanza = new ModificatoriParametri();
            istanza.go();
        }

        private void go()
        {
            // ref
            // out
            // out var
            // in
            esercitaRef();
            esercitaRefConTipoNonPrimitivo();
            esercitaOut();
            esercitaIn();

            // int.TryParse()
        }

        private void esercitaIn()
        {
            int in1 = 123;
            untilizzoIn(in in1);
        }

        private void untilizzoIn(in int value)
        {
            // value = 42; non posso scrivere il parametro 'in' perche' e' readonly
        }

        private void esercitaRefConTipoNonPrimitivo()
        {
            var listRefNo = new List<string>();
            listRefNo.Add("0 - refNo iniziale");

            utilizzoRefNoTipoNonPrimitivo(listRefNo);

            LogLista(nameof(esercitaRefConTipoNonPrimitivo), listRefNo);



            var listRefSi = new List<string>();
            listRefSi.Add("0 - refSi iniziale");

            utilizzoRefSiTipoNonPrimitivo(ref listRefSi);
            LogLista(nameof(esercitaRefConTipoNonPrimitivo), listRefSi);
        }

        private static void LogLista(string name, List<string> list)
        {
            Console.WriteLine(name);
            Console.WriteLine(String.Join(", ", list));
            Console.WriteLine();
        }

        private void utilizzoRefNoTipoNonPrimitivo(List<string> list)
        {
            list.Add("1 - refNo");
            list = new List<string>(); // senza il ref non ha effetto sul chiamante
            list.Add("2 - refNo istanza nuova, non verra' stampato");
        }
        private void utilizzoRefSiTipoNonPrimitivo(ref List<string> list)
        {
            list.Add("1 - refSi istanza originale");

            list = new List<string>(); // con il ref ha effetto sul chiamante
            list.Add("2 - refSi istanza nuova");
        }

        private void esercitaOut()
        {
            int outSi ;           
            utilizzoOutSi(out outSi); // la funzione e' obbligata a scrivere il valore del parametro
        }

        private void utilizzoOutSi(out int value)
        {
            // Console.WriteLine(value); questo da errore perche' e' obbligatorio inizializzarlo 
            value = 456;
        }

        private void esercitaRef()
        {
            int refSi = 42;
            int refNo = 43;

            utilizzoRefSi(ref refSi);
            utilizzoRefNo(refNo); // il solito comportamento by value

            Console.WriteLine($"refSi={refSi}\nrefNo={refNo}\n");
        }

        private void utilizzoRefSi(ref int valore)
        {
            valore = 123;
        }
        private void utilizzoRefNo(int valore)
        {
            valore = 123;
        }
    }
}
