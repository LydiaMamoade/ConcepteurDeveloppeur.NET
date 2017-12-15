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
            //tabEntierV1[3] = 140; // Erreur Exception

            string[,] tab3D_V1 = new string[2, 3];
            tab3D_V1[0, 0] = "Paris";
            tab3D_V1[0, 1] = "Lyon";
            tab3D_V1[0, 2] = "Maseille";
            tab3D_V1[1, 0] = "Rome";
            tab3D_V1[1, 1] = "Naples";
            tab3D_V1[1, 2] = "Palerme";

            //int[] tabEntierV2= { 10,20,30};

            string[,] tab3D_V2 ={
                   { "Paris","Lyon", "Maseille"}, { "Maseille", "Naples", "Palerme"}
                  };

            Personne[] tabPersonne = new Personne[3];
            tabPersonne[0] = new Personne { Nom = "Alfred", Age = 10 };
            tabPersonne[1] = new Personne { Nom = "Beatrice", Age = 10 };
            tabPersonne[2] = new Personne { Nom = "Chalies", Age = 10 };
            Personne[] tabPersonne_v2 = {
                new Personne { Nom = "Alfred", Age = 10 },
                new Personne { Nom = "Beatrice", Age = 10 },
                new Personne { Nom = "Chalies", Age = 10 }
            };
            int ntabPersonne = tabPersonne_v2.Length;
            int nDim = tab3D_V2.Rank; // dimension
            int nE1emDim2 = tab3D_V2.GetLength(1);

            int IndexOf30 = Array.IndexOf(tabEntierV1, 30); // 2
            int ValIndex0 = tabEntierV1[0]; // 10
            int DerniereValeur = tabEntierV1[tabEntierV1.Length - 1];// 30
            //Foreach
            for (int i=0; i<tabPersonne_v2.Length; i++)
            {
                Console.WriteLine(tabPersonne_v2[i].Nom);
            }
            foreach (Personne p in tabPersonne_v2) 
            {
                Console.WriteLine(p.Nom);
            }
            Console.Read();
        }
    }
    //class Personne: Object, toutes les héritent de la classe Object
    class Personne
    {
        public string Nom;
        public int Age;
    }
}
