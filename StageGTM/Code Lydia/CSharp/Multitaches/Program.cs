using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multitaches
{
    class Program
    {
        static void Main(string[] args)
        {
            // change la couleur de la console
            if (Console.BackgroundColor == ConsoleColor.Black)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
            }
            //

            Compteur jaune = new Compteur();
            Compteur rose = new Compteur
            {
                Min = 1,
                Max = 20,
                Pas = 2,
                Pause = 500,
                Couleur = ConsoleColor.Magenta
            };
            Compteur bleu = new Compteur
            {
                Min = 1,
                Max = 30,
                Pas = 1,
                Pause = 100,
                Couleur = ConsoleColor.Cyan
            };
            //jaune.Compte();
            //rose.Compte();

            CompteDelegate jauneD = new CompteDelegate(jaune.Compte);
            CompteDelegate roseD = new CompteDelegate(rose.Compte);
            CompteDelegate blueD = new CompteDelegate(bleu.Compte);

            jauneD.BeginInvoke(new AsyncCallback(Fini), "jaune");
            roseD.BeginInvoke(new AsyncCallback(Fini), "rose");
            blueD.Invoke();


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("J'ai fini !!!");


            Console.Read();
        }

        //private static void RoseFini(IAsyncResult ar)
        //{
        //    Console.ForegroundColor = ConsoleColor.White;
        //    Console.WriteLine("Le rose a fini!!!");
        //}

        //private static void JauneFini(IAsyncResult ar)
        //{
        //    Console.ForegroundColor = ConsoleColor.White;
        //    Console.WriteLine("Le jaune a fini !!!");
        //}

        private static void Fini(IAsyncResult ar)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Le {0} a fini !!!", ar.AsyncState.ToString());
        }
    }

    class Compteur
    {
        public int Min = 1;
        public int Max = 10;
        public int Pas = 1;
        public int Pause = 1000;
        public ConsoleColor Couleur = ConsoleColor.Yellow;

        public void Compte()
        {
            for (int i = Min; i <= Max; i += Pas)
            {
                Console.ForegroundColor = Couleur;
                //Console.BackgroundColor = Couleur;
                //Console.WriteLine("ouiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiimmmmmmmmmmmmmmmmmmmmmmmmmmmmmm");
                Console.WriteLine(i);
                Thread.Sleep(Pause);

            }
        }
    }
    delegate void CompteDelegate();

}
