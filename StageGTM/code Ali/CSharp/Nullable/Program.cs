using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Ecole GabrielPeri = null;

            Nullable<int> i = null;
            int? j = null;
            i = 12;
            i = null;
            string s = null; // pas d'espace mémoire
            string t = "";   // espace mémoire réservé mais vide

            if (i.HasValue)
                s = i.ToString();
        }
    }
    class Ecole
    {

    }
}
