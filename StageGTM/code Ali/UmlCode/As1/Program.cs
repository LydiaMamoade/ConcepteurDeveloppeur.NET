using System;
using N2;

namespace N1
{
    class Program
    {
        static void Main(string[] args)
        {
            Jeu partie = new Jeu();
            partie.Initialiser();
            Joueur j1 = new Joueur();
            j1.Initialiser();
            Statut resultat = Statut.NonDefini;

            // while (resultat != Statut.Gagne && resultat != Statut.Perdu)
            // Non A ET NON B <=> NON (A OU B)
            while (!(resultat == Statut.Gagne || resultat == Statut.Perdu))
            {
                j1.DonnerUnNombre(partie.NombreADeviner);
                resultat = partie.Comparer(j1);
                j1.NombrePropose = 0;
                switch (resultat)
                {
                    case Statut.TropPetit:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Trop petit"); break;
                    case Statut.TropGrand:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Trop grand"); break;
                    case Statut.Gagne:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Gagné !!"); break;
                    case Statut.Perdu:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Perdu"); break;
                }
            }
            Console.Read();
        }
    }
}
