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
        static public event GoDelegue Go;
        static void Main(string[] args)
        {
            Actions lesActions = new Actions();
            // evement Go qui declanche les 3 action
            Go += lesActions.Action1;
            Go += lesActions.Action2;
            Go += lesActions.Action3;

            Go();
           
        }
    }

    class Actions
    {
     
      
        public void Action1()
        {
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Action1");
            Console.WriteLine(DateTime.Now.ToLongTimeString());

        }
        public void Action2()
        {
            Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Action2");
            Console.WriteLine(DateTime.Now.ToLongTimeString());

        }
        public void Action3()
        {
            Thread.Sleep(10000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Action3");
            Console.WriteLine(DateTime.Now.ToLongTimeString());

        }


    }
    delegate void GoDelegue();

}
