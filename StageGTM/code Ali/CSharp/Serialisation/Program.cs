using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace Serialisation
{
    class Program
    {
        private const string FICHIER_BINAIRE = @"..\..\listeSalle.bin";
        private const string FICHIER_XML = @"..\..\listeSalle.xml";
        static void Main(string[] args)
        {
            Console.WriteLine("1. Sérialiser \n2.Désérialiser \n Tapez 1 ou 2");
            string saisie = Console.ReadLine();
            switch (saisie)
            {
                case "1": Serialiser(); break;
                case "2": Deserialiser(); break;
            }
            Console.Read();
        }

        private static void Deserialiser()
        {
            Console.WriteLine("1. Binaire \n2.XML \n Tapez 1 ou 2");
            string saisie = Console.ReadLine();
            Personnes listePersonne = null;
            switch (saisie)
            {
                case "1":
                    if (File.Exists(FICHIER_BINAIRE))
                    {
                        FileStream flux = File.OpenRead(FICHIER_BINAIRE);
                        BinaryFormatter deserialiseur = new BinaryFormatter();
                        listePersonne = (Personnes)deserialiseur.Deserialize(flux);
                    }
                    else
                    {
                        Console.WriteLine("Pas de fichier binaire");
                    }
                    break;
                case "2":
                    if (File.Exists(FICHIER_XML))
                    {
                        FileStream flux = File.OpenRead(FICHIER_XML);
                        SoapFormatter deserialiseur = new SoapFormatter();
                        listePersonne = (Personnes)deserialiseur.Deserialize(flux);
                    }
                    else
                    {
                        Console.WriteLine("Pas de fichier xml");
                    }
                    break;
            }
            if (listePersonne != null)
            {
                foreach (var personne in listePersonne)
                {
                    Console.WriteLine(personne);
                }
            }
        }

        private static void Serialiser()
        {
            // Création de la liste
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

            // Sérialisation
            Console.WriteLine("1. Binaire \n2.XML \n Tapez 1 ou 2");
            string saisie = Console.ReadLine();
            switch (saisie)
            {
                case "1":
                    FileStream flux = File.Create(FICHIER_BINAIRE);
                    BinaryFormatter serialiseur = new BinaryFormatter();
                    serialiseur.Serialize(flux, listePersonne);
                    flux.Close();
                    break;
                case "2":
                    flux = File.Create(FICHIER_XML);
                    SoapFormatter serialiseur2 = new SoapFormatter();
                    serialiseur2.Serialize(flux, listePersonne);
                    flux.Close();
                    break;
            }
        }
    }
    [Serializable()]
    class Personne
    {
        public string Prenom;
        public string Ville;
        public override string ToString()
        {
            return string.Format("{0} - {1}", Prenom, Ville);
        }
    }
    [Serializable()]
    class Personnes : List<Personne>
    {

    }
}
