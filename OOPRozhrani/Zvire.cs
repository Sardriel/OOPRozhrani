using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRozhrani
{
    abstract class  Zvire : IComparable
    {
        public int Vaha { get; set; }
        public abstract void PresunSe();
        public void Dychej()
        {
            Console.WriteLine("Dycham...");
        }
        public int CompareTo(object obj)
        {
            Zvire jine = (Zvire)obj;
            if (this.Vaha < jine.Vaha)
                return -1;
            if (this.Vaha > jine.Vaha)
                return 1;
            return 0;
        }

        public static Zvire operator + (Zvire zvire1, Zvire zvire2)
        {
            if (((zvire1 is Ptak) && (zvire2 is Jester))
               ||
               ((zvire2 is Ptak) && (zvire1 is Jester)))
                return new PtakoJester() { Vaha = zvire1.Vaha + zvire2.Vaha };
            return null;
        }

        
    }
}
