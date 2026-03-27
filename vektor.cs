using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon2026_310_jovanj


{
    class Vektor
    {
        public tacka pocetak;
        public tacka kraj;
        public Vektor(tacka a, tacka b)
        {
            pocetak = a;
            kraj = b;

        }
        public Vektor(tacka a)
        {
            tacka poc = new tacka();
            pocetak = poc;
            kraj = a;
        }
        public tacka centriraj()
        {
            double x = kraj.x - pocetak.x;
            double y = kraj.y - pocetak.y;
            return new tacka(x, y);
        }
        static public double SP(Vektor a, Vektor b)
        {
            tacka A = a.centriraj();
            tacka B = b.centriraj();
            return A.x * B.x + A.y * B.y;
        }
        static public double VP(Vektor a, Vektor b)
        {
            tacka A = a.centriraj();
            tacka B = b.centriraj();
            double k = A.x * B.y - A.y * B.x;
            return k;
        }
        public double duzina()
        {
            tacka finalna = this.centriraj();
            return finalna.d();
        }
        static public bool seku_se(Vektor a, Vektor b)
        {
            int a_b = ravan.SIS(a, b.pocetak, b.kraj);
            Console.WriteLine("ab" + a_b.ToString());
            int b_a = ravan.SIS(b, a.pocetak, a.kraj);
            Console.WriteLine("ba" + b_a.ToString());
            if (a_b * b_a != 0)
            {
                return true;
            }

            return false;
        }
    }
}