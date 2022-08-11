using System;
using System.Collections.Generic;

namespace OOPRozhrani
{
    class Rozhrani
    {
        static void Main(string[] args)
        {
            List<Zvire> zvirata = new List<Zvire>();
            zvirata.Add(new Ptak() { Vaha = 1 });
            zvirata.Add(new Delfin() { Vaha = 8 });
            zvirata.Add(new Delfin() { Vaha = 9 });
            zvirata.Add(new PtakoJester() { Vaha = 3 });
            zvirata.Add(new PtakoJester() { Vaha = 2 });
            zvirata.Sort();
            foreach (Zvire zvire in zvirata)
            {
                Console.WriteLine(zvire);
                zvire.Dychej();
                if (zvire is Delfin)
                    ((Delfin)zvire).Vyskoc();
                
            }

            Jester jester = new Jester { Vaha = 5 };
            Ptak ptak = new Ptak { Vaha = 1 };
            Delfin delfin = new Delfin { Vaha = 10 };
            Console.WriteLine();

            Console.WriteLine("Křížím {0} a {1}", jester, ptak);
            Zvire krizenec1 = jester + ptak;
            Console.WriteLine("Výsledkem je {0} s váhou {1}", krizenec1, krizenec1.Vaha);
            Console.WriteLine("Křížím {0} a {1}", jester, delfin);
            Zvire krizenec2 = jester + delfin;
            Console.WriteLine("Výsledkem je {0}", krizenec2);

            
        }
    }
}
