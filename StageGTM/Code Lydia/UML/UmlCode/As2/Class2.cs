using System;
using n1;


namespace n2
{
    public class Jeu
    {
        public int NombreADeviner = 0;
        public int NCoupMax = 6;
        public Statut Comparer(Jouer j)
        {
            j.NCoup++;// = ncoup =ncoup +1

            if (j.NombrePropose < NombreADeviner) return Statut.TropPetit;
            if (j.NombrePropose == NombreADeviner) return Statut.Gagner;
            if (j.NCoup > NCoupMax) return Statut.Perdu;
           
            return Statut.TropGrand;
        }

        public void Initialiser()
        {
            Random alea = new Random(); // gener un nombre aleatoire
            NombreADeviner = alea.Next(1, 99); // genere un nombre aleatoire entre 1 et 99
        }
    }


    public class Jouer
    {
        public Statut Resultat = Statut.NonDefini;
        public int NombrePropose = 0;
        public int NCoup = 0;

        public void Initialiser()
        {
            NCoup = 0;
            Resultat = Statut.NonDefini;
            NombrePropose = 0;
        }

        public void DonneUnNombre(int n)
        {
            // Tant le nombre donné par le jouer est zero, on continue de lui demander de saisir un nombre.
            // Si le nombre est différent de Zero on le récupère en string et on le converti en entier afin de faire la comparaion
            while (NombrePropose == 0)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Deviner un nombre compris entre 1 et 99 ({0}):", NCoup + 1);     // utilisateur tape au clavier
                var saisie = Console.ReadLine();                               // recupere ce que l'utilisateur à taper (ReadLine donne un string)
                                                                               //var  veut dire que le compilateur sait de quel type est la variable saisie 
                OnTricheV1(saisie, n);

                int saisieInt = 0;
                // TryParse convertir un string en un entier
                if (int.TryParse(saisie, out saisieInt))                       // convertir un string en un entier
                {
                    NombrePropose = saisieInt;
                }
            }

        }


        [Obsolete("Utiliser la version 2 de cette méthode")] // Obsolete permet de passer des informations au developpeur qui va utiliser un code


        // surcharge overload
        private void OnTricheV1(string saisie, int n)
        {
            if (saisie == "yyy")
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(n);
            }
        }

        private void OnTricheV2(string saisie, int n, ConsoleColor couleur)
        {
            if (saisie == "yyy")
            {
                Console.ForegroundColor = couleur;
                Console.WriteLine(n);
            }
        }

    }
}
