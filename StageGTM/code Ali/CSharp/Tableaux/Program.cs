using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableaux
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;

            int[] tabEntierV1 = new int[n];
            tabEntierV1[0] = 10;
            tabEntierV1[1] = 20;
            tabEntierV1[2] = 30;
            //tabEntier[3] = 40; // Erreur : Exception déclenchée

            string[,] tab3D_V1 = new string[2, 3];
            tab3D_V1[0, 0] = "Paris";
            tab3D_V1[0, 1] = "Lyon";
            tab3D_V1[0, 2] = "Marseille";
            tab3D_V1[1, 0] = "Rome";
            tab3D_V1[1, 1] = "Naples";
            tab3D_V1[1, 2] = "Palerme";

            Personne[] tabPersonne_V1 = new Personne[3];
            tabPersonne_V1[0] = new Personne { Nom = "Alfred", Age = 10 };
            tabPersonne_V1[1] = new Personne { Nom = "Béatrice", Age = 20 };
            tabPersonne_V1[2] = new Personne { Nom = "Charles", Age = 30 };

            // Facilités d'écriture
            int[] tabEntierV2 = { 10, 20, 30 };
            string[,] tab3D_V2 = {
                {"Paris", "Lyon","Marseille"},
                {"Rome", "Naples","Palerme"},
            };
            Personne[] tabPersonne_V2 = {
                    new Personne { Nom = "Alfred", Age = 10 },
                    new Personne { Nom = "Béatrice", Age = 20 },
                    new Personne { Nom = "Charles", Age = 30 }
            };
            int nTabPersonne = tabPersonne_V2.Length;
            int nDim = tab3D_V2.Rank;
            int nElemDim2 = tab3D_V2.GetLength(1);

            int indexOf30 = Array.IndexOf(tabEntierV1, 30); // 2
            int ValIndex0 = tabEntierV1[0]; // 10
            int DerniereValeur = tabEntierV1[tabEntierV1.Length - 1]; // 30

            // Foreach
            for (int i = 0; i < tabPersonne_V2.Length; i++)
            {
                Console.WriteLine(tabPersonne_V2[i].Nom);
            }
            foreach (Personne p in tabPersonne_V2)
            {
                Console.WriteLine(p.Nom);
            }
        }
    }
    class Personne 
    {
        public string Nom;
        public int Age;
    }
}
