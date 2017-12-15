using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
    class Program
    {
        private const string FICHIER_XML = @"..\..\Personnes.xml";
        private static Personnes ListePersonne = new Personnes();
        static void Main(string[] args)
        {
            bool fin = false;
            do
            {
                Init();

                Console.WriteLine("1. Saisie \n2.Recherche \n Tapez 1 ou 2");
                string saisie = Console.ReadLine();
                switch (saisie)
                {
                    case "1":
                        Saisie();
                        Serialiser();
                        break;
                    case "2":
                        Recherche();
                        break;
                }
                Console.Write("Encore ? (O/N)");
                saisie = Console.ReadLine();
                fin = saisie.StartsWith("N");
            } while (!fin);
        }

        private static void Serialiser()
        {
            FileStream flux = File.Create(FICHIER_XML);
            SoapFormatter serialiseur = new SoapFormatter();
            serialiseur.Serialize(flux, ListePersonne);
            flux.Close();
        }


        private static void Init()
        {
            Deserialiser();
            Console.Clear();
            foreach(var p in ListePersonne)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        private static void Deserialiser()
        {
            IFormatter deserialiseur = null;
            if (File.Exists(FICHIER_XML))
            {
                FileStream flux = File.OpenRead(FICHIER_XML);
                deserialiseur = new SoapFormatter();
                ListePersonne = (Personnes)deserialiseur.Deserialize(flux);
                flux.Close();
            }
        }

        private static void Recherche()
        {
            Console.Write("Tapez année de naissance: ");
            string saisie = Console.ReadLine();
            int annee=0;
            int.TryParse (saisie, out annee);
            var reponse = ListePersonne.Where(p => p.DateDeNaissance.Year == annee);
            foreach(var p in reponse)
            Console.WriteLine(p);
        }

        private static void Saisie()
        {
            bool end = false;
            while (!end)
            {
                Console.WriteLine("Tapez 1 pour ajouter une personne et 2 pour quitter");
                string saisie = Console.ReadLine();
                switch (saisie)
                {
                    case "1":
                        Personne p = new Personne();
                        Console.Write("Nom:");
                        saisie = Console.ReadLine();
                        p.Nom = saisie;
                        Console.Write("Prénom:");
                        saisie = Console.ReadLine();
                        p.Prenom = saisie;
                        Console.Write("Date de naissance:");
                        saisie = Console.ReadLine();
                        DateTime.TryParse(saisie, out p.DateDeNaissance);
                        ListePersonne.Add(p);
                        break;
                    case "2":
                        end = true;
                        break;
                }
            }
        }

        [Serializable()]
        class Personne
        {
            public string Nom = "";
            public string Prenom = "";
            public DateTime DateDeNaissance = DateTime.MinValue;
            public override string ToString()
            {
                return Nom + " " + Prenom + " : " + DateDeNaissance.ToLongDateString();
            }
        }
        [Serializable()]
        class Personnes : List<Personne>
        {

        }
    }
}
