using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            CarteBancaire carte1 = new CarteBancaire();
            carte1.Type = "Visa";
            carte1.Numero = "0000 0000 0000 0000";
            carte1.MoisValidite = 4;
            carte1.AnneeValidite = 18;
            carte1.Titulaire = "MAKRI";
            carte1.Cryptogramme = "000";

            //carte1.Demandeur = "Banque";
            carte1.Demandeur = new Personne { Nom = "Banque" };
            carte1.CodeSecret = "1234";

            //carte1.Demandeur = "Ulysse";
            carte1.Demandeur = new Personne { Nom = "Ulysse" };
            carte1.CodeSecret = "5678";
            //carte1.SetCodeSecret("1234");

            //carte1.Demandeur = "Makri";

            Personne moi = new Personne { Nom = "Makri" };
            carte1.Demandeur = moi;

            Console.WriteLine("Le code secret de la carte de {0} est {1}", carte1.Titulaire, carte1.CodeSecret);
            //Console.WriteLine("Le code secret de la carte de {0} est {1}", carte1.Titulaire, carte1.GetCodeSecret());

            Console.Read();
        }
    }
    class CarteBancaire
    {
        public string Type; // Visa MasterCard
        public string Numero;
        public int MoisValidite;
        public int AnneeValidite;
        public string Titulaire;
        public string Cryptogramme;
        public Personne Demandeur;

        // Version 0
        //public string CodeSecret;

        // Version 1
        //private string CodeSecret;
        //public string GetCodeSecret()
        //{
        //    return CodeSecret;
        //}
        //public void SetCodeSecret(string value)
        //{
        //    CodeSecret = value;
        //}

        // Version 2
        private string x;
        public string CodeSecret
        {
            get
            {
                if (Demandeur.Nom == "Makri")
                    return x;
                else
                    return "XXXX";
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
