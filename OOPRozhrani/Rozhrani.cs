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

            foreach (Zvire zvire in zvirata)
            {
                Console.WriteLine(zvire);
                zvire.Dychej();
                if (zvire is Delfin)
                    ((Delfin)zvire).Vyskoc();
            }
        }
    }
}
