using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace poligon2026_310_jovanj
{
    class poligon
    {
        int br_temena;
        tacka[] teme;

        public poligon(int n)
        {
            br_temena = n;
            teme = new tacka[n];
            for (int i = 0; i < n; i++)
            {
                teme[i] = new tacka();
            }
        }
        public void unos()
        {
            for (int i = 0; i < br_temena; i++)
            {
                Console.WriteLine("Ax({0})=", i + 1);
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ay({0})=", i + 1);
                double y = Convert.ToDouble(Console.ReadLine());
                teme[i].x = x; teme[i].y = y;
            }
        }
        public void stampaj()
        {
            Console.WriteLine("Poligon od " + br_temena + "tacaka");
            for (int i = 0; i < br_temena; i++)
            {
                Console.WriteLine("A{0}" + "(" + teme[i].x + "," + teme[i].y + ")", i + 1);
            }
        }
        public void snimi()
        {
            StreamWriter izlaz = new StreamWriter("poligon.txt");
            izlaz.WriteLine(br_temena);
            for (int i = 0; i < br_temena; i++)
            {
                izlaz.WriteLine(teme[i].x);
                izlaz.WriteLine(teme[i].y);

            }
            izlaz.Close();
        }
        public static poligon ucitaj()
        {
            StreamReader ulaz = new StreamReader("poligon.txt");
            int n = Convert.ToInt32(ulaz.ReadLine());
            poligon novi = new poligon(n);
            for (int i = 0; i < n; i++)
            {
                novi.teme[i].x = Convert.ToDouble(ulaz.ReadLine());
                novi.teme[i].y = Convert.ToDouble(ulaz.ReadLine());
            }
            ulaz.Close();
            return novi;
        }
        public Vektor[] stranice()
        {
            Vektor[] str = new Vektor[br_temena];
            for (int i = 0; i < br_temena - 1; i++)
            {
                str[i] = new Vektor(teme[i], teme[i + 1]);
                str[br_temena-1] = new Vektor(teme[br_temena-1], teme[0]);
            }
            return str;
        }
        public double obim()
        {
            Vektor[] str = this.stranice();
            double obim = 0;
            for (int i=0; i< br_temena; i++)
            {
                obim += str[i].duzina();
            }
            return obim;
        }

        public bool prost()
        {
            bool isto = false;
            for (int i = 0; i< br_temena; i++)
            {
                for (int j = i+1; j< br_temena; j++)
                {
                    if(tacka.jednake(teme[i], teme[j]))
                    {
                        isto = true;
                    }
                }
            }
            Console.WriteLine("isto=" + isto.ToString());
            if (isto) return false;

            Vektor[] str = stranice();
            bool presek = false;
            for(int i=0; i <br_temena-2; i++)
            {
                int kraj;
                if (i == 0) kraj = br_temena - 1;
                else kraj = br_temena;
                for( int j=0; j < kraj ; j++)
                {
                    if (Vektor.seku_se(str[i], str[j])) presek = true;
                    Console.WriteLine("presek=" + presek.ToString());
                }
            }
            
            if (presek) return false;
            
            else return true;
            
        }

    }
}