using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructeur
{
    class Program
    {
        static void Main(string[] args)
        {
            Maison m1 = new Maison();           // Jaune
            Maison m2 = new Maison("rouge");    // Rouge
            Batiment b1 = new Batiment();       // Vert

            Math m = new Math(); // Erreur
        }
    }
    class Maison
    {
        public string Couleur = "Bleu";
        // Constructeur par défaut
        public Maison() : this("jaune")
        {

        }
        // Autre constructeur
        public Maison(string c)
        {
            Couleur = c;
        }
    }
    class Batiment : Maison
    {
        public const bool FondationBeton = true;
        public readonly int SurfaceTerrasse;
        public Batiment() : base("vert") // Appel au constructeur de base
        {
            //FondationBeton = false; // Erreur
            SurfaceTerrasse = 3000;
            // ...
            // SurfaceTerrasse = 5000; // Erreur
        }
    }
    class Math
    {
        private Math()
        {

        }
        static Math() // Execution de cette méthode avant le chargement de cette classe
        {
        }
    }
}
