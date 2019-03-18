using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab02_template
{
    public struct Koordinat
    {
        public int X;
        public int Y;
        public void Coords(int p_x, int p_y)
        {
            X = p_x;
            Y = p_y;
            //Constructor metot
        }
    }
    public struct Daire
    {
        public double yaricap;
         public  Koordinat K; //Sol üst köşe koordinat
    }
    public struct Dikdortgen
    {
        public double yukseklik, genislik;
        public Koordinat K;

    }
    public class Hesap
    {
        public static Koordinat daire_merkez_bul(Koordinat sol_ust, double yaricap)
        {
            Koordinat merkez;
            merkez.X = (int)(sol_ust.X + yaricap);
            merkez.Y = (int)(sol_ust.Y + yaricap);
            return merkez;
        }
        public static Koordinat dikdortgen_merkez_bul(Koordinat sol_ust, double yukseklik, double genislik)
        {
            Koordinat merkez;
            merkez.X = (int)(sol_ust.X + (genislik/2) );
            merkez.Y = (int)(sol_ust.Y + (yukseklik/2) ) ;
            return merkez;
        }
        public static double daire_alan(double yaricap)
        {
            return Math.PI * Math.Pow(yaricap, 2);
        }
        public static double dikdortgen_alan(double genislik,double yukseklik)
        {
            return genislik * yukseklik;
        }
        public static double dikdortgen_cevre(double genislik, double yukseklik)
        {
            return (genislik + yukseklik)*2;
        }
        public static double daire_cevre(double yaricap)
        {
            return Math.PI*yaricap * 2;
        }
    }
}
