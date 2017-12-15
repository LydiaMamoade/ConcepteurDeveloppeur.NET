using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {

            Auto Clio = new Auto { Modele = "Clio2", Marque = "Renault", Proprietaire = "Jean" };

            //Auto Ds3 = new Auto { Modele = "Ds3+", Marque = "Citroen", Proprietaire = "qing" };
            Auto Ds3;
            Ds3 = new Auto();
            Ds3.Modele = "Ds3+";
            Ds3.Marque = "Citroen";
            Ds3.Proprietaire = "qing";

            //Moto M1450FLHR = new Moto { Marque = "Harlay-Davidson", Proprietaire = "Johnny", Nom ="Eclaire"};
            Moto M1450FLHR = new Moto();
            M1450FLHR.Nom = "Eclaire";
            M1450FLHR.Marque = "Harlay-Davidson";
            M1450FLHR.Proprietaire = "Johnny";

            Console.WriteLine("le proprietaire de la  {2} ({0}) est {1}", Clio.Marque, Clio.Proprietaire, Clio.Modele);
            Console.WriteLine("le proprietaire de la {2} ({0}) est {1}", Ds3.Marque, Ds3.Proprietaire, Ds3.Modele);
            Console.WriteLine("le proprietaire de l'{2} ({0}) est {1}", M1450FLHR.Marque, M1450FLHR.Proprietaire, M1450FLHR.Nom);

            Console.Read();
        }
    }
    class Auto : Vehicule
    {
        public string Modele;
    }

    class Vehicule
    {
        public string Marque;
        public string Proprietaire;

    }

    class Moto : Vehicule
    {
        public string Nom;
    }
}
