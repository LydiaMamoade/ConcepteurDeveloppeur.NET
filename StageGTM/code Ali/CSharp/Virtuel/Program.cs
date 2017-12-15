using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtuel
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto lamborghini = new Auto();
            lamborghini.Rouler();

            Moto kawazaki = new Moto();
            kawazaki.Rouler();

            // Polymorphisme
            Vehicule v;
            if (Console.ReadLine() == "A")
                v = new Auto();
            else
                v = new Moto();
            v.Rouler();

            Vehicule cesna = new Avion();
            cesna.Rouler();

            Console.Read();
        }
    }
    class Vehicule
    {
        public virtual void Rouler() { Console.WriteLine("Le véhicule roule"); }
    }
    class Auto : Vehicule
    {
        public override void Rouler()
        {
            base.Rouler();
            Console.WriteLine("L'auto roule");
        }
    }
    class Moto : Vehicule
    {
        public override void Rouler() { Console.WriteLine("La moto roule"); }
    }
    class Harley : Moto
    {
        public override void Rouler() { Console.WriteLine("La moto roule"); }
    }
    class Avion : Vehicule
    {
        public virtual new void Rouler()
        {
            Console.WriteLine("L'avion vole");
        }
    }
    class Jet : Avion
    {
        public override void Rouler() { Console.WriteLine("Le jet vole"); }
    }
}
