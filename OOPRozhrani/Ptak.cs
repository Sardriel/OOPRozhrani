using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRozhrani
{
    class Ptak:IPtak
    {
        public void Pipni()
        {
            Console.WriteLine("♫ ♫ ♫");
        }
        public void Dychej()
        {
            Console.WriteLine("Dýchám...");
        }
        public void Klovni()
        {
            Console.WriteLine("Klov, klov!");
        }

    }
}
