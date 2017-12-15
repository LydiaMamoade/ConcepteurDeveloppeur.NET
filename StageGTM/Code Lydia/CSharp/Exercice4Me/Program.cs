using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
    class Program
    {
        private const string FICHIER_BINAIRE = @"\\PARME25\Lydia\Code\CSharp\Exercice4\listeSalle.bin";
        private const string FICHIER_XML = @"\\PARME25\Lydia\Code\CSharp\Exercice4\listeSalle.xml";
        static void Main(string[] args)
        {
            Console.WriteLine("1. Sérialiser \n2.Désérialiser \n Tapez 1 ou 2");
            string saisie = Console.ReadLine();
            switch (saisie)
            {
                case "1": Saisie(); break;
                case "2": Recherche(); break;
            }

            Serialiser();

            Console.Read();

        }

        private static void Saisie()
        {
            throw new NotImplementedException();
        }

        private static void Recherche()
        {
            throw new NotImplementedException();
        }

        private static void Serialiser()
        {

            // Création de la liste
            var listePersonne = new List<String>();

            int NbPersMax = 2;
            int Nb = 0;

            while (Nb < NbPersMax)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Personne " + (Nb + 1));
                Console.WriteLine("Veillez entrer votre Nom ");
                string saisieNom = Console.ReadLine();

                Console.WriteLine("Veillez entrer votre Prenom ");
                string saisiePrenom = Console.ReadLine();

                Console.WriteLine("Veillez entrer votre age ");
                string saisieAge = Console.ReadLine();

                var p = new Personne();
                p.Nom = saisieNom;
                p.Prenom = saisiePrenom;
                int age;
                if (int.TryParse(saisieAge, out age)) p.Age = age;

                var listPersonne = new List<Personne>();
                listPersonne.Add(p);


                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Numéro {0}: Vous vous  appelez {1} {2} et vous avez {3}ans ", (Nb + 1), p.Nom, p.Prenom, age);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Nb++;

            }

            
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
    //[Serializable()]
    class Personne
    {
        public string Nom ="";
        public string Prenom = " ";
        public int Age ;
        //public Datime DateDeNaissance = DateTime.MinValue;
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}",Nom,  Prenom, Age);
        }
    }
    //[Serializable()]

}
