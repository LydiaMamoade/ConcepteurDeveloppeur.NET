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

            Vehicule deudeuch = new Auto();
            deudeuch.Rouler();

            // Polymorphisme
            Vehicule v;
            if (Console.ReadLine() == "A")
                v = new Auto();
            else
                v = new Moto();
            v.Rouler();  // = L'auto roule si tape A  = La moto roule si on tape autre chose que A

            Vehicule cesna = new Avion();
            cesna.Rouler();

            Console.Read();
        }
    }
    class Vehicule
    {
        public virtual void Rouler() // virtual veut dire que la méthode peut être remplacer
        {
            Console.WriteLine("\t Le véhicule roule");
        }
    }
    class Auto : Vehicule
    {
        public override void Rouler() // remplace la méthode rouler de la classe vehicule
        {
            base.Rouler(); // appelle la méthode rouler de véhicule
            Console.WriteLine("L'auto roule");
        }
    }

    class Moto : Vehicule
    {
        public override void Rouler() // remplace la méthode rouler de la classe vehicule
        {
            Console.WriteLine("\t La moto roule");
        }
    }
    class Harley : Moto
    {
        public override void Rouler() // remplace la méthode rouler de la classe vehicule
        {
            Console.WriteLine("Harley roule");
        }
    }
    class Avion : Vehicule
    {
        public virtual new void Rouler() // remplace la méthode rouler de la classe vehicule. new case le lien entre avion et véhicule (héritage)
        {
            base.Rouler();
            Console.WriteLine(" L'avion vole");
        }
    }
    class Jet : Avion
    {
        public override void Rouler() // remplace la méthode rouler de la classe vehicule
        {
            Console.WriteLine(" Le jet vole");
        }
    }

    sealed class A { }
    //class  B :A { } est impossible

    //interface I2
    //{
    //    void m3();
    //    void m2();
    //}
    //interface I1
    //{
    //    void m1();
    //    void m2();
    //}
    //class H : I1,  I2
    //{
    //    public void m1() { }
    //    public void m3() { }
    //    public void I2.m2() { }
    //    public void I1.m1() { }

    //}
}
