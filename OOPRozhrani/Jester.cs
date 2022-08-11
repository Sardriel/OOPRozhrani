using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRozhrani
{
    class Jester: Zvire, IJester
    {
        public void PlazSe()
        {
            Console.WriteLine("Plazím se...");
        }

        public override void PresunSe()
        {
            Console.WriteLine("Plazím se...");
        }

        public override string ToString()
        {
            return "Ještěr";
        }
    }
}
