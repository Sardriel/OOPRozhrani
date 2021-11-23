using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRozhrani
{
    class PtakoJester : IJester, IPtak
    {
        public void Dychej()
        {
            Console.WriteLine("Dýchám...");
        }

        public void Pipni()
        {
            Console.WriteLine("♫ ♫♫ ♫ ♫ ♫♫");
        }

        public void PlazSe()
        {
            Console.WriteLine("Plazím se...");
        }
    }
}
