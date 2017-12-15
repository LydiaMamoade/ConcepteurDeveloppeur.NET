using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonProgramme
{
    class Program
    {
        static void Main(string[] args)
        {
            Personnes listePersonne = new Personnes();
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

            int indexAgadir;
            for (int i = 0; i < listePersonne.Count; i++)
            {
                if (listePersonne[i].Ville == "Agadir")
                {
                    indexAgadir = i;
                    break;
                }
            }

            var reponses = listePersonne.Where(p => p.Ville.EndsWith("A") || p.Prenom.StartsWith("A"));
            foreach (Personne p in reponses)
            {

                Console.WriteLine(p);
              

            }
            Console.Read();
            //  Personne pTana;
            //foreach (Personne p in listePersonne)
            //{
            //    if (p.Ville == "Tana")
            //    {
            //        pTana = p;
            //        Console.WriteLine(p);
            //        Console.Read();
            //    }
            //}
        }

    }

    class Personne
    {
        public string Prenom;
        public string Ville;

        public override string ToString()
        {
            return Prenom + " " + Ville;
        }

    }

    class Personnes : IEnumerable<Personne>
    {
        private List<Personne> ListePrivee = new List<Personne>();  //encapsulation d'une liste de classe type Personne

        public void Add(Personne p)     // Methode add qui permet d'ajouter des éléments dans la liste qui encapsule ListePree
        {
            ListePrivee.Add(p);

        }

        public IEnumerator<Personne> GetEnumerator()
        {
            return new PersonneInumerator(ListePrivee);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new PersonneInumerator(ListePrivee);
        }



        public int Count { get { return ListePrivee.Count; } }

        public Personne this[int i] { get { return ListePrivee[i]; } }

    }

    internal class PersonneInumerator : IEnumerator<Personne>
    {
        private List<Personne> listePrivee;

        private int Index = -1;

        public PersonneInumerator(List<Personne> listePrivee)
        {
            this.listePrivee = listePrivee;
        }

        public Personne Current
        {
            get
            {
                return listePrivee[Index];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return this.listePrivee[Index];
            }
        }

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            Index++;
            return Index < this.listePrivee.Count;
        }

        public void Reset()
        {
            Index = -1;
        }
    }
}
