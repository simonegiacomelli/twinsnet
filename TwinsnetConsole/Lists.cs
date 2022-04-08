using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinsnetConsole
{
    internal class Lists
    {
        static public void Main(string[] args)
        {
            Console.WriteLine($"I'm {nameof(Lists)}");

            List<int> list1 = new List<int>();

            list1.Add(1);
            list1.Add(2);
            list1.Add(3);

            // il seguente non fuziona perche' la lista e' dichiarata 
            // per gestire integer e non stringhe
            // list1.Add("Ciao");

            Console.WriteLine("Ecco gli elementi di list1:");
            foreach (var elemento in list1)
            {
                Console.WriteLine("  " + elemento);
            }


            // con la seguente istruzione, ho duplicato list1 
            var list2 = new List<int>(list1) ;

            list2.Insert(0, 666);

            Console.WriteLine("Ecco gli elementi di list2:");
            foreach (var elemento in list2)
            {
                Console.WriteLine("  " + elemento);
            }

            var list3 = new List<int>(400) ;
            list3.AddRange(list2) ;
            list3.Remove(1);

            Console.WriteLine($"Ecco gli elementi di list3 (Count={list3.Count}):");
            foreach (var elemento in list3)
            {
                Console.WriteLine("  " + elemento);
            }

            
            list3.Sort();

            Console.WriteLine($"Ecco gli elementi di list3 sortata:");
            foreach (var elemento in list3)
            {
                Console.WriteLine("  " + elemento);
            }

            var index666 = list3.IndexOf(666);

            Console.WriteLine("list3.IndexOf(666) = " + index666);

            Console.WriteLine("list3.IndexOf(7) = " + list3.IndexOf(7));

                        
        }
    }
}
