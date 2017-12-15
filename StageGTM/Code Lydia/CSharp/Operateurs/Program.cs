using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operateurs
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = 45;
            int c = a + b;   // + une methode
            c = Plus(a, b);

            Boite b1 = new Boite { Hauteur = 1, Largeur = 2, Longueur = 3 };
            Boite b2 = b1 * 2;
            Boite b3 = 2 * b1;


            Console.Read();

        }
        static int Plus(int i, int j) { return i + j; }
    }

    class Boite
    {
        public double Hauteur;
        public double Longueur;
        public double Largeur;
        public static Boite operator *(int i, Boite b)
        {
            return b * i;
        }

        public static Boite operator *(Boite b, int i)
        {
            Boite nouvelleBoite = new Boite
            {
                Hauteur = b.Hauteur * 2,
                Largeur = b.Largeur * 2,
                Longueur = b.Longueur * 2
            };

            return nouvelleBoite;
        }

    }

}



