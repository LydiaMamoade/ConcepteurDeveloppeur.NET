using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodeDExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Microsoft fournit   précisément    au travers de     la plateforme .Net un ensemble d'outils.";
            int nombreMots = phrase.NombreMots('p');
            //int nombreMots = Outils.NombreMots(phrase);
        }
    }
    public static class Outils
    {
        public static int NombreMots(this string s, char commencePar)
        {
            var tableMots =  s.Split(new char[] { ' ', '\'' }, StringSplitOptions.RemoveEmptyEntries);
            int compteur = 0;
            foreach(string mot in tableMots)
            {
                if (mot[0] == commencePar) compteur++;
            }
            return compteur;
        }
    }
}
