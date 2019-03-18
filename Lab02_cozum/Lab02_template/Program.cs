using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab02_template
{
    class Program
    {
        static void Main(string[] args)
        {
            Daire ucan_daire = new Daire();
            Koordinat sol_ust = new Koordinat();
            sol_ust.Coords(12, 20);
            ucan_daire.K = sol_ust;
            ucan_daire.yaricap = 5;

            Dikdortgen dimdikdortgen = new Dikdortgen();
            dimdikdortgen.K = sol_ust;
            dimdikdortgen.genislik = 50;
            dimdikdortgen.yukseklik = 30;

            Console.WriteLine("Daire cevre = " + Hesap.daire_cevre(ucan_daire.yaricap));
            Console.WriteLine("Daire alan = " + Hesap.daire_alan(ucan_daire.yaricap));
            Console.WriteLine("Dikdörtgen cevre = " + Hesap.dikdortgen_cevre(dimdikdortgen.yukseklik,dimdikdortgen.genislik));
            Console.WriteLine("Dikdörtgen alan = " + Hesap.dikdortgen_alan(dimdikdortgen.yukseklik, dimdikdortgen.genislik));



        }
    }
}
