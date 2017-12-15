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
            for(int i=0; i < int.MaxValue; i++)
            {
                using (Livre livre1 = new Livre())
                {

                } // GC libère l'objet livre1
                
                //GC.Collect(); // Ménage complet : trop long
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
