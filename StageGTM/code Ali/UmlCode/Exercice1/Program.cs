using System;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto Clio = new Auto { Modele="Clio 2",  Marque= "Renault", Proprietaire = "Jean"};
            Auto Ds3 = new Auto();
            Moto Modele1450FLHR = new Moto();

            Ds3.Marque = "Citroën";
            Ds3.Proprietaire = "Qing";
            Ds3.Modele = "DS3+";
            Modele1450FLHR.Marque = "Harley-Davidson";
            Modele1450FLHR.Proprietaire = "Johnny";
            Modele1450FLHR.Nom = "Eclair";

            Console.WriteLine("Le propriétaire de la {2} ({0}) est {1}", 
                Clio.Marque, Clio.Proprietaire, Clio.Modele);
            Console.WriteLine("Le propriétaire de la {2} ({0}) est {1}", 
                Ds3.Marque, Ds3.Proprietaire, Ds3.Modele);
            Console.WriteLine("Le propriétaire de la {2} ({0}) est {1}", 
                Modele1450FLHR.Marque, Modele1450FLHR.Proprietaire, Modele1450FLHR.Nom);

            Console.Read();
        }
    }
    class Auto : Vehicule
    {
        public string Modele;
    }
    class Vehicule
    {
        public string Proprietaire;
        public string Marque;
    }
    class Moto : Vehicule
    {
        public string Nom;
    }
}
