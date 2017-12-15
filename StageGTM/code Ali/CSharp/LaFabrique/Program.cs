using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaFabrique
{
    class Program
    {
        static void Main(string[] args)
        {
            var listePersonne = new Personnes();
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

            Personne pTana;
            foreach(Personne p in listePersonne)
            {
                if (p.Ville == "Tana")
                {
                    pTana = p;
                }
            }
        }
        class Personne
        {
            public string Prenom;
            public string Ville;
        }
        class Personnes : IEnumerable<Personne>
        {
            private List<Personne> listePrivee = new List<Personne>();
            public void Add(Personne p)
            {
                listePrivee.Add(p);
            }

            public IEnumerator<Personne> GetEnumerator()
            {
                return new PersonneEnumerator(listePrivee);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return new PersonneEnumerator(listePrivee);
            }

            public int Count { get { return listePrivee.Count; } }
            public Personne this[int i]
            {
                get { return listePrivee[i]; }
            }
        }
        class PersonneEnumerator : IEnumerator<Personne>
        {
            private List<Personne> ListePrivee2;
            private int Index = -1;
            public PersonneEnumerator(List<Personne> liste)
            {
                ListePrivee2 = liste;
            }
            public Personne Current
            {
                get
                {
                    return ListePrivee2[Index];
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return ListePrivee2[Index];
                }
            }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                Index++;
                return Index < ListePrivee2.Count;
            }

            public void Reset()
            {
                Index = -1;
            }
        }
    }
}