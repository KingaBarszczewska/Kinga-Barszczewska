using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pozycja p = new Pozycja("C4");
            Pozycja p2 = new Pozycja("A5");
            Figura f = new Pionek(p.Figura.KOLOR_BIAŁY);
            Console.WriteLine(f.CzyMoznaPrzesunac(p2));
        }
    }
}
