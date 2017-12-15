using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Actions lesActions= new Actions();


            //lesActions.Action1();             //m1
            //lesActions.Action2(10);           //m2
            //lesActions.Action3("Hello");      //m3

            var D1 = new ActionDelegue1(lesActions.Action1);
            var D2 = new ActionDelegue2(lesActions.Action2);
            var D3 = new ActionDelgue3(lesActions.Action3);

            Console.WriteLine(DateTime.Now.ToLongTimeString());


            D1.BeginInvoke(null, null);
            D2.BeginInvoke(10,null, null);
            D3.Invoke("Hello");

            Console.WriteLine(DateTime.Now.ToLongTimeString());

            Console.Read();
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
        public void Action2(int i)
        {
            Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Action2");
            Console.WriteLine(DateTime.Now.ToLongTimeString());

        }
        public void Action3(string s)
        {
            Thread.Sleep(10000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Action3");
            Console.WriteLine(DateTime.Now.ToLongTimeString());

        }
        

    }

    delegate void ActionDelegue1();
    delegate void ActionDelegue2(int i);
    delegate void ActionDelgue3(string s);

}
