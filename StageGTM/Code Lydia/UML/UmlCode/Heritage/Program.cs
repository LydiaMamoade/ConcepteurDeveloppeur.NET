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
            Cheval JollyJumper = new Cheval();    // JollyJumpper objet de la classe cheval
            JollyJumper.Allaiter();
            Console.Read();
        }
    }
    class Cheval : Mammifere      // héritage, la classe cheval contient toutes les propriétés de mammifère et de la classe Animal
    {
        // Propriétés
        public string Nom;
        public int Age;
        // Méthodes
        public void Courrir() { }
    }

    class Mammifere : Animal   // héritage, la classe mammifère contient toutes les propriétés de Animal
    {
        public void Allaiter ()
        {
            Console.WriteLine("Allaitement en cours..");
        }
    } 
     class chien : Mammifere // héritage, la classe chien contient toutes les propriétés de mammifère et de la classe Animal
    {

    }  
    class Animal { } 
}
