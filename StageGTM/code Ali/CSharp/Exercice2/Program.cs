using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercice2
{
    class Program
    {
         public static event GoDelegue Go;
       static void Main(string[] args)
        {
            Actions lesActions = new Actions();
            // Evenement Go qui déclenche les 3 actions.
            Go += lesActions.Action1;
            Go += lesActions.Action2;
            Go += lesActions.Action3;

            Go();

            Console.Read();
        }
    }
    delegate void GoDelegue();
    class Actions
    {

        public void Action1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Action 1");
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }
        public void Action2()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Action 2");
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }
        public void Action3()
        {
            Thread.Sleep(10000);
            Console.WriteLine("Action 3");
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }
    }

}
