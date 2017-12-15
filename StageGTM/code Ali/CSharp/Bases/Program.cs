using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bases
{
    /// <summary>
    /// Classe principale
    /// </summary>
    class Program
    {
        /// <summary>
        /// Programme principal
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int i = 17;
            int j = 0;
            int k = 0;

            // Version 1
            //if (j != 0)
            //    k = i / j;

            // Version 2
            try
            {
                k = i / j;
                // ...
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Division par zéro impossible");
            }
            catch (Exception e)
            {
                Console.WriteLine("Autre erreur");
            }
            finally
            {
                
            }

            i = 1;
            j = 2;
            j = ++i;  // i=2; j=2;
            j = i++;  // j=1; i=2;

            if (i == 1) ;

            {
                int e;
                {
                    int d;

                }

            }
            {
                int e;
            }

            // if
            if (i==1)  // if (bool)
            {
                j = 3;
            }
            else if (i == 2)
            {

            }
            else if (i == 3)
            {

            }
            else
            {

            }

            // switch
            switch (i)
            {
                case 1:
                    // ....
                    break;
                case 2:
                    // ...
                    break;
                case 3:
                case 6:
                    // ...
                    break;
                default:
                    // ...
                    break;
            }

            // While
            while (false)
            {

            }

            // do while
            do
            {

            }
            while (false);

            // for
            for(int s=0, t=0; s < 10; s++)
            {

            }


            // Plantage volontaire
            //throw new Exception("C'est fait exprès !");
            i = 3;
            j = 4;
            int resultat = Mathematic.Addition(i, j);

            i = 3;
            j = 4;
            resultat = Mathematic.AdditionPlus(ref i, j);

            i = 3;
            j = 4;
            resultat = Mathematic.AdditionPlus(ref i, j);

            i = 3;
            j = 4;
            resultat = 0;
            Mathematic.AdditionPlus(i, j, out resultat);

            i = 3;
            j = 4;
            k = 5;
            resultat = Mathematic.Multiplication(i, j, k);

            resultat = Mathematic.Multiplication(5,6,7,8,9,10,11);

            resultat = Mathematic.Factorielle(5);
        }
    }

    class Mathematic
    {
        public static int Addition(int x, int y)
        {
            return x + y;
        }
        public static int AdditionPlus(ref int x, int y)
        {
            x++;
            y++;
            return x + y;
        }
        public static void AdditionPlus(int x, int y, out int res)
        {
            res= x + y;
        }
        public static int Multiplication(int x, int y)
        {
            return x * y;
        }
        public static int Multiplication(int x, int y, int z)
        {
            return x * y * z;
        }
        public static int Multiplication(params int[] liste)
        {
            int resultat = 1;
            for(int i=0; i < liste.Length; i++)
            {
                resultat *= liste[i];
            }
            return resultat;
        }
        public static int Factorielle(int n)
        {
            if (n == 1) return 1;
            return n * Factorielle(n - 1);
        }
    }
}
