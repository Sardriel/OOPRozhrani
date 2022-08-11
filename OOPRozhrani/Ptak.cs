using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRozhrani
{
    class Ptak: Zvire, IPtak
    {
        public override void PresunSe()
        {
            Console.WriteLine("Letím...");
        }
        public void Pipni()
        {
            Console.WriteLine("♫ ♫ ♫");
        }
        
        public void Klovni()
        {
            Console.WriteLine("Klov, klov!");
        }

        public override string ToString()
        {
            return "Pták";
        }
    }
}
