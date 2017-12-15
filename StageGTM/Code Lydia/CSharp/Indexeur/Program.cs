using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexeur
{
    class Program
    {
        static void Main(string[] args)
        {
            Personnes listePersonne = new Personnes();
            listePersonne.Add(new Personne { Prenom = "Théodoros", Ville = "Athènes" });
            listePersonne.Add(new Personne { Prenom = "Thi Qui Khanh", Ville = "Hochiminh" });
            listePersonne.Add(new Personne { Prenom = "Lydia", Ville = "Bangui" });
            listePersonne.Add(new Personne { Prenom = " Niry ", Ville = "Tana" });
            listePersonne.Add(new Personne { Prenom = "Velio ", Ville = "Mexico" });
            listePersonne.Add(new Personne { Prenom = "Hédi ", Ville = "Melun " });
            listePersonne.Add(new Personne { Prenom = "Raja ", Ville = "Agadir " });
            listePersonne.Add(new Personne { Prenom = "Yiping ", Ville = "Shanghai" });
            listePersonne.Add(new Personne { Prenom = "Armelle", Ville = "Douala" });
            listePersonne.Add(new Personne { Prenom = "Denis", Ville = "Paris" });
            listePersonne.Add(new Personne { Prenom = "Hafid", Ville = "Bejaia" });
            listePersonne.Add(new Personne { Prenom = "Pierre Yves", Ville = "Nancy" });
            listePersonne.Add(new Personne { Prenom = "Maurice", Ville = "Clamart" });

            Personne p1 = listePersonne[9];
            Personne p2 = listePersonne["Maurise"];

        }
    }
    class Personne
    {
        public string Prenom;
        public string Ville;
    }
    class Personnes:List<Personne>
    {
        public Personne this[string prenom]
        {
            get { return this.Where(p => p.Prenom == prenom).FirstOrDefault; } // this l'objet dans lequel je suis 
        }

    }
}
