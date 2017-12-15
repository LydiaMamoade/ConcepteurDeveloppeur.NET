using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encaptulation
{
    class Program
    {
        static void Main(string[] args)
        {
            CarteBancaire Carte1 = new CarteBancaire
            {
                Type = "Visa",
                Numero = "0000 0000 0000 0000",
                MoisValidite = 4,
                AnneeValidite = 18,
                Titulaire = "MAKRI",
                Cryptogramme = "000",
                //CodeSecret = "1234"   // version0 
                       
            };
            Carte1.Demandeur = new Personne { Nom = "Banque" };
           // Carte1.Demandeur.Nom = "Banque";
            Carte1.CodeSecret="1234";

            Carte1.Demandeur = new Personne { Nom = "Ulysse" };
            // Carte1.Demandeur.Nom = "Ulysse";
            Carte1.CodeSecret="5678";  // version1
                                       // Carte1.SetCodeSecret("1234");  // version2
            Carte1.Demandeur = new Personne { Nom = "Ulysse" };
            //Carte1.Demandeur.Nom = "Ulysse";

            Personne moi = new Personne { Nom = "Ulysse" };

            //Console.WriteLine("Le code secret de la carte {0} est {1}", Carte1.Titulaire, Carte1.GetCodeSecret()); // version1
            Console.WriteLine("Le code secret de la carte {0} est {1}", Carte1.Titulaire, Carte1.CodeSecret); //version 2
            Console.Read();
        }
    }
    class CarteBancaire
    {
        public string Type; // visa Mastercard
        public string Numero;
        public int MoisValidite;
        public int AnneeValidite;
        public string Titulaire;
        public string Cryptogramme;

        // version0
        //public string CodeSecret;
        // public string Demandeur;
        // Version 1
        //private string CodeSecret;
        //public string GetCodeSecret()   //cette méthode permet de recupéré le CodeSecret
        //{
        //    return CodeSecret;
        //}
        //public void SetCodeSecret(string value)   // cette méthode permet de  mettre une valeur  dans codeCodeSecret
        //{
        //    CodeSecret = value;
        //}
        // version 2
        public Personne Demandeur;
        private string x;
        public string CodeSecret
        {
            get

            {
               
                if (Demandeur.Nom == "MAKRI")
                    return x;
                else
                    return "xxxx";
            }
            set
            {
                
                if (Demandeur.Nom == "Banque")
                   x = value;
            }
        }                                                                         

    }
    class Personne
    {
        public string Nom; 
      
    }
}
