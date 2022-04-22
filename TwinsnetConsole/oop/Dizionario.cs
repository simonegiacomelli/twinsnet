using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinsnetConsole.oop
{
    internal class Dizionario
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("I'm Dizionario");

            var numeri = new Dictionary<int, string>();

            numeri[2] = "due";
            numeri[5] = "cinque";


            Console.WriteLine("Ricerca chiave intera tra 0 e 5");
            foreach (var index in Enumerable.Range(0, 6))
            {
                var value = numeri.GetValueOrDefault(index);
                Console.WriteLine($"  numeri[{index}]={value}");
            }

            Console.WriteLine("Ciclo su dictionary `numeri` per chiave");
            foreach (var key in numeri.Keys)
            {
                var value = numeri[key];
                Console.WriteLine($"  key={key} value={value}");
            }

            Console.WriteLine("Stampa di tutte le entry nel dictionary `numeri`");
            foreach (var entry in numeri) // con il tipo esplicito: foreach(KeyValuePair<int, string> entry in numeri)
            {

                Console.WriteLine($"  entry.Key={entry.Key} entry.Value={entry.Value} entry=`{entry}`");
            }


            var nomi = new List<string>() { "Simone", "Franco", "Paolo", "Nicola", "Lorenzo", "Stefano", "Oleg" };


            Console.WriteLine("Groupby sulla lista nomi per ottoenere un dictionary");

            // il tipo esplicito di `raggruppato` e'
            // Dictionary<char, List<string>>
            var raggruppato = nomi.GroupBy(x => x[0]).ToDictionary(x => x.Key, x => x.ToList());
            Console.WriteLine($"raggrupato={raggruppato}");

            StampaDictionary(raggruppato);

            Console.WriteLine("Groupby manuale sul dictionary nomi per `caricare` un Dictionary");

            var raggrMan = new Dictionary<char, List<string>>();

            foreach (var nome in nomi)
            {
                char key = nome[0];               
                var valueOrNull = raggrMan.GetValueOrDefault(key);
                var value = valueOrNull != null ? valueOrNull : new List<string>();
                raggrMan[key] = value;
                value.Add(nome);
            }
            StampaDictionary(raggruppato);


            var sonoUguali = 'S'.Equals('s') == 's'.Equals('S');
            var sonoUgual2 = 'S'.Equals(3);
           


            var set1 = new HashSet<string>() { "Foo", "Stefano" , "Oleg" };

            foreach(var nome in nomi)
            {
                var contenuto = set1.Contains(nome);
                Console.WriteLine($"Il nome {nome} e' contenuto nel set: {contenuto}");
            }

            var personeTeam = nomi.ToHashSet();
            var inVacaza = new HashSet<string>() { "Oleg", "Francesco" };


            var personeDelTeamInVacanza = personeTeam.Intersect(inVacaza);
            var personeDelTeamPresenti=   personeTeam.Except(inVacaza);
            var estraneiInVacanza = inVacaza.Except(personeDelTeamPresenti);
            var personeDelTeamEdEstranei = inVacaza.Union(estraneiInVacanza);

        }
        static void StampaDictionary(Dictionary<char, List<string>> raggruppato)
        {
            foreach (var entry in raggruppato)
            {
                var nomiConcatenati = String.Join(", ", entry.Value);
                Console.WriteLine($"  key={entry.Key} , value={nomiConcatenati}");
            }
        }

    }
}
