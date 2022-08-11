using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRozhrani
{
    class Delfin: Zvire
    {
        public override void PresunSe()
        {
            Console.WriteLine("Plavu...");
        }
        public void Vyskoc()
        {
            Console.WriteLine("Vyskočil jsem nad hladinu...");
        }

        public override string ToString()
        {
            return "Delfín";
        }
    }
}
