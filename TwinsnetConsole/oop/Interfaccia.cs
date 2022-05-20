using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinsnetConsole.oop;

interface Serbatoio
{
    int Disponibilita { get; set; }


    // int capacita;  non si puo' fare perche' un interfaccia non ha fields
    // int Capacita(); questo e' valido ma preferisco usare le proprieta'
    int Capacita { get; }

}

interface Motore
{
    int NumeroCilindri { get; }
    bool Avvia();


}



class Trattore : Serbatoio, Motore
{
    public int Disponibilita { get ; set; }

    public int Capacita => 80;

    public int NumeroCilindri => 6;

    public bool Avvia()
    {
        throw new NotImplementedException();
    }
}
