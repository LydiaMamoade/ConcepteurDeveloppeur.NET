using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevinerUnNombre
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
    class Joueur
    {
        public int NombrePropose = 0;
        public Statut Resultat = Statut.NonDefini;
        public int NCoup = 0;

        public void Initialiser()
        {
            NCoup = 0;
            Resultat = Statut.NonDefini;
            NombrePropose = 0;
        }

        internal void DonnerUnNombre(int n)
        {
            while (NombrePropose == 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Donner un nombre entre 1 et 99 ({0}) : ", NCoup + 1);
                string saisie = Console.ReadLine();
                OnTriche(saisie, n);  // Overload
                int saisieInt = 0;
                if (int.TryParse(saisie, out saisieInt))
                {
                    NombrePropose = saisieInt;
                }
            }
        }

        [Obsolete("Utiliser la version 2 de cette méthode")]
        private void OnTriche(string saisie, int n)
        {
            if (saisie == "yyy")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(n);
            }
        }
        private void OnTriche(string saisie, int n, ConsoleColor couleur)
        {
            if (saisie == "yyy")
            {
                Console.ForegroundColor = couleur;
                Console.WriteLine(n);
            }
        }
    }
    class Jeu
    {
        public int NombreADeviner = 0;
        public int NCoupMax = 6;
        public Statut Comparer(Joueur j)
        {
            j.NCoup++;
            if (j.NombrePropose == NombreADeviner) return Statut.Gagne;
            if (j.NCoup > NCoupMax) return Statut.Perdu;
            if (j.NombrePropose < NombreADeviner) return Statut.TropPetit;
            return Statut.TropGrand;
        }

        public void Initialiser()
        {
            Random alea = new Random();
            NombreADeviner = alea.Next(1, 99);
        }
    }
    enum Statut { NonDefini, TropPetit, TropGrand, Gagne, Perdu }
}
