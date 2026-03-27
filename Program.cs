using poligon2026_310_jovanj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon2026_310_jovanj

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jovan Jovanovic
            //tacka a = new tacka(1, 1);
            //Console.WriteLine(a.ugao());
            //Console.WriteLine(a.d());
            //tacka A = new tacka(3, 1);
            //tacka B = new tacka(-1, 3);
            //tacka C = new tacka(3, 3);
            //vektor OA = new vektor(A);
            //vektor OB = new vektor(B);
            //vektor AC = new vektor(A, C);
            //Console.WriteLine(vektor.SP(OA, OB));
            //Console.WriteLine(vektor.VP(OA, AC));
            //Console.ReadKey();

            //tacka A = new tacka(1, 2);
            // tacka B = new tacka(3, 2);
            // tacka C = new tacka(2, 3);
            //tacka D = new tacka(2, 2);
            // Console.WriteLine("Kolko temena?");
            //int n = Convert.ToInt32(Console.ReadLine());
            // poligon prvi = new poligon(n);
            // prvi.unos();
            //prvi.stampaj();
            //prvi.snimi();
            //poligon jovan = new poligon(4);
            //jovan.unos();
            //jovan.snimi();
            //jovan.stampaj();
            //double obim = jovan.obim();
            //Console.WriteLine("Obim=" + obim.ToString());

            //poligon jovan = new poligon(6);
            //jovan.unos();
            //jovan.snimi();
            poligon jovan = poligon.ucitaj();
            Console.WriteLine(jovan.prost());
            
            
            //Vektor[] str = jovan.stranice();
            //Console.WriteLine(Vektor.seku_se(str[0], str[2]));
            // 0 2 ne
            // 1 3 ne

        }
    }
}