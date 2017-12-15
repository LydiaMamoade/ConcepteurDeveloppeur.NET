using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Version 1
            //A a = new GetSet.A();

            ////int x = a.i; // pas possible car private
            //int x = a.Get();

            ////a.i =88; // pas possible car private
            //a.Set(88);

            //Version 2: identique à i public
            A a = new A();
            int x = a.i;
            a.i = 88;
        }
    }
    class A
    {
        //Version 0, 1, 2 et 3 sont strictement identique
        //Version 0
        public int i = 77;
        // Version 1
        //private int i = 77;
        //public int Get(){ return i; }
        //public void Set(int value) { i = value; }

        // Version 1bis
        //private int i = 77;
        //public int Get(){ return i; }
        //public void Set(int value) {if(value<=100) i = value; }

        // Version 2
        //private int _i = 77;
        //public int i
        //{
        //    get { return _i; }
        //    set { _i = value; }
        //}
        //Version3
        // public int i { get; set; }
    }

}
