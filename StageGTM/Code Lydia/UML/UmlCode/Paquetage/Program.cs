using System;                      // redarde dans systeme
using Espace2.Espace4;
using Autre = Espace2.Espace3;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espace1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Coucou!");
            F f1 = new F();
            Autre.A a1 = new Espace2.Espace3.A();
        }
    }
    class A { }
    class B { }
}
