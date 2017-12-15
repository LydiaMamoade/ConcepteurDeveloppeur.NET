using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Emplacement> places = new List<Emplacement> {
                new Emplacement {Nom="A" },
                new Emplacement {Nom="B" },
                new Emplacement {Nom="C" }
            };

            // La pile de pièces est posé à l'emplacement A
            //places[0].Pieces.Add(new Piece { Nom = "piece10c", taille = 5 });
            places[0].Pieces.Add(new Piece { Nom = "piece20c", taille = 4 });
            places[0].Pieces.Add(new Piece { Nom = "piece50c", taille = 3 });
            places[0].Pieces.Add(new Piece { Nom = "piece1€", taille = 2 });
            places[0].Pieces.Add(new Piece { Nom = "piece2€", taille = 1 });

            Jeu j = new Jeu();
            // Déplacer la pile de pièces de A vers B en prenant C comme intermédiaire
            j.Deplacer(places[0], places[1], places[2]);

            Console.Read();
        }
    }
    class Piece
    {
        public int taille;
        public string Nom;
        public override string ToString()
        {
            return taille.ToString();
        }
    }
    class Emplacement
    {
        public string Nom;
        public List<Piece> Pieces = new List<Piece>();
        public override string ToString()
        {
            return Nom;
        }
    }
    class Jeu
    {
        public void Deplacer(Emplacement initial, Emplacement objectif, Emplacement intermediaire)
        {
            Piece p = initial.Pieces[0];

            if (initial.Pieces.Count == 1)
            {
                Console.WriteLine("{0}{1}{2}", p.taille, initial.Nom, objectif.Nom);
                objectif.Pieces.Add(p);
                initial.Pieces.Remove(p);
            }
            else
            {
                // Etape 1
                initial.Pieces.Remove(p);
                Deplacer(initial, intermediaire, objectif);

                // Etape 2
                initial.Pieces.Add(p);
                Deplacer(initial, objectif, intermediaire);

                // Etape 3
                Deplacer(intermediaire, objectif, initial);
            }
        }

    }
}
