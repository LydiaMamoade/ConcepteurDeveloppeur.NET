using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste
{
    class Program
    {
        static void Main(string[] args)
        {
            var listePersonne = new List<Personne> {
                 new Personne { Prenom = "Théodoros", Ville = "Athènes" },
                 new Personne { Prenom = "Thi Qui Khanh", Ville = "Hochiminh" },
                 new Personne { Prenom = "Lydia", Ville = "Bangui" },
                 new Personne { Prenom = " Niry ", Ville = "Tana" },
                 new Personne { Prenom = "Velio ", Ville = "Mexico" },
                 new Personne { Prenom = "Hédi ", Ville = "Melun " },
                 new Personne { Prenom = "Raja ", Ville = "Agadir " },
                 new Personne { Prenom = "Yiping ", Ville = "Shanghai" },
                 new Personne { Prenom = "Armelle", Ville = "Douala" },
                 new Personne { Prenom = "Denis", Ville = "Paris" },
                 new Personne { Prenom = "Hafid", Ville = "Bejaia" },
                 new Personne { Prenom = "Pierre Yves", Ville = "Nancy" },
                 new Personne { Prenom = "Maurice", Ville = "Clamart" },
          };


            var listeEntier = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            var listeComplexe = new List<List<Personne>>();

            foreach (Personne p in listePersonne)
            {
                if (p.Prenom.Contains("e"))
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("{0}\t{1}", p.Prenom, p.Ville);


            }
            Console.Read();
        }

        private static void Foreach(Personne personne, object p, object listPersonne)
        {
            throw new NotImplementedException();
        }
    }
    class Personne
    {
        public string Prenom;
        public string Ville;
    }
}
