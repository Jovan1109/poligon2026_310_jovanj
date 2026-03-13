using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon2026_310_jovanj
{
    internal class vektor
    {
        tacka pocetak;
        tacka kraj;

        public vektor(tacka A, tacka B) 
        { 
            pocetak= A;
            kraj= B;
        }

        public vektor(tacka A)
        {
            tacka poc = new tacka();
            pocetak= poc;
            kraj = A;
        }

        public tacka centriraj()
        {
            double x = kraj.x - pocetak.x;
            double y = kraj.y - pocetak.y;
            return new tacka(x,y);
        }

        public double SP(vektor a, vektor b) 
        {
            return 0;
        }

    }
}
