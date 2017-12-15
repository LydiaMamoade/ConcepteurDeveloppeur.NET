using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu
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
                j1.NombrePropose =  0;
               // Console.WriteLine("le resultat est {0}", resultat);
                // switch  selon la valeur de
                switch (resultat)
                {
                    case Statut.TropPetit:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Trop petit"); break;                        
                    case Statut.TropGrand:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Trop Grand");  break;                        
                    case Statut.Gagner:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Gagné!! ");  break;                       
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
    /*====================================================================================================*/
    /****************************************** CLASSE JOUER **********************************************/
    /*====================================================================================================*/
    class Jouer
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

        internal void DonneUnNombre(int n)
        {
            // Tant le nombre donné par le jouer est zero, on continue de lui demander de saisir un nombre.
            // Si le nombre est différent de Zero on le récupère en string et on le converti en entier afin de faire la comparaion
            while (NombrePropose == 0)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Deviner un nombre compris entre 1 et 99 ({0}):", NCoup+1);     // utilisateur tape au clavier
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
    /*====================================================================================================*/
    /****************************************** CLASSE JEU ***********************************************/
    /*====================================================================================================*/
    class Jeu
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

        internal void Initialiser()
        {
            Random alea = new Random(); // gener un nombre aleatoire
            NombreADeviner = alea.Next(1, 99); // genere un nombre aleatoire entre 1 et 99
            
        }

        //public void AfficheResultat)
        //{
        //    Console.WriteLine("{0}!" x);
        //}


    }
    enum Statut { NonDefini, TropPetit, TropGrand, Gagner, Perdu }   // enumeration liste des entier 1 2 3 4 5 enum class de type valeur

}
