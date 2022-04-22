using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinsnetConsole.oop
{
    class Class1
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("I'm oop.Class1");

            var saluti = new List<string>() { "ciao", "hola", "hello" };
            var indexOfHola = saluti.IndexOf("hola");
            Console.WriteLine($"saluti.IndexOf(\"hola\")={indexOfHola}");

            var scricciolo = new Gatto("Scricciolo"); // abbiamo creato un'istanza di Gatto

            FaiVerso(scricciolo); //Gatto eredita Animale, e per questo motivo possiamo chiamare FaiVerso(...)

            var tom = new Cane("Tom");
            FaiVerso(tom);

        }

        static public void FaiVerso(Animale animale)
        {
            Console.WriteLine($"Verso di {animale.Nome}: {animale.Verso()}");
        }


    }

    public class Animale
    {
        public string Nome;

        public Animale(string nome)
        {
            this.Nome = nome;
        }

        public virtual String Verso()
        {
            return "nessun verso";
        }
    }

    class Gatto : Animale // ereditarieta'
    {

        public Gatto(string nome) : base(nome)
        {

        }

        public override String Verso()
        {
            return "miao"; // polimorfismo
        }
    }
    class Cane : Animale
    {
        public Cane(string nome) : base(nome)
        {

        }
        public override String Verso()
        {
            return "bau";
        }
    }


}
