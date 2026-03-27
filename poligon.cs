using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace poligon2026_310_jovanj
{
    internal class poligon
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
         public void obim()
        {
            for(int i=0; <= br_temena; i++)
            {
                int prvi = 1;
                int drugi = (i+1) % br_temena;

                 
            }
        }

        public vektor[] stranice()
        {
            vektor[] str = new vektor[br_temena];
            for (int i =0; i< br_temena; i++)
            {
                str[i]= new vektor(teme[i], teme[i+1]);
            }
        }

        double duzina()
        {
            tacka centr = this.centriraj();
            return centr.d();
        }
    }
}