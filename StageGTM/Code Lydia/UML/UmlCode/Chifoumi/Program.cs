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
            Joueur machine = new Joueur { EstHumain = true };
            var choixHumain = humain.Choisir();
            var choixMachine = machine.Choisir();
            Jeu parie = new Jeu();
            var resultat = parie.Comparer(choixMachine, choixHumain);
            switch (resultat)
            {
                case ResultatEnum.Gagner: Console.WriteLine("Gagné!"); break;
                case ResultatEnum.Perdu: Console.WriteLine("Perdu!"); break;
                case ResultatEnum.Egalite: Console.WriteLine("Egalité!"); break;
            }
            Console.Read();
        }
        
    }
    class Joueur
    {
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
            int i = alea.Next(1, 3);
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

            Console.Write("Choisir: 1 pour Pierre, 2 pour Feuille, 3 pour Ciseau: ");     // utilisateur tape au clavier
            int choix = 0;
            while (choix == 0)
            {
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
            }
            return ChoixEnum.Indefini;
        }
    }
    class Jeu
    {

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

    }

    enum ResultatEnum { Egalite, Gagner, Perdu }
    enum ChoixEnum { Indefini, Pierre, Feuille, Ciseau }
}