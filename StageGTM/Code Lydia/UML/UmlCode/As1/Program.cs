using System;
using n2;

namespace n1
{
    class Program
    {
        static void Main(string[] args)
        {

            Jeu partie = new Jeu();
            partie.Initialiser(); // determiner le nombre qu'il faut deviner
            Jouer j1 = new Jouer();
            j1.Initialiser();
            Statut resultat = Statut.NonDefini;
            // Tant le jouer ne perd ni ne gagne on continue le jeu
            // while (resultat != Statut.Gagner && resultat !== Statut.Perdu) //  Non A et Non B  = non(A ou B); & esperluete        
            while (!(resultat == Statut.Gagner || resultat == Statut.Perdu)) // || caractère pie 
            {

                j1.DonneUnNombre(partie.NombreADeviner);
                resultat = partie.Comparer(j1);
                j1.NombrePropose = 0;
                // Console.WriteLine("le resultat est {0}", resultat);
                // switch  selon la valeur de
                switch (resultat)
                {
                    case Statut.TropPetit:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Trop petit"); break;
                    case Statut.TropGrand:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Trop Grand"); break;
                    case Statut.Gagner:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Gagné!! "); break;
                    case Statut.Perdu:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Perdu"); break;

                }
                //Console.WriteLine("Nombre a deviner {0}", partie.NombreADeviner);
            }
            //Jeu party = new Jeu();
            //party.Initialiser();
            //Console.WriteLine("Nombre a deviner {0}", partie.NombreADeviner);
            Console.Read();
        }
    }
}
