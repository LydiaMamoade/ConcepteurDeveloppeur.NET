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
            var Terre = new PlanetteHabitable { YaDlo = true, Masse = 50, Rayon = 90 };
            var Mars = new PlanetteHabitable { YaDlo = true, Masse = 150, Rayon = 100 };
            var Soleil = new Etoile { Luminosite = 5000, Masse = 100, Rayon = 200 };
        }
    }
    class PlanetteHabitable :Planette, IHabitable, IHabite
    {
        public int NPopulation()
        {
            //...
            return 3000;
        }
        public decimal TauxDoxygene()
        {
            //...
            return 0.3M;
        }
        public int Temperature()
        {
            //...
            return 25;

        }
    }
    class Planette : Astre
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
