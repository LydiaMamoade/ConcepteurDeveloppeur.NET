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
            int compteur;
            
            Console.Write("Donner la limite supérieur: ");     
            string LimiteSup = Console.ReadLine();

            Console.Write("Donner la limite inf: ");
            string LimiteInf = Console.ReadLine();

            Console.Write("Donner la vitesse :");
            string vitesse = Console.ReadLine();

            int debut = 0;
            int fin = 0;
            int lim = 0;

            var conversionDebut = int.TryParse(LimiteInf, out debut);
            bool conditionDeDebut = conversionDebut && debut > 0;

            var conversionFin = int.TryParse(LimiteSup, out fin);
            bool conditionDeFin = conversionFin && fin > debut;

            var conversionVitesse = int.TryParse(vitesse, out lim);
            bool conditionDeVitesse = conversionVitesse && lim >= 0 && lim < 4;


            //if (  (int.TryParse(LimiteInf, out debut) && debut > 0   ) && 
            //      (int.TryParse(LimiteSup, out fin )  && fin > debut ) && 
            //      (int.TryParse(vitesse, out lim) && lim >=0 && lim < 4 )
            //   )
            if (conditionDeDebut && conditionDeFin && conditionDeVitesse)
            {
                for (compteur = debut; compteur < fin; compteur++)
                {

                    if (compteur % 10 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        
                    }
                    else
                        Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("{0}", compteur);
                    Thread.Sleep((3 - lim) * 500 + 100);
                    
                }

            }  
            else
                Console.WriteLine("Erreur faire un autre choix s'il vous plait!!!");
            Console.Read();
        }
    }

}
