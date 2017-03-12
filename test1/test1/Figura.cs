using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    abstract class Figura
    {
        protected Pozycja pozycja = null;
        public Pozycja Pozycja
        {
            get
            {
                return pozycja;
            }
        }

        public string kolor;
        protected bool CzyPionowo (Pozycja nowaPozycja)
        {
            return Pozycja.Y == nowaPozycja.Y;
        }
        protected bool CzyPoziomo(Pozycja nowaPozycja)
        {
            return Pozycja.X == nowaPozycja.X
        }
        protected bool CzySkos(Pozycja nowaPozycja)
        {
            return Math.Abs(Pozycja.Y - nowaPozycja.Y) == Math.Abs(Pozycja.X - nowaPozycja.X);

        }
    }
}
