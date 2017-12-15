using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto fiat500 = new Auto();
            if (fiat500 is Auto) Console.WriteLine("La fiat500 est une auto");
            if (fiat500 is Vehicule) Console.WriteLine("La fiat500 est un véhicule");
            if (! (fiat500 is Moto)) Console.WriteLine("La fiat500 n'est pas une moto");

            Vehicule porsche = new Auto();

            ((Auto)porsche).Rouler();       // Conversion 1 : ()
            Auto a = porsche as Auto;       // Conversion 2 : si pas possible a=null
            string s = porsche.ToString();  // Conversion 3 : une méthode
            DateTime d = Convert.ToDateTime("11/12/2017"); // Conversion 4

            Console.Read();
        }
    }
    class Auto : Vehicule
    {
        public void Rouler() { Console.WriteLine("L'auto roule"); }
    }
    class Vehicule { }
    class Moto : Vehicule { }
}
