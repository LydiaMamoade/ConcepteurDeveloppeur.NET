using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var Terre = new PlaneteHabitable { YaDlo = true, Masse = 50, Rayon = 80 };
            var Mars = new PlaneteHabitable { YaDlo = true, Masse = 150, Rayon = 90 };
            var Soleil = new Etoile { Luminosite = 5000, Masse = 100, Rayon = 200 };
            var EtoileDuBerger = new Etoile { Luminosite = 15000, Masse = 2100, Rayon = 1200 };
        }
    }

    class PlaneteHabitable : Planete, IHabitable, IHabite
    {
        public int NPopulation()
        {
            return 3000;
        }

        public decimal TauxDoxygene()
        {
            // ..
            return 0.3M;
        }

        public int Temperature()
        {
            // ..
            return 25;

        }
    }
    class Planete : Astre
    {
        public bool YaDlo = false;
    }
    class Etoile : Astre
    {
        public int Luminosite;
    }
    class Astre
    {
        public int Rayon;
        public int Masse;
    }
    interface IHabitable
    {
        decimal TauxDoxygene();
        int Temperature();

    }
    interface IHabite
    {
        int NPopulation();
    }
}
