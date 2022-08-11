using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRozhrani
{
    class PtakoJester : Zvire, IJester, IPtak
    {
        

        public void Pipni()
        {
            Console.WriteLine("♫ ♫♫ ♫ ♫ ♫♫");
        }

        public void PlazSe()
        {
            Console.WriteLine("Plazím se...");
        }
        public override string ToString()
        {
            return "Jsem ptakoještěr a vážím " + Vaha.ToString();
        }
    }
}
