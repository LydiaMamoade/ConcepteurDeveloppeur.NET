using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregation
{
    class Program
    {
        static void Main(string[] args)
        {
            // classe de type référence
            Cheval c1;                      // Déclaration
            c1 = new Cheval();               // construction
            c1.Nom = "Jolly jumper";        // Initialisations
            c1.Proprietaire = "Lucky luke";

            // classe de type valeur
            int i;                  // Déclaration et construction
            i = 7;                  // Initialisation

            Cheval c2;               // Déclaration
            c2 = new Cheval();
            c2 = c1;
            c2.Proprietaire = "Tintin";

            Cheval c3 = new Cheval { Nom = "Tornardo", Proprietaire = "Zorro" };

            Console.WriteLine("c1 : {0} est la propriété de {1}", c1.Nom, c1.Proprietaire);
            Console.WriteLine("c3 : {0} est la propriété de {1}", c3.Nom, c3.Proprietaire);
            Console.Read();
        }
    }
    class Cheval
    {
        public string Nom;
        public string Proprietaire;
    }
}
