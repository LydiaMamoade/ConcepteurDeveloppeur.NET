using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Cheval JollyJumper = new Cheval();
            JollyJumper.Allaiter();
            Console.Read();
        }
    }
    class Cheval : Mammifere
    {
        // Propriétés
        public string Nom;
        public int Age;

        // Méthodes
        public void Courrir() { }
    }
    class Mammifere : Animal
    {
        public void Allaiter()
        {
            Console.WriteLine("Allaitement en cours...");
        }
    }
    class Chien : Mammifere
    {
    }
    class Animal { }
}
