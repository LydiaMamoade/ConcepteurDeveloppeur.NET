using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Début : ");
            string saisie = Console.ReadLine();
            int debut = 0;
            if (int.TryParse(saisie, out debut) && debut > 0)
            {
                Console.Write("Fin : ");
                saisie = Console.ReadLine();
                int fin = 0;
                if (int.TryParse(saisie, out fin) && fin > debut)
                {
                    Console.Write("Vitesse : ");
                    saisie = Console.ReadLine();
                    int vitesse = 0;
                    if (int.TryParse(saisie, out vitesse) && vitesse > 0 && vitesse < 4)
                    {
                        for (int i = debut; i <= fin; i++)
                        {
                            if (i % 10 == 0)
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            else
                                Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine(i);
                            Thread.Sleep((3 - vitesse) * 500 + 100);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Saisie incorrecte !");
                    }
                }
                else
                {
                    Console.WriteLine("Saisie incorrecte !");
                }
            }
            else
            {
                Console.WriteLine("Saisie incorrecte !");
            }
            Console.Read();
        }
    }
}
