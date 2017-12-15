using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bases
{
    /// <summary>
    /// Programme principal
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int i = 17; // system.Int64 i=17, byte entier sur 8 bites
            int j = 0;
            int k = 0;

            //version 1
            //if (j != 0)
            //{
            //    k = i / j;
            //}
            // Version 2 l'exception
            //try
            //{
            //    k = i / j;
            //    //...
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine("Division par zéro impossible");
            //    Console.Read();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Autre erreur");
            //    Console.Read();
            //}
            //finally // exécute dans tous les cas
            //{

            //}
            //i = 1;
            //j = 2;
            //j = ++i; //i=2 j=2  on fait l'incrémentation avant l'affectation
            //j = i++; //i=2 j=1 on fait l'affectation avant l'incrémentation 

            //{ /*IF */}
            //if (i == 1) // resultat bouléen
            //{
            //    j = 3;
            //}
            //else if (i == 2)
            //{

            //}
            //else if (i == 3)
            //{

            //}
            //else
            //{

            //}

            //{ /* switch */}
            //switch (i)
            //{
            //    case 1:
            //        //..
            //        break;
            //    case 2:
            //        //...
            //        break;
            //    case 3:
            //        // ...
            //        break;
            //    default:
            //        //...
            //        break;
            //}

            //{ /* while */}
            //while () // parenthèse obligatoire instruction entre parenthèse type bouléen, on teste avant d'exécuter
            //{
            // //...
            //}

            //do // on exécute d'abord avant de teste
            //{

            //}
            //while ();

            //for(int i=0, t=0; i< 10; s++)
            //{

            //}

            //// Plantage volontaire
            //int m = 17 / j;
            //throw new Exception("C'est fait exprès"); // je plante exprès
            i = 3;
            j = 4;
            int resultat = 0;
            int resultat3 = Mathematic.Addition(i, j);
            Mathematic.AdditionPlus(i, j, out resultat);

            i = 3;
            j = 4;
            int resultat1 = Mathematic.Multiplication(i, j);

            int resultat2 = Mathematic.Multiplication(1,2,3,4,5,6);

            
            
            int resultatFact = Mathematic.Factoriellle(5);
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
        public static void AdditionPlus( int x, int y, out int res) // out paramètre de sortie
        {
           
           res =x + y;
        }
        public static int Multiplication(int x, int y)
        {
            return x*y;
        }

        public static int Multiplication(params int [] liste)
        {
            int resultat = 1;
            for (int i=0; i<liste.Length; i++)
            {
                resultat *= liste[i];
            }
            return resultat;
        }

        public static int Factoriellle(int n)
        {
            if (n == 1) return 1;
            return n * Factoriellle(n - 1); // fonction recursive une methode qui fait appel à elle meme

        }
    }

}
