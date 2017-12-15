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
            Cheval c1;                                        // déclaration
            c1 = new Cheval();                                // contruction
            c1.Nom = "Jolly jumper";
            c1.Proprietaire = "Lucky luke";

            // classe type valeur
            int i;                                          // Déclaration construction
            i = 7;                                          // Initialisation

            Cheval c2;                                      // Déclaration
            c2 = c1;                                       
            c2.Proprietaire = "Zorro";
            c2.Proprietaire = "Tintin";

            Cheval c3 = new Cheval { Nom = "Tornade", Proprietaire = "Zorro" };

            Console.WriteLine("c1: {0} la proprietaire de {1}", c1.Nom, c1.Proprietaire);
            Console.WriteLine("c3: {0} la proprietaire de {1}", c3.Nom, c3.Proprietaire);
            Console.Read();

        }
    }
    class Cheval
    {
        public string Nom;
        public string Proprietaire;
    }
}
