using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chifoumi
{
    class Program
    {
        static void Main(string[] args)
        {
            Joueur humain = new Joueur { EstHumain = true };
            Joueur machine = new Joueur { EstHumain = false };
            Jeu partie = new Jeu();


            while (!humain.AGagner() && !machine.AGagner())
            {
                var choixHumain = humain.Choisir();
                var choixMachine = machine.Choisir();
                var resultat = partie.Comparer(choixMachine, choixHumain);
                string s = "";
                switch (resultat)
                {
                    case ResultatEnum.Gagner:
                        Console.ForegroundColor = ConsoleColor.Green;
                        humain.Points++;
                        machine.Points = 0;
                        s = "Gagné";
                        break;
                    case ResultatEnum.Perdu:
                        Console.ForegroundColor = ConsoleColor.Red;
                        machine.Points++;
                        humain.Points = 0;
                        s = "Perdu";
                        break;
                    case ResultatEnum.Egalite:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        humain.Points = 0;
                        machine.Points = 0;
                        s = "Egalité";
                        break;
                }
                Console.WriteLine("{0} - {1}: {4} - {2}/{3}", choixHumain, choixMachine, humain.Points, machine.Points, s);
            }
            partie.ResultatFinal(humain);

            Console.Read();

        }

    }
    class Joueur

    {
        public int Points = 0;
        public ChoixEnum Choix = ChoixEnum.Indefini;

        public ResultatEnum Resultat = ResultatEnum.Egalite;
        public bool EstHumain = false;

        public ChoixEnum Choisir()
        {
            if (EstHumain)
                return ChoisirPourHumain();
            else
                return ChoisirPourMachine();
        }

        private ChoixEnum ChoisirPourMachine()
        {
            Random alea = new Random(); // gener un nombre aleatoire
            int i = alea.Next(1, 4);
            switch (i)
            {
                case 1: return ChoixEnum.Pierre;
                case 2: return ChoixEnum.Feuille;
                case 3: return ChoixEnum.Ciseau;
                default: return ChoixEnum.Indefini;
            }

        }

        private ChoixEnum ChoisirPourHumain()
        {
            int choix = 0;
            while (choix == 0)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Choisir: 1 pour Pierre, 2 pour Feuille, 3 pour Ciseau: ");     // utilisateur tape au clavier
                string saisie = Console.ReadLine();
                if (int.TryParse(saisie, out choix) && choix >= 1 && choix <= 3)
                {
                    switch (choix)
                    {
                        case 1: return ChoixEnum.Pierre;
                        case 2: return ChoixEnum.Feuille;
                        case 3: return ChoixEnum.Ciseau;
                        default: return ChoixEnum.Indefini;
                    }
                }
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erreur faire un autre choix s'il vous plait!!!");
                choix = 0;
            }
            return ChoixEnum.Indefini;
        }

        public bool AGagner() { return Points >= 3; }
    }
    class Jeu
    {

        //public int NCoupMax = 5;
        //while 
        public ResultatEnum Comparer(ChoixEnum choixMachine, ChoixEnum choixHumain)
        {
            if (choixMachine == choixHumain)
                return ResultatEnum.Egalite;

            if ((choixMachine == ChoixEnum.Pierre && choixHumain == ChoixEnum.Ciseau) ||
                (choixMachine == ChoixEnum.Feuille && choixHumain == ChoixEnum.Pierre) ||
                (choixMachine == ChoixEnum.Ciseau && choixHumain == ChoixEnum.Feuille)
               )
                return ResultatEnum.Perdu;
            return ResultatEnum.Gagner;
        }

        internal void ResultatFinal(Joueur humain)
        {
            if (humain.AGagner())
                Console.WriteLine("Vous avez gagner!");
            else
                Console.WriteLine("Vous avez perdu!");
        }
    }

    enum ResultatEnum { Egalite, Gagner, Perdu }
    enum ChoixEnum { Indefini, Pierre, Feuille, Ciseau }
}