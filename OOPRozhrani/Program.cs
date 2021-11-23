using System;

namespace OOPRozhrani
{
    class Program
    {
        static void Main(string[] args)
        {
            IPtak ptak = new Ptak();
            PtakoJester ptakoJester = new PtakoJester();
            ptakoJester.Pipni();
            ptak.Dychej();
        }
    }
}
