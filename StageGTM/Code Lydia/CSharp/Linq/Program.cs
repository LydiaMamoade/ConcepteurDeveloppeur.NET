using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var listePersonne = new List<Personne>();
            listePersonne.Add(new Personne { Prenom = "Théodoros", Ville = "Athènes" });
            listePersonne.Add(new Personne { Prenom = "Thi Qui Khanh", Ville = "Hochiminh" });
            listePersonne.Add(new Personne { Prenom = "Lydia", Ville = "Bangui" });
            listePersonne.Add(new Personne { Prenom = "Niry", Ville = "Tana" });
            listePersonne.Add(new Personne { Prenom = "Velio", Ville = "Mexico" });
            listePersonne.Add(new Personne { Prenom = "Hédi", Ville = "Melun" });
            listePersonne.Add(new Personne { Prenom = "Raja", Ville = "Agadir" });
            listePersonne.Add(new Personne { Prenom = "Yiqing", Ville = "Shanghai" });
            listePersonne.Add(new Personne { Prenom = "Armelle", Ville = "Douala" });
            listePersonne.Add(new Personne { Prenom = "Denis", Ville = "Paris" });
            listePersonne.Add(new Personne { Prenom = "Hafid", Ville = "Bejaia" });
            listePersonne.Add(new Personne { Prenom = "Pierre Yves", Ville = "Nancy" });
            listePersonne.Add(new Personne { Prenom = "Ali", Ville = "Lyon" });
            listePersonne.Add(new Personne { Prenom = "Maurice", Ville = "Clamart" });

            var pAH = listePersonne.Where(p => p.Ville == "Athènes" || p.Ville == "Hochiminh"); // Linq natif
            pAH = from p in listePersonne where p.Ville == "Bangui" || p.Ville == "Mexico" select p;

            pAH = listePersonne.Where(p => p.Ville.EndsWith("i"));
            var listePrenom = listePersonne.Where(p => p.Ville == "Douala" || p.Ville == "Paris").Select(p => p.Prenom);
            var liste = listePrenom.ToArray();

            foreach (var p in listePrenom)
            {
                Console.WriteLine(p);
            }

            List<Planete> planetes = new List<Planete>();
            planetes.Add(new Planete { Nom = "Mercure", SystemeSolaire = true, Distance = 1 });
            planetes.Add(new Planete { Nom = "Vénus", SystemeSolaire = true, Distance = 2 });
            planetes.Add(new Planete { Nom = "Terre", SystemeSolaire = true, Distance = 3 });
            planetes.Add(new Planete { Nom = "Mars", SystemeSolaire = true, Distance = 4 });
            planetes.Add(new Planete { Nom = "Jupiter", SystemeSolaire = true, Distance = 5 });
            planetes.Add(new Planete { Nom = "Saturne", SystemeSolaire = true, Distance = 6 });
            planetes.Add(new Planete { Nom = "Uranus", SystemeSolaire = true, Distance = 7 });
            planetes.Add(new Planete { Nom = "Neptune", SystemeSolaire = true, Distance = 8 });
            planetes.Add(new Planete { Nom = "Alien", SystemeSolaire = true, Distance = 100 });

            var terre = planetes[2];
            var reponses1 = planetes.Where(p => p!= terre && p.Distance - terre.Distance <= 2 && p.SystemeSolaire);
            var reponses = reponses1.Where(p => p.Nom.StartsWith("M"));

            var reponses2 = planetes
                .Where(p => p != terre)
                // Classe anonyme
                .Select(p => new { Nom = p.Nom, DistanceTerre = Math.Abs(p.Distance - terre.Distance) });

            foreach (var reponse in reponses2)
            {
                Console.WriteLine(reponse);
            }
            Console.Read();
        }
    }
    class Personne
    {
        public string Prenom;
        public string Ville;
    }
    class Planete
    {
        public string Nom;
        public bool SystemeSolaire;
        public int Distance;
        public override string ToString()
        {
            return Nom + " : " + Distance.ToString();
        }
    }
    //class X
    //{
    //    public string Nom;
    //    public int DistanceTerre;
    //}
}
