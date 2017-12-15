using System;
using N1;

namespace N2
{
    public class Joueur
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

        public void DonnerUnNombre(int n)
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
    public class Jeu
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
}
