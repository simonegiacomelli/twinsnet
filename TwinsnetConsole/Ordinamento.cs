using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinsnetConsole;

public class Ordinamento
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"I'm {nameof(Ordinamento)}");

        List<Dispositivo> dispositivi = Dispositivo.NuovaListaDispositiviDiEsempio();

        // fluent api

        var o1 = dispositivi
            .OrderBy(x => x.Tipologia)
            .ThenBy(x => x.Descrizione)
            .ToList();

        foreach (var dispositivo in o1)
        {
            Console.WriteLine(dispositivo);
        }

    }


}

//poco plain old c# object

public class Dispositivo
{
    public int Id { get; set; }
    public string Descrizione { get; set; }
    public string Tipologia { get; set; }

 
    override public string ToString()
    {
        return $"{Id} {Descrizione.PadRight(25)} {Tipologia}";
    }

    public static List<Dispositivo> NuovaListaDispositiviDiEsempio()
    {
        return new List<Dispositivo> {
            new Dispositivo { Id=1, Descrizione ="Motore avvio", Tipologia = "motore" },
            new Dispositivo { Id=2, Descrizione = "Rele avvio", Tipologia = "rele" },
            new Dispositivo { Id=3, Descrizione ="Pompa spurgo", Tipologia = "pompa" } ,
            new Dispositivo { Id=4, Descrizione = "Motore girello", Tipologia= "motore" },
        };
    }

}
