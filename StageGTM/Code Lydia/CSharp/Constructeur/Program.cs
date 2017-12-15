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
            Maison m1 = new Maison();                 // jaune
            Maison m2 = new Maison("rouge");          // rouge
            Batiment b1 = new Batiment();             // vert

            //Math m = new Math()
        }
    }
    class Maison
    {
        public string Couleur = "Bleu";
        // constructeur
        // this cherche dans la classe un construction qui a le meme parametre que lui
        public Maison() : this("jaune") // constructeur par defaut, aucun paramètre, il existe un autre contructeur il faut le définir aussi si on veut l'utiliser
        {

        }
        public Maison(string c) // autre constructeur avec paramètre
        {
            Couleur = c;

        }
    }
    class Batiment : Maison
    {
        public const bool FondationVeton = true;
        public readonly int SurfaceTerrasse;
        public Batiment() : base("vert") // fait appel au construction base celui de la classe maison premier constructeur qui est en haut 
        {
            //FondationVeton = false; // Erreur
            SurfaceTerrasse = 3000;

            //SurfaceTerrasse = 5000; // Erreur


        }
    }

   class Math
    {
       private Math()
        {
                
        }
         static Math() { }
    }
}
