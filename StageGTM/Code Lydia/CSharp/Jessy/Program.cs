using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jessy
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < int.MaxValue; i++)
            {
                using (Livre Livre1 = new Livre())  // libère la mémoire rapidement
                {

                }          // Gc libère l'objet livre1  
                
                // GC.Collect(); / mauvaise solution ménage complet mais trop log
            }

        }
    }

    class Livre : IDisposable
    {
        public void Dispose()
        {
            
        }
    }
}
