using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercice1
{
    delegate void ActionDelegue1();
    delegate void ActionDelegue2(int i);
    delegate void ActionDelegue3(string s);
    class Program
    {
        static void Main(string[] args)
        {
            Actions lesActions = new Actions();
            //lesActions.Action1();         // m1
            //lesActions.Action2(10);       // m2 
            //lesActions.Action3("Hello");  // m3
            var d1 = new ActionDelegue1(lesActions.Action1);
            var d2 = new ActionDelegue2(lesActions.Action2);
            var d3 = new ActionDelegue3(lesActions.Action3);
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            d1.BeginInvoke(null, null);
            d2.BeginInvoke(10, null, null);
            d3.Invoke("Hello");

            Console.Read();
        }
    }
    class Actions
    {
        public void Action1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Action 1");
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }
        public void Action2(int i)
        {
            Thread.Sleep(5000);
            Console.WriteLine("Action 2");
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }
        public void Action3(string s)
        {
            Thread.Sleep(10000);
            Console.WriteLine("Action 3");
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }
    }
}
